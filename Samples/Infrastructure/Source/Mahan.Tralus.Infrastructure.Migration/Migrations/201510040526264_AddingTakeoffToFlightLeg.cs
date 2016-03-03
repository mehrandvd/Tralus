namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTakeoffToFlightLeg : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Infrastructure.City", "TimeZoneId", c => c.Guid());
            //AddColumn("Infrastructure.City", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Country", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Continent", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.Currency", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.IataRegionCode", "ProgrammingKey", c => c.String());
            //AddColumn("Infrastructure.IataRegionCode", "Name", c => c.String());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeUtc", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeLocal", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeHome", c => c.DateTime());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateUtc", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateLocal", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateHome", c => c.DateTime(storeType: "date"));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarYearUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarMonthUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarDayUtc", c => c.Int());
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeUtc", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeLocal", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeHome", c => c.Time(precision: 7));
            AddColumn("Infrastructure.FlightLeg", "TakeOffDateTime_LocalTimeZoneId", c => c.String());
            //AlterColumn("Infrastructure.City", "Name", c => c.String());
            //AlterColumn("Infrastructure.Country", "Name", c => c.String());
            //AlterColumn("Infrastructure.Continent", "Name", c => c.String());
            //AlterColumn("Infrastructure.Currency", "Name", c => c.String());
            //CreateIndex("Infrastructure.City", "TimeZoneId");
            //AddForeignKey("Infrastructure.City", "TimeZoneId", "dbo.TimeZones", "Id");
            //DropColumn("Infrastructure.City", "TimeZone");
            //DropColumn("Infrastructure.IataRegionCode", "RegionName");
        }
        
        public override void Down()
        {
            //AddColumn("Infrastructure.IataRegionCode", "RegionName", c => c.String(maxLength: 200));
            //AddColumn("Infrastructure.City", "TimeZone", c => c.String(maxLength: 200));
            //DropForeignKey("Infrastructure.City", "TimeZoneId", "dbo.TimeZones");
            //DropIndex("Infrastructure.City", new[] { "TimeZoneId" });
            //AlterColumn("Infrastructure.Currency", "Name", c => c.String(maxLength: 50));
            //AlterColumn("Infrastructure.Continent", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Infrastructure.Country", "Name", c => c.String(maxLength: 200));
            //AlterColumn("Infrastructure.City", "Name", c => c.String(maxLength: 200));
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_LocalTimeZoneId");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeHome");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeLocal");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_TimeUtc");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarDayUtc");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarMonthUtc");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_AltCalendarYearUtc");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateHome");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateLocal");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateUtc");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeHome");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeLocal");
            DropColumn("Infrastructure.FlightLeg", "TakeOffDateTime_DateTimeUtc");
            //DropColumn("Infrastructure.IataRegionCode", "Name");
            //DropColumn("Infrastructure.IataRegionCode", "ProgrammingKey");
            //DropColumn("Infrastructure.Currency", "ProgrammingKey");
            //DropColumn("Infrastructure.Continent", "ProgrammingKey");
            //DropColumn("Infrastructure.Country", "ProgrammingKey");
            //DropColumn("Infrastructure.City", "ProgrammingKey");
            //DropColumn("Infrastructure.City", "TimeZoneId");
        }
    }
}
