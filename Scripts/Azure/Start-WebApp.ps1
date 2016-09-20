[CmdletBinding()]
param(
    [Parameter(Mandatory=$True)]
    [string]$WebSiteName,

    [Parameter(Mandatory=$False)]
    [string]$Slot
)

$WebSite = Get-AzureRmWebApp -Name $WebSiteName
$ResourceGroupName = $WebSite.ResourceGroup

if($Slot)
{
    Start-AzureRmWebAppSlot -Name $WebSiteName -ResourceGroupName $ResourceGroupName -Slot $Slot | Out-Null
    Write-Host "Started slot '$Slot' belonging to web app '$WebSiteName'"
}
else
{
    Start-AzureRmWebApp -Name $WebSiteName -ResourceGroupName $ResourceGroupName | Out-Null
    Write-Host "Started web app '$WebSiteName'"
}