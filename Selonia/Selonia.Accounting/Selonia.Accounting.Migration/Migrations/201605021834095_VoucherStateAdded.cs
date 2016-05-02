namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoucherStateAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VoucherStates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Int(nullable: false),
                        ProgrammingKey = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vouchers", "VoucherState_Id", c => c.Guid());
            CreateIndex("dbo.Vouchers", "VoucherState_Id");
            AddForeignKey("dbo.Vouchers", "VoucherState_Id", "dbo.VoucherStates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vouchers", "VoucherState_Id", "dbo.VoucherStates");
            DropIndex("dbo.Vouchers", new[] { "VoucherState_Id" });
            DropColumn("dbo.Vouchers", "VoucherState_Id");
            DropTable("dbo.VoucherStates");
        }
    }
}
