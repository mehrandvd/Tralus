[CmdletBinding()]

Param
(
    # Param1 help description
    [Parameter(Mandatory=$true,
               ValueFromPipelineByPropertyName=$true,
               Position=0)]
    [String]
    $ServiceName
)

$service = Get-Service $ServiceName -ErrorAction SilentlyContinue

if ($service)
{
    $service.Start()
}
    