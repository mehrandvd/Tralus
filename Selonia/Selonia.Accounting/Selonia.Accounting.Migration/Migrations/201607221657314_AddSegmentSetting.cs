namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSegmentSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.LedgerSegmentSetting",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Level = c.Int(nullable: false),
                        IsMandatory = c.Boolean(nullable: false),
                        Description = c.String(),
                        Ledger_Id = c.Guid(),
                        SegmentGroup_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Accounting.AccLedger", t => t.Ledger_Id)
                .ForeignKey("Accounting.SegmentGroup", t => t.SegmentGroup_Id)
                .Index(t => t.Ledger_Id)
                .Index(t => t.SegmentGroup_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Accounting.LedgerSegmentSetting", "SegmentGroup_Id", "Accounting.SegmentGroup");
            DropForeignKey("Accounting.LedgerSegmentSetting", "Ledger_Id", "Accounting.AccLedger");
            DropIndex("Accounting.LedgerSegmentSetting", new[] { "SegmentGroup_Id" });
            DropIndex("Accounting.LedgerSegmentSetting", new[] { "Ledger_Id" });
            DropTable("Accounting.LedgerSegmentSetting");
        }
    }
}
