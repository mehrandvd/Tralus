using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsCommon.Get, "TralusMigrationScript")]
    public class GetTralusMigrationScriptCmdlet : TralusMigrationCmdletBase
    {
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            var migrator = GetMigrator();

            var migrationBundles = migrator.GetMigrationPlan();

            if (!migrationBundles.Any())
            {
                WriteWarning("No pending migration.");
                return;
            }

            var bundleNumber = 1;

            foreach (var migrationBundle in migrationBundles)
            {
                WriteObject(string.Format("\n-- Part {0}: {1}\n--\tContains:", bundleNumber++, migrationBundle));
                
                foreach (var applyingMigration in migrationBundle.MigrationNames)
                {
                    WriteObject(string.Format("--\t\t-{0}", applyingMigration));
                }

                var scriptor = new MigratorScriptingDecorator(migrationBundle.GetNewMigrator());
                var script = scriptor.ScriptUpdate(migrationBundle.SourceMigrationName, migrationBundle.TargetMigrationName);
                
                WriteObject(script);
            }
        }
    }
}