namespace Selonia.Accounting.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remainings : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "Tralus.ModuleInfo",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Version = c.String(),
            //            AssemblyFileName = c.String(),
            //            IsMain = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "Tralus.EntityNumbering",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            PropertyName = c.String(),
            //            Title = c.String(),
            //            Script = c.String(),
            //            TargetTypeFullName = c.String(),
            //            WhenToRun = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Tralus.EntitySequence",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(),
            //            Description = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Tralus.EntitySequenceItem",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            EntitySequenceId = c.Guid(nullable: false),
            //            CreationDateTime = c.DateTime(nullable: false),
            //            SeqValue = c.Long(nullable: false),
            //            UsedFor = c.String(),
            //            Param1 = c.String(),
            //            Param2 = c.String(),
            //            Param3 = c.String(),
            //            Param4 = c.String(),
            //            Param5 = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Tralus.EntitySequence", t => t.EntitySequenceId, cascadeDelete: true)
            //    .Index(t => t.EntitySequenceId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("Tralus.EntitySequenceItem", "EntitySequenceId", "Tralus.EntitySequence");
            //DropIndex("Tralus.EntitySequenceItem", new[] { "EntitySequenceId" });
            //DropTable("Tralus.EntitySequenceItem");
            //DropTable("Tralus.EntitySequence");
            //DropTable("Tralus.EntityNumbering");
            //DropTable("Tralus.ModuleInfo");
        }
    }
}
