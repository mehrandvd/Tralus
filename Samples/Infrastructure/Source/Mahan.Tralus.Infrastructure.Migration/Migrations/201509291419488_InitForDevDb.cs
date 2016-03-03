namespace Mahan.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitForDevDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Infrastructure.AirlineStation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        NameEn = c.String(maxLength: 200),
                        StationManagerName = c.String(maxLength: 200),
                        StationManagerMobilePhone = c.String(maxLength: 200),
                        PhoneNo = c.String(maxLength: 200),
                        Fax = c.String(maxLength: 200),
                        Extension = c.String(maxLength: 200),
                        EmailAddress = c.String(maxLength: 200),
                        LocalityTypeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.LocalityType", t => t.LocalityTypeId)
                .Index(t => t.LocalityTypeId);
            
            CreateTable(
                "Infrastructure.AirportAirlineStation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AirlineStationId = c.Guid(),
                        AirportId = c.Guid(),
                        Email = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AirlineStation", t => t.AirlineStationId)
                .ForeignKey("Infrastructure.Airport", t => t.AirportId)
                .Index(t => t.AirlineStationId)
                .Index(t => t.AirportId);
            
            CreateTable(
                "Infrastructure.Airport",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        NameEn = c.String(maxLength: 200),
                        IataAirportCode = c.String(maxLength: 3),
                        CityId = c.Guid(),
                        Status = c.String(maxLength: 20),
                        LocalityTypeId = c.Guid(),
                        NickName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.City", t => t.CityId)
                .ForeignKey("Infrastructure.LocalityType", t => t.LocalityTypeId)
                .Index(t => t.CityId)
                .Index(t => t.LocalityTypeId);
            
            CreateTable(
                "Infrastructure.City",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        CountryId = c.Guid(),
                        NameEn = c.String(maxLength: 200),
                        TimeZone = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Country", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "Infrastructure.Country",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        IsoAlpha3 = c.String(maxLength: 3),
                        IsoAlpha2 = c.String(maxLength: 2),
                        IataCode = c.String(),
                        NameEn = c.String(maxLength: 200),
                        UnNumeric3 = c.String(maxLength: 3),
                        Fips104 = c.String(maxLength: 2),
                        IataRegionCodeId = c.Guid(),
                        CurrencyId = c.Guid(),
                        ContinentId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Continent", t => t.ContinentId)
                .ForeignKey("Infrastructure.Currency", t => t.CurrencyId)
                .ForeignKey("Infrastructure.IataRegionCode", t => t.IataRegionCodeId)
                .Index(t => t.IataRegionCodeId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ContinentId);
            
            CreateTable(
                "Infrastructure.Continent",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(maxLength: 200),
                        NameEn = c.String(maxLength: 200),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Currency",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        Symbol = c.String(maxLength: 20),
                        NameEn = c.String(maxLength: 50),
                        Code = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.IataRegionCode",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RegionCode = c.String(maxLength: 200),
                        RegionName = c.String(maxLength: 200),
                        RegionNameEn = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.LocalityType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Long(),
                        NameEn = c.String(maxLength: 200),
                        ProgrammingKey = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.CargoType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        Code = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.DelayCode",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DelayTypeId = c.Guid(),
                        Description = c.String(),
                        DescriptionEn = c.String(),
                        Code = c.String(maxLength: 10),
                        IsEnabled = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.DelayType", t => t.DelayTypeId)
                .Index(t => t.DelayTypeId);
            
            CreateTable(
                "Infrastructure.DelayType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.FlightLeg",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightNumberId = c.Guid(),
                        FlightTypeId = c.Guid(),
                        Status = c.String(maxLength: 200),
                        ScheduledDepartureDateTime_DateTimeUtc = c.DateTime(),
                        ScheduledDepartureDateTime_DateTimeLocal = c.DateTime(),
                        ScheduledDepartureDateTime_DateTimeHome = c.DateTime(),
                        ScheduledDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
                        ScheduledDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
                        ScheduledDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
                        ScheduledDepartureDateTime_AltCalendarYearUtc = c.Int(),
                        ScheduledDepartureDateTime_AltCalendarMonthUtc = c.Int(),
                        ScheduledDepartureDateTime_AltCalendarDayUtc = c.Int(),
                        ScheduledDepartureDateTime_TimeUtc = c.Time(precision: 7),
                        ScheduledDepartureDateTime_TimeLocal = c.Time(precision: 7),
                        ScheduledDepartureDateTime_TimeHome = c.Time(precision: 7),
                        ScheduledDepartureDateTime_LocalTimeZoneId = c.String(),
                        EstimatedDepartureDateTime_DateTimeUtc = c.DateTime(),
                        EstimatedDepartureDateTime_DateTimeLocal = c.DateTime(),
                        EstimatedDepartureDateTime_DateTimeHome = c.DateTime(),
                        EstimatedDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
                        EstimatedDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
                        EstimatedDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
                        EstimatedDepartureDateTime_AltCalendarYearUtc = c.Int(),
                        EstimatedDepartureDateTime_AltCalendarMonthUtc = c.Int(),
                        EstimatedDepartureDateTime_AltCalendarDayUtc = c.Int(),
                        EstimatedDepartureDateTime_TimeUtc = c.Time(precision: 7),
                        EstimatedDepartureDateTime_TimeLocal = c.Time(precision: 7),
                        EstimatedDepartureDateTime_TimeHome = c.Time(precision: 7),
                        EstimatedDepartureDateTime_LocalTimeZoneId = c.String(),
                        ActualDepartureDateTime_DateTimeUtc = c.DateTime(),
                        ActualDepartureDateTime_DateTimeLocal = c.DateTime(),
                        ActualDepartureDateTime_DateTimeHome = c.DateTime(),
                        ActualDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
                        ActualDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
                        ActualDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
                        ActualDepartureDateTime_AltCalendarYearUtc = c.Int(),
                        ActualDepartureDateTime_AltCalendarMonthUtc = c.Int(),
                        ActualDepartureDateTime_AltCalendarDayUtc = c.Int(),
                        ActualDepartureDateTime_TimeUtc = c.Time(precision: 7),
                        ActualDepartureDateTime_TimeLocal = c.Time(precision: 7),
                        ActualDepartureDateTime_TimeHome = c.Time(precision: 7),
                        ActualDepartureDateTime_LocalTimeZoneId = c.String(),
                        EstimatedArrivalDateTime_DateTimeUtc = c.DateTime(),
                        EstimatedArrivalDateTime_DateTimeLocal = c.DateTime(),
                        EstimatedArrivalDateTime_DateTimeHome = c.DateTime(),
                        EstimatedArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
                        EstimatedArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
                        EstimatedArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
                        EstimatedArrivalDateTime_AltCalendarYearUtc = c.Int(),
                        EstimatedArrivalDateTime_AltCalendarMonthUtc = c.Int(),
                        EstimatedArrivalDateTime_AltCalendarDayUtc = c.Int(),
                        EstimatedArrivalDateTime_TimeUtc = c.Time(precision: 7),
                        EstimatedArrivalDateTime_TimeLocal = c.Time(precision: 7),
                        EstimatedArrivalDateTime_TimeHome = c.Time(precision: 7),
                        EstimatedArrivalDateTime_LocalTimeZoneId = c.String(),
                        ActualArrivalDateTime_DateTimeUtc = c.DateTime(),
                        ActualArrivalDateTime_DateTimeLocal = c.DateTime(),
                        ActualArrivalDateTime_DateTimeHome = c.DateTime(),
                        ActualArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
                        ActualArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
                        ActualArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
                        ActualArrivalDateTime_AltCalendarYearUtc = c.Int(),
                        ActualArrivalDateTime_AltCalendarMonthUtc = c.Int(),
                        ActualArrivalDateTime_AltCalendarDayUtc = c.Int(),
                        ActualArrivalDateTime_TimeUtc = c.Time(precision: 7),
                        ActualArrivalDateTime_TimeLocal = c.Time(precision: 7),
                        ActualArrivalDateTime_TimeHome = c.Time(precision: 7),
                        ActualArrivalDateTime_LocalTimeZoneId = c.String(),
                        AircraftRegisterId = c.Guid(),
                        LegId = c.Guid(),
                        ScheduledAircraftTypeId = c.Guid(),
                        ArrivalAirportId = c.Guid(),
                        DepartureAirportId = c.Guid(),
                        RepetitionReasonCode = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
                .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
                .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
                .ForeignKey("Infrastructure.FlightNumber", t => t.FlightNumberId)
                .ForeignKey("Infrastructure.FlightType", t => t.FlightTypeId)
                .ForeignKey("Infrastructure.Leg", t => t.LegId)
                .ForeignKey("Infrastructure.AircraftType", t => t.ScheduledAircraftTypeId)
                .Index(t => t.FlightNumberId)
                .Index(t => t.FlightTypeId)
                .Index(t => t.AircraftRegisterId)
                .Index(t => t.LegId)
                .Index(t => t.ScheduledAircraftTypeId)
                .Index(t => t.ArrivalAirportId)
                .Index(t => t.DepartureAirportId);
            
            CreateTable(
                "Infrastructure.AircraftRegister",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(maxLength: 200),
                        AircraftId = c.Guid(),
                        ShortRegisterCode = c.String(maxLength: 3),
                        HasFirstClassSeat = c.Boolean(),
                        Status = c.String(maxLength: 20),
                        Timestamp = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Aircrafts", t => t.AircraftId)
                .Index(t => t.AircraftId);
            
            CreateTable(
                "Infrastructure.Aircrafts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SerialNo = c.String(maxLength: 200),
                        AircraftTypeId = c.Guid(),
                        Register = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftType", t => t.AircraftTypeId)
                .Index(t => t.AircraftTypeId);
            
            CreateTable(
                "Infrastructure.AircraftType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        Manufacturer = c.String(maxLength: 200),
                        TypeVariation = c.String(maxLength: 200),
                        FullTypeName = c.String(maxLength: 200),
                        IataCode = c.String(maxLength: 3),
                        IcaoCode = c.String(maxLength: 4),
                        FwName = c.String(maxLength: 3),
                        Status = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.AircraftRegisterSeatInfo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate_Date = c.DateTime(storeType: "date"),
                        StartDate_DateInAltCalendar = c.String(),
                        StartDate_AltCalendarYearUtc = c.Int(),
                        StartDate_AltCalendarMonthUtc = c.Int(),
                        StartDate_AltCalendarDayUtc = c.Int(),
                        EndDate_Date = c.DateTime(storeType: "date"),
                        EndDate_DateInAltCalendar = c.String(),
                        EndDate_AltCalendarYearUtc = c.Int(),
                        EndDate_AltCalendarMonthUtc = c.Int(),
                        EndDate_AltCalendarDayUtc = c.Int(),
                        SeatCountBusiness = c.Long(),
                        SeatCountEconomy = c.Long(),
                        AircraftRegisterId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
                .Index(t => t.AircraftRegisterId);
            
            CreateTable(
                "Infrastructure.AircraftRegisterNonAvailableSeat",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate_Date = c.DateTime(storeType: "date"),
                        StartDate_DateInAltCalendar = c.String(),
                        StartDate_AltCalendarYearUtc = c.Int(),
                        StartDate_AltCalendarMonthUtc = c.Int(),
                        StartDate_AltCalendarDayUtc = c.Int(),
                        EndDate_Date = c.DateTime(storeType: "date"),
                        EndDate_DateInAltCalendar = c.String(),
                        EndDate_AltCalendarYearUtc = c.Int(),
                        EndDate_AltCalendarMonthUtc = c.Int(),
                        EndDate_AltCalendarDayUtc = c.Int(),
                        AircraftRegisterId = c.Guid(),
                        SeatCountBusiness = c.Long(),
                        SeatCountBusinessPlus = c.Long(),
                        SeatCountEconomy = c.Long(),
                        SeatNumberBusiness = c.String(maxLength: 200),
                        SeatNumberBusinessPlus = c.String(maxLength: 200),
                        SeatNumberEconomy = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
                .Index(t => t.AircraftRegisterId);
            
            CreateTable(
                "Infrastructure.FlightNumber",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AirlineId = c.Guid(),
                        FullFlightNumber = c.String(maxLength: 200),
                        ShortFlightNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Airline", t => t.AirlineId)
                .Index(t => t.AirlineId);
            
            CreateTable(
                "Infrastructure.Airline",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        CountryId = c.Guid(),
                        IataCode = c.String(maxLength: 200),
                        IcaoCode = c.String(maxLength: 200),
                        Abv = c.String(maxLength: 200),
                        FullName = c.String(maxLength: 200),
                        ShortName = c.String(maxLength: 200),
                        Status = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Country", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "Infrastructure.FlightType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        ProgrammingKey = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Leg",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArrivalAirportId = c.Guid(),
                        DepartureAirportId = c.Guid(),
                        Name = c.String(maxLength: 200),
                        Status = c.String(maxLength: 20),
                        LocalityTypeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
                .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
                .ForeignKey("Infrastructure.LocalityType", t => t.LocalityTypeId)
                .Index(t => t.ArrivalAirportId)
                .Index(t => t.DepartureAirportId)
                .Index(t => t.LocalityTypeId);
            
            CreateTable(
                "Infrastructure.PassengerType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        Code = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.RouteAircraft",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        NumLegs = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.RouteAircraftLeg",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RouteAircraftId = c.Guid(),
                        LegId = c.Guid(),
                        LegNo = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Leg", t => t.LegId)
                .ForeignKey("Infrastructure.RouteAircraft", t => t.RouteAircraftId)
                .Index(t => t.RouteAircraftId)
                .Index(t => t.LegId);
            
            CreateTable(
                "Infrastructure.RouteTemplate",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        RouteTemplateTypeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.RouteTemplateType", t => t.RouteTemplateTypeId)
                .Index(t => t.RouteTemplateTypeId);
            
            CreateTable(
                "Infrastructure.RouteTemplateType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.RouteTemplateLeg",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RouteTemplateId = c.Guid(),
                        LegId = c.Guid(),
                        LegOrder = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Leg", t => t.LegId)
                .ForeignKey("Infrastructure.RouteTemplate", t => t.RouteTemplateId)
                .Index(t => t.RouteTemplateId)
                .Index(t => t.LegId);
            
            CreateTable(
                "Infrastructure.SeatClass",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        Code = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.TicketType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        Code = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Company",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CommercialCode = c.Double(),
                        Title = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimeZones",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IanaCode = c.String(maxLength: 200),
                        ProgrammingKey = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Unit",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Infrastructure.RouteTemplateLeg", "RouteTemplateId", "Infrastructure.RouteTemplate");
            DropForeignKey("Infrastructure.RouteTemplateLeg", "LegId", "Infrastructure.Leg");
            DropForeignKey("Infrastructure.RouteTemplate", "RouteTemplateTypeId", "Infrastructure.RouteTemplateType");
            DropForeignKey("Infrastructure.RouteAircraftLeg", "RouteAircraftId", "Infrastructure.RouteAircraft");
            DropForeignKey("Infrastructure.RouteAircraftLeg", "LegId", "Infrastructure.Leg");
            DropForeignKey("Infrastructure.FlightLeg", "ScheduledAircraftTypeId", "Infrastructure.AircraftType");
            DropForeignKey("Infrastructure.FlightLeg", "LegId", "Infrastructure.Leg");
            DropForeignKey("Infrastructure.Leg", "LocalityTypeId", "Infrastructure.LocalityType");
            DropForeignKey("Infrastructure.Leg", "DepartureAirportId", "Infrastructure.Airport");
            DropForeignKey("Infrastructure.Leg", "ArrivalAirportId", "Infrastructure.Airport");
            DropForeignKey("Infrastructure.FlightLeg", "FlightTypeId", "Infrastructure.FlightType");
            DropForeignKey("Infrastructure.FlightLeg", "FlightNumberId", "Infrastructure.FlightNumber");
            DropForeignKey("Infrastructure.FlightNumber", "AirlineId", "Infrastructure.Airline");
            DropForeignKey("Infrastructure.Airline", "CountryId", "Infrastructure.Country");
            DropForeignKey("Infrastructure.FlightLeg", "DepartureAirportId", "Infrastructure.Airport");
            DropForeignKey("Infrastructure.FlightLeg", "ArrivalAirportId", "Infrastructure.Airport");
            DropForeignKey("Infrastructure.FlightLeg", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            DropForeignKey("Infrastructure.AircraftRegisterNonAvailableSeat", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            DropForeignKey("Infrastructure.AircraftRegisterSeatInfo", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            DropForeignKey("Infrastructure.Aircrafts", "AircraftTypeId", "Infrastructure.AircraftType");
            DropForeignKey("Infrastructure.AircraftRegister", "AircraftId", "Infrastructure.Aircrafts");
            DropForeignKey("Infrastructure.DelayCode", "DelayTypeId", "Infrastructure.DelayType");
            DropForeignKey("Infrastructure.AirlineStation", "LocalityTypeId", "Infrastructure.LocalityType");
            DropForeignKey("Infrastructure.AirportAirlineStation", "AirportId", "Infrastructure.Airport");
            DropForeignKey("Infrastructure.Airport", "LocalityTypeId", "Infrastructure.LocalityType");
            DropForeignKey("Infrastructure.Airport", "CityId", "Infrastructure.City");
            DropForeignKey("Infrastructure.City", "CountryId", "Infrastructure.Country");
            DropForeignKey("Infrastructure.Country", "IataRegionCodeId", "Infrastructure.IataRegionCode");
            DropForeignKey("Infrastructure.Country", "CurrencyId", "Infrastructure.Currency");
            DropForeignKey("Infrastructure.Country", "ContinentId", "Infrastructure.Continent");
            DropForeignKey("Infrastructure.AirportAirlineStation", "AirlineStationId", "Infrastructure.AirlineStation");
            DropIndex("Infrastructure.RouteTemplateLeg", new[] { "LegId" });
            DropIndex("Infrastructure.RouteTemplateLeg", new[] { "RouteTemplateId" });
            DropIndex("Infrastructure.RouteTemplate", new[] { "RouteTemplateTypeId" });
            DropIndex("Infrastructure.RouteAircraftLeg", new[] { "LegId" });
            DropIndex("Infrastructure.RouteAircraftLeg", new[] { "RouteAircraftId" });
            DropIndex("Infrastructure.Leg", new[] { "LocalityTypeId" });
            DropIndex("Infrastructure.Leg", new[] { "DepartureAirportId" });
            DropIndex("Infrastructure.Leg", new[] { "ArrivalAirportId" });
            DropIndex("Infrastructure.Airline", new[] { "CountryId" });
            DropIndex("Infrastructure.FlightNumber", new[] { "AirlineId" });
            DropIndex("Infrastructure.AircraftRegisterNonAvailableSeat", new[] { "AircraftRegisterId" });
            DropIndex("Infrastructure.AircraftRegisterSeatInfo", new[] { "AircraftRegisterId" });
            DropIndex("Infrastructure.Aircrafts", new[] { "AircraftTypeId" });
            DropIndex("Infrastructure.AircraftRegister", new[] { "AircraftId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "DepartureAirportId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "ArrivalAirportId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "ScheduledAircraftTypeId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "LegId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "AircraftRegisterId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "FlightTypeId" });
            DropIndex("Infrastructure.FlightLeg", new[] { "FlightNumberId" });
            DropIndex("Infrastructure.DelayCode", new[] { "DelayTypeId" });
            DropIndex("Infrastructure.Country", new[] { "ContinentId" });
            DropIndex("Infrastructure.Country", new[] { "CurrencyId" });
            DropIndex("Infrastructure.Country", new[] { "IataRegionCodeId" });
            DropIndex("Infrastructure.City", new[] { "CountryId" });
            DropIndex("Infrastructure.Airport", new[] { "LocalityTypeId" });
            DropIndex("Infrastructure.Airport", new[] { "CityId" });
            DropIndex("Infrastructure.AirportAirlineStation", new[] { "AirportId" });
            DropIndex("Infrastructure.AirportAirlineStation", new[] { "AirlineStationId" });
            DropIndex("Infrastructure.AirlineStation", new[] { "LocalityTypeId" });
            DropTable("Infrastructure.Unit");
            DropTable("dbo.TimeZones");
            DropTable("Infrastructure.Company");
            DropTable("Infrastructure.TicketType");
            DropTable("Infrastructure.SeatClass");
            DropTable("Infrastructure.RouteTemplateLeg");
            DropTable("Infrastructure.RouteTemplateType");
            DropTable("Infrastructure.RouteTemplate");
            DropTable("Infrastructure.RouteAircraftLeg");
            DropTable("Infrastructure.RouteAircraft");
            DropTable("Infrastructure.PassengerType");
            DropTable("Infrastructure.Leg");
            DropTable("Infrastructure.FlightType");
            DropTable("Infrastructure.Airline");
            DropTable("Infrastructure.FlightNumber");
            DropTable("Infrastructure.AircraftRegisterNonAvailableSeat");
            DropTable("Infrastructure.AircraftRegisterSeatInfo");
            DropTable("Infrastructure.AircraftType");
            DropTable("Infrastructure.Aircrafts");
            DropTable("Infrastructure.AircraftRegister");
            DropTable("Infrastructure.FlightLeg");
            DropTable("Infrastructure.DelayType");
            DropTable("Infrastructure.DelayCode");
            DropTable("Infrastructure.CargoType");
            DropTable("Infrastructure.LocalityType");
            DropTable("Infrastructure.IataRegionCode");
            DropTable("Infrastructure.Currency");
            DropTable("Infrastructure.Continent");
            DropTable("Infrastructure.Country");
            DropTable("Infrastructure.City");
            DropTable("Infrastructure.Airport");
            DropTable("Infrastructure.AirportAirlineStation");
            DropTable("Infrastructure.AirlineStation");
        }
    }
}
