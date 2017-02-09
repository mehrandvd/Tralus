namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FrameworkMergeDashboadKpiAcc : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.DashboardDatas",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Content = c.String(),
            //            Title = c.String(),
            //            SynchronizeTitle = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.KpiDefinitions",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Active = c.Boolean(nullable: false),
            //            TargetObjectTypeFullName = c.String(),
            //            Criteria = c.String(),
            //            Expression = c.String(),
            //            GreenZone = c.Single(nullable: false),
            //            RedZone = c.Single(nullable: false),
            //            Compare = c.Boolean(nullable: false),
            //            RangeName = c.String(),
            //            RangeToCompareName = c.String(),
            //            MeasurementFrequency = c.Int(nullable: false),
            //            MeasurementMode = c.Int(nullable: false),
            //            Direction = c.Int(nullable: false),
            //            ChangedOn = c.DateTime(nullable: false),
            //            SuppressedSeries = c.String(),
            //            EnableCustomizeRepresentation = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.KpiInstances",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            ForceMeasurementDateTime = c.DateTime(),
            //            Settings = c.String(),
            //            KpiDefinition_ID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.KpiDefinitions", t => t.KpiDefinition_ID, cascadeDelete: true)
            //    .Index(t => t.KpiDefinition_ID);
            
            //CreateTable(
            //    "dbo.KpiHistoryItems",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            RangeStart = c.DateTime(nullable: false),
            //            RangeEnd = c.DateTime(nullable: false),
            //            Value = c.Single(nullable: false),
            //            KpiInstance_ID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.KpiInstances", t => t.KpiInstance_ID, cascadeDelete: true)
            //    .Index(t => t.KpiInstance_ID);
            
            //CreateTable(
            //    "dbo.KpiScorecards",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.KpiInstanceKpiScorecards",
            //    c => new
            //        {
            //            KpiInstance_ID = c.Int(nullable: false),
            //            KpiScorecard_ID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.KpiInstance_ID, t.KpiScorecard_ID })
            //    .ForeignKey("dbo.KpiInstances", t => t.KpiInstance_ID, cascadeDelete: true)
            //    .ForeignKey("dbo.KpiScorecards", t => t.KpiScorecard_ID, cascadeDelete: true)
            //    .Index(t => t.KpiInstance_ID)
            //    .Index(t => t.KpiScorecard_ID);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.KpiInstances", "KpiDefinition_ID", "dbo.KpiDefinitions");
            //DropForeignKey("dbo.KpiInstanceKpiScorecards", "KpiScorecard_ID", "dbo.KpiScorecards");
            //DropForeignKey("dbo.KpiInstanceKpiScorecards", "KpiInstance_ID", "dbo.KpiInstances");
            //DropForeignKey("dbo.KpiHistoryItems", "KpiInstance_ID", "dbo.KpiInstances");
            //DropIndex("dbo.KpiInstanceKpiScorecards", new[] { "KpiScorecard_ID" });
            //DropIndex("dbo.KpiInstanceKpiScorecards", new[] { "KpiInstance_ID" });
            //DropIndex("dbo.KpiHistoryItems", new[] { "KpiInstance_ID" });
            //DropIndex("dbo.KpiInstances", new[] { "KpiDefinition_ID" });
            //DropTable("dbo.KpiInstanceKpiScorecards");
            //DropTable("dbo.KpiScorecards");
            //DropTable("dbo.KpiHistoryItems");
            //DropTable("dbo.KpiInstances");
            //DropTable("dbo.KpiDefinitions");
            //DropTable("dbo.DashboardDatas");
        }
    }
}
