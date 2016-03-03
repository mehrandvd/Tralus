using System;
using System.Data.Common;
using System.Data.Entity;
using Mahan.Tralus.Framework.Data;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace  Mahan.Tralus.Infrastructure.Data {
    public class InfrastructureDbContext : DbContextBase<InfrastructureDbContext>
	{
		public InfrastructureDbContext(String connectionString): base(connectionString) 
        {
		}
		
        public InfrastructureDbContext(DbConnection connection): base(connection, false) 
        {
		}

        public InfrastructureDbContext()
        {
        }

        //public virtual DbSet<Aircraft> Aircrafts { get; set; }
        //public virtual DbSet<AircraftRegister> AircraftRegisters { get; set; }
        //public virtual DbSet<AircraftRegisterNonAvailableSeat> AircraftRegisterNonAvailableSeats { get; set; }
        //public virtual DbSet<AircraftRegisterSeatInfo> AircraftRegisterSeatInfos { get; set; }
        //public virtual DbSet<AircraftType> AircraftTypes { get; set; }
        //public virtual DbSet<Airline> GI_Airline { get; set; }
        //public virtual DbSet<Airport> GI_Airport { get; set; }
        //public virtual DbSet<City> GI_City { get; set; }
        //public virtual DbSet<CityOffsetDst> GI_City_OffsetDST { get; set; }
        //public virtual DbSet<CityOffsetUtc> GI_City_OffsetUTC { get; set; }
        //public virtual DbSet<Company> GI_Company { get; set; }
        //public virtual DbSet<Continent> GI_Continent { get; set; }
        //public virtual DbSet<Country> GI_Country { get; set; }
        //public virtual DbSet<Currency> GI_Currency { get; set; }
        //public virtual DbSet<IataCountryCode> GI_IATA_CountryCode { get; set; }
        //public virtual DbSet<IataRegionCode> GI_IATA_RegionCode { get; set; }
        //public virtual DbSet<LirRegisterGroup> GI_LIRRegisterGroup { get; set; }
        //public virtual DbSet<LocalityType> GI_LOOKUP_LocalityType { get; set; }
        //public virtual DbSet<Person> GI_Person { get; set; }
        //public virtual DbSet<RouteLegAirports> GI_Route_Leg_Airports { get; set; }
        //public virtual DbSet<Unit> GI_Unit { get; set; }
	}
}