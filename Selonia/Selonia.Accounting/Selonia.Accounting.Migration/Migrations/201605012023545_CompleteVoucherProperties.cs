namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompleteVoucherProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VoucherTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Analyses",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Criteria = c.String(),
            //            ObjectTypeName = c.String(),
            //            DimensionPropertiesString = c.String(),
            //            PivotGridSettingsContent = c.Binary(),
            //            ChartSettingsContent = c.Binary(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Vouchers", "TempNo", c => c.String());
            AddColumn("dbo.Vouchers", "FixNo", c => c.String());
            AddColumn("dbo.Vouchers", "Description", c => c.String());
            AddColumn("dbo.Vouchers", "VoucherType_Id", c => c.Guid());
            CreateIndex("dbo.Vouchers", "VoucherType_Id");
            AddForeignKey("dbo.Vouchers", "VoucherType_Id", "dbo.VoucherTypes", "Id");
            DropColumn("dbo.Vouchers", "VoucherNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vouchers", "VoucherNo", c => c.String());
            DropForeignKey("dbo.Vouchers", "VoucherType_Id", "dbo.VoucherTypes");
            DropIndex("dbo.Vouchers", new[] { "VoucherType_Id" });
            DropColumn("dbo.Vouchers", "VoucherType_Id");
            DropColumn("dbo.Vouchers", "Description");
            DropColumn("dbo.Vouchers", "FixNo");
            DropColumn("dbo.Vouchers", "TempNo");
            //DropTable("dbo.Analyses");
            DropTable("dbo.VoucherTypes");
        }
    }
}
