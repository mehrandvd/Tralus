Add-PSSnapin -Name "Microsoft.TeamFoundation.PowerShell"

<#
.Example
    Invoke-IncrementRevision -AssemblyInfoPah E:\project1\AssemblyInfo.cs"
#>
function Invoke-IncrementRevision {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [String]
        $AssemblyInfoPath
    )
    Process{
        $content = Get-Content -Raw -Path $AssemblyInfoPath
        $regex = New-Object -TypeName "Regex" -ArgumentList "(?'fixPart'(?:\d+\.){3})(?'rev'\d+)"
        if (-not $regex.IsMatch($content)) {
            throw "Revision number was not found in $AssemblyInfoPath"
        }
        $fixPart = ($regex.Matches($content)).Groups[1].Value
        $revPart = [int](($regex.Matches($content)).Groups[2].Value)
        $newVersion = "$fixPart$($revPart + 1)"
        $regex.Replace($content, $newVersion) | Out-File -FilePath $AssemblyInfoPath -Force
    }
}


<#
.Example
    Update-RevisionNumber -Path E:\project1"
#>
function Update-RevisionNumber {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [String]
        $Path
    )

    Process{
        $asmPath = (Get-ChildItem -Path $Path -Recurse -Include "AssemblyInfo*.*").FullName
        
        $asmPath | Invoke-ValidateUnlocking 
        Add-TfsPendingChange -Edit -Item $asmPath | Out-Null
        $asmPath | Invoke-IncrementRevision
        New-TfsChangeset -Item $asmPath -Comment "Increment revision number." | Out-Null
    }
}

function Invoke-ValidateUnlocking {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [String]
        $AssemblyInfoPath
    )
    Process{
        $checkedOutInfo = @(Get-TfsPendingChange -Item $AssemblyInfoPath -User *)
        if($checkedOutInfo.Count -ge 1) {
            throw "$AssemblyInfoPath is checked-out by $($checkedOutInfo.PendingSetOwner -join ',')"
        }
    }
}
$env:CUSTOM_VERSION = "1.2.3.4"
Update-RevisionNumber -Path $Env:TF_BUILD_SOURCESDIRECTORY
