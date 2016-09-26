[CmdletBinding()]

Param
(
    # Param1 help description
    [Parameter(Mandatory=$true,
               Position=0)]
    [String]
    $ServiceName,

    [Parameter(Mandatory=$true,
               Position=1)]
    [String]
    $BinaryPathName
)

$service = Get-Service $ServiceName -ErrorAction SilentlyContinue

if (!$service)
{
   New-Service -Name $ServiceName -BinaryPathName $BinaryPathName -StartupType Automatic
}
    