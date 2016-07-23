namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLevelToVoucherItemSegment : DbMigration
    {
        public override void Up()
        {
            AddColumn("Accounting.VoucherItemSegment", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Accounting.VoucherItemSegment", "Level");
        }
    }
}
