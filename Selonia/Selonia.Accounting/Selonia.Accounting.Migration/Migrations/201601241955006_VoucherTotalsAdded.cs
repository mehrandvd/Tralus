namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoucherTotalsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vouchers", "CreditSum", c => c.Long());
            AddColumn("dbo.Vouchers", "DebitSum", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vouchers", "DebitSum");
            DropColumn("dbo.Vouchers", "CreditSum");
        }
    }
}
