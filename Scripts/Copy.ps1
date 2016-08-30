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
    $includeFileTypes,

	[string[]]
    $excludeFileTypes,

	[string[]]
    $excludeFileNames

)

#$includeFileTypes = "*.exe","*.dll","*.exe.config","*.config","*.xml"
#$includeFileNames = "*framework*", "*shell*"
$binFolders = $("*bin*")



$selectedFile = Get-ChildItem  $sourceLocation -recurse  -Include $binFolders | 
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $buildConfiguration } |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $includeFileNames -Exclude $excludeFileNames} |
            ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $includeFileTypes -Exclude $excludeFileTypes} 

if(-not (Test-Path $dropLocationPath)) {
    New-Item -Path $dropLocationPath -ItemType Directory | Out-Null
}

$selectedFile | ForEach-Object{
                            $newDestination = $dropLocationPath

                            $filePath = $_.DirectoryName
                            $indexOflastFolder = $filePath.ToLower().IndexOf($buildConfiguration.ToLower())
							Out-Host -InputObject $indexOflastFolder
							Out-Host -InputObject $filePath
							Out-Host -InputObject $buildConfiguration
							if($indexOflastFolder -gt 0){
								if($filePath.Length -gt $indexOflastFolder+$buildConfiguration.Length+1){
							
									$directory = $filePath.Substring($indexOflastFolder+$buildConfiguration.Length+1)
									$newDestination = Join-Path $dropLocationPath $directory
									if(-not (Test-Path $newDestination)) {
										New-Item -Path $newDestination -ItemType Directory  | Out-Null
										   }
								}
							}
                            Copy-Item $_ -Destination $newDestination
                      }
            
