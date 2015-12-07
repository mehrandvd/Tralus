using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Management.Automation;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsCommon.Get, "TralusMigrationDatabases")]
    public class GetTralusMigrationDatabasesCmdlet : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            var config = TralusConfiguration.GetConfiguration();

            foreach (ConnectionStringSettings connectionString in config.ConnectionStrings.ConnectionStrings)
            {
                WriteObject(string.Format("[{0}]:\t\t\t{1}", connectionString.Name, connectionString.ConnectionString));
            }
        }
    }
}
