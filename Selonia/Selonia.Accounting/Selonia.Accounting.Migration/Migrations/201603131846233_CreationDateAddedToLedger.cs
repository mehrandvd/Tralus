namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreationDateAddedToLedger : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccLedgers", "CreationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccLedgers", "CreationDate");
        }
    }
}
