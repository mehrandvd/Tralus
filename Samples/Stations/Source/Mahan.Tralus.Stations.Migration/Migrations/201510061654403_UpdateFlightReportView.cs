namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFlightReportView : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Stations.FlightReportView", "FuellingSum", c => c.Long());
            //AddColumn("Stations.FlightReportView", "HasFuelling", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "DelaySum", c => c.Long());
            //AddColumn("Stations.FlightReportView", "HasDelay", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "SpecialServicesCount", c => c.Long());
            //AddColumn("Stations.FlightReportView", "HasSpecialService", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "HasCargo", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "HasPassenger", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("Stations.FlightReportView", "HasPassenger");
            //DropColumn("Stations.FlightReportView", "HasCargo");
            //DropColumn("Stations.FlightReportView", "HasSpecialService");
            //DropColumn("Stations.FlightReportView", "SpecialServicesCount");
            //DropColumn("Stations.FlightReportView", "HasDelay");
            //DropColumn("Stations.FlightReportView", "DelaySum");
            //DropColumn("Stations.FlightReportView", "HasFuelling");
            //DropColumn("Stations.FlightReportView", "FuellingSum");
        }
    }
}
