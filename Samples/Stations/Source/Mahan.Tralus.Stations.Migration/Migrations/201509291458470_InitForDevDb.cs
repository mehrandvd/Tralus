namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitForDevDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Stations.DestinationCargo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DestinationProfileId = c.Guid(nullable: false),
                        CargoTypeId = c.Guid(nullable: false),
                        CargoPieces = c.Long(),
                        CargoWeight = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.CargoType", t => t.CargoTypeId, cascadeDelete: true)
                .ForeignKey("Stations.DestinationProfile", t => t.DestinationProfileId, cascadeDelete: true)
                .Index(t => t.DestinationProfileId)
                .Index(t => t.CargoTypeId);
            
            //CreateTable(
            //    "Infrastructure.CargoType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            Code = c.Long(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.DestinationProfile",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IsMainRoute = c.Boolean(),
                        AirportId = c.Guid(),
                        ExtraBaggageAmount = c.Long(),
                        ExtraBaggageWeight = c.Double(),
                        FlightLegId = c.Guid(),
                        DestinationProfile_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.Airport", t => t.AirportId)
                .ForeignKey("Stations.DestinationProfile", t => t.DestinationProfile_Id)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .Index(t => t.AirportId)
                .Index(t => t.FlightLegId)
                .Index(t => t.DestinationProfile_Id);
            
            //CreateTable(
            //    "Infrastructure.Airport",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            NameEn = c.String(maxLength: 200),
            //            IataAirportCode = c.String(maxLength: 3),
            //            CityId = c.Guid(),
            //            Status = c.String(maxLength: 20),
            //            LocalityTypeId = c.Guid(),
            //            NickName = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.City", t => t.CityId)
            //    .ForeignKey("Infrastructure.LocalityType", t => t.LocalityTypeId)
            //    .Index(t => t.CityId)
            //    .Index(t => t.LocalityTypeId);
            
            //CreateTable(
            //    "Infrastructure.City",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            CountryId = c.Guid(),
            //            NameEn = c.String(maxLength: 200),
            //            TimeZone = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Country", t => t.CountryId)
            //    .Index(t => t.CountryId);
            
            //CreateTable(
            //    "Infrastructure.Country",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            IsoAlpha3 = c.String(maxLength: 3),
            //            IsoAlpha2 = c.String(maxLength: 2),
            //            IataCode = c.String(),
            //            NameEn = c.String(maxLength: 200),
            //            UnNumeric3 = c.String(maxLength: 3),
            //            Fips104 = c.String(maxLength: 2),
            //            IataRegionCodeId = c.Guid(),
            //            CurrencyId = c.Guid(),
            //            ContinentId = c.Guid(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Continent", t => t.ContinentId)
            //    .ForeignKey("Infrastructure.Currency", t => t.CurrencyId)
            //    .ForeignKey("Infrastructure.IataRegionCode", t => t.IataRegionCodeId)
            //    .Index(t => t.IataRegionCodeId)
            //    .Index(t => t.CurrencyId)
            //    .Index(t => t.ContinentId);
            
            //CreateTable(
            //    "Infrastructure.Continent",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Code = c.String(maxLength: 200),
            //            NameEn = c.String(maxLength: 200),
            //            Name = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.Currency",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 50),
            //            Symbol = c.String(maxLength: 20),
            //            NameEn = c.String(maxLength: 50),
            //            Code = c.String(maxLength: 5),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.IataRegionCode",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            RegionCode = c.String(maxLength: 200),
            //            RegionName = c.String(maxLength: 200),
            //            RegionNameEn = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.LocalityType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Code = c.Long(),
            //            NameEn = c.String(maxLength: 200),
            //            ProgrammingKey = c.String(),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.DestinationSpecialService",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DestinationProfileId = c.Guid(nullable: false),
                        SpecialServiceTypeId = c.Guid(nullable: false),
                        SpecialServiceCount = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Stations.DestinationProfile", t => t.DestinationProfileId, cascadeDelete: true)
                .ForeignKey("Stations.SpecialServiceType", t => t.SpecialServiceTypeId, cascadeDelete: true)
                .Index(t => t.DestinationProfileId)
                .Index(t => t.SpecialServiceTypeId);
            
            CreateTable(
                "Stations.SpecialServiceType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 200),
                        ProgrammingKey = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.FlightLeg",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            FlightNumberId = c.Guid(),
            //            FlightTypeId = c.Guid(),
            //            Status = c.String(maxLength: 200),
            //            ScheduledDepartureDateTime_DateTimeUtc = c.DateTime(),
            //            ScheduledDepartureDateTime_DateTimeLocal = c.DateTime(),
            //            ScheduledDepartureDateTime_DateTimeHome = c.DateTime(),
            //            ScheduledDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
            //            ScheduledDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
            //            ScheduledDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
            //            ScheduledDepartureDateTime_AltCalendarYearUtc = c.Int(),
            //            ScheduledDepartureDateTime_AltCalendarMonthUtc = c.Int(),
            //            ScheduledDepartureDateTime_AltCalendarDayUtc = c.Int(),
            //            ScheduledDepartureDateTime_TimeUtc = c.Time(precision: 7),
            //            ScheduledDepartureDateTime_TimeLocal = c.Time(precision: 7),
            //            ScheduledDepartureDateTime_TimeHome = c.Time(precision: 7),
            //            ScheduledDepartureDateTime_LocalTimeZoneId = c.String(),
            //            EstimatedDepartureDateTime_DateTimeUtc = c.DateTime(),
            //            EstimatedDepartureDateTime_DateTimeLocal = c.DateTime(),
            //            EstimatedDepartureDateTime_DateTimeHome = c.DateTime(),
            //            EstimatedDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
            //            EstimatedDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
            //            EstimatedDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
            //            EstimatedDepartureDateTime_AltCalendarYearUtc = c.Int(),
            //            EstimatedDepartureDateTime_AltCalendarMonthUtc = c.Int(),
            //            EstimatedDepartureDateTime_AltCalendarDayUtc = c.Int(),
            //            EstimatedDepartureDateTime_TimeUtc = c.Time(precision: 7),
            //            EstimatedDepartureDateTime_TimeLocal = c.Time(precision: 7),
            //            EstimatedDepartureDateTime_TimeHome = c.Time(precision: 7),
            //            EstimatedDepartureDateTime_LocalTimeZoneId = c.String(),
            //            ActualDepartureDateTime_DateTimeUtc = c.DateTime(),
            //            ActualDepartureDateTime_DateTimeLocal = c.DateTime(),
            //            ActualDepartureDateTime_DateTimeHome = c.DateTime(),
            //            ActualDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
            //            ActualDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
            //            ActualDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
            //            ActualDepartureDateTime_AltCalendarYearUtc = c.Int(),
            //            ActualDepartureDateTime_AltCalendarMonthUtc = c.Int(),
            //            ActualDepartureDateTime_AltCalendarDayUtc = c.Int(),
            //            ActualDepartureDateTime_TimeUtc = c.Time(precision: 7),
            //            ActualDepartureDateTime_TimeLocal = c.Time(precision: 7),
            //            ActualDepartureDateTime_TimeHome = c.Time(precision: 7),
            //            ActualDepartureDateTime_LocalTimeZoneId = c.String(),
            //            EstimatedArrivalDateTime_DateTimeUtc = c.DateTime(),
            //            EstimatedArrivalDateTime_DateTimeLocal = c.DateTime(),
            //            EstimatedArrivalDateTime_DateTimeHome = c.DateTime(),
            //            EstimatedArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
            //            EstimatedArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
            //            EstimatedArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
            //            EstimatedArrivalDateTime_AltCalendarYearUtc = c.Int(),
            //            EstimatedArrivalDateTime_AltCalendarMonthUtc = c.Int(),
            //            EstimatedArrivalDateTime_AltCalendarDayUtc = c.Int(),
            //            EstimatedArrivalDateTime_TimeUtc = c.Time(precision: 7),
            //            EstimatedArrivalDateTime_TimeLocal = c.Time(precision: 7),
            //            EstimatedArrivalDateTime_TimeHome = c.Time(precision: 7),
            //            EstimatedArrivalDateTime_LocalTimeZoneId = c.String(),
            //            ActualArrivalDateTime_DateTimeUtc = c.DateTime(),
            //            ActualArrivalDateTime_DateTimeLocal = c.DateTime(),
            //            ActualArrivalDateTime_DateTimeHome = c.DateTime(),
            //            ActualArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
            //            ActualArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
            //            ActualArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
            //            ActualArrivalDateTime_AltCalendarYearUtc = c.Int(),
            //            ActualArrivalDateTime_AltCalendarMonthUtc = c.Int(),
            //            ActualArrivalDateTime_AltCalendarDayUtc = c.Int(),
            //            ActualArrivalDateTime_TimeUtc = c.Time(precision: 7),
            //            ActualArrivalDateTime_TimeLocal = c.Time(precision: 7),
            //            ActualArrivalDateTime_TimeHome = c.Time(precision: 7),
            //            ActualArrivalDateTime_LocalTimeZoneId = c.String(),
            //            AircraftRegisterId = c.Guid(),
            //            LegId = c.Guid(),
            //            ScheduledAircraftTypeId = c.Guid(),
            //            ArrivalAirportId = c.Guid(),
            //            DepartureAirportId = c.Guid(),
            //            RepetitionReasonCode = c.Long(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
            //    .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
            //    .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
            //    .ForeignKey("Infrastructure.FlightNumber", t => t.FlightNumberId)
            //    .ForeignKey("Infrastructure.FlightType", t => t.FlightTypeId)
            //    .ForeignKey("Infrastructure.Leg", t => t.LegId)
            //    .ForeignKey("Infrastructure.AircraftType", t => t.ScheduledAircraftTypeId)
            //    .Index(t => t.FlightNumberId)
            //    .Index(t => t.FlightTypeId)
            //    .Index(t => t.AircraftRegisterId)
            //    .Index(t => t.LegId)
            //    .Index(t => t.ScheduledAircraftTypeId)
            //    .Index(t => t.ArrivalAirportId)
            //    .Index(t => t.DepartureAirportId);
            
            //CreateTable(
            //    "Infrastructure.AircraftRegister",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Code = c.String(maxLength: 200),
            //            AircraftId = c.Guid(),
            //            ShortRegisterCode = c.String(maxLength: 3),
            //            HasFirstClassSeat = c.Boolean(),
            //            Status = c.String(maxLength: 20),
            //            Timestamp = c.DateTime(),
            //            IsActive = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Aircrafts", t => t.AircraftId)
            //    .Index(t => t.AircraftId);
            
            //CreateTable(
            //    "Infrastructure.Aircrafts",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            SerialNo = c.String(maxLength: 200),
            //            AircraftTypeId = c.Guid(),
            //            Register = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.AircraftType", t => t.AircraftTypeId)
            //    .Index(t => t.AircraftTypeId);
            
            //CreateTable(
            //    "Infrastructure.AircraftType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            Manufacturer = c.String(maxLength: 200),
            //            TypeVariation = c.String(maxLength: 200),
            //            FullTypeName = c.String(maxLength: 200),
            //            IataCode = c.String(maxLength: 3),
            //            IcaoCode = c.String(maxLength: 4),
            //            FwName = c.String(maxLength: 3),
            //            Status = c.String(maxLength: 20),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.AircraftRegisterSeatInfo",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            StartDate_Date = c.DateTime(storeType: "date"),
            //            StartDate_DateInAltCalendar = c.String(),
            //            StartDate_AltCalendarYearUtc = c.Int(),
            //            StartDate_AltCalendarMonthUtc = c.Int(),
            //            StartDate_AltCalendarDayUtc = c.Int(),
            //            EndDate_Date = c.DateTime(storeType: "date"),
            //            EndDate_DateInAltCalendar = c.String(),
            //            EndDate_AltCalendarYearUtc = c.Int(),
            //            EndDate_AltCalendarMonthUtc = c.Int(),
            //            EndDate_AltCalendarDayUtc = c.Int(),
            //            SeatCountBusiness = c.Long(),
            //            SeatCountEconomy = c.Long(),
            //            AircraftRegisterId = c.Guid(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
            //    .Index(t => t.AircraftRegisterId);
            
            //CreateTable(
            //    "Infrastructure.AircraftRegisterNonAvailableSeat",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            StartDate_Date = c.DateTime(storeType: "date"),
            //            StartDate_DateInAltCalendar = c.String(),
            //            StartDate_AltCalendarYearUtc = c.Int(),
            //            StartDate_AltCalendarMonthUtc = c.Int(),
            //            StartDate_AltCalendarDayUtc = c.Int(),
            //            EndDate_Date = c.DateTime(storeType: "date"),
            //            EndDate_DateInAltCalendar = c.String(),
            //            EndDate_AltCalendarYearUtc = c.Int(),
            //            EndDate_AltCalendarMonthUtc = c.Int(),
            //            EndDate_AltCalendarDayUtc = c.Int(),
            //            AircraftRegisterId = c.Guid(),
            //            SeatCountBusiness = c.Long(),
            //            SeatCountBusinessPlus = c.Long(),
            //            SeatCountEconomy = c.Long(),
            //            SeatNumberBusiness = c.String(maxLength: 200),
            //            SeatNumberBusinessPlus = c.String(maxLength: 200),
            //            SeatNumberEconomy = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
            //    .Index(t => t.AircraftRegisterId);
            
            //CreateTable(
            //    "Infrastructure.FlightNumber",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            AirlineId = c.Guid(),
            //            FullFlightNumber = c.String(maxLength: 200),
            //            ShortFlightNumber = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Airline", t => t.AirlineId)
            //    .Index(t => t.AirlineId);
            
            //CreateTable(
            //    "Infrastructure.Airline",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            CountryId = c.Guid(),
            //            IataCode = c.String(maxLength: 200),
            //            IcaoCode = c.String(maxLength: 200),
            //            Abv = c.String(maxLength: 200),
            //            FullName = c.String(maxLength: 200),
            //            ShortName = c.String(maxLength: 200),
            //            Status = c.String(maxLength: 20),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Country", t => t.CountryId)
            //    .Index(t => t.CountryId);
            
            //CreateTable(
            //    "Infrastructure.FlightType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Code = c.Int(nullable: false),
            //            ProgrammingKey = c.String(),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.Leg",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            ArrivalAirportId = c.Guid(),
            //            DepartureAirportId = c.Guid(),
            //            Name = c.String(maxLength: 200),
            //            Status = c.String(maxLength: 20),
            //            LocalityTypeId = c.Guid(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
            //    .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
            //    .ForeignKey("Infrastructure.LocalityType", t => t.LocalityTypeId)
            //    .Index(t => t.ArrivalAirportId)
            //    .Index(t => t.DepartureAirportId)
            //    .Index(t => t.LocalityTypeId);
            
            CreateTable(
                "Stations.DestinationPassenger",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DestinationProfileId = c.Guid(nullable: false),
                        SeatClassId = c.Guid(nullable: false),
                        PassengerTypeId = c.Guid(nullable: false),
                        TicketTypeId = c.Guid(nullable: false),
                        PassengerCount = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Stations.DestinationProfile", t => t.DestinationProfileId, cascadeDelete: true)
                .ForeignKey("Infrastructure.PassengerType", t => t.PassengerTypeId, cascadeDelete: true)
                .ForeignKey("Infrastructure.SeatClass", t => t.SeatClassId, cascadeDelete: true)
                .ForeignKey("Infrastructure.TicketType", t => t.TicketTypeId, cascadeDelete: true)
                .Index(t => t.DestinationProfileId)
                .Index(t => t.SeatClassId)
                .Index(t => t.PassengerTypeId)
                .Index(t => t.TicketTypeId);
            
            //CreateTable(
            //    "Infrastructure.PassengerType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            Code = c.Long(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.SeatClass",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            Code = c.Long(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "Infrastructure.TicketType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //            Code = c.Long(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightDelay",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DelayCodeId = c.Guid(),
                        FlightLegId = c.Guid(),
                        Duration = c.Long(),
                        RemarkDelay = c.String(maxLength: 200),
                        DelayDescriptionFa = c.String(maxLength: 200),
                        DelayDescriptionEn = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.DelayCode", t => t.DelayCodeId)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .Index(t => t.DelayCodeId)
                .Index(t => t.FlightLegId);
            
            //CreateTable(
            //    "Infrastructure.DelayCode",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            DelayTypeId = c.Guid(),
            //            Description = c.String(),
            //            DescriptionEn = c.String(),
            //            Code = c.String(maxLength: 10),
            //            IsEnabled = c.Boolean(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("Infrastructure.DelayType", t => t.DelayTypeId)
            //    .Index(t => t.DelayTypeId);
            
            //CreateTable(
            //    "Infrastructure.DelayType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Name = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightEvent",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightEventTypeId = c.Guid(),
                        FlightLegId = c.Guid(),
                        EventDateTime_DateTimeUtc = c.DateTime(),
                        EventDateTime_DateTimeLocal = c.DateTime(),
                        EventDateTime_DateTimeHome = c.DateTime(),
                        EventDateTime_DateUtc = c.DateTime(storeType: "date"),
                        EventDateTime_DateLocal = c.DateTime(storeType: "date"),
                        EventDateTime_DateHome = c.DateTime(storeType: "date"),
                        EventDateTime_AltCalendarYearUtc = c.Int(),
                        EventDateTime_AltCalendarMonthUtc = c.Int(),
                        EventDateTime_AltCalendarDayUtc = c.Int(),
                        EventDateTime_TimeUtc = c.Time(precision: 7),
                        EventDateTime_TimeLocal = c.Time(precision: 7),
                        EventDateTime_TimeHome = c.Time(precision: 7),
                        EventDateTime_LocalTimeZoneId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Stations.FlightEventType", t => t.FlightEventTypeId)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .Index(t => t.FlightEventTypeId)
                .Index(t => t.FlightLegId);
            
            CreateTable(
                "Stations.FlightEventType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ProgrammingKey = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightFuelling",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FuellingTypeId = c.Guid(),
                        Amount = c.Long(),
                        FlightLegId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .ForeignKey("Stations.FuellingType", t => t.FuellingTypeId)
                .Index(t => t.FuellingTypeId)
                .Index(t => t.FlightLegId);
            
            CreateTable(
                "Stations.FuellingType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightSummary",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TotalDelay = c.DateTime(),
                        TotalLoadPieces = c.Int(),
                        TotalLoadWeight = c.Int(),
                        TotalPassengers = c.Int(),
                        TotalSpecialServiceCount = c.Int(),
                        TotalFuel = c.Long(),
                        FlightLegId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .Index(t => t.FlightLegId);
            
            CreateTable(
                "Stations.FlightRemark",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Remark = c.String(),
                        UserId = c.Guid(),
                        CreationDate_DateTimeUtc = c.DateTime(),
                        CreationDate_DateTimeLocal = c.DateTime(),
                        CreationDate_DateTimeHome = c.DateTime(),
                        CreationDate_DateUtc = c.DateTime(storeType: "date"),
                        CreationDate_DateLocal = c.DateTime(storeType: "date"),
                        CreationDate_DateHome = c.DateTime(storeType: "date"),
                        CreationDate_AltCalendarYearUtc = c.Int(),
                        CreationDate_AltCalendarMonthUtc = c.Int(),
                        CreationDate_AltCalendarDayUtc = c.Int(),
                        CreationDate_TimeUtc = c.Time(precision: 7),
                        CreationDate_TimeLocal = c.Time(precision: 7),
                        CreationDate_TimeHome = c.Time(precision: 7),
                        CreationDate_LocalTimeZoneId = c.String(),
                        FlightLegId = c.Guid(),
                        FlightRemarkTypeId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .ForeignKey("Stations.FlightRemarkType", t => t.FlightRemarkTypeId)
                .ForeignKey("System.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.FlightLegId)
                .Index(t => t.FlightRemarkTypeId);
            
            CreateTable(
                "Stations.FlightRemarkType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightReport",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightLegId = c.Guid(),
                        FlightReportStateId = c.String(),
                        FlightReportState_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
                .ForeignKey("Stations.FlightReportState", t => t.FlightReportState_Id)
                .Index(t => t.FlightLegId)
                .Index(t => t.FlightReportState_Id);
            
            CreateTable(
                "Stations.FlightReportState",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightReportActivityTimingSetup",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TimeBeforeStdStationStaffMinute = c.Long(),
                        TimeBeforeStdStationManagerMinute = c.Long(),
                        TimeBeforeStdSendToOccMinute = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Stations.FlightReportFileAttachment",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FlightReportId = c.Guid(),
                        FlightReportFileAttachmentTypeId = c.Guid(),
                        Description = c.String(),
                        AttachedDate_DateTimeUtc = c.DateTime(),
                        AttachedDate_DateTimeLocal = c.DateTime(),
                        AttachedDate_DateTimeHome = c.DateTime(),
                        AttachedDate_DateUtc = c.DateTime(storeType: "date"),
                        AttachedDate_DateLocal = c.DateTime(storeType: "date"),
                        AttachedDate_DateHome = c.DateTime(storeType: "date"),
                        AttachedDate_AltCalendarYearUtc = c.Int(),
                        AttachedDate_AltCalendarMonthUtc = c.Int(),
                        AttachedDate_AltCalendarDayUtc = c.Int(),
                        AttachedDate_TimeUtc = c.Time(precision: 7),
                        AttachedDate_TimeLocal = c.Time(precision: 7),
                        AttachedDate_TimeHome = c.Time(precision: 7),
                        AttachedDate_LocalTimeZoneId = c.String(),
                        AttachedBy = c.String(),
                        AttachmentFile = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Stations.FlightReport", t => t.FlightReportId)
                .ForeignKey("Stations.FlightReportFileAttachmentType", t => t.FlightReportFileAttachmentTypeId)
                .Index(t => t.FlightReportId)
                .Index(t => t.FlightReportFileAttachmentTypeId);
            
            CreateTable(
                "Stations.FlightReportFileAttachmentType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        RequiresDescription = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        //    CreateTable(
        //        "Stations.FlightReportView",
        //        c => new
        //            {
        //                Id = c.Guid(nullable: false),
        //                FlightLegId = c.Guid(),
        //                Status = c.String(maxLength: 200),
        //                FlightNumberId = c.Guid(),
        //                FlightTypeId = c.Guid(),
        //                AircraftRegisterId = c.Guid(),
        //                AircraftTypeId = c.Guid(),
        //                DepartureAirportId = c.Guid(),
        //                ArrivalAirportId = c.Guid(),
        //                ScheduledDepartureDateTime_DateTimeUtc = c.DateTime(),
        //                ScheduledDepartureDateTime_DateTimeLocal = c.DateTime(),
        //                ScheduledDepartureDateTime_DateTimeHome = c.DateTime(),
        //                ScheduledDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                ScheduledDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                ScheduledDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
        //                ScheduledDepartureDateTime_AltCalendarYearUtc = c.Int(),
        //                ScheduledDepartureDateTime_AltCalendarMonthUtc = c.Int(),
        //                ScheduledDepartureDateTime_AltCalendarDayUtc = c.Int(),
        //                ScheduledDepartureDateTime_TimeUtc = c.Time(precision: 7),
        //                ScheduledDepartureDateTime_TimeLocal = c.Time(precision: 7),
        //                ScheduledDepartureDateTime_TimeHome = c.Time(precision: 7),
        //                ScheduledDepartureDateTime_LocalTimeZoneId = c.String(),
        //                ActualDepartureDateTime_DateTimeUtc = c.DateTime(),
        //                ActualDepartureDateTime_DateTimeLocal = c.DateTime(),
        //                ActualDepartureDateTime_DateTimeHome = c.DateTime(),
        //                ActualDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                ActualDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                ActualDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
        //                ActualDepartureDateTime_AltCalendarYearUtc = c.Int(),
        //                ActualDepartureDateTime_AltCalendarMonthUtc = c.Int(),
        //                ActualDepartureDateTime_AltCalendarDayUtc = c.Int(),
        //                ActualDepartureDateTime_TimeUtc = c.Time(precision: 7),
        //                ActualDepartureDateTime_TimeLocal = c.Time(precision: 7),
        //                ActualDepartureDateTime_TimeHome = c.Time(precision: 7),
        //                ActualDepartureDateTime_LocalTimeZoneId = c.String(),
        //                EstimatedDepartureDateTime_DateTimeUtc = c.DateTime(),
        //                EstimatedDepartureDateTime_DateTimeLocal = c.DateTime(),
        //                EstimatedDepartureDateTime_DateTimeHome = c.DateTime(),
        //                EstimatedDepartureDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                EstimatedDepartureDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                EstimatedDepartureDateTime_DateHome = c.DateTime(storeType: "date"),
        //                EstimatedDepartureDateTime_AltCalendarYearUtc = c.Int(),
        //                EstimatedDepartureDateTime_AltCalendarMonthUtc = c.Int(),
        //                EstimatedDepartureDateTime_AltCalendarDayUtc = c.Int(),
        //                EstimatedDepartureDateTime_TimeUtc = c.Time(precision: 7),
        //                EstimatedDepartureDateTime_TimeLocal = c.Time(precision: 7),
        //                EstimatedDepartureDateTime_TimeHome = c.Time(precision: 7),
        //                EstimatedDepartureDateTime_LocalTimeZoneId = c.String(),
        //                ActualArrivalDateTime_DateTimeUtc = c.DateTime(),
        //                ActualArrivalDateTime_DateTimeLocal = c.DateTime(),
        //                ActualArrivalDateTime_DateTimeHome = c.DateTime(),
        //                ActualArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                ActualArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                ActualArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
        //                ActualArrivalDateTime_AltCalendarYearUtc = c.Int(),
        //                ActualArrivalDateTime_AltCalendarMonthUtc = c.Int(),
        //                ActualArrivalDateTime_AltCalendarDayUtc = c.Int(),
        //                ActualArrivalDateTime_TimeUtc = c.Time(precision: 7),
        //                ActualArrivalDateTime_TimeLocal = c.Time(precision: 7),
        //                ActualArrivalDateTime_TimeHome = c.Time(precision: 7),
        //                ActualArrivalDateTime_LocalTimeZoneId = c.String(),
        //                EstimatedArrivalDateTime_DateTimeUtc = c.DateTime(),
        //                EstimatedArrivalDateTime_DateTimeLocal = c.DateTime(),
        //                EstimatedArrivalDateTime_DateTimeHome = c.DateTime(),
        //                EstimatedArrivalDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                EstimatedArrivalDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                EstimatedArrivalDateTime_DateHome = c.DateTime(storeType: "date"),
        //                EstimatedArrivalDateTime_AltCalendarYearUtc = c.Int(),
        //                EstimatedArrivalDateTime_AltCalendarMonthUtc = c.Int(),
        //                EstimatedArrivalDateTime_AltCalendarDayUtc = c.Int(),
        //                EstimatedArrivalDateTime_TimeUtc = c.Time(precision: 7),
        //                EstimatedArrivalDateTime_TimeLocal = c.Time(precision: 7),
        //                EstimatedArrivalDateTime_TimeHome = c.Time(precision: 7),
        //                EstimatedArrivalDateTime_LocalTimeZoneId = c.String(),
        //                AtaEventDateTime_DateTimeUtc = c.DateTime(),
        //                AtaEventDateTime_DateTimeLocal = c.DateTime(),
        //                AtaEventDateTime_DateTimeHome = c.DateTime(),
        //                AtaEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                AtaEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                AtaEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                AtaEventDateTime_AltCalendarYearUtc = c.Int(),
        //                AtaEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                AtaEventDateTime_AltCalendarDayUtc = c.Int(),
        //                AtaEventDateTime_TimeUtc = c.Time(precision: 7),
        //                AtaEventDateTime_TimeLocal = c.Time(precision: 7),
        //                AtaEventDateTime_TimeHome = c.Time(precision: 7),
        //                AtaEventDateTime_LocalTimeZoneId = c.String(),
        //                CctEventDateTime_DateTimeUtc = c.DateTime(),
        //                CctEventDateTime_DateTimeLocal = c.DateTime(),
        //                CctEventDateTime_DateTimeHome = c.DateTime(),
        //                CctEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                CctEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                CctEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                CctEventDateTime_AltCalendarYearUtc = c.Int(),
        //                CctEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                CctEventDateTime_AltCalendarDayUtc = c.Int(),
        //                CctEventDateTime_TimeUtc = c.Time(precision: 7),
        //                CctEventDateTime_TimeLocal = c.Time(precision: 7),
        //                CctEventDateTime_TimeHome = c.Time(precision: 7),
        //                CctEventDateTime_LocalTimeZoneId = c.String(),
        //                DctEventDateTime_DateTimeUtc = c.DateTime(),
        //                DctEventDateTime_DateTimeLocal = c.DateTime(),
        //                DctEventDateTime_DateTimeHome = c.DateTime(),
        //                DctEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                DctEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                DctEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                DctEventDateTime_AltCalendarYearUtc = c.Int(),
        //                DctEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                DctEventDateTime_AltCalendarDayUtc = c.Int(),
        //                DctEventDateTime_TimeUtc = c.Time(precision: 7),
        //                DctEventDateTime_TimeLocal = c.Time(precision: 7),
        //                DctEventDateTime_TimeHome = c.Time(precision: 7),
        //                DctEventDateTime_LocalTimeZoneId = c.String(),
        //                InEventDateTime_DateTimeUtc = c.DateTime(),
        //                InEventDateTime_DateTimeLocal = c.DateTime(),
        //                InEventDateTime_DateTimeHome = c.DateTime(),
        //                InEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                InEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                InEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                InEventDateTime_AltCalendarYearUtc = c.Int(),
        //                InEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                InEventDateTime_AltCalendarDayUtc = c.Int(),
        //                InEventDateTime_TimeUtc = c.Time(precision: 7),
        //                InEventDateTime_TimeLocal = c.Time(precision: 7),
        //                InEventDateTime_TimeHome = c.Time(precision: 7),
        //                InEventDateTime_LocalTimeZoneId = c.String(),
        //                OutEventDateTime_DateTimeUtc = c.DateTime(),
        //                OutEventDateTime_DateTimeLocal = c.DateTime(),
        //                OutEventDateTime_DateTimeHome = c.DateTime(),
        //                OutEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                OutEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                OutEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                OutEventDateTime_AltCalendarYearUtc = c.Int(),
        //                OutEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                OutEventDateTime_AltCalendarDayUtc = c.Int(),
        //                OutEventDateTime_TimeUtc = c.Time(precision: 7),
        //                OutEventDateTime_TimeLocal = c.Time(precision: 7),
        //                OutEventDateTime_TimeHome = c.Time(precision: 7),
        //                OutEventDateTime_LocalTimeZoneId = c.String(),
        //                OffEventDateTime_DateTimeUtc = c.DateTime(),
        //                OffEventDateTime_DateTimeLocal = c.DateTime(),
        //                OffEventDateTime_DateTimeHome = c.DateTime(),
        //                OffEventDateTime_DateUtc = c.DateTime(storeType: "date"),
        //                OffEventDateTime_DateLocal = c.DateTime(storeType: "date"),
        //                OffEventDateTime_DateHome = c.DateTime(storeType: "date"),
        //                OffEventDateTime_AltCalendarYearUtc = c.Int(),
        //                OffEventDateTime_AltCalendarMonthUtc = c.Int(),
        //                OffEventDateTime_AltCalendarDayUtc = c.Int(),
        //                OffEventDateTime_TimeUtc = c.Time(precision: 7),
        //                OffEventDateTime_TimeLocal = c.Time(precision: 7),
        //                OffEventDateTime_TimeHome = c.Time(precision: 7),
        //                OffEventDateTime_LocalTimeZoneId = c.String(),
        //                SpecialServicesCount = c.Long(),
        //                CargoPiecesCount = c.Long(),
        //                CargoWeightSum = c.Long(),
        //                PassengersCount = c.Long(),
        //            })
        //        .PrimaryKey(t => t.Id)
        //        .ForeignKey("Infrastructure.AircraftRegister", t => t.AircraftRegisterId)
        //        .ForeignKey("Infrastructure.AircraftType", t => t.AircraftTypeId)
        //        .ForeignKey("Infrastructure.Airport", t => t.ArrivalAirportId)
        //        .ForeignKey("Infrastructure.Airport", t => t.DepartureAirportId)
        //        .ForeignKey("Infrastructure.FlightLeg", t => t.FlightLegId)
        //        .ForeignKey("Infrastructure.FlightNumber", t => t.FlightNumberId)
        //        .ForeignKey("Infrastructure.FlightType", t => t.FlightTypeId)
        //        .Index(t => t.FlightLegId)
        //        .Index(t => t.FlightNumberId)
        //        .Index(t => t.FlightTypeId)
        //        .Index(t => t.AircraftRegisterId)
        //        .Index(t => t.AircraftTypeId)
        //        .Index(t => t.DepartureAirportId)
        //        .Index(t => t.ArrivalAirportId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("Stations.FlightReportView", "FlightTypeId", "Infrastructure.FlightType");
            //DropForeignKey("Stations.FlightReportView", "FlightNumberId", "Infrastructure.FlightNumber");
            //DropForeignKey("Stations.FlightReportView", "FlightLegId", "Infrastructure.FlightLeg");
            //DropForeignKey("Stations.FlightReportView", "DepartureAirportId", "Infrastructure.Airport");
            //DropForeignKey("Stations.FlightReportView", "ArrivalAirportId", "Infrastructure.Airport");
            //DropForeignKey("Stations.FlightReportView", "AircraftTypeId", "Infrastructure.AircraftType");
            //DropForeignKey("Stations.FlightReportView", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            DropForeignKey("Stations.FlightReportFileAttachment", "FlightReportFileAttachmentTypeId", "Stations.FlightReportFileAttachmentType");
            DropForeignKey("Stations.FlightReportFileAttachment", "FlightReportId", "Stations.FlightReport");
            DropForeignKey("Stations.FlightReport", "FlightReportState_Id", "Stations.FlightReportState");
            DropForeignKey("Stations.FlightReport", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightRemark", "UserId", "System.User");
            DropForeignKey("Stations.FlightRemark", "FlightRemarkTypeId", "Stations.FlightRemarkType");
            DropForeignKey("Stations.FlightRemark", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightSummary", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightFuelling", "FuellingTypeId", "Stations.FuellingType");
            DropForeignKey("Stations.FlightFuelling", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightEvent", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightEvent", "FlightEventTypeId", "Stations.FlightEventType");
            DropForeignKey("Stations.FlightDelay", "FlightLegId", "Infrastructure.FlightLeg");
            DropForeignKey("Stations.FlightDelay", "DelayCodeId", "Infrastructure.DelayCode");
            //DropForeignKey("Infrastructure.DelayCode", "DelayTypeId", "Infrastructure.DelayType");
            DropForeignKey("Stations.DestinationPassenger", "TicketTypeId", "Infrastructure.TicketType");
            DropForeignKey("Stations.DestinationPassenger", "SeatClassId", "Infrastructure.SeatClass");
            DropForeignKey("Stations.DestinationPassenger", "PassengerTypeId", "Infrastructure.PassengerType");
            DropForeignKey("Stations.DestinationPassenger", "DestinationProfileId", "Stations.DestinationProfile");
            DropForeignKey("Stations.DestinationProfile", "FlightLegId", "Infrastructure.FlightLeg");
            //DropForeignKey("Infrastructure.FlightLeg", "ScheduledAircraftTypeId", "Infrastructure.AircraftType");
            //DropForeignKey("Infrastructure.FlightLeg", "LegId", "Infrastructure.Leg");
            //DropForeignKey("Infrastructure.Leg", "LocalityTypeId", "Infrastructure.LocalityType");
            //DropForeignKey("Infrastructure.Leg", "DepartureAirportId", "Infrastructure.Airport");
            //DropForeignKey("Infrastructure.Leg", "ArrivalAirportId", "Infrastructure.Airport");
            //DropForeignKey("Infrastructure.FlightLeg", "FlightTypeId", "Infrastructure.FlightType");
            //DropForeignKey("Infrastructure.FlightLeg", "FlightNumberId", "Infrastructure.FlightNumber");
            //DropForeignKey("Infrastructure.FlightNumber", "AirlineId", "Infrastructure.Airline");
            //DropForeignKey("Infrastructure.Airline", "CountryId", "Infrastructure.Country");
            //DropForeignKey("Infrastructure.FlightLeg", "DepartureAirportId", "Infrastructure.Airport");
            //DropForeignKey("Infrastructure.FlightLeg", "ArrivalAirportId", "Infrastructure.Airport");
            //DropForeignKey("Infrastructure.FlightLeg", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            //DropForeignKey("Infrastructure.AircraftRegisterNonAvailableSeat", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            //DropForeignKey("Infrastructure.AircraftRegisterSeatInfo", "AircraftRegisterId", "Infrastructure.AircraftRegister");
            //DropForeignKey("Infrastructure.Aircrafts", "AircraftTypeId", "Infrastructure.AircraftType");
            //DropForeignKey("Infrastructure.AircraftRegister", "AircraftId", "Infrastructure.Aircrafts");
            DropForeignKey("Stations.DestinationSpecialService", "SpecialServiceTypeId", "Stations.SpecialServiceType");
            DropForeignKey("Stations.DestinationSpecialService", "DestinationProfileId", "Stations.DestinationProfile");
            DropForeignKey("Stations.DestinationProfile", "DestinationProfile_Id", "Stations.DestinationProfile");
            DropForeignKey("Stations.DestinationCargo", "DestinationProfileId", "Stations.DestinationProfile");
            DropForeignKey("Stations.DestinationProfile", "AirportId", "Infrastructure.Airport");
            //DropForeignKey("Infrastructure.Airport", "LocalityTypeId", "Infrastructure.LocalityType");
            //DropForeignKey("Infrastructure.Airport", "CityId", "Infrastructure.City");
            //DropForeignKey("Infrastructure.City", "CountryId", "Infrastructure.Country");
            //DropForeignKey("Infrastructure.Country", "IataRegionCodeId", "Infrastructure.IataRegionCode");
            //DropForeignKey("Infrastructure.Country", "CurrencyId", "Infrastructure.Currency");
            //DropForeignKey("Infrastructure.Country", "ContinentId", "Infrastructure.Continent");
            DropForeignKey("Stations.DestinationCargo", "CargoTypeId", "Infrastructure.CargoType");
            //DropIndex("Stations.FlightReportView", new[] { "ArrivalAirportId" });
            //DropIndex("Stations.FlightReportView", new[] { "DepartureAirportId" });
            //DropIndex("Stations.FlightReportView", new[] { "AircraftTypeId" });
            //DropIndex("Stations.FlightReportView", new[] { "AircraftRegisterId" });
            //DropIndex("Stations.FlightReportView", new[] { "FlightTypeId" });
            //DropIndex("Stations.FlightReportView", new[] { "FlightNumberId" });
            //DropIndex("Stations.FlightReportView", new[] { "FlightLegId" });
            DropIndex("Stations.FlightReportFileAttachment", new[] { "FlightReportFileAttachmentTypeId" });
            DropIndex("Stations.FlightReportFileAttachment", new[] { "FlightReportId" });
            DropIndex("Stations.FlightReport", new[] { "FlightReportState_Id" });
            DropIndex("Stations.FlightReport", new[] { "FlightLegId" });
            DropIndex("Stations.FlightRemark", new[] { "FlightRemarkTypeId" });
            DropIndex("Stations.FlightRemark", new[] { "FlightLegId" });
            DropIndex("Stations.FlightRemark", new[] { "UserId" });
            DropIndex("Stations.FlightSummary", new[] { "FlightLegId" });
            DropIndex("Stations.FlightFuelling", new[] { "FlightLegId" });
            DropIndex("Stations.FlightFuelling", new[] { "FuellingTypeId" });
            DropIndex("Stations.FlightEvent", new[] { "FlightLegId" });
            DropIndex("Stations.FlightEvent", new[] { "FlightEventTypeId" });
            //DropIndex("Infrastructure.DelayCode", new[] { "DelayTypeId" });
            DropIndex("Stations.FlightDelay", new[] { "FlightLegId" });
            DropIndex("Stations.FlightDelay", new[] { "DelayCodeId" });
            DropIndex("Stations.DestinationPassenger", new[] { "TicketTypeId" });
            DropIndex("Stations.DestinationPassenger", new[] { "PassengerTypeId" });
            DropIndex("Stations.DestinationPassenger", new[] { "SeatClassId" });
            DropIndex("Stations.DestinationPassenger", new[] { "DestinationProfileId" });
            //DropIndex("Infrastructure.Leg", new[] { "LocalityTypeId" });
            //DropIndex("Infrastructure.Leg", new[] { "DepartureAirportId" });
            //DropIndex("Infrastructure.Leg", new[] { "ArrivalAirportId" });
            //DropIndex("Infrastructure.Airline", new[] { "CountryId" });
            //DropIndex("Infrastructure.FlightNumber", new[] { "AirlineId" });
            //DropIndex("Infrastructure.AircraftRegisterNonAvailableSeat", new[] { "AircraftRegisterId" });
            //DropIndex("Infrastructure.AircraftRegisterSeatInfo", new[] { "AircraftRegisterId" });
            //DropIndex("Infrastructure.Aircrafts", new[] { "AircraftTypeId" });
            //DropIndex("Infrastructure.AircraftRegister", new[] { "AircraftId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "DepartureAirportId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "ArrivalAirportId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "ScheduledAircraftTypeId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "LegId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "AircraftRegisterId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "FlightTypeId" });
            //DropIndex("Infrastructure.FlightLeg", new[] { "FlightNumberId" });
            DropIndex("Stations.DestinationSpecialService", new[] { "SpecialServiceTypeId" });
            DropIndex("Stations.DestinationSpecialService", new[] { "DestinationProfileId" });
            //DropIndex("Infrastructure.Country", new[] { "ContinentId" });
            //DropIndex("Infrastructure.Country", new[] { "CurrencyId" });
            //DropIndex("Infrastructure.Country", new[] { "IataRegionCodeId" });
            //DropIndex("Infrastructure.City", new[] { "CountryId" });
            //DropIndex("Infrastructure.Airport", new[] { "LocalityTypeId" });
            //DropIndex("Infrastructure.Airport", new[] { "CityId" });
            DropIndex("Stations.DestinationProfile", new[] { "DestinationProfile_Id" });
            DropIndex("Stations.DestinationProfile", new[] { "FlightLegId" });
            DropIndex("Stations.DestinationProfile", new[] { "AirportId" });
            DropIndex("Stations.DestinationCargo", new[] { "CargoTypeId" });
            DropIndex("Stations.DestinationCargo", new[] { "DestinationProfileId" });
            //DropTable("Stations.FlightReportView");
            DropTable("Stations.FlightReportFileAttachmentType");
            DropTable("Stations.FlightReportFileAttachment");
            DropTable("Stations.FlightReportActivityTimingSetup");
            DropTable("Stations.FlightReportState");
            DropTable("Stations.FlightReport");
            DropTable("Stations.FlightRemarkType");
            DropTable("Stations.FlightRemark");
            DropTable("Stations.FlightSummary");
            DropTable("Stations.FuellingType");
            DropTable("Stations.FlightFuelling");
            DropTable("Stations.FlightEventType");
            DropTable("Stations.FlightEvent");
            //DropTable("Infrastructure.DelayType");
            //DropTable("Infrastructure.DelayCode");
            DropTable("Stations.FlightDelay");
            //DropTable("Infrastructure.TicketType");
            //DropTable("Infrastructure.SeatClass");
            //DropTable("Infrastructure.PassengerType");
            DropTable("Stations.DestinationPassenger");
            //DropTable("Infrastructure.Leg");
            //DropTable("Infrastructure.FlightType");
            //DropTable("Infrastructure.Airline");
            //DropTable("Infrastructure.FlightNumber");
            //DropTable("Infrastructure.AircraftRegisterNonAvailableSeat");
            //DropTable("Infrastructure.AircraftRegisterSeatInfo");
            //DropTable("Infrastructure.AircraftType");
            //DropTable("Infrastructure.Aircrafts");
            //DropTable("Infrastructure.AircraftRegister");
            //DropTable("Infrastructure.FlightLeg");
            DropTable("Stations.SpecialServiceType");
            DropTable("Stations.DestinationSpecialService");
            //DropTable("Infrastructure.LocalityType");
            //DropTable("Infrastructure.IataRegionCode");
            //DropTable("Infrastructure.Currency");
            //DropTable("Infrastructure.Continent");
            //DropTable("Infrastructure.Country");
            //DropTable("Infrastructure.City");
            //DropTable("Infrastructure.Airport");
            DropTable("Stations.DestinationProfile");
            //DropTable("Infrastructure.CargoType");
            DropTable("Stations.DestinationCargo");
        }
    }
}
