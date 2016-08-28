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

$selectedFile | copy-Custom  -destination $dropLocationPath -lastFolderInclude $buildConfiguration -Verbose


function copy-Custom
{
     param(  
                [Parameter(
                    Position=0, 
                    Mandatory=$true, 
                    ValueFromPipeline=$true,
                    ValueFromPipelineByPropertyName=$true)
                ]
                [System.IO.FileInfo[]]
                $files,
    
                [Parameter(Mandatory = $true)]
                [String]
                $destination,
    
                [Parameter(Mandatory = $true)]
                [String]
                $lastFolderInclude
          )

            process {
                        foreach($file in $files){
                            $newDestination = $destination

                            $filePath = $file.DirectoryName
                            $indexOflastFolder = $filePath.IndexOf($lastFolderInclude)

                            if($filePath.Length -gt $indexOflastFolder+$buildConfiguration.Length+1){
                            Out-Host -InputObject $indexOflastFolder 
                            
                                $directory = $filePath.Substring($indexOflastFolder+$buildConfiguration.Length+1)
                                Out-Host -InputObject log
                                Out-Host -InputObject $directory
                                $newDestination = Join-Path $destination $directory
                                Out-Host -InputObject $newDestination
                                if(-not (Test-Path $newDestination)) {
                                    New-Item -Path $newDestination -ItemType Directory  | Out-Null
                                       }
                            }

                            Copy-Item $file -Destination $newDestination
                      }
            }
}