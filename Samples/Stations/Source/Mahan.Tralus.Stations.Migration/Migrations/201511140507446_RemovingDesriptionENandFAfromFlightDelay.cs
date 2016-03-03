namespace Mahan.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingDesriptionENandFAfromFlightDelay : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Stations.FlightDelay", "FlightLegId", "Infrastructure.FlightLeg");
            DropIndex("Stations.FlightDelay", new[] { "FlightLegId" });

            //AddColumn("Infrastructure.DelayCode", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.DelayCode", "Name", c => c.String());
            //AddColumn("Infrastructure.DelayType", "ProgrammingKey", c => c.String());
           
            AlterColumn("Stations.FlightDelay", "FlightLegId", c => c.Guid(nullable: false));

            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String());
            
            CreateIndex("Stations.FlightDelay", "FlightLegId");
            
            // It's on a View
            // AddForeignKey("Stations.DestinationProfile", "FlightLegId", "Stations.FlightReportView", "Id");
            
            //AddForeignKey("Stations.FlightDelay", "FlightLegId", "Stations.FlightReportView", "Id", cascadeDelete: true);
            
            AddForeignKey("Stations.FlightDelay", "FlightLegId", "Infrastructure.FlightLeg", "Id", cascadeDelete: true);
            
            
            DropColumn("Stations.FlightDelay", "DelayDescriptionFa");
            DropColumn("Stations.FlightDelay", "DelayDescriptionEn");
        }
        
        public override void Down()
        {
            AddColumn("Stations.FlightDelay", "DelayDescriptionEn", c => c.String(maxLength: 200));
            AddColumn("Stations.FlightDelay", "DelayDescriptionFa", c => c.String(maxLength: 200));
            
            DropForeignKey("Stations.FlightDelay", "FlightLegId", "Infrastructure.FlightLeg");
            
            //DropForeignKey("Stations.FlightDelay", "FlightLegId", "Stations.FlightReportView");
            //DropForeignKey("Stations.DestinationProfile", "FlightLegId", "Stations.FlightReportView");
            
            DropIndex("Stations.FlightDelay", new[] { "FlightLegId" });
 //         
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Stations.FlightDelay", "FlightLegId", c => c.Guid());
 //         
            //DropColumn("Infrastructure.DelayType", "ProgrammingKey");
 //         DropColumn("Infrastructure.DelayCode", "Name");
 //         DropColumn("Infrastructure.DelayCode", "ProgrammingKey");
           
            CreateIndex("Stations.FlightDelay", "FlightLegId");
            AddForeignKey("Stations.FlightDelay", "FlightLegId", "Infrastructure.FlightLeg", "Id");
        }
    }
}
