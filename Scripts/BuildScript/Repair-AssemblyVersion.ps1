 [CmdletBinding()]
    Param (
        [Parameter(Mandatory=$true)]
        [string]
        $AssemblyfilePath
    )
    
    Process {

            $content = Get-Content -Path $AssemblyfilePath
            $defaultVersion = "1.0.0.0"
            $AssemblyFileVersion ="assembly: AssemblyFileVersion" 
            $incorrentVersionRegex =  New-Object -TypeName "Regex" -ArgumentList "(?<!//.+)(?:\d+\.)+\*"

            if ($incorrentVersionRegex.IsMatch($content)) {
            $content = $incorrentVersionRegex.Replace($content, $defaultVersion)
            }

            if(!$content.Contains($AssemblyFileVersion)){
            Add-Content -Value "[assembly: AssemblyFileVersion(""1.0.0.0"")]" -Path $AssemblyfilePath 
            }
   }




