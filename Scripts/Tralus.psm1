Import-Module WebAdministration

function Bootstrap {
    [CmdletBinding()]
    Param(
        [parameter(mandatory=$true)]
        [pscredential]
        $Credential = (Get-Credential -Message "Enter your username please" -UserName ($env:USERNAME))
    )

    Process{
        $appName = "Tralus"
        $databaseName = "Local$($appName)_DEV"
        $projectName = "$($appName)Local"
        $projectPath = Join-Path $HOME $projectName
        $websitePath = Join-Path $projectPath "web"
        $databasePath = Join-Path $websitePath "App_Data"
       
        Add-Workspace -Path $projectPath -SubDirectory @('win','web\bin','web\App_Data')
        Set-EnvironmentVariable -Path $projectName
        Grant-WorkspacePermission -Path $websitePath -Identity "Everyone"
        Enable-IIS
        $port = getAvailablePort
        Add-Website -Name $appName -Path $websitePath -Port $port -Username $Credential.username -Password $Credential.GetNetworkCredential().Password
        # New-Database -Name $databaseName -Instance "$($appName)Instance" -DatabaseDirectory $databasePath
    }
}


function Set-EnvironmentVariable{
    [cmdletBinding()]
    Param(
    [parameter(mandatory = $true)]
        [string]
        $Path
    )

    Process{
        Write-Verbose "Add Environment Variable"
        [Environment]::SetEnvironmentVariable("Tralus", "%USERPROFILE%\$Path", "User")
        [Environment]::SetEnvironmentVariable("TralusWin", "%USERPROFILE%\$Path\Win", "User")
        [Environment]::SetEnvironmentVariable("TralusWeb", "%USERPROFILE%\$Path\Web", "User")
    }
}

function getAvailablePort {
    $websites = @(Get-Website)
    $lastPort = "80"
    if ($websites.Count -gt 0) {
        $lastPort = ($websites.bindings.collection |
            Where-Object {$_.protocol -eq "http"} |  
                ForEach-Object {[int]($_.bindingInformation.split(':')[1])} | 
                    Measure-Object -Maximum).Maximum.ToString()
    }

    $newPort = ([int][String]::Format("{0:9000}",[int]($lastPort.Substring($lastPort.Length - 2)))) + 1
    return $newPort
}

function Add-Workspace {
    [CmdletBinding()]
    Param(
        [parameter(mandatory = $true)]
        [string]
        $Path,


        [parameter(mandatory = $true)]
        [string[]]
        $SubDirectory
    )

    Process {
        Write-Verbose "Creating workspace"
        $SubDirectory | 
            Select-Object @{n = 'Path'; e = {Join-Path $Path $_}} | 
                ForEach-Object {
                    if (-not (Test-Path $_.Path)) {
                        New-Item -ItemType Directory -Path $_.Path | Out-Null
                    } else {
                        Write-Warning "$($_.Path) already exists."
                    }
                }
    }
}

function Grant-WorkspacePermission {
    [CmdletBinding()]
    Param(
        [parameter(mandatory = $true)]
        [string]
        $Path,

        [parameter(mandatory = $true)]
        [string]
        $Identity
        
    )

    Process {
        Write-Verbose "Granting workspace permission"
        if (Test-Path $Path) {
            $target = Get-Item -Path $Path
            $acl = $target.GetAccessControl()
            $permission = $Identity, "Modify", @("ContainerInherit","ObjectInherit"), "None", "Allow"
            $rule = New-Object System.Security.AccessControl.FileSystemAccessRule $permission
            $acl.SetAccessRule($rule)
            $target.SetAccessControl($acl)
        } else {
            Write-Warning "$Path does not exist for applying permission."
        }
    }
}

