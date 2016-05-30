namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitySequenceAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "System.EntitySequence",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "System.EntitySequenceItem",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EntitySequenceId = c.Guid(nullable: false),
                        CreationDateTime = c.DateTime(nullable: false),
                        SeqValue = c.Long(nullable: false),
                        RefInfo = c.String(),
                        Param1 = c.String(),
                        Param2 = c.String(),
                        Param3 = c.String(),
                        Param4 = c.String(),
                        Param5 = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("System.EntitySequence", t => t.EntitySequenceId, cascadeDelete: true)
                .Index(t => t.EntitySequenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("System.EntitySequenceItem", "EntitySequenceId", "System.EntitySequence");
            DropIndex("System.EntitySequenceItem", new[] { "EntitySequenceId" });
            DropTable("System.EntitySequenceItem");
            DropTable("System.EntitySequence");
        }
    }
}
