namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitForDevDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "System.StateMachineAppearance",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TargetItems = c.String(),
                        AppearanceItemType = c.String(),
                        Criteria = c.String(),
                        Context = c.String(),
                        Priority = c.Int(nullable: false),
                        FontStyle = c.Int(),
                        FontColorInt = c.Int(nullable: false),
                        BackColorInt = c.Int(nullable: false),
                        Visibility = c.Int(),
                        Enabled = c.Boolean(),
                        Method = c.String(),
                        State_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.StateMachineState", t => t.State_Id)
                .Index(t => t.State_Id);
            
            CreateTable(
                "System.StateMachineState",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Caption = c.String(),
                        MarkerValue = c.String(),
                        TargetObjectCriteria = c.String(),
                        StateMachine_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.StateMachine", t => t.StateMachine_Id)
                .Index(t => t.StateMachine_Id);
            
            CreateTable(
                "System.StateMachine",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                        TargetObjectTypeName = c.String(),
                        StatePropertyNameBase = c.String(),
                        ExpandActionsInDetailView = c.Boolean(nullable: false),
                        StartState_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.StateMachineState", t => t.StartState_Id)
                .Index(t => t.StartState_Id);
            
            CreateTable(
                "System.StateMachineTransition",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Caption = c.String(),
                        Index = c.Int(nullable: false),
                        SaveAndCloseView = c.Boolean(nullable: false),
                        TargetState_Id = c.Guid(),
                        SourceState_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.StateMachineState", t => t.TargetState_Id)
                .ForeignKey("System.StateMachineState", t => t.SourceState_Id)
                .Index(t => t.TargetState_Id)
                .Index(t => t.SourceState_Id);
            
            CreateTable(
                "System.CandidateUser",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.Role",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsAdministrative = c.Boolean(nullable: false),
                        CanEditModel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.TypePermissionObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Permissions = c.String(),
                        AllowRead = c.Boolean(nullable: false),
                        AllowWrite = c.Boolean(nullable: false),
                        AllowCreate = c.Boolean(nullable: false),
                        AllowDelete = c.Boolean(nullable: false),
                        AllowNavigate = c.Boolean(nullable: false),
                        TargetTypeFullName = c.String(),
                        Role_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.Role", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "System.SecuritySystemInstancePermissionsObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Operations = c.String(),
                        InstanceId = c.Guid(),
                        Owner_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.TypePermissionObject", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "System.SecuritySystemMemberPermissionsObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Members = c.String(),
                        Criteria = c.String(),
                        AllowRead = c.Boolean(nullable: false),
                        AllowWrite = c.Boolean(nullable: false),
                        EffectiveRead = c.Boolean(),
                        EffectiveWrite = c.Boolean(),
                        Owner_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.TypePermissionObject", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "System.SecuritySystemObjectPermissionsObject",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Permissions = c.String(),
                        Criteria = c.String(),
                        AllowRead = c.Boolean(nullable: false),
                        AllowWrite = c.Boolean(nullable: false),
                        AllowDelete = c.Boolean(nullable: false),
                        AllowNavigate = c.Boolean(nullable: false),
                        EffectiveRead = c.Boolean(),
                        EffectiveWrite = c.Boolean(),
                        EffectiveDelete = c.Boolean(),
                        EffectiveNavigate = c.Boolean(),
                        Owner_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.TypePermissionObject", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "System.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ChangePasswordOnFirstLogon = c.Boolean(nullable: false),
                        StoredPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.RoleRoles",
                c => new
                    {
                        ParentRoleId = c.Guid(nullable: false),
                        ChildRoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ParentRoleId, t.ChildRoleId })
                .ForeignKey("System.Role", t => t.ParentRoleId)
                .ForeignKey("System.Role", t => t.ChildRoleId)
                .Index(t => t.ParentRoleId)
                .Index(t => t.ChildRoleId);
            
            CreateTable(
                "System.UserRoles",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("System.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("System.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("System.UserRoles", "RoleId", "System.Role");
            DropForeignKey("System.UserRoles", "UserId", "System.User");
            DropForeignKey("System.TypePermissionObject", "Role_Id", "System.Role");
            DropForeignKey("System.SecuritySystemObjectPermissionsObject", "Owner_Id", "System.TypePermissionObject");
            DropForeignKey("System.SecuritySystemMemberPermissionsObject", "Owner_Id", "System.TypePermissionObject");
            DropForeignKey("System.SecuritySystemInstancePermissionsObject", "Owner_Id", "System.TypePermissionObject");
            DropForeignKey("System.RoleRoles", "ChildRoleId", "System.Role");
            DropForeignKey("System.RoleRoles", "ParentRoleId", "System.Role");
            DropForeignKey("System.StateMachineTransition", "SourceState_Id", "System.StateMachineState");
            DropForeignKey("System.StateMachineTransition", "TargetState_Id", "System.StateMachineState");
            DropForeignKey("System.StateMachineState", "StateMachine_Id", "System.StateMachine");
            DropForeignKey("System.StateMachine", "StartState_Id", "System.StateMachineState");
            DropForeignKey("System.StateMachineAppearance", "State_Id", "System.StateMachineState");
            DropIndex("System.UserRoles", new[] { "RoleId" });
            DropIndex("System.UserRoles", new[] { "UserId" });
            DropIndex("System.RoleRoles", new[] { "ChildRoleId" });
            DropIndex("System.RoleRoles", new[] { "ParentRoleId" });
            DropIndex("System.SecuritySystemObjectPermissionsObject", new[] { "Owner_Id" });
            DropIndex("System.SecuritySystemMemberPermissionsObject", new[] { "Owner_Id" });
            DropIndex("System.SecuritySystemInstancePermissionsObject", new[] { "Owner_Id" });
            DropIndex("System.TypePermissionObject", new[] { "Role_Id" });
            DropIndex("System.StateMachineTransition", new[] { "SourceState_Id" });
            DropIndex("System.StateMachineTransition", new[] { "TargetState_Id" });
            DropIndex("System.StateMachine", new[] { "StartState_Id" });
            DropIndex("System.StateMachineState", new[] { "StateMachine_Id" });
            DropIndex("System.StateMachineAppearance", new[] { "State_Id" });
            DropTable("System.UserRoles");
            DropTable("System.RoleRoles");
            DropTable("System.User");
            DropTable("System.SecuritySystemObjectPermissionsObject");
            DropTable("System.SecuritySystemMemberPermissionsObject");
            DropTable("System.SecuritySystemInstancePermissionsObject");
            DropTable("System.TypePermissionObject");
            DropTable("System.Role");
            DropTable("System.CandidateUser");
            DropTable("System.StateMachineTransition");
            DropTable("System.StateMachine");
            DropTable("System.StateMachineState");
            DropTable("System.StateMachineAppearance");
        }
    }
}
