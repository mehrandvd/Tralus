namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfFlightRemarkTypeAndFuellingTypeToFixedEntityBase : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Infrastructure.DelayCode", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.DelayCode", "Name", c => c.String());
            //AddColumn("Infrastructure.DelayType", "ProgrammingKey", c => c.String());
            AddColumn("Stations.FuellingType", "ProgrammingKey", c => c.String());
            AddColumn("Stations.FlightRemarkType", "ProgrammingKey", c => c.String());
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String());
            AlterColumn("Stations.FuellingType", "Code", c => c.Int(nullable: false));
            AlterColumn("Stations.FlightRemarkType", "Code", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Stations.FlightRemarkType", "Code", c => c.String());
            AlterColumn("Stations.FuellingType", "Code", c => c.String());
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String(maxLength: 200));
            DropColumn("Stations.FlightRemarkType", "ProgrammingKey");
            DropColumn("Stations.FuellingType", "ProgrammingKey");
            //DropColumn("Infrastructure.DelayType", "ProgrammingKey");
            //DropColumn("Infrastructure.DelayCode", "Name");
            //DropColumn("Infrastructure.DelayCode", "ProgrammingKey");
        }
    }
}
