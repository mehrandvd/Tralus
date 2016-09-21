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
    Stop-AzureWebsite -Name $WebSiteName -Slot $Slot | Out-Null
    Write-Host "Stopped slot '$Slot' belonging to web app '$WebSiteName'"
}
else
{
    Stop-AzureWebsite -Name $WebSiteName
    Write-Host "Stopped web app '$WebSiteName'"
}