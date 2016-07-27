[CmdletBinding()]
Param(
   [Parameter(Mandatory = $true)]
   [string]$vstsAccount,

   [Parameter(Mandatory = $true)]
   [string]$projectName,

   [string]$buildNumber ,

   [Parameter(Mandatory = $true)]
   [string]$user,

   [Parameter(Mandatory = $true)]
   [string]$token,

   [Parameter(Mandatory = $true)]
   [string]$artifactName ,

	[Parameter(Mandatory = $true)]
   [string]$downloadLocation ,

	[string]$buildDefinitionsName
)



$body = @{
            "api-version"="2.0"
            "`$top"="1"
            resultFilter="succeeded"
    }


if(![string]::IsNullOrWhiteSpace($buildNumber))
{
    $body.buildNumber = $buildNumber
}


# Base64-encodes the Personal Access Token (PAT) appropriately
$base64AuthInfo = [Convert]::ToBase64String([Text.Encoding]::ASCII.GetBytes(("{0}:{1}" -f $user,$token)))

$buildDefinitionsUrl = "https://$vstsAccount.visualstudio.com/DefaultCollection/$projectName/_apis/build/definitions"
$buildurl = "https://$vstsAccount.visualstudio.com/DefaultCollection/$projectName/_apis/build/builds"

if(![string]::IsNullOrWhiteSpace($buildDefinitionsName))
{
	$buildDefinitionBody = @{
		"api-version"="2.0"
	}

    $buildDefinitionBody.name = $buildDefinitionsName

	$result = Invoke-RestMethod -Uri $buildDefinitionsUrl -Method Get -ContentType "application/json" -Headers @{Authorization=("Basic {0}" -f $base64AuthInfo)} -Body $buildDefinitionBody

	if ($result.count -eq 0)
	{
		throw "Unable to locate Build Definition  $($buildDefinitionsName)"
	}

	$body.definitions = $result.value.id
}


$result = Invoke-RestMethod -Uri $buildurl -Method Get -ContentType "application/json" -Headers @{Authorization=("Basic {0}" -f $base64AuthInfo)} -Body $body

if ($result.count -eq 0)
{
     throw "Unable to locate Build ID for Build Number $($buildNumber)"
}

$buildId = $result.value.id

$artifactUrl = "https://$vstsAccount.visualstudio.com/DefaultCollection/$projectName/_apis/build/builds/$buildId/artifacts?api-version=2.0&artifactName=$artifactName"
$artifactresult = Invoke-RestMethod -Uri $artifactUrl -Method Get -ContentType "application/json" -Headers @{Authorization=("Basic {0}" -f $base64AuthInfo)}

if ($artifactresult.count -eq 0)
{
     throw "Unable to locate Artifact for Build ID $($buildId)"
}

$artifactDownloadUrl = $artifactresult.resource.downloadUrl

$wc = New-Object System.Net.WebClient
$wc.Headers.Add("Authorization","Basic {0}" -f $base64AuthInfo)
$wc.DownloadFile($artifactDownloadUrl, $downloadLocation)
