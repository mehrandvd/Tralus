namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityNumberingAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "System.EntityNumbering",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PropertyName = c.String(),
                        Title = c.String(),
                        Script = c.String(),
                        TargetTypeFullName = c.String(),
                        WhenToRun = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("System.EntityScript", "ExecutionType");
            DropColumn("System.EntityScript", "PropertyName");
        }
        
        public override void Down()
        {
            AddColumn("System.EntityScript", "PropertyName", c => c.String());
            AddColumn("System.EntityScript", "ExecutionType", c => c.Int(nullable: false));
            DropTable("System.EntityNumbering");
        }
    }
}
