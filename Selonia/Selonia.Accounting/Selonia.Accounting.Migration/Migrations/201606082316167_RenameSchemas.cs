namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSchemas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccGenerals", newName: "AccGeneral");
            RenameTable(name: "dbo.AccGroups", newName: "AccGroup");
            RenameTable(name: "dbo.AccLedgers", newName: "AccLedger");
            RenameTable(name: "dbo.Segments", newName: "Segment");
            RenameTable(name: "dbo.SegmentGroups", newName: "SegmentGroup");
            RenameTable(name: "dbo.Vouchers", newName: "Voucher");
            RenameTable(name: "dbo.VoucherItems", newName: "VoucherItem");
            RenameTable(name: "dbo.VoucherItemSegments", newName: "VoucherItemSegment");
            RenameTable(name: "dbo.VoucherStates", newName: "VoucherState");
            RenameTable(name: "dbo.VoucherTypes", newName: "VoucherType");
            //MoveTable(name: "System.StateMachineAppearance", newSchema: "Tralus");
            //MoveTable(name: "System.StateMachine", newSchema: "Tralus");
            //MoveTable(name: "System.StateMachineState", newSchema: "Tralus");
            //MoveTable(name: "System.StateMachineTransition", newSchema: "Tralus");
            MoveTable(name: "dbo.AccGeneral", newSchema: "Accounting");
            MoveTable(name: "dbo.AccGroup", newSchema: "Accounting");
            MoveTable(name: "dbo.AccLedger", newSchema: "Accounting");
            MoveTable(name: "dbo.Segment", newSchema: "Accounting");
            MoveTable(name: "dbo.SegmentGroup", newSchema: "Accounting");
            MoveTable(name: "dbo.Voucher", newSchema: "Accounting");
            MoveTable(name: "dbo.VoucherItem", newSchema: "Accounting");
            MoveTable(name: "dbo.VoucherItemSegment", newSchema: "Accounting");
            MoveTable(name: "dbo.VoucherState", newSchema: "Accounting");
            MoveTable(name: "dbo.VoucherType", newSchema: "Accounting");
            //MoveTable(name: "System.User", newSchema: "Tralus");
            //MoveTable(name: "System.Role", newSchema: "Tralus");
            //MoveTable(name: "System.TypePermissionObject", newSchema: "Tralus");
            //MoveTable(name: "System.SecuritySystemInstancePermissionsObject", newSchema: "Tralus");
            //MoveTable(name: "System.SecuritySystemMemberPermissionsObject", newSchema: "Tralus");
            //MoveTable(name: "System.SecuritySystemObjectPermissionsObject", newSchema: "Tralus");
            //MoveTable(name: "dbo.ReportDataV2", newSchema: "Tralus");
            //MoveTable(name: "dbo.Analyses", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFWorkflowDefinitions", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFStartWorkflowRequests", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFRunningWorkflowInstanceInfoes", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFWorkflowInstanceControlCommandRequests", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFInstanceKeys", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFTrackingRecords", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFWorkflowInstances", newSchema: "Tralus");
            //MoveTable(name: "dbo.EFUserActivityVersions", newSchema: "Tralus");
            //MoveTable(name: "System.UserRoles", newSchema: "Tralus");
            //MoveTable(name: "System.RoleRoles", newSchema: "Tralus");
            //RenameColumn(table: "Tralus.StateMachineAppearance", name: "StateMachineState_Id", newName: "State_Id");
            //RenameIndex(table: "Tralus.StateMachineAppearance", name: "IX_StateMachineState_Id", newName: "IX_State_Id");
            //CreateTable(
            //    "Tralus.ModelDifferences",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            UserId = c.String(),
            //            ContextId = c.String(),
            //            Version = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "Tralus.ModelDifferenceAspects",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Xml = c.String(),
            //            Owner_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("Tralus.ModelDifferences", t => t.Owner_ID)
            //    .Index(t => t.Owner_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Tralus.ModelDifferenceAspects", "Owner_ID", "Tralus.ModelDifferences");
            DropIndex("Tralus.ModelDifferenceAspects", new[] { "Owner_ID" });
            DropTable("Tralus.ModelDifferenceAspects");
            DropTable("Tralus.ModelDifferences");
            RenameIndex(table: "Tralus.StateMachineAppearance", name: "IX_State_Id", newName: "IX_StateMachineState_Id");
            RenameColumn(table: "Tralus.StateMachineAppearance", name: "State_Id", newName: "StateMachineState_Id");
            MoveTable(name: "Tralus.RoleRoles", newSchema: "System");
            MoveTable(name: "Tralus.UserRoles", newSchema: "System");
            MoveTable(name: "Tralus.EFUserActivityVersions", newSchema: "dbo");
            MoveTable(name: "Tralus.EFWorkflowInstances", newSchema: "dbo");
            MoveTable(name: "Tralus.EFTrackingRecords", newSchema: "dbo");
            MoveTable(name: "Tralus.EFInstanceKeys", newSchema: "dbo");
            MoveTable(name: "Tralus.EFWorkflowInstanceControlCommandRequests", newSchema: "dbo");
            MoveTable(name: "Tralus.EFRunningWorkflowInstanceInfoes", newSchema: "dbo");
            MoveTable(name: "Tralus.EFStartWorkflowRequests", newSchema: "dbo");
            MoveTable(name: "Tralus.EFWorkflowDefinitions", newSchema: "dbo");
            MoveTable(name: "Tralus.Analyses", newSchema: "dbo");
            MoveTable(name: "Tralus.ReportDataV2", newSchema: "dbo");
            MoveTable(name: "Tralus.SecuritySystemObjectPermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.SecuritySystemMemberPermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.SecuritySystemInstancePermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.TypePermissionObject", newSchema: "System");
            MoveTable(name: "Tralus.Role", newSchema: "System");
            MoveTable(name: "Tralus.User", newSchema: "System");
            MoveTable(name: "Accounting.VoucherType", newSchema: "dbo");
            MoveTable(name: "Accounting.VoucherState", newSchema: "dbo");
            MoveTable(name: "Accounting.VoucherItemSegment", newSchema: "dbo");
            MoveTable(name: "Accounting.VoucherItem", newSchema: "dbo");
            MoveTable(name: "Accounting.Voucher", newSchema: "dbo");
            MoveTable(name: "Accounting.SegmentGroup", newSchema: "dbo");
            MoveTable(name: "Accounting.Segment", newSchema: "dbo");
            MoveTable(name: "Accounting.AccLedger", newSchema: "dbo");
            MoveTable(name: "Accounting.AccGroup", newSchema: "dbo");
            MoveTable(name: "Accounting.AccGeneral", newSchema: "dbo");
            MoveTable(name: "Tralus.StateMachineTransition", newSchema: "System");
            MoveTable(name: "Tralus.StateMachineState", newSchema: "System");
            MoveTable(name: "Tralus.StateMachine", newSchema: "System");
            MoveTable(name: "Tralus.StateMachineAppearance", newSchema: "System");
            RenameTable(name: "dbo.VoucherType", newName: "VoucherTypes");
            RenameTable(name: "dbo.VoucherState", newName: "VoucherStates");
            RenameTable(name: "dbo.VoucherItemSegment", newName: "VoucherItemSegments");
            RenameTable(name: "dbo.VoucherItem", newName: "VoucherItems");
            RenameTable(name: "dbo.Voucher", newName: "Vouchers");
            RenameTable(name: "dbo.SegmentGroup", newName: "SegmentGroups");
            RenameTable(name: "dbo.Segment", newName: "Segments");
            RenameTable(name: "dbo.AccLedger", newName: "AccLedgers");
            RenameTable(name: "dbo.AccGroup", newName: "AccGroups");
            RenameTable(name: "dbo.AccGeneral", newName: "AccGenerals");
        }
    }
}
