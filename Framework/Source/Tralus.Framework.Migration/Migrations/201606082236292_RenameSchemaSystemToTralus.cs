namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSchemaSystemToTralus : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "System.StateMachineAppearance", newSchema: "Tralus");
            MoveTable(name: "System.StateMachineState", newSchema: "Tralus");
            MoveTable(name: "System.StateMachine", newSchema: "Tralus");
            MoveTable(name: "System.StateMachineTransition", newSchema: "Tralus");
            MoveTable(name: "System.CandidateUser", newSchema: "Tralus");
            MoveTable(name: "System.DummyObject", newSchema: "Tralus");
            MoveTable(name: "System.EntityNumbering", newSchema: "Tralus");
            MoveTable(name: "System.EntityRuleScript", newSchema: "Tralus");
            MoveTable(name: "System.EntitySequence", newSchema: "Tralus");
            MoveTable(name: "System.EntitySequenceItem", newSchema: "Tralus");
            MoveTable(name: "System.Role", newSchema: "Tralus");
            MoveTable(name: "System.TypePermissionObject", newSchema: "Tralus");
            MoveTable(name: "System.SecuritySystemInstancePermissionsObject", newSchema: "Tralus");
            MoveTable(name: "System.SecuritySystemMemberPermissionsObject", newSchema: "Tralus");
            MoveTable(name: "System.SecuritySystemObjectPermissionsObject", newSchema: "Tralus");
            MoveTable(name: "System.User", newSchema: "Tralus");
            MoveTable(name: "System.SystemEnvironmentTest", newSchema: "Tralus");
            MoveTable(name: "dbo.ReportDataV2", newSchema: "Tralus");
            MoveTable(name: "dbo.Analyses", newSchema: "Tralus");
            MoveTable(name: "dbo.EFWorkflowDefinitions", newSchema: "Tralus");
            MoveTable(name: "dbo.EFStartWorkflowRequests", newSchema: "Tralus");
            MoveTable(name: "dbo.EFRunningWorkflowInstanceInfoes", newSchema: "Tralus");
            MoveTable(name: "dbo.EFWorkflowInstanceControlCommandRequests", newSchema: "Tralus");
            MoveTable(name: "dbo.EFInstanceKeys", newSchema: "Tralus");
            MoveTable(name: "dbo.EFTrackingRecords", newSchema: "Tralus");
            MoveTable(name: "dbo.EFWorkflowInstances", newSchema: "Tralus");
            MoveTable(name: "dbo.EFUserActivityVersions", newSchema: "Tralus");
            MoveTable(name: "dbo.ModelDifferences", newSchema: "Tralus");
            MoveTable(name: "dbo.ModelDifferenceAspects", newSchema: "Tralus");
            MoveTable(name: "System.RoleRoles", newSchema: "Tralus");
            MoveTable(name: "System.UserRoles", newSchema: "Tralus");
        }
        
        public override void Down()
        {
            MoveTable(name: "Tralus.UserRoles", newSchema: "System");
            MoveTable(name: "Tralus.RoleRoles", newSchema: "System");
            MoveTable(name: "Tralus.ModelDifferenceAspects", newSchema: "dbo");
            MoveTable(name: "Tralus.ModelDifferences", newSchema: "dbo");
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
            MoveTable(name: "Tralus.SystemEnvironmentTest", newSchema: "System");
            MoveTable(name: "Tralus.User", newSchema: "System");
            MoveTable(name: "Tralus.SecuritySystemObjectPermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.SecuritySystemMemberPermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.SecuritySystemInstancePermissionsObject", newSchema: "System");
            MoveTable(name: "Tralus.TypePermissionObject", newSchema: "System");
            MoveTable(name: "Tralus.Role", newSchema: "System");
            MoveTable(name: "Tralus.EntitySequenceItem", newSchema: "System");
            MoveTable(name: "Tralus.EntitySequence", newSchema: "System");
            MoveTable(name: "Tralus.EntityRuleScript", newSchema: "System");
            MoveTable(name: "Tralus.EntityNumbering", newSchema: "System");
            MoveTable(name: "Tralus.DummyObject", newSchema: "System");
            MoveTable(name: "Tralus.CandidateUser", newSchema: "System");
            MoveTable(name: "Tralus.StateMachineTransition", newSchema: "System");
            MoveTable(name: "Tralus.StateMachine", newSchema: "System");
            MoveTable(name: "Tralus.StateMachineState", newSchema: "System");
            MoveTable(name: "Tralus.StateMachineAppearance", newSchema: "System");
        }
    }
}
