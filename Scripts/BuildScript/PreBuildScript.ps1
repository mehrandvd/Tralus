


<#
.Example
    Get-AssemblyFile -Path 'D:\amirhosseinab\Documents\Projects\Core\Tralus\Framework\Source' | ft 
    Get-AssemblyFile -Path 'C:\Work\Core\Tralus\Shell\Source\Source\Mahan.Tralus.Framework.BusinessModel\Properties'
#>
function Get-AssemblyFile {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [string]
        $Path,

        [string]
        $MainTextPattern = ".Module\"
    )
    
    Process {
        $AssemblyFilePaths = (Get-ChildItem -Path $Path -Recurse -Include "AssemblyInfo.cs").FullName
        
        $obj = @()
        foreach ($path in $AssemblyFilePaths) {
            $content = Get-Content -Path $Path -Raw
            $fileName = Split-Path -Path $Path -Leaf 
            $version = getVersion $content
            $prop = @{
                Path = $Path
                IsMain = $Path.Contains($MainTextPattern)
                Content = $content
                Version = $version
            }
            
            $obj = New-Object psobject -Property $prop
            Write-Output $obj
        }
    }
}

function getVersion ($content) {
    $defaultVersion = "1.0.0.0"
    $incorrentVersionRegex =  New-Object -TypeName "Regex" -ArgumentList "(?<!//.+)(?:\d+\.)+\*"
        if ($incorrentVersionRegex.IsMatch($content)) {
        $content = $incorrentVersionRegex.Replace($content, $defaultVersion)
    }
    
    $correntVersionRegex = New-Object -TypeName "Regex" -ArgumentList "(?:\d+\.){3}\d+"
    return $correntVersionRegex.Match($content).Value
}

<#
.Example
    Invoke-ValidateUnlock -Path @("D:\amirhosseinab\Documents\Projects\Core\Tralus\Scripts\BuildScript\PreBuildScript.ps1",
                                  "D:\amirhosseinab\Documents\Projects\Core\Tralus\Scripts\BuildScript\PostBuildScript.ps1")
#>
function Invoke-ValidateUnlock {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [string[]]
        $Path
    )
    
    Process {
        $checkedOutInfo = @(Get-TfsPendingChange -Item $Path -User *)
        $errorMessage = ""
        if ($checkedOutInfo.Count -eq 1) {
            $errorMessage = ($checkedOutInfo | Select-Object -Property @{n = 'Message'; e = {"[$($_.ServerItem)] is check-out by [$($_.PendingSetOwner)]"}}).Message -join "`n"
        } elseif ($checkedOutInfo.Count -gt 1) {
            $errorMessage = ($checkedOutInfo | Select-Object -Property @{n = 'Message'; e = {"[$($_.PendingChanges.ServerItem)] is check-out by [$($_.OwnerName)]"}}).Message -join "`n"
        }

        if ($errorMessage -ne "") {
            throw $errorMessage
        }
        
    }
}


<#
.Example
    
#>
function Invoke-CheckOut {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [string[]]
        $Path
    )
    
    Process {
        Add-TfsPendingChange -Edit -Item $Path | Out-Null       
    }
}

<#
.Example
    
#>
function Update-AssemblyVersion {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [psobject[]]
        $Assembly 
    )
    
    Process {
        $currentVersion = ($assembly | Where-Object {$_.IsMain})[0].Version
        $lastNumberVersion = $currentVersion.LastIndexOf('.') + 1
        $fixPart = $currentVersion.Substring(0,$lastNumberVersion);
        $revPart = [int]($currentVersion.Substring($lastNumberVersion))
        $newVersion = "$fixPart$($revPart + 1)"

        
        foreach ($asm in $Assembly){
            $correntVersionRegex = New-Object -TypeName "Regex" -ArgumentList "(?:\d+\.){3}\d+"
            $correntVersionRegex.Replace($asm.Content, $newVersion).Trim() | Out-File -FilePath $asm.Path -Force
            Write-Output $asm.Content.Trim()
        }
    }
}


<#
.Example
    
#>
function Invoke-CheckIn {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [string[]]
        $Path ,

        [Parameter(Mandatory=$true)]
        [string]
        $Comment
    )
    
    Process {
        
        New-TfsChangeset -Item $Path -Comment $Comment | Out-Null      
       
    }
}



Add-PSSnapin -Name "Microsoft.TeamFoundation.PowerShell"
$exitCode = 0

$Path = $Env:TF_BUILD_SOURCESDIRECTORY
$assembly = Get-AssemblyFile -Path $Path

try
{
    Invoke-ValidateUnlock -Path $assembly.Path
    Invoke-CheckOut -Path $assembly.Path
    Update-AssemblyVersion -Assembly $assembly
    Invoke-CheckIn -Path $assembly.Path -Comment "Increment revision number."
}
catch [System.Exception]
{
    $exitCode = 1
}
exit $exitCode