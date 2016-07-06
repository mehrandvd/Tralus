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
    $buildConfiguration

)

$fileTypes = $("*.exe","*.dll","*.exe.config","*.config","*.pdb","*.xml")
$binFolders = $("*bin*")



$dllfiles = Get-ChildItem  $sourceLocation -recurse  -Include $binFolders | 
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $buildConfiguration } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include "Melkradar*.dll" }

$pdbfiles = Get-ChildItem  $sourceLocation -recurse  -Include $binFolders | 
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $buildConfiguration } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include "Melkradar*.pdb" }


if(-not (Test-Path $dropLocationPath)) {
    New-Item -Path $dropLocationPath -ItemType Directory | Out-Null
}

$dllfiles | Copy-Item -Destination $dropLocationPath -Recurse -Force
$pdbfiles | Copy-Item -Destination $dropLocationPath -Recurse -Force
