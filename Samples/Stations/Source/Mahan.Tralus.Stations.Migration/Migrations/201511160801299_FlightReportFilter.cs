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
                        AircraftRegister_Id = c.Guid(),
                        ArrivalAirport_Id = c.Guid(),
                        DepartureAirport_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegister_Id)
                .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirport_Id)
                .ForeignKey("Infrastructure.Airport", t => t.DepartureAirport_Id)
                .Index(t => t.AircraftRegister_Id)
                .Index(t => t.ArrivalAirport_Id)
                .Index(t => t.DepartureAirport_Id);
            
            //AddColumn("Infrastructure.DelayCode", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.DelayCode", "Name", c => c.String());
            //AddColumn("Infrastructure.DelayType", "ProgrammingKey", c => c.String());
            //AlterColumn("Stations.SpecialServiceType", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Infrastructure.DelayType", "Name", c => c.String());
            //DropColumn("Stations.SpecialServiceType", "Description");
            //DropColumn("Stations.SpecialServiceType", "DescriptionEn");
        }
        
        public override void Down()
        {
            
            DropForeignKey("Stations.FlightReportFilters", "DepartureAirport_Id", "Infrastructure.Airport");
            DropForeignKey("Stations.FlightReportFilters", "ArrivalAirport_Id", "Infrastructure.Airport");
            DropForeignKey("Stations.FlightReportFilters", "AircraftRegister_Id", "Infrastructure.AircraftRegister");
            DropIndex("Stations.FlightReportFilters", new[] { "DepartureAirport_Id" });
            DropIndex("Stations.FlightReportFilters", new[] { "ArrivalAirport_Id" });
            DropIndex("Stations.FlightReportFilters", new[] { "AircraftRegister_Id" });
            DropTable("Stations.FlightReportFilters");
        }
    }
}
