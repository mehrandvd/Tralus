namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityScriptAdded : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "System.StateMachineAppearance", name: "StateMachineState_Id", newName: "State_Id");
            //RenameIndex(table: "System.StateMachineAppearance", name: "IX_StateMachineState_Id", newName: "IX_State_Id");
            CreateTable(
                "System.EntityScript",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Script = c.String(),
                        ExecutionType = c.Int(nullable: false),
                        WhenToRun = c.Int(nullable: false),
                        PropertyName = c.String(),
                        TargetTypeFullName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("System.EntityScript");
            //RenameIndex(table: "System.StateMachineAppearance", name: "IX_State_Id", newName: "IX_StateMachineState_Id");
            //RenameColumn(table: "System.StateMachineAppearance", name: "State_Id", newName: "StateMachineState_Id");
        }
    }
}
