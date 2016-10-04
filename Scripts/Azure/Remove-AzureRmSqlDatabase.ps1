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
    $DatabaseName
)

Write-Host $ResourceGroupName
Write-Host $ServerName
Write-Host $DatabaseName

Remove-AzureRmSqlDatabase -ResourceGroupName $ResourceGroupName  -ServerName $ServerName  -DatabaseName $DatabaseName -Confirm -Force
