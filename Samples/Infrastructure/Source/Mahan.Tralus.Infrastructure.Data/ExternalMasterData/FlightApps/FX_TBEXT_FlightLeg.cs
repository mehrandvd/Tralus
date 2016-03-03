namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FX_TBEXT_FlightLeg
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public DateTime? Departure_SCHEDULED_DATE_UTC { get; set; }

        public DateTime? Departure_SCHEDULED_TIME_UTC { get; set; }

        public DateTime? Departure_SCHEDULED_DATETIME_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_DATE_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_DATETIME_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_TIME_UTC { get; set; }

        public DateTime? Departure_ACTUAL_DATE_UTC { get; set; }

        public DateTime? Departure_ACTUAL_TIME_UTC { get; set; }

        public DateTime? Departure_ACTUAL_DATETIME_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_DATE_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_TIME_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_DATETIME_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_DATE_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_TIME_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_DATETIME_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_DATE_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_TIME_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_DATETIME_UTC { get; set; }

        public DateTime? Takeoff_DATE_UTC { get; set; }

        public DateTime? Takeoff_TIME_UTC { get; set; }

        public DateTime? Takeoff_DATETIME_UTC { get; set; }

        public DateTime? Touchdown_DATE_UTC { get; set; }

        public DateTime? Touchdown_TIME_UTC { get; set; }

        public DateTime? Touchdown_DATETIME_UTC { get; set; }

        [StringLength(19)]
        public string FW_Touchdown_DATETIME_UTC { get; set; }

        [StringLength(3)]
        public string FW_Status { get; set; }

        public long? FW_LegNumber { get; set; }

        [StringLength(9)]
        public string FW_AC { get; set; }

        [StringLength(2000)]
        public string FW_SI_Text { get; set; }

        [StringLength(7)]
        public string FW_Version { get; set; }

        [StringLength(3)]
        public string FW_Delay_Type_02 { get; set; }

        public long? FW_Delay_Duration_02 { get; set; }

        [StringLength(3)]
        public string FW_Departure_Station { get; set; }

        [StringLength(19)]
        public string FW_Arrival_SCHEDULED_DATETIME_UTC { get; set; }

        [StringLength(5)]
        public string FW_Gate { get; set; }

        [StringLength(3)]
        public string FW_ACOwn { get; set; }

        [StringLength(3)]
        public string FW_ACTyp { get; set; }

        [StringLength(8)]
        public string FW_FlightNumber { get; set; }

        [StringLength(2)]
        public string FW_DIV_RCODE { get; set; }

        [StringLength(10)]
        public string FW_Departure_DATE_UTC { get; set; }

        [StringLength(3)]
        public string FW_Orig_ACTyp { get; set; }

        [StringLength(1)]
        public string FW_DIV_FLAG { get; set; }

        public long? FW_Delay_Duration_03 { get; set; }

        [StringLength(19)]
        public string FW_Arrival_ESTIMATED_DATETIME_UTC { get; set; }

        public long? FW_Delay_Duration_01 { get; set; }

        [StringLength(1)]
        public string FW_STC { get; set; }

        [StringLength(19)]
        public string FW_Departure_SCHEDULED_DATETIME_UTC { get; set; }

        [StringLength(19)]
        public string FW_Takeoff_DATETIME_UTC { get; set; }

        public long? FW_Delay_Duration_04 { get; set; }

        [StringLength(3)]
        public string FW_Delay_Type_03 { get; set; }

        [StringLength(3)]
        public string FW_Arrival_Station { get; set; }

        [StringLength(19)]
        public string FW_Arrival_ACTUAL_DATETIME_UTC { get; set; }

        [StringLength(19)]
        public string FW_TStamp { get; set; }

        [StringLength(12)]
        public string FW_Pax_Counts { get; set; }

        [StringLength(3)]
        public string FW_Delay_Type_04 { get; set; }

        [StringLength(8)]
        public string FW_TRI_FLTID { get; set; }

        [StringLength(19)]
        public string FW_Departure_ACTUAL_DATETIME_UTC { get; set; }

        [StringLength(255)]
        public string FW_FLT_Notes { get; set; }

        [StringLength(3)]
        public string FW_Delay_Type_01 { get; set; }

        [StringLength(12)]
        public string FW_Book { get; set; }

        public DateTime? Timestamp { get; set; }

        public long? ID_FX_TBRAW_FW_Legs { get; set; }

        public long? ID_FLT_FlightNumber { get; set; }

        public long? ID_FLT_Route_FlightLeg_SCHEDULED { get; set; }

        public long? ID_FLT_Route_FlightLeg_ACTUAL { get; set; }

        public long? ID_FLT_LOOKUP_FlightType { get; set; }

        public long? ID_GI_AircraftRegister { get; set; }

        public long? ID_GI_AircraftType_ACTUAL { get; set; }

        public long? ID_GI_AircraftType_SCHEDULED { get; set; }

        public bool? ForceDuplicate { get; set; }

        public long? ID_GI_Airline { get; set; }

        [StringLength(19)]
        public string FW_Departure_ESTIMATED_DATETIME_UTC { get; set; }

        public long? ID_FX_TBEXT_FlightLeg_PreviousLegOfAircraft { get; set; }
    }
}
