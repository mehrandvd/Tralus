using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.Data;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsData.Publish, "TralusDatabaseSeed", SupportsShouldProcess = true)]
    public class RunTralusMigrationSeedCmdlet : TralusMigrationCmdletBase
    {
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            DbConnectionInfo dbConnectionInfo = null;
            var cstr = "";

            if (!string.IsNullOrWhiteSpace(ConnectionString))
            {
                dbConnectionInfo = new DbConnectionInfo(ConnectionString, "System.Data.SqlClient");
                WriteVerbose(string.Format("Using database: {0}", ConnectionString));
                cstr = ConnectionString;
            }
            else if (!string.IsNullOrWhiteSpace(ConnectionName))
            {
                var config = TralusConfiguration.GetConfiguration();
                ConnectionStringSettings connectionString = config.ConnectionStrings.ConnectionStrings[ConnectionName];

                if (connectionString != null)
                {
                    WriteVerbose(string.Format("Using database: [{0}]: {1}", connectionString.Name, connectionString.ConnectionString));
                    dbConnectionInfo = new DbConnectionInfo(connectionString.ConnectionString, connectionString.ProviderName);
                    cstr = connectionString.ConnectionString;
                }
                else
                {
                    WriteWarning(string.Format("Connection string not found: {0}", ConnectionName));
                }
            }

            if (!string.IsNullOrWhiteSpace(cstr))
            {
                foreach (var migrationAssembly in MigrationAssemblies)
                {
                    try
                    {
                        var assembly = Assembly.Load(migrationAssembly);

                        var configTypes = assembly.GetTypes()
                            .Where(t => t.IsSubclassOf(typeof(DbMigrationsConfiguration)) && !t.IsAbstract);

                        var configs = configTypes.Select(Activator.CreateInstance);

                        foreach (var config in configs)
                        {
                            var type = config.GetType();
                            var method = type.GetMethod("ApplySeed");
                            method.Invoke(config, new object[]{cstr});
                        }


                    }

                    catch (Exception exception)
                    {
                        WriteWarning(string.Format("Unable to load assembly: {0}", migrationAssembly));
                        WriteWarning(exception.ToString());
                    }
                }
            }
        }
    }
}
