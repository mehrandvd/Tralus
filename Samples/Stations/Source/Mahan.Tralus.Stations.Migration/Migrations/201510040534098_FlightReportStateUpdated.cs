namespace Mahan.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlightReportStateUpdated : DbMigration
    {
        public override void Up()
        {
            //RenameColumn(table: "Stations.FlightReportView", name: "AircraftTypeId", newName: "ScheduledAircraftTypeId");
            //RenameIndex(table: "Stations.FlightReportView", name: "IX_AircraftTypeId", newName: "IX_ScheduledAircraftTypeId");
            //CreateTable(
            //    "dbo.TimeZones",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            IanaCode = c.String(maxLength: 200),
            //            ProgrammingKey = c.String(),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //AddColumn("Infrastructure.City", "TimeZoneId", c => c.Guid());
            //AddColumn("Infrastructure.City", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Country", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Continent", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Currency", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.IataRegionCode", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.IataRegionCode", "Name", c => c.String());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeUtc", c => c.DateTime());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeLocal", c => c.DateTime());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeHome", c => c.DateTime());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateUtc", c => c.DateTime(storeType: "date"));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateLocal", c => c.DateTime(storeType: "date"));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateHome", c => c.DateTime(storeType: "date"));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarYearUtc", c => c.Int());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarMonthUtc", c => c.Int());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarDayUtc", c => c.Int());
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeUtc", c => c.Time(precision: 7));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeLocal", c => c.Time(precision: 7));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeHome", c => c.Time(precision: 7));
            //AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_LocalTimeZoneId", c => c.String());
            AddColumn("Stations.FlightReportState", "ProgrammingKey", c => c.String());
            //AddColumn("Stations.FlightReportView", "FlightReportId", c => c.Guid());
            //AddColumn("Stations.FlightReportView", "FlightReportStateId", c => c.Guid());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeUtc", c => c.DateTime());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeLocal", c => c.DateTime());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeHome", c => c.DateTime());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateUtc", c => c.DateTime(storeType: "date"));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateLocal", c => c.DateTime(storeType: "date"));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_DateHome", c => c.DateTime(storeType: "date"));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarYearUtc", c => c.Int());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarMonthUtc", c => c.Int());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarDayUtc", c => c.Int());
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_TimeUtc", c => c.Time(precision: 7));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_TimeLocal", c => c.Time(precision: 7));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_TimeHome", c => c.Time(precision: 7));
            //AddColumn("Stations.FlightReportView", "TakeOffDateTime_LocalTimeZoneId", c => c.String());
            //AlterColumn("Infrastructure.City", "Name", c => c.String());
            //AlterColumn("Infrastructure.Country", "Name", c => c.String());
            //AlterColumn("Infrastructure.Continent", "Name", c => c.String());
            //AlterColumn("Infrastructure.Currency", "Name", c => c.String());
            //CreateIndex("Infrastructure.City", "TimeZoneId");
            //CreateIndex("Stations.FlightReportView", "FlightReportId");
            //CreateIndex("Stations.FlightReportView", "FlightReportStateId");
            //AddForeignKey("Infrastructure.City", "TimeZoneId", "dbo.TimeZones", "Id");
            //AddForeignKey("Stations.FlightReportView", "FlightReportId", "Stations.FlightReport", "Id");
            //AddForeignKey("Stations.FlightReportView", "FlightReportStateId", "Stations.FlightReportState", "Id");
            //DropColumn("Infrastructure.City", "TimeZone");
            //DropColumn("Infrastructure.IataRegionCode", "RegionName");
        }
        
        public override void Down()
        {
            //AddColumn("Infrastructure.IataRegionCode", "RegionName", c => c.String(maxLength: 200));
            //AddColumn("Infrastructure.City", "TimeZone", c => c.String(maxLength: 200));
            //DropForeignKey("Stations.FlightReportView", "FlightReportStateId", "Stations.FlightReportState");
            //DropForeignKey("Stations.FlightReportView", "FlightReportId", "Stations.FlightReport");
            //DropForeignKey("Infrastructure.City", "TimeZoneId", "dbo.TimeZones");
            //DropIndex("Stations.FlightReportView", new[] { "FlightReportStateId" });
            //DropIndex("Stations.FlightReportView", new[] { "FlightReportId" });
            //DropIndex("Infrastructure.City", new[] { "TimeZoneId" });
            //AlterColumn("Infrastructure.Currency", "Name", c => c.String(maxLength: 50));
            //AlterColumn("Infrastructure.Continent", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Infrastructure.Country", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Infrastructure.City", "Name", c => c.String(maxLength: 200));
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_LocalTimeZoneId");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_TimeHome");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_TimeLocal");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_TimeUtc");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarDayUtc");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarMonthUtc");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_AltCalendarYearUtc");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateHome");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateLocal");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateUtc");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeHome");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeLocal");
            //DropColumn("Stations.FlightReportView", "TakeOffDateTime_DateTimeUtc");
            //DropColumn("Stations.FlightReportView", "FlightReportStateId");
            //DropColumn("Stations.FlightReportView", "FlightReportId");
            DropColumn("Stations.FlightReportState", "ProgrammingKey");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_LocalTimeZoneId");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeHome");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeLocal");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeUtc");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarDayUtc");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarMonthUtc");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarYearUtc");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateHome");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateLocal");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateUtc");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeHome");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeLocal");
            //DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeUtc");
            //DropColumn("Infrastructure.IataRegionCode", "Name");
            //DropColumn("Infrastructure.IataRegionCode", "ProgrammingKey");
            //DropColumn("Infrastructure.Currency", "ProgrammingKey");
            //DropColumn("Infrastructure.Continent", "ProgrammingKey");
            //DropColumn("Infrastructure.Country", "ProgrammingKey");
            //DropColumn("Infrastructure.City", "ProgrammingKey");
            //DropColumn("Infrastructure.City", "TimeZoneId");
            //DropTable("dbo.TimeZones");
            //RenameIndex(table: "Stations.FlightReportView", name: "IX_ScheduledAircraftTypeId", newName: "IX_AircraftTypeId");
            //RenameColumn(table: "Stations.FlightReportView", name: "ScheduledAircraftTypeId", newName: "AircraftTypeId");
        }
    }
}
