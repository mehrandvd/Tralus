namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FlightAppsDbContext : DbContext
    {
        public FlightAppsDbContext()
            : base("name=FlightAppsDb")
        {
        }

        public virtual DbSet<C_GI_Aircraft> C_GI_Aircraft { get; set; }
        public virtual DbSet<FLT_DelayCode> FLT_DelayCode { get; set; }
        public virtual DbSet<FLT_FlightNumber> FLT_FlightNumber { get; set; }
        public virtual DbSet<FLT_LOOKUP_FlightType> FLT_LOOKUP_FlightType { get; set; }
        public virtual DbSet<FLT_Route_FlightLeg> FLT_Route_FlightLeg { get; set; }
        public virtual DbSet<FX_TBENT_FlightLeg> FX_TBENT_FlightLeg { get; set; }
        public virtual DbSet<FX_TBEXT_FlightLeg> FX_TBEXT_FlightLeg { get; set; }
        public virtual DbSet<GI_Aircraft> GI_Aircraft { get; set; }
        public virtual DbSet<GI_AircraftRegister> GI_AircraftRegister { get; set; }
        public virtual DbSet<GI_AircraftRegister_NonAvailableSeat> GI_AircraftRegister_NonAvailableSeat { get; set; }
        public virtual DbSet<GI_AircraftRegister_SeatInfo> GI_AircraftRegister_SeatInfo { get; set; }
        public virtual DbSet<GI_AircraftType> GI_AircraftType { get; set; }
        public virtual DbSet<GI_Airline> GI_Airline { get; set; }
        public virtual DbSet<GI_Airport> GI_Airport { get; set; }
        public virtual DbSet<GI_City> GI_City { get; set; }
        public virtual DbSet<GI_LOOKUP_LocalityType> GI_LOOKUP_LocalityType { get; set; }
        public virtual DbSet<GI_Route_Leg_Airports> GI_Route_Leg_Airports { get; set; }
        public virtual DbSet<STA_AirportAirlineStation> STA_AirportAirlineStation { get; set; }
        public virtual DbSet<VW_OperationsMaster> VW_OperationsMaster { get; set; }
        public virtual DbSet<GI_Country> GI_Country { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
