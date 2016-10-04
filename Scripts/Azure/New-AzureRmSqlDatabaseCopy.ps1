[CmdletBinding()]
Param(
    [Parameter(Mandatory=$true)]
    [String] 
    $ResourceGroupName, 

    [Parameter(Mandatory=$true)]
    [String] 
    $ServerName,

    [Parameter(Mandatory=$true)]
    [String] 
    $DatabaseName,

    [Parameter(Mandatory=$true)]
    [String] 
    $CopyServerName,

    [Parameter(Mandatory=$true)]
    [String] 
    $CopyDatabaseName,

    [Parameter(Mandatory=$true)]
    [String] 
    $CopyResourceGroupName
)

Write-Host $ResourceGroupName
Write-Host $ServerName
Write-Host $DatabaseName
Write-Host $CopyResourceGroupName
Write-Host $CopyServerName
Write-Host $CopyDatabaseName

New-AzureRmSqlDatabaseCopy -ResourceGroupName $ResourceGroupName  -ServerName $ServerName -DatabaseName $DatabaseName  -CopyServerName $CopyServerName  -CopyDatabaseName $CopyDatabaseName -CopyResourceGroupName $CopyResourceGroupName -Verbose