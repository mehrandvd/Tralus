[CmdletBinding()]
param(
    [Parameter(Mandatory=$True)]
    [string]$WebSiteName,

    [Parameter(Mandatory=$False)]
    [string]$Slot
)

if($Slot)
{
    Start-AzureWebsite -Name $WebSiteName  -Slot $Slot | Out-Null
    Write-Host "Started slot '$Slot' belonging to web app '$WebSiteName'"
}
else
{
    Start-AzureWebsite -Name $WebSiteName | Out-Null
    Write-Host "Started web app '$WebSiteName'"
}