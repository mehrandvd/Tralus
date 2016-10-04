[CmdletBinding()]
Param(
    [Parameter(Mandatory=$true)]
    [String] $ResourceGroupName,
    
    [Parameter(Mandatory=$true)] 
    [String] $ServerName,

    [Parameter(Mandatory=$true)]
    [String] $DatabaseName,

    [Parameter(Mandatory=$true)]
    [String] 
    $Edition

)

Write-Host $ResourceGroupName
Write-Host $ServerName
Write-Host $DatabaseName
Write-Host $Edition

Set-AzureRmSqlDatabase -ResourceGroupName $ResourceGroupName  -ServerName $ServerName  -DatabaseName $DatabaseName -Edition $Edition