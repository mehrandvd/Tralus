using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsCommon.Get, "TralusMigrationPlan")]
    public class GetTralusMigrationPlanCmdlet : TralusMigrationCmdletBase
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
                WriteObject(string.Format("\nPart {0} ({1})\n\tContains:", bundleNumber++, migrationBundle));

                foreach (var applyingMigration in migrationBundle.MigrationNames)
                {
                    WriteObject(string.Format("\t\t-{0}", applyingMigration));
                }
            }
        }
    }
}