function Enable-IIS {
    [CmdletBinding()]
    Param(
    )
    
    process {
        $features  = @(
            "IIS-WebServerRole",
            "IIS-WebServer",
            "IIS-CommonHttpFeatures",
            "IIS-HttpErrors",
            "IIS-ApplicationDevelopment",
            "IIS-NetFxExtensibility",
            "IIS-NetFxExtensibility45",
            "IIS-HealthAndDiagnostics",
            "IIS-HttpLogging",
            "IIS-Security",
            "IIS-RequestFiltering",
            "IIS-Performance",
            "IIS-WebServerManagementTools",
           # "IIS-WindowsAuthentication",
            "IIS-StaticContent",
            "IIS-DefaultDocument",
            "IIS-DirectoryBrowsing",
            #"IIS-WebDAV",
            "IIS-ASPNET",
            "IIS-ASPNET45",
            "IIS-ISAPIExtensions",
            "IIS-ISAPIFilter",
            "IIS-HttpCompressionStatic",
            "IIS-ManagementConsole"
        )
        
        $osBuildNumber = Get-CimInstance -ClassName win32_operatingsystem | select -ExpandProperty BuildNumber

        if($osBuildNumber.StartsWith("10")){
                Write-Verbose "Enabling IIS for Windows 10 family"
                Enable-WindowsOptionalFeature -FeatureName $features -All -Online
        }
        else {
            if ($osBuildNumber -eq 9600) {
                Write-Verbose "Enabling IIS for Windows 8 family"
                Enable-WindowsOptionalFeature -FeatureName $features -All -Online
            } else  {
                Write-Verbose "Enabling IIS for Windows 7 family"
                $featureList = ($features | Select-Object @{n='Feature'; e={"`"/FeatureName:$_`""}}).Feature -join " "
                &"dism" "/online" "/enable-feature" $featureList
            }
        }
    }
}

function Add-Website {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $true)]
        [String]$Name,

        [Parameter(Mandatory = $true)]
        [String]$Path,

        [Parameter(Mandatory = $true)]
        [int]$Port,

        [Parameter(Mandatory = $true)]
        [String]$Username,

        [Parameter(Mandatory = $true)]
        [String]$Password

    )
    Process {
        $actualName = "$Name`_$(($env:USERNAME).Replace('.',''))"

        if (-not (Test-Path IIS:\AppPools\$actualName)) {
            Write-Verbose "Creating AppPool $actualName"
            New-WebAppPool -Name $actualName | Out-Null
                        
            Write-Verbose "Configuring AppPool $actualName"
            Set-ItemProperty -Path "IIS:\AppPools\$actualName" -Name ProcessModel.identityType -Value 3
            Set-ItemProperty -Path "IIS:\AppPools\$actualName" -Name ProcessModel.username -Value $Username
            Set-ItemProperty -Path "IIS:\AppPools\$actualName" -Name ProcessModel.password -Value $Password
            Set-ItemProperty (Join-Path "IIS:\AppPools" $actualName) -Name "managedRuntimeVersion" -Value "v4.0"
           
        } else {
            Write-Warning "$actualName ApplicationPool already exists."
        }


        $newWebsiteParams = @{
            "Name" = $actualName
            "Port" = $Port
            "PhysicalPath" = $Path
            "ApplicationPool" = $actualName
        }

        #If there is no website in IIS at all, it throws Index was outside the bound of array exception
        #For workaround this issue we set website Id manually
        if (@(Get-Website).Count -eq 0) {
            $newWebsiteParams += @{
                "Id" = 1
            }
        }

        if (@(Get-Website | ? Name -EQ $actualName).Count -eq 0) {
            Write-Verbose "Creating Website $actualName"
            New-Website @newWebsiteParams | Out-Null
        } else {
            Write-Warning "$actualName website already exists!"
        }

        Write-Verbose "Restarting AppPool"
        Restart-WebAppPool -Name $actualName
    }
}

function New-Database {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $true)]
        [String]$Name,

        [Parameter(Mandatory = $true)]
        [String]$Instance,

        [Parameter(Mandatory = $true)]
        [String]$DatabaseDirectory
    )

    Process {
        Write-Verbose "Checking current localdb instances."
        $existingDB = @(&"sqllocaldb" "i")
        if (-not $existingDB.Contains($Instance)) {
            Write-Verbose "Creating $Instance instances."
            &"sqllocaldb" "c" $Instance
        } else {
            Write-Warning "$Instance instance already exists!"
        }

        #$dbPath = Join-Path $DatabaseDirectory "$Name.mdf"

        #if (-not (Test-Path $dbPath)) {
        #    $createDatabaseCommand = "Create Database $Name on (Name = `"$Name`", FileName = `"$dbPath`")"
        #    Write-Verbose "Createing $Name database on $dbPath"
        #    Invoke-Sqlcmd -ServerInstance "(localdb)\$Instance" -Query $createDatabaseCommand
        #} else {
        #    Write-Warning "[$dbPath] already exists!"
        #}
    }
}
