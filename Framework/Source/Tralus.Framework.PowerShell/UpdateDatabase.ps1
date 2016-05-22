cd (Join-Path $HOME 'TralusLocal\win')
Import-Module .\Tralus.Framework.PowerShell.dll

$toMigrate = @("Tralus.Framework.Migration")
$connectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=Tralus;Integrated Security=True;App=Tralus"

Update-TralusDatabase -MigrationAssemblies $toMigrate -ConnectionString $connectionString -WhatIf -Verbose