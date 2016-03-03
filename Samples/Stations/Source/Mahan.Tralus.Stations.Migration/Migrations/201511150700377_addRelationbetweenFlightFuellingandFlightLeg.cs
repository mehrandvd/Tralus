namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationbetweenFlightFuellingandFlightLeg : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Stations.FlightFuelling", "FlightLegId", "Infrastructure.FlightLeg");
            DropIndex("Stations.FlightFuelling", new[] { "FlightLegId" });
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            AlterColumn("Stations.FlightFuelling", "FlightLegId", c => c.Guid(nullable: false));
            
            CreateIndex("Stations.FlightFuelling", "FlightLegId");
            
            //AddForeignKey("Stations.FlightFuelling", "FlightLegId", "Stations.FlightReportView", "Id", cascadeDelete: true);
            
            AddForeignKey("Stations.FlightFuelling", "FlightLegId", "Infrastructure.FlightLeg", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Stations.FlightFuelling", "FlightLegId", "Infrastructure.FlightLeg");
           
            // DropForeignKey("Stations.FlightFuelling", "FlightLegId", "Stations.FlightReportView");
           
            DropIndex("Stations.FlightFuelling", new[] { "FlightLegId" });
            
            AlterColumn("Stations.FlightFuelling", "FlightLegId", c => c.Guid());
            
            CreateIndex("Stations.FlightFuelling", "FlightLegId");
            AddForeignKey("Stations.FlightFuelling", "FlightLegId", "Infrastructure.FlightLeg", "Id");
        }
    }
}
