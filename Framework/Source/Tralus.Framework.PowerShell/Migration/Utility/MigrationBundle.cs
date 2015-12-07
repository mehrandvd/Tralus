using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Tralus.Framework.PowerShell.Migration
{
    public class MigrationBundle
    {
        public string SourceMigrationName { get; set; }
        public string TargetMigrationName { get; set; }

        public List<string> MigrationNames { get; set; }

        public DbMigrator Migrator { get; set; }

        public DbMigrator GetNewMigrator()
        {
            return new DbMigrator(Migrator.Configuration);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} -> {2}", Migrator.Configuration, SourceMigrationName ?? "[NULL]",
                TargetMigrationName);
        }
    }
}