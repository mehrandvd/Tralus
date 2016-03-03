namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLT_OperationsMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_AirLine { get; set; }

        public long? ID_FLT_FlightNumber { get; set; }

        public long? ID_FLT_LOOKUP_FlightType { get; set; }

        [StringLength(200)]
        public string Status { get; set; }

        public DateTime? Scheduled_DepartureDate_Local { get; set; }

        public DateTime? Scheduled_DepartureDate_UTC { get; set; }

        public DateTime? Scheduled_DepartureTime_Local { get; set; }

        public DateTime? Scheduled_DepartureTime_UTC { get; set; }

        [StringLength(30)]
        public string STD_UTC_OrderByString { get; set; }

        public long? ID_GI_AircraftRegister { get; set; }

        public long? ID_FLT_Route_FlightLeg { get; set; }

        public DateTime? Timestamp { get; set; }

        public long? ID_GI_AircraftType { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        public long? ID_STA_AirlineStation { get; set; }

        public long? ID_GI_Airport_ARRIVAL { get; set; }

        public long? ID_GI_Airport_DEPARTURE { get; set; }

        public long? LegNumber { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        public long? ID_GI_AircraftRegister_FW { get; set; }

        public long? ID_FX_TBENT_FlightLeg { get; set; }

        [StringLength(80)]
        public string CALC_DepartureTime { get; set; }

        public DateTime? Scheduled_DepartureDate_Local_P { get; set; }

        public DateTime? Scheduled_DepartureDatetime_UTC { get; set; }

        public DateTime? Scheduled_DepartureDatetime_Local { get; set; }

        [StringLength(3)]
        public string TAG_ArrivalAirport { get; set; }

        [StringLength(3)]
        public string TAG_DepartureAirport { get; set; }

        [StringLength(10)]
        public string TAG_Register { get; set; }

        [StringLength(40)]
        public string TAG_AircraftType { get; set; }

        public long? ID_GI_City_DEPARTURE { get; set; }

        public long? ID_GI_City_ARRIVAL { get; set; }

        public DateTime? SCHEDULED_DepartureDATETIME_TEHRAN { get; set; }

        public DateTime? ACTUAL_DepartureDATETIME_TEHRAN { get; set; }

        public DateTime? ACTUAL_DepartureDATETIME_UTC { get; set; }

        public DateTime? ACTUAL_ArrivalDATETIME_UTC { get; set; }

        [StringLength(10)]
        public string AircraftRegister { get; set; }

        [StringLength(50)]
        public string FlightNumber { get; set; }

        public DateTime? Takeoff_Datetime { get; set; }

        public long? FR_Status { get; set; }

        [StringLength(200)]
        public string FlightType { get; set; }
    }
}
