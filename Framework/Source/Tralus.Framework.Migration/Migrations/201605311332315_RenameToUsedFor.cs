namespace Tralus.Framework.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameToUsedFor : DbMigration
    {
        public override void Up()
        {
            AddColumn("System.EntitySequenceItem", "UsedFor", c => c.String());
            DropColumn("System.EntitySequenceItem", "RefInfo");
        }
        
        public override void Down()
        {
            AddColumn("System.EntitySequenceItem", "RefInfo", c => c.String());
            DropColumn("System.EntitySequenceItem", "UsedFor");
        }
    }
}
