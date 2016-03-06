namespace Mahan.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlightReportFilter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Stations.FlightReportFilters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightNumber = c.String(),
                        StartDate_DateTimeUtc = c.DateTime(),
                        StartDate_DateTimeLocal = c.DateTime(),
                        StartDate_DateTimeHome = c.DateTime(),
                        StartDate_DateUtc = c.DateTime(storeType: "date"),
                        StartDate_DateLocal = c.DateTime(storeType: "date"),
                        StartDate_DateHome = c.DateTime(storeType: "date"),
                        StartDate_AltCalendarYearUtc = c.Int(),
                        StartDate_AltCalendarMonthUtc = c.Int(),
                        StartDate_AltCalendarDayUtc = c.Int(),
                        StartDate_TimeUtc = c.Time(precision: 7),
                        StartDate_TimeLocal = c.Time(precision: 7),
                        StartDate_TimeHome = c.Time(precision: 7),
                        StartDate_LocalTimeZoneId = c.String(),
                        EndDate_DateTimeUtc = c.DateTime(),
                        EndDate_DateTimeLocal = c.DateTime(),
                        EndDate_DateTimeHome = c.DateTime(),
                        EndDate_DateUtc = c.DateTime(storeType: "date"),
                        EndDate_DateLocal = c.DateTime(storeType: "date"),
                        EndDate_DateHome = c.DateTime(storeType: "date"),
                        EndDate_AltCalendarYearUtc = c.Int(),
                        EndDate_AltCalendarMonthUtc = c.Int(),
                        EndDate_AltCalendarDayUtc = c.Int(),
                        EndDate_TimeUtc = c.Time(precision: 7),
                        EndDate_TimeLocal = c.Time(precision: 7),
                        EndDate_TimeHome = c.Time(precision: 7),
                        EndDate_LocalTimeZoneId = c.String(),
                        ArrivalAirportId = c.Guid(),
                        DepartureAirportId = c.Guid(),
                        AircraftRegisterId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
                .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
                .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
                .Index(t => t.ArrivalAirportId)
                .Index(t => t.DepartureAirportId)
                .Index(t => t.AircraftRegisterId);
            
            AddColumn("Stations.SpecialServiceType", "Description", c => c.String(maxLength: 200));
            AddColumn("Stations.SpecialServiceType", "DescriptionEn", c => c.String());
            AlterColumn("Stations.SpecialServiceType", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("Stations.FlightReportFilters", "DepartureAirportId", "Infrastructure.Airport");
            DropForeignKey("Stations.FlightReportFilters", "ArrivalAirportId", "Infrastructure.Airport");
            DropForeignKey("Stations.FlightReportFilters", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            DropIndex("Stations.FlightReportFilters", new[] { "AircraftRegisterId" });
            DropIndex("Stations.FlightReportFilters", new[] { "DepartureAirportId" });
            DropIndex("Stations.FlightReportFilters", new[] { "ArrivalAirportId" });
            AlterColumn("Stations.SpecialServiceType", "Name", c => c.String(maxLength: 200));
            DropColumn("Stations.SpecialServiceType", "DescriptionEn");
            DropColumn("Stations.SpecialServiceType", "Description");
            DropTable("Stations.FlightReportFilters");
        }
    }
}
