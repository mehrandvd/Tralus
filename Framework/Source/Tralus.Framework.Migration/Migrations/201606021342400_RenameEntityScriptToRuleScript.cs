namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameEntityScriptToRuleScript : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "System.EntityScript", newName: "EntityRuleScript");
        }
        
        public override void Down()
        {
            RenameTable(name: "System.EntityRuleScript", newName: "EntityScript");
        }
    }
}
