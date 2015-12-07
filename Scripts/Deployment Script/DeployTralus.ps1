Configuration DeployWebsite {

    # Import the module that defines custom resources
    Import-DscResource -Module xWebAdministration

    Node $AllNodes.NodeName
    {
        # Clean website content folder
        Script CleanContent {
            GetScript = {
                #Do nothing
            }
            SetScript = {
                Remove-Item -LiteralPath $using:Node.DestinationPath -Recurse -Force 
            }
            TestScript = {
                -not (Test-Path -LiteralPath $using:Node.DestinationPath)
            }
        }

        # Copy the website content
        File WebContent
        {
            Ensure = "Present"
            SourcePath = $applicationPath
            DestinationPath = $Node.DestinationPath
            Recurse = $true
            Type = "Directory"
            DependsOn = "[Script]CleanContent"
        }

        # Create the new Website with HTTPS
        xWebsite NewWebsite
        {
            Ensure = "Present"
            Name = $Node.WebsiteName
            State = "Started"
            ApplicationPool = $Node.WebsiteName
            PhysicalPath = $Node.DestinationPath
            BindingInfo = MSFT_xWebBindingInformation {
                            Protocol = "HTTP"
                            Port = $Node.Port
                          }
            DependsOn = @("[File]WebContent", "[xWebAppPool]NewWebAppPool")
        }

        Script WebsiteHostHeader {
            GetScript = {
                #Do nothing
            }
            SetScript = {
                $thumbprint = Get-ChildItem Cert:\LocalMachine\My | Where-Object {$_.Subject -like "*mahan*"}
                if ($thumbprint) {
                    New-WebBinding -Name $using:Node.WebsiteName -HostHeader $using:Node.HostHeader -Protocol "https" -SslFlags 0
                    New-Item -Path "IIS:\SslBindings\0.0.0.0!443" -Value $thumbprint
                }
            }
            
            TestScript = {
                if ($using:Node.HostHeader -eq "") {
                    return $true
                }

                @(Get-WebBinding -Name $using:Node.WebsiteName -HostHeader $using:Node.HostHeader).Count -eq 1
            }

            DependsOn = "[xWebsite]NewWebsite"
        }

        xWebAppPool NewWebAppPool
        {
            Name   = $Node.WebsiteName
            Ensure = "Present"
            State  = "Started"
        }
            
        <#
        # Config variables
        Script ConfigVariables {
            GetScript = {
                #Do nothing
            }
            
            SetScript = {
                $path = Join-Path $using:Node.DestinationPath "web.config"
                [string]$configContent = Get-Content -LiteralPath $path -Raw
                $configContent = $configContent.Replace("__APP_CONNECTION_STRING__", $using:appConnectionString)
                $configContent = $configContent.Replace("__GATEWAY_CONNECTION_STRING__", $using:gatewayConnectionString)
                $configContent = $configContent.Replace("__MGT_CONNECTION_STRING__", $using:mgtConnectionString)
                $configContent = $configContent.Replace("__ADFS_RESOURCE_NAME__", $using:resourceName)
                $configContent = $configContent.Replace("__ADFS_CLIENT_ID__", $using:clientId)
                $configContent | Out-File -FilePath $path -Encoding utf8 -Force
            }

            TestScript = {
                return $false
            }

            DependsOn = "[xWebsite]NewWebsite"
        }
        #>
    }
}

DeployWebsite -ConfigurationData $ConfigurationData –Verbose
