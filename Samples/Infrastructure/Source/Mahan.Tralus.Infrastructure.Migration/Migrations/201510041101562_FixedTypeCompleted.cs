namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedTypeCompleted : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TimeZones", newName: "TimeZone");
            MoveTable(name: "dbo.TimeZone", newSchema: "Infrastructure");
            AddColumn("Infrastructure.City", "TimeZoneId", c => c.Guid());
            AddColumn("Infrastructure.City", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.Country", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.Continent", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.Currency", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.IataRegionCode", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.IataRegionCode", "Name", c => c.String());
            AlterColumn("Infrastructure.City", "Name", c => c.String());
            AlterColumn("Infrastructure.Country", "Name", c => c.String());
            AlterColumn("Infrastructure.Continent", "Name", c => c.String());
            AlterColumn("Infrastructure.Currency", "Name", c => c.String());
            CreateIndex("Infrastructure.City", "TimeZoneId");
            AddForeignKey("Infrastructure.City", "TimeZoneId", "Infrastructure.TimeZone", "Id");
            DropColumn("Infrastructure.City", "TimeZone");
            DropColumn("Infrastructure.IataRegionCode", "RegionName");
        }
        
        public override void Down()
        {
            AddColumn("Infrastructure.IataRegionCode", "RegionName", c => c.String(maxLength: 200));
            AddColumn("Infrastructure.City", "TimeZone", c => c.String(maxLength: 200));
            DropForeignKey("Infrastructure.City", "TimeZoneId", "Infrastructure.TimeZone");
            DropIndex("Infrastructure.City", new[] { "TimeZoneId" });
            AlterColumn("Infrastructure.Currency", "Name", c => c.String(maxLength: 50));
            AlterColumn("Infrastructure.Continent", "Name", c => c.String(maxLength: 200));
            AlterColumn("Infrastructure.Country", "Name", c => c.String(maxLength: 200));
            AlterColumn("Infrastructure.City", "Name", c => c.String(maxLength: 200));
            DropColumn("Infrastructure.IataRegionCode", "Name");
            DropColumn("Infrastructure.IataRegionCode", "ProgrammingKey");
            DropColumn("Infrastructure.Currency", "ProgrammingKey");
            DropColumn("Infrastructure.Continent", "ProgrammingKey");
            DropColumn("Infrastructure.Country", "ProgrammingKey");
            DropColumn("Infrastructure.City", "ProgrammingKey");
            DropColumn("Infrastructure.City", "TimeZoneId");
            MoveTable(name: "Infrastructure.TimeZone", newSchema: "dbo");
            RenameTable(name: "dbo.TimeZone", newName: "TimeZones");
        }
    }
}
