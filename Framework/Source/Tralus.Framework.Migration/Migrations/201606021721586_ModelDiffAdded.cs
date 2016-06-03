namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelDiffAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModelDifferences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ContextId = c.String(),
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ModelDifferenceAspects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Xml = c.String(),
                        Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ModelDifferences", t => t.Owner_ID)
                .Index(t => t.Owner_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModelDifferenceAspects", "Owner_ID", "dbo.ModelDifferences");
            DropIndex("dbo.ModelDifferenceAspects", new[] { "Owner_ID" });
            DropTable("dbo.ModelDifferenceAspects");
            DropTable("dbo.ModelDifferences");
        }
    }
}
