namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFiscalYear : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.FiscalYear",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Accounting.AccLedger", "FiscalYear_Id", c => c.Guid());
            AddColumn("Accounting.Voucher", "FiscalYear_Id", c => c.Guid());
            CreateIndex("Accounting.AccLedger", "FiscalYear_Id");
            CreateIndex("Accounting.Voucher", "FiscalYear_Id");
            AddForeignKey("Accounting.AccLedger", "FiscalYear_Id", "Accounting.FiscalYear", "Id");
            AddForeignKey("Accounting.Voucher", "FiscalYear_Id", "Accounting.FiscalYear", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Accounting.Voucher", "FiscalYear_Id", "Accounting.FiscalYear");
            DropForeignKey("Accounting.AccLedger", "FiscalYear_Id", "Accounting.FiscalYear");
            DropIndex("Accounting.Voucher", new[] { "FiscalYear_Id" });
            DropIndex("Accounting.AccLedger", new[] { "FiscalYear_Id" });
            DropColumn("Accounting.Voucher", "FiscalYear_Id");
            DropColumn("Accounting.AccLedger", "FiscalYear_Id");
            DropTable("Accounting.FiscalYear");
        }
    }
}
