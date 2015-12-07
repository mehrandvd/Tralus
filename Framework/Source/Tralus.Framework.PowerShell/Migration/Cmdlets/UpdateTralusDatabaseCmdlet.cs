using System.Linq;
using System.Management.Automation;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsData.Update, "TralusDatabase", SupportsShouldProcess = true)]
    public class UpdateTralusDatabaseCmdlet : TralusMigrationCmdletBase
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
                WriteObject(string.Format("\n{0}. Migrating ({1}):", bundleNumber++, migrationBundle));
                
                foreach (var applyingMigration in migrationBundle.MigrationNames)
                {
                    WriteObject(string.Format("\t-[{0}]", applyingMigration));
                }

                if (ShouldProcess("Database", string.Format("Applying migration up to: [{0}]", migrationBundle.TargetMigrationName)))
                {
                    var dbMigrator = migrationBundle.GetNewMigrator();
                    dbMigrator.Update(migrationBundle.TargetMigrationName);

                    WriteObject("\tDone.\n");
                }
            }
        }
    }
}