using System;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.PowerShell.Migration
{
    public class TralusMigrationCmdletBase : PSCmdlet
    {
        
        [Parameter(Mandatory = true, ParameterSetName = "By ConnectionName")]
        [Parameter(Mandatory = true, ParameterSetName = "By ConnectionString")]
        [Parameter(Mandatory = true, ParameterSetName = "By NoConnection")]
        public string[] MigrationAssemblies { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "By ConnectionName")]
        public string ConnectionName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "By ConnectionString")]
        public string ConnectionString { get; set; }

        protected Migrator GetMigrator()
        {
            var migrator = new Migrator {LogDetail = WriteObject, LogWarning = WriteWarning};

            if (!string.IsNullOrWhiteSpace(ConnectionString))
            {
                migrator.TargetDatabase = new DbConnectionInfo(ConnectionString, "System.Data.SqlClient");
                WriteVerbose(string.Format("Using database: {0}", ConnectionString));
            }
            else if (!string.IsNullOrWhiteSpace(ConnectionName))
            {
                var config = TralusConfiguration.GetConfiguration();
                ConnectionStringSettings connectionString = config.ConnectionStrings.ConnectionStrings[ConnectionName];

                if (connectionString != null)
                {
                    WriteVerbose(string.Format("Using database: [{0}]: {1}", connectionString.Name, connectionString.ConnectionString));
                    migrator.TargetDatabase = new DbConnectionInfo(connectionString.ConnectionString, connectionString.ProviderName);
                }
                else
                {
                    WriteWarning(string.Format("Connection string not found: {0}", ConnectionName));
                }
            }


            foreach (var migrationAssembly in MigrationAssemblies)
            {
                try
                {
                    var assembly = Assembly.Load(migrationAssembly);
                    migrator.MigrationAssemblies.Add(assembly);
                    
                    if (assembly == null)
                        throw new Exception("Unable to load module. Returned assembly is null.");
                }

                catch (Exception exception)
                {
                    WriteWarning(string.Format("Unable to load assembly: {0}", migrationAssembly));
                    WriteWarning(exception.ToString());
                }
            }
            return migrator;
        }
    }
}
