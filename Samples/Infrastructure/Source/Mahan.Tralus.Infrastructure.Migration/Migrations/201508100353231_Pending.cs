namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pending : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Infrastructure.Countries", "ContinentId", "Infrastructure.Continents");
            DropForeignKey("Infrastructure.Countries", "CurrencyId", "Infrastructure.Currencies");
            DropForeignKey("Infrastructure.Countries", "IataRegionCodeId", "Infrastructure.IataRegionCodes");
            DropForeignKey("Infrastructure.Cities", "CountryId", "Infrastructure.Countries");
            DropForeignKey("Infrastructure.Airports", "CityId", "Infrastructure.Cities");
            DropForeignKey("Infrastructure.Airports", "LocalityTypeId", "Infrastructure.LocalityTypes");
            DropForeignKey("Infrastructure.Aircrafts", "AircraftTypeId", "Infrastructure.AircraftTypes");
            DropForeignKey("Infrastructure.AircraftRegisters", "AircraftId", "Infrastructure.Aircrafts");
            DropForeignKey("Infrastructure.AircraftRegisters", "LirRegisterGroupId", "Infrastructure.LirRegisterGroups");
            DropForeignKey("Infrastructure.AircraftRegisterNonAvailableSeats", "AircraftRegisterId", "Infrastructure.AircraftRegisters");
            DropForeignKey("Infrastructure.AircraftRegisterSeatInfos", "AircraftRegisterId", "Infrastructure.AircraftRegisters");
            DropForeignKey("Infrastructure.Airlines", "CountryId", "Infrastructure.Countries");
            DropForeignKey("Infrastructure.CityOffsetDsts", "CityId", "Infrastructure.Cities");
            DropForeignKey("Infrastructure.CityOffsetUtcs", "CityId", "Infrastructure.Cities");
            DropForeignKey("Infrastructure.IataCountryCodes", "CountryId", "Infrastructure.Countries");
            DropForeignKey("Infrastructure.RouteLegAirports", "ArrivalAirportId", "Infrastructure.Airports");
            DropForeignKey("Infrastructure.RouteLegAirports", "DepartureAirportId", "Infrastructure.Airports");
            DropIndex("Infrastructure.Airports", new[] { "CityId" });
            DropIndex("Infrastructure.Airports", new[] { "LocalityTypeId" });
            DropIndex("Infrastructure.Cities", new[] { "CountryId" });
            DropIndex("Infrastructure.Countries", new[] { "IataRegionCodeId" });
            DropIndex("Infrastructure.Countries", new[] { "CurrencyId" });
            DropIndex("Infrastructure.Countries", new[] { "ContinentId" });
            DropIndex("Infrastructure.Aircrafts", new[] { "AircraftTypeId" });
            DropIndex("Infrastructure.AircraftRegisters", new[] { "AircraftId" });
            DropIndex("Infrastructure.AircraftRegisters", new[] { "LirRegisterGroupId" });
            DropIndex("Infrastructure.AircraftRegisterNonAvailableSeats", new[] { "AircraftRegisterId" });
            DropIndex("Infrastructure.AircraftRegisterSeatInfos", new[] { "AircraftRegisterId" });
            DropIndex("Infrastructure.Airlines", new[] { "CountryId" });
            DropIndex("Infrastructure.CityOffsetDsts", new[] { "CityId" });
            DropIndex("Infrastructure.CityOffsetUtcs", new[] { "CityId" });
            DropIndex("Infrastructure.IataCountryCodes", new[] { "CountryId" });
            DropIndex("Infrastructure.RouteLegAirports", new[] { "ArrivalAirportId" });
            DropIndex("Infrastructure.RouteLegAirports", new[] { "DepartureAirportId" });
            DropTable("Infrastructure.Airports");
            DropTable("Infrastructure.Cities");
            DropTable("Infrastructure.Countries");
            DropTable("Infrastructure.Continents");
            DropTable("Infrastructure.Currencies");
            DropTable("Infrastructure.IataRegionCodes");
            DropTable("Infrastructure.LocalityTypes");
            DropTable("Infrastructure.Aircrafts");
            DropTable("Infrastructure.AircraftTypes");
            DropTable("Infrastructure.AircraftRegisters");
            DropTable("Infrastructure.LirRegisterGroups");
            DropTable("Infrastructure.AircraftRegisterNonAvailableSeats");
            DropTable("Infrastructure.AircraftRegisterSeatInfos");
            DropTable("Infrastructure.Airlines");
            DropTable("Infrastructure.CityOffsetDsts");
            DropTable("Infrastructure.CityOffsetUtcs");
            DropTable("Infrastructure.Companies");
            DropTable("Infrastructure.IataCountryCodes");
            DropTable("Infrastructure.People");
            DropTable("Infrastructure.RouteLegAirports");
            DropTable("Infrastructure.Units");
        }
        
        public override void Down()
        {
            CreateTable(
                "Infrastructure.Units",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.RouteLegAirports",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ArrivalAirportId = c.String(maxLength: 128),
                        DepartureAirportId = c.String(maxLength: 128),
                        Name = c.String(maxLength: 200),
                        Status = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.People",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 200),
                        LastName = c.String(maxLength: 200),
                        NationalCode = c.Double(),
                        IdentificationNumber = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.IataCountryCodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IataCode = c.String(maxLength: 2),
                        CountryId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Companies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CommercialCode = c.Double(),
                        Title = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.CityOffsetUtcs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CityId = c.String(maxLength: 128),
                        OffsetUtc = c.Long(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.CityOffsetDsts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CityId = c.String(maxLength: 128),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        OffsetDst = c.Long(),
                        ToDateUtc = c.DateTime(),
                        FromDateUtc = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Airlines",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                        CountryId = c.String(maxLength: 128),
                        IataCode = c.String(maxLength: 200),
                        IcaoCode = c.String(maxLength: 200),
                        Abv = c.String(maxLength: 200),
                        FullName = c.String(maxLength: 200),
                        ShortName = c.String(maxLength: 200),
                        Status = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.AircraftRegisterSeatInfos",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        SeatCountBusiness = c.Long(),
                        SeatCountEconomy = c.Long(),
                        AircraftRegisterId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.AircraftRegisterNonAvailableSeats",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        AircraftRegisterId = c.String(maxLength: 128),
                        SeatCountBusiness = c.Long(),
                        SeatCountBusinessPlus = c.Long(),
                        SeatCountEconomy = c.Long(),
                        SeatNumberBusiness = c.String(maxLength: 200),
                        SeatNumberBusinessPlus = c.String(maxLength: 200),
                        SeatNumberEconomy = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.LirRegisterGroups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.AircraftRegisters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Code = c.String(maxLength: 200),
                        AircraftId = c.String(maxLength: 128),
                        ShortRegisterCode = c.String(maxLength: 3),
                        HasFirstClassSeat = c.Boolean(),
                        Status = c.String(maxLength: 20),
                        LirRegisterGroupId = c.String(maxLength: 128),
                        Timestamp = c.DateTime(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.AircraftTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
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
                "Infrastructure.Aircrafts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SerialNo = c.String(maxLength: 200),
                        AircraftTypeId = c.String(maxLength: 128),
                        Register = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.LocalityTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                        Code = c.Long(),
                        NameEn = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.IataRegionCodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegionCode = c.String(maxLength: 200),
                        RegionName = c.String(maxLength: 200),
                        RegionNameEn = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Currencies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 50),
                        Symbol = c.String(maxLength: 20),
                        NameEn = c.String(maxLength: 50),
                        Code = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Continents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Code = c.String(maxLength: 200),
                        NameEn = c.String(maxLength: 200),
                        Name = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Countries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                        IsoAlpha3 = c.String(maxLength: 3),
                        IsoAlpha2 = c.String(maxLength: 2),
                        NameEn = c.String(maxLength: 200),
                        UnNumeric3 = c.String(maxLength: 3),
                        Fips104 = c.String(maxLength: 2),
                        IataRegionCodeId = c.String(maxLength: 128),
                        CurrencyId = c.String(maxLength: 128),
                        ContinentId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Cities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                        CountryId = c.String(maxLength: 128),
                        NameEn = c.String(maxLength: 200),
                        TimeZone = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Infrastructure.Airports",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 200),
                        IataAirportCode = c.String(maxLength: 3),
                        NameEn = c.String(maxLength: 200),
                        CityId = c.String(maxLength: 128),
                        Status = c.String(maxLength: 20),
                        LocalityTypeId = c.String(maxLength: 128),
                        NickName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("Infrastructure.RouteLegAirports", "DepartureAirportId");
            CreateIndex("Infrastructure.RouteLegAirports", "ArrivalAirportId");
            CreateIndex("Infrastructure.IataCountryCodes", "CountryId");
            CreateIndex("Infrastructure.CityOffsetUtcs", "CityId");
            CreateIndex("Infrastructure.CityOffsetDsts", "CityId");
            CreateIndex("Infrastructure.Airlines", "CountryId");
            CreateIndex("Infrastructure.AircraftRegisterSeatInfos", "AircraftRegisterId");
            CreateIndex("Infrastructure.AircraftRegisterNonAvailableSeats", "AircraftRegisterId");
            CreateIndex("Infrastructure.AircraftRegisters", "LirRegisterGroupId");
            CreateIndex("Infrastructure.AircraftRegisters", "AircraftId");
            CreateIndex("Infrastructure.Aircrafts", "AircraftTypeId");
            CreateIndex("Infrastructure.Countries", "ContinentId");
            CreateIndex("Infrastructure.Countries", "CurrencyId");
            CreateIndex("Infrastructure.Countries", "IataRegionCodeId");
            CreateIndex("Infrastructure.Cities", "CountryId");
            CreateIndex("Infrastructure.Airports", "LocalityTypeId");
            CreateIndex("Infrastructure.Airports", "CityId");
            AddForeignKey("Infrastructure.RouteLegAirports", "DepartureAirportId", "Infrastructure.Airports", "Id");
            AddForeignKey("Infrastructure.RouteLegAirports", "ArrivalAirportId", "Infrastructure.Airports", "Id");
            AddForeignKey("Infrastructure.IataCountryCodes", "CountryId", "Infrastructure.Countries", "Id");
            AddForeignKey("Infrastructure.CityOffsetUtcs", "CityId", "Infrastructure.Cities", "Id");
            AddForeignKey("Infrastructure.CityOffsetDsts", "CityId", "Infrastructure.Cities", "Id");
            AddForeignKey("Infrastructure.Airlines", "CountryId", "Infrastructure.Countries", "Id");
            AddForeignKey("Infrastructure.AircraftRegisterSeatInfos", "AircraftRegisterId", "Infrastructure.AircraftRegisters", "Id");
            AddForeignKey("Infrastructure.AircraftRegisterNonAvailableSeats", "AircraftRegisterId", "Infrastructure.AircraftRegisters", "Id");
            AddForeignKey("Infrastructure.AircraftRegisters", "LirRegisterGroupId", "Infrastructure.LirRegisterGroups", "Id");
            AddForeignKey("Infrastructure.AircraftRegisters", "AircraftId", "Infrastructure.Aircrafts", "Id");
            AddForeignKey("Infrastructure.Aircrafts", "AircraftTypeId", "Infrastructure.AircraftTypes", "Id");
            AddForeignKey("Infrastructure.Airports", "LocalityTypeId", "Infrastructure.LocalityTypes", "Id");
            AddForeignKey("Infrastructure.Airports", "CityId", "Infrastructure.Cities", "Id");
            AddForeignKey("Infrastructure.Cities", "CountryId", "Infrastructure.Countries", "Id");
            AddForeignKey("Infrastructure.Countries", "IataRegionCodeId", "Infrastructure.IataRegionCodes", "Id");
            AddForeignKey("Infrastructure.Countries", "CurrencyId", "Infrastructure.Currencies", "Id");
            AddForeignKey("Infrastructure.Countries", "ContinentId", "Infrastructure.Continents", "Id");
        }
    }
}
