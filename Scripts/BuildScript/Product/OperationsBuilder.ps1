[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]
    $DropLocationRootPath, #= "E:\TralusBuilds",

    [Parameter(Mandatory = $true)]
    [string]
    $DropLocationPath #= "E:\TralusBuilds\Mahan.Tralus.Aviation\1.0.0.12"
)

function getLatestBuildNumber {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true,ValueFromPipeline=$true)]
        [String]
        $RawPath
    )
    
    Process {
        Write-Output $RawPath.Substring(0,$RawPath.IndexOf("%") - 1) | 
            Get-ChildItem -Directory | 
                Where-Object {$_ -match "(?:\d+\.){3}\d+"} | 
                    Select-Object Name, @{n = "Revision"; e = {[int]($_.Name.Substring($_.Name.LastIndexOf(".") + 1))}} | 
                        Sort-Object Revision -Descending |
                            Select-Object -First 1 -ExpandProperty Name
    }
}

function shouldCopy ($item) {
    $path = Join-Path $item.Destination (Split-Path -Path $item.Path -Leaf)
    $VerbosePreference = "Continue"
    Write-Verbose "Should copy [[$path]]"
    if ([System.IO.File]::Exists($path)) {
        if ($item.Overwrite) {
            return $true
        }
    } else {
        return $true
    }
    return $false
}

function runRecipe ($ingredients, $dropLocationRootPath, [string[]]$excludedItems) {
    Write-Output $ingredients |
        ForEach-Object {$_} -PipelineVariable recipe | 
            ForEach-Object {Join-Path  $dropLocationRootPath $_.Path } -PipelineVariable rp | 
                getLatestBuildNumber | 
                    ForEach-Object {$rp.Replace("%",$_)} |
                        Resolve-Path | 
                            Select-Object @{n = 'Path'; e = {$_}}, @{n = 'Destination'; e = {$recipe.Destination}}, @{n = 'Overwrite'; e = {$recipe.Overwrite}} |
                                ForEach-Object {
                                    if (shouldCopy $_) {
                                        Copy-Item -Path $_.Path -Destination $_.Destination -Recurse -Exclude $excludedItems -Force -Verbose -Container
                                    }
                                }
}


$appName = "Web"
$DestinationPath = Join-Path $DropLocationPath $appName
if(-not (Test-Path $DestinationPath)){
    New-Item $DestinationPath -ItemType Directory | Out-Null
}
$binFolder = Join-Path $DestinationPath "bin"
$webIngredients = @(
    @{Path = "Tralus.Shell-Dev\%\PublishedWebsite\*"; Destination = $DestinationPath; Overwrite = $true},
    @{Path = "Tralus.Framework-Dev\%\*"; Destination = $binFolder; Overwrite = $true},
    @{Path = "Tralus.Infrastructure-Dev\%\*"; Destination = $binFolder; Overwrite = $false},
    @{Path = "Tralus.JourneyPanel-Dev\%\*"; Destination = $binFolder; Overwrite = $false}
    @{Path = "Mahan.Tralus.Operations\%\Products\Mahan.Journey.dll"; Destination = $binFolder; Overwrite = $true}
)
runRecipe -ingredients $webIngredients -dropLocationRootPath $DropLocationRootPath -excludedItems @("logs","_PublishedWebsites")

$appName = "Win"
$DestinationPath = Join-Path $DropLocationPath $appName
if(-not (Test-Path $DestinationPath)){
    New-Item $DestinationPath -ItemType Directory | Out-Null
}
$winIngredients = @(
    @{Path = "Tralus.Shell-Dev\%\*"; Destination = $DestinationPath; Overwrite = $true},
    @{Path = "Tralus.Framework-Dev\%\*"; Destination = $DestinationPath; Overwrite = $true},
    @{Path = "Tralus.Infrastructure-Dev\%\*"; Destination = $DestinationPath; Overwrite = $false},
    @{Path = "Tralus.JourneyPanel-Dev\%\*"; Destination = $DestinationPath; Overwrite = $false}
)
runRecipe -ingredients $winIngredients -dropLocationRootPath $DropLocationRootPath -excludedItems @("logs","*PublishedWebsite*")

