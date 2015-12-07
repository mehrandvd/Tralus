[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]
    $DropLocationPath,

    [Parameter(Mandatory = $true)]
    [string]
    $RepositoryPath,

    [string]
    $SearchKeyword = "Mahan.Tralus"

)

$fileTypes = $("*.exe","*.dll","*.exe.config","*.config","*.pdb","*.xml")
$sourceSubFolders = $("*bin*","*obj*")

$files = Get-ChildItem $Env:TF_BUILD_SOURCESDIRECTORY -recurse -include $sourceSubFolders | 
	Where-Object { $_.PSIsContainer } | 
	    ForEach-Object { Get-ChildItem -Path $_.FullName -Recurse -include $fileTypes }


$targetAssemblyPath = $files | Where-Object {$_.Name -like "$SearchKeyword*"} | Select-Object -First 1 -ExpandProperty FullName
$version = (Get-ItemProperty -Path $targetAssemblyPath).VersionInfo.ProductVersion

$versionedDropLocationPath = Join-Path $DropLocationPath $version

if(-not (Test-Path $RepositoryPath)) {
    New-Item -Path $RepositoryPath -ItemType Directory | Out-Null
}

if(-not (Test-Path $versionedDropLocationPath)) {
    New-Item -Path $versionedDropLocationPath -ItemType Directory | Out-Null
}

$files | Copy-Item -Destination $versionedDropLocationPath -Recurse -Force
$files | Copy-Item -Destination $RepositoryPath -Recurse -Force
