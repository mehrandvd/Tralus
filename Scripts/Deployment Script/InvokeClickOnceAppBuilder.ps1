    [CmdletBinding()]
    Param (
        [Parameter(mandatory = $true)]
        [string]
        $ApplicationName, # = "Journey-Dev",

        [Parameter(mandatory = $true)]
        [string]
        $ManifestName, # = "Journey",
        
        [Parameter(mandatory = $true)]
        [string]
        $SourcePath, # = "E:\aaa\1.0.0.3",

        [Parameter(mandatory = $true)]
        [string]
        $DeploymentRootPath, #= "E:\TralusClickOnceDeployments",

        [Parameter(mandatory = $true)]
        [string]
        $DeploymentUrl, #= "http://172.17.96.65:9911"

        [Parameter(mandatory = $true)]
        [string]
        $Version, #= "1.0.0.40"

	[Parameter(mandatory = $true)]
        [string]
        $certificateFilePath,

	[Parameter(mandatory = $true)]
        [string]
        $certificatePassword
    )
    
        ### New Application ###
        $Mage = "D:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\mage.exe"
        
        $deploymentPath = Join-Path $DeploymentRootPath $ApplicationName
        $destinationPath = Join-Path $deploymentPath $Version
        
        $manifestFilePath = Join-Path $destinationPath "$ManifestName.manifest"
        $appCodeBase = Join-Path ( Join-Path $ApplicationName $Version) "$ManifestName.manifest"

        $deploymentFilePath = Join-Path $destinationPath "$ManifestName.application"

        

        $providerUrl = "$DeploymentUrl/$ManifestName.application"
        
        if (-not (Test-Path $destinationPath)) {
            if ($PSCmdlet.ShouldProcess($destinationPath, "Create Destination Path")) {
                New-Item -ItemType Directory -Path $destinationPath | Write-Host
            }
        }
        
        if ($PSCmdlet.ShouldProcess($SourcePath, "Copy application content to destination")) {
            Copy-Item -Path (Join-Path $SourcePath "*") -Destination $destinationPath -Recurse -Force | Write-Host
        }

        $mageNewAppArgs = @(
            "-New", "Application"
            "-Processor", "msil" 
            "-ToFile", $manifestFilePath
            "-Name", $ApplicationName
            "-Version", $Version 
            "-FromDirectory", $destinationPath 
            "-UseManifestForTrust", $true
            "-Publisher", "MelkRadar"
        )
        if ($PSCmdlet.ShouldProcess($manifestFilePath, "Running Mage.exe to create Manifest file")) {
            . $Mage $mageNewAppArgs | Write-Host
        }

        if ($PSCmdlet.ShouldProcess("Append .deploy extenstion to all files")) {
            $destinationPath | Get-ChildItem -File -Recurse -Exclude "*.manifest" | Rename-Item -NewName {"$($_.Name).deploy"}
        }

        $mageSignAppArgs = @(
            "-Sign", $manifestFilePath
            "-CertFile", $certificateFilePath
            "-Password", $certificatePassword
        )
        if ($PSCmdlet.ShouldProcess($manifestFilePath, "Running Mage.exe to sign Manifest file")) {
            . $mage $mageSignAppArgs | Write-Host
        }

        ### New Deployment ###
        
        $mageNewDeploymentArgs = @(
            "-New", "Deployment"
            "-Processor", "msil"
            "-Install", $true
            "-AppManifest", $manifestFilePath
            "-AppCodeBase", $appCodeBase
            "-ToFile", $deploymentFilePath
            "-Name", $ApplicationName
            "-UseManifestForTrust", $true
            "-ProviderURL", $providerUrl
            "-Version", $Version
            "-Publisher", "Mahan"
        )
        if ($PSCmdlet.ShouldProcess($deploymentFilePath, "Running Mage.exe to create Deployment file")) {
            . $mage $mageNewDeploymentArgs | Write-Host
            Write-Verbose "Deployment file created for $providerUrl"
        }

        $mageMinimumVersion = @(
            "-Update", $deploymentFilePath
            "-MinVersion", $version
        )
        if ($PSCmdlet.ShouldProcess($Version, "Update minimum version")) {
            . $mage $mageMinimumVersion | Write-Host
        }
        
        if ($PSCmdlet.ShouldProcess($deploymentFilePath, "Set custom settings")) {
            $content = [xml](Get-Content -Path $deploymentFilePath -Raw)
            
            $content.assembly.deployment.SetAttribute("mapFileExtensions", "true")
            
            $content.assembly.deployment.subscription.update.AppendChild($content.CreateElement("beforeApplicationStartup")) | Write-Host
            
            $expirationElement = $content.assembly.deployment.subscription.update.GetElementsByTagName("expiration")[0]
            
            $content.assembly.deployment.subscription.update.RemoveChild($expirationElement) | Write-Host
            
            $content.assembly.deployment.subscription.update.InnerXml = "<beforeApplicationStartup />"

            $content.Save($deploymentFilePath)
        }

        $mageSignDeploymentArgs = @(
            "-Sign", $deploymentFilePath
            "-CertFile", $certificateFilePath
            "-Password", $certificatePassword
        )
        if ($PSCmdlet.ShouldProcess($deploymentFilePath, "Running Mage.exe to sign Deployment file")) {
            . $mage $mageSignDeploymentArgs | Write-Host
        }
    
