using System.Data.Entity.Migrations;

namespace Tralus.Framework.PowerShell.Migration
{
    public class ApplyingMigration
    {
        public DbMigrator Migrator { get; set; }
        public string MigrationName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Migrator.Configuration, MigrationName);
        }
    }
}