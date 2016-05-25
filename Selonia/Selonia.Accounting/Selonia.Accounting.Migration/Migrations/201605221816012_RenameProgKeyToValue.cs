namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProgKeyToValue : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VoucherStates", "ProgrammingKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VoucherStates", "ProgrammingKey", c => c.String());
        }
    }
}
