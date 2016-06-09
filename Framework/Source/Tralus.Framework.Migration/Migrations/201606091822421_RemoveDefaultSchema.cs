namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDefaultSchema : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "Tralus.Analyses", newName: "Analysis");
            RenameTable(name: "Tralus.EFInstanceKeys", newName: "EFInstanceKey");
            RenameTable(name: "Tralus.EFRunningWorkflowInstanceInfoes", newName: "EFRunningWorkflowInstanceInfo");
            RenameTable(name: "Tralus.EFStartWorkflowRequests", newName: "EFStartWorkflowRequest");
            RenameTable(name: "Tralus.EFTrackingRecords", newName: "EFTrackingRecord");
            RenameTable(name: "Tralus.EFUserActivityVersions", newName: "EFUserActivityVersion");
            RenameTable(name: "Tralus.EFWorkflowDefinitions", newName: "EFWorkflowDefinition");
            RenameTable(name: "Tralus.EFWorkflowInstances", newName: "EFWorkflowInstance");
            RenameTable(name: "Tralus.EFWorkflowInstanceControlCommandRequests", newName: "EFWorkflowInstanceControlCommandRequest");
            RenameTable(name: "Tralus.ModelDifferences", newName: "ModelDifference");
            RenameTable(name: "Tralus.ModelDifferenceAspects", newName: "ModelDifferenceAspect");
        }
        
        public override void Down()
        {
            RenameTable(name: "Tralus.ModelDifferenceAspect", newName: "ModelDifferenceAspects");
            RenameTable(name: "Tralus.ModelDifference", newName: "ModelDifferences");
            RenameTable(name: "Tralus.EFWorkflowInstanceControlCommandRequest", newName: "EFWorkflowInstanceControlCommandRequests");
            RenameTable(name: "Tralus.EFWorkflowInstance", newName: "EFWorkflowInstances");
            RenameTable(name: "Tralus.EFWorkflowDefinition", newName: "EFWorkflowDefinitions");
            RenameTable(name: "Tralus.EFUserActivityVersion", newName: "EFUserActivityVersions");
            RenameTable(name: "Tralus.EFTrackingRecord", newName: "EFTrackingRecords");
            RenameTable(name: "Tralus.EFStartWorkflowRequest", newName: "EFStartWorkflowRequests");
            RenameTable(name: "Tralus.EFRunningWorkflowInstanceInfo", newName: "EFRunningWorkflowInstanceInfoes");
            RenameTable(name: "Tralus.EFInstanceKey", newName: "EFInstanceKeys");
            RenameTable(name: "Tralus.Analysis", newName: "Analyses");
        }
    }
}
