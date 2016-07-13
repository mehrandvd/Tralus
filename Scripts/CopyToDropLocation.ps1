[CmdletBinding()]
param(
[Parameter(Mandatory = $true)]
    [string]
    $sourceLocation,

    [Parameter(Mandatory = $true)]
    [string]
    $dropLocationPath,

    [Parameter(Mandatory = $true)]
    [string]
    $buildConfiguration,

    [Parameter(Mandatory = $true)]
    [string[]]
    $includeFileNames,

    [Parameter(Mandatory = $true)]
    [string[]]
    $includeFileTypes
)

#$includeFileTypes = "*.exe","*.dll","*.exe.config","*.config","*.xml"
#$includeFileNames = "*framework*", "*shell*"
$binFolders = $("*bin*")



$applicationfiles = Get-ChildItem  $sourceLocation -recurse  -Include $binFolders | 
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $buildConfiguration } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $includeFileNames } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $includeFileTypes } 

$pdbfiles = Get-ChildItem  $sourceLocation -recurse  -Include $binFolders | 
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $buildConfiguration } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $includeFileNames } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include "*.pdb" }


if(-not (Test-Path $dropLocationPath)) {
    New-Item -Path $dropLocationPath -ItemType Directory | Out-Null
}

$applicationfiles | Copy-Item -Destination $dropLocationPath -Recurse -Force
$pdbfiles | Copy-Item -Destination $dropLocationPath -Recurse -Force