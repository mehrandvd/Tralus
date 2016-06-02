namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkflowAdded : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "System.StateMachineAppearance", name: "State_Id", newName: "StateMachineState_Id");
            RenameIndex(table: "System.StateMachineAppearance", name: "IX_State_Id", newName: "IX_StateMachineState_Id");
            CreateTable(
                "dbo.EFWorkflowDefinitions",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        TypeStorage = c.String(),
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Xaml = c.String(),
                        Criteria = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AutoStartWhenObjectIsCreated = c.Boolean(nullable: false),
                        AutoStartWhenObjectFitsCriteria = c.Boolean(nullable: false),
                        AllowMultipleRuns = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.EFStartWorkflowRequests",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Id = c.Int(nullable: false),
                        TargetWorkflowUniqueId = c.String(),
                        TargetObjectKeyStorage = c.String(),
                        TypeStorage = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.EFRunningWorkflowInstanceInfoes",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Id = c.Int(nullable: false),
                        WorkflowName = c.String(),
                        WorkflowUniqueId = c.String(),
                        TargetObjectHandle = c.String(),
                        ActivityInstanceId = c.Guid(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.EFWorkflowInstanceControlCommandRequests",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Id = c.Int(nullable: false),
                        TargetWorkflowUniqueId = c.String(),
                        TargetActivityInstanceId = c.Guid(nullable: false),
                        Command = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Result = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.EFInstanceKeys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KeyId = c.Guid(nullable: false),
                        InstanceId = c.Guid(nullable: false),
                        Properties = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EFTrackingRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InstanceId = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Data = c.String(),
                        ActivityId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EFWorkflowInstances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(),
                        InstanceId = c.Guid(nullable: false),
                        Status = c.Int(nullable: false),
                        Content = c.String(),
                        Metadata = c.String(),
                        ExpirationDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EFUserActivityVersions",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Id = c.Int(nullable: false),
                        WorkflowUniqueId = c.String(),
                        Xaml = c.String(),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EFUserActivityVersions");
            DropTable("dbo.EFWorkflowInstances");
            DropTable("dbo.EFTrackingRecords");
            DropTable("dbo.EFInstanceKeys");
            DropTable("dbo.EFWorkflowInstanceControlCommandRequests");
            DropTable("dbo.EFRunningWorkflowInstanceInfoes");
            DropTable("dbo.EFStartWorkflowRequests");
            DropTable("dbo.EFWorkflowDefinitions");
            RenameIndex(table: "System.StateMachineAppearance", name: "IX_StateMachineState_Id", newName: "IX_State_Id");
            RenameColumn(table: "System.StateMachineAppearance", name: "StateMachineState_Id", newName: "State_Id");
        }
    }
}
