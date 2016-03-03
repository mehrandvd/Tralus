namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionFAandENtoSpecialServiceType : DbMigration
    {
        public override void Up()
        {
            AddColumn("Stations.SpecialServiceType", "Description", c => c.String(maxLength: 200));
            AddColumn("Stations.SpecialServiceType", "DescriptionEn", c => c.String());
            AlterColumn("Stations.SpecialServiceType", "Name", c => c.String());
            
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String(maxLength: 200));
            //DropColumn("Infrastructure.DelayCode", "ProgrammingKey");
            //DropColumn("Infrastructure.DelayCode", "Name");
            //DropColumn("Infrastructure.DelayType", "ProgrammingKey");
        }
        
        public override void Down()
        {
            //AddColumn("Infrastructure.DelayType", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.DelayCode", "Name", c => c.String());
            //AddColumn("Infrastructure.DelayCode", "ProgrammingKey", c => c.String());
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String());
           
            AlterColumn("Stations.SpecialServiceType", "Name", c => c.String(maxLength: 200));
            DropColumn("Stations.SpecialServiceType", "DescriptionEn");
            DropColumn("Stations.SpecialServiceType", "Description");
        }
    }
}
