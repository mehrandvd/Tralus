namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitAcc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccGenerals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        Group_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccGroups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.AccGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccLedgers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        General_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccGenerals", t => t.General_Id)
                .Index(t => t.General_Id);
            
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        SegmentGroup_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SegmentGroups", t => t.SegmentGroup_Id)
                .Index(t => t.SegmentGroup_Id);
            
            CreateTable(
                "dbo.SegmentGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VoucherDate = c.DateTime(),
                        VoucherNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VoucherItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RowNo = c.Int(nullable: false),
                        Debit = c.Long(nullable: false),
                        Credit = c.Long(nullable: false),
                        Description = c.String(),
                        Ledger_Id = c.Guid(),
                        Voucher_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccLedgers", t => t.Ledger_Id)
                .ForeignKey("dbo.Vouchers", t => t.Voucher_Id)
                .Index(t => t.Ledger_Id)
                .Index(t => t.Voucher_Id);
            
            CreateTable(
                "dbo.VoucherItemSegments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Segment_Id = c.Guid(),
                        VoucherItem_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Segments", t => t.Segment_Id)
                .ForeignKey("dbo.VoucherItems", t => t.VoucherItem_Id)
                .Index(t => t.Segment_Id)
                .Index(t => t.VoucherItem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VoucherItems", "Voucher_Id", "dbo.Vouchers");
            DropForeignKey("dbo.VoucherItemSegments", "VoucherItem_Id", "dbo.VoucherItems");
            DropForeignKey("dbo.VoucherItemSegments", "Segment_Id", "dbo.Segments");
            DropForeignKey("dbo.VoucherItems", "Ledger_Id", "dbo.AccLedgers");
            DropForeignKey("dbo.Segments", "SegmentGroup_Id", "dbo.SegmentGroups");
            DropForeignKey("dbo.AccLedgers", "General_Id", "dbo.AccGenerals");
            DropForeignKey("dbo.AccGenerals", "Group_Id", "dbo.AccGroups");
            DropIndex("dbo.VoucherItemSegments", new[] { "VoucherItem_Id" });
            DropIndex("dbo.VoucherItemSegments", new[] { "Segment_Id" });
            DropIndex("dbo.VoucherItems", new[] { "Voucher_Id" });
            DropIndex("dbo.VoucherItems", new[] { "Ledger_Id" });
            DropIndex("dbo.Segments", new[] { "SegmentGroup_Id" });
            DropIndex("dbo.AccLedgers", new[] { "General_Id" });
            DropIndex("dbo.AccGenerals", new[] { "Group_Id" });
            DropTable("dbo.VoucherItemSegments");
            DropTable("dbo.VoucherItems");
            DropTable("dbo.Vouchers");
            DropTable("dbo.SegmentGroups");
            DropTable("dbo.Segments");
            DropTable("dbo.AccLedgers");
            DropTable("dbo.AccGroups");
            DropTable("dbo.AccGenerals");
        }
    }
}
