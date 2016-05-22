namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProgKeyToValue : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VoucherStates", "ProgrammingKey");
            AddColumn("dbo.VoucherStates", "Value", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VoucherStates", "Value");
            AddColumn("dbo.VoucherStates", "ProgrammingKey", c => c.String());
        }
    }
}
