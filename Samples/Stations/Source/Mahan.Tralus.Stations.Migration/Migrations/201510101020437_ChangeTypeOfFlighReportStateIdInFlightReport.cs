namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfFlighReportStateIdInFlightReport : DbMigration
    {
        public override void Up()
        {
            DropIndex("Stations.FlightReport", new[] { "FlightReportState_Id" });
            DropColumn("Stations.FlightReport", "FlightReportStateId");
            RenameColumn(table: "Stations.FlightReport", name: "FlightReportState_Id", newName: "FlightReportStateId");
            AlterColumn("Stations.FlightReport", "FlightReportStateId", c => c.Guid());
            CreateIndex("Stations.FlightReport", "FlightReportStateId");
            //DropColumn("Stations.FlightReportView", "FuellingSum");
            //DropColumn("Stations.FlightReportView", "HasFuelling");
            //DropColumn("Stations.FlightReportView", "HasDelay");
            //DropColumn("Stations.FlightReportView", "SpecialServicesCount");
            //DropColumn("Stations.FlightReportView", "HasCargo");
            //DropColumn("Stations.FlightReportView", "HasPassenger");
        }
        
        public override void Down()
        {
            //AddColumn("Stations.FlightReportView", "HasPassenger", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "HasCargo", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "SpecialServicesCount", c => c.Long());
            //AddColumn("Stations.FlightReportView", "HasDelay", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "HasFuelling", c => c.Boolean(nullable: false));
            //AddColumn("Stations.FlightReportView", "FuellingSum", c => c.Long());
            DropIndex("Stations.FlightReport", new[] { "FlightReportStateId" });
            AlterColumn("Stations.FlightReport", "FlightReportStateId", c => c.String());
            RenameColumn(table: "Stations.FlightReport", name: "FlightReportStateId", newName: "FlightReportState_Id");
            AddColumn("Stations.FlightReport", "FlightReportStateId", c => c.String());
            CreateIndex("Stations.FlightReport", "FlightReportState_Id");
        }
    }
}
