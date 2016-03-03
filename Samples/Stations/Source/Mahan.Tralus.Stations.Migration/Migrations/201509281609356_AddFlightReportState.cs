namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlightReportState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightReportStates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Infrastructure.LocalityType", "ProgrammingKey", c => c.String());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeUtc", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeLocal", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeHome", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateUtc", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateLocal", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateHome", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarYearUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarMonthUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarDayUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeUtc", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeLocal", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeHome", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_LocalTimeZoneId", c => c.String());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeUtc", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeLocal", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeHome", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateUtc", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateLocal", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateHome", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarYearUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarMonthUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarDayUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeUtc", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeLocal", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeHome", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_LocalTimeZoneId", c => c.String());
            AddColumn("Stations.FlightReport", "FlightReportStateId", c => c.String());
            AddColumn("Stations.FlightReport", "FlightReportState_Id", c => c.Guid());
            AlterColumn("Infrastructure.LocalityType", "Name", c => c.String());
            CreateIndex("Stations.FlightReport", "FlightReportState_Id");
            AddForeignKey("Stations.FlightReport", "FlightReportState_Id", "dbo.FlightReportStates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Stations.FlightReport", "FlightReportState_Id", "dbo.FlightReportStates");
            DropIndex("Stations.FlightReport", new[] { "FlightReportState_Id" });
            AlterColumn("Infrastructure.LocalityType", "Name", c => c.String(maxLength: 200));
            DropColumn("Stations.FlightReport", "FlightReportState_Id");
            DropColumn("Stations.FlightReport", "FlightReportStateId");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_LocalTimeZoneId");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeHome");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeLocal");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_TimeUtc");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarDayUtc");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarMonthUtc");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_AltCalendarYearUtc");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateHome");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateLocal");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateUtc");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeHome");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeLocal");
            DropColumn("Infrastructure.FlightLeg", "ActualArrivalDateTime_DateTimeUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_LocalTimeZoneId");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeHome");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeLocal");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_TimeUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarDayUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarMonthUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_AltCalendarYearUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateHome");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateLocal");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateUtc");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeHome");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeLocal");
            DropColumn("Infrastructure.FlightLeg", "EstimatedArrivalDateTime_DateTimeUtc");
            DropColumn("Infrastructure.LocalityType", "ProgrammingKey");
            DropTable("dbo.FlightReportStates");
        }
    }
}
