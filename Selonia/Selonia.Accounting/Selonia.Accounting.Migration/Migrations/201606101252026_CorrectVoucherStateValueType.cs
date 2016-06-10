namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectVoucherStateValueType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Accounting.VoucherState", "Value", c => c.String());
        }

        public override void Down()
        {
        }
    }
}
