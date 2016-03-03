namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FX_TBENT_FlightLeg
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public DateTime? Departure_SCHEDULED_DATE_LOCAL { get; set; }

        public DateTime? Departure_SCHEDULED_DATE_UTC { get; set; }

        public DateTime? Departure_SCHEDULED_TIME_LOCAL { get; set; }

        public DateTime? Departure_SCHEDULED_TIME_UTC { get; set; }

        public DateTime? Departure_SCHEDULED_DATETIME_LOCAL { get; set; }

        public DateTime? Departure_SCHEDULED_DATETIME_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_DATE_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_DATE_LOCAL { get; set; }

        public DateTime? Departure_ESTIMATED_DATETIME_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_TIME_LOCAL { get; set; }

        public DateTime? Departure_ESTIMATED_TIME_UTC { get; set; }

        public DateTime? Departure_ESTIMATED_DATETIME_LOCAL { get; set; }

        public DateTime? Departure_ACTUAL_DATE_LOCAL { get; set; }

        public DateTime? Departure_ACTUAL_DATE_UTC { get; set; }

        public DateTime? Departure_ACTUAL_TIME_LOCAL { get; set; }

        public DateTime? Departure_ACTUAL_TIME_UTC { get; set; }

        public DateTime? Departure_ACTUAL_DATETIME_LOCAL { get; set; }

        public DateTime? Departure_ACTUAL_DATETIME_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_DATE_LOCAL { get; set; }

        public DateTime? Arrival_SCHEDULED_DATE_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_TIME_LOCAL { get; set; }

        public DateTime? Arrival_SCHEDULED_TIME_UTC { get; set; }

        public DateTime? Arrival_SCHEDULED_DATETIME_LOCAL { get; set; }

        public DateTime? Arrival_SCHEDULED_DATETIME_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_DATE_LOCAL { get; set; }

        public DateTime? Arrival_ACTUAL_DATE_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_TIME_LOCAL { get; set; }

        public DateTime? Arrival_ACTUAL_TIME_UTC { get; set; }

        public DateTime? Arrival_ACTUAL_DATETIME_LOCAL { get; set; }

        public DateTime? Arrival_ACTUAL_DATETIME_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_DATE_LOCAL { get; set; }

        public DateTime? Arrival_ESTIMATED_DATE_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_TIME_LOCAL { get; set; }

        public DateTime? Arrival_ESTIMATED_TIME_UTC { get; set; }

        public DateTime? Arrival_ESTIMATED_DATETIME_LOCAL { get; set; }

        public DateTime? Arrival_ESTIMATED_DATETIME_UTC { get; set; }

        public DateTime? Takeoff_DATE_LOCAL { get; set; }

        public DateTime? Takeoff_DATE_UTC { get; set; }

        public DateTime? Takeoff_TIME_LOCAL { get; set; }

        public DateTime? Takeoff_TIME_UTC { get; set; }

        public DateTime? Takeoff_DATETIME_LOCAL { get; set; }

        public DateTime? Takeoff_DATETIME_UTC { get; set; }

        public DateTime? Touchdown_DATE_LOCAL { get; set; }

        public DateTime? Touchdown_DATE_UTC { get; set; }

        public DateTime? Touchdown_TIME_LOCAL { get; set; }

        public DateTime? Touchdown_TIME_UTC { get; set; }

        public DateTime? Touchdown_DATETIME_LOCAL { get; set; }

        public DateTime? Touchdown_DATETIME_UTC { get; set; }

        public DateTime? Timestamp { get; set; }

        public long? ID_FLT_FlightNumber { get; set; }

        public long? ID_FLT_Route_FlightLeg_SCHEDULED { get; set; }

        public long? ID_FLT_Route_FlightLeg_ACTUAL { get; set; }

        public long? ID_FLT_LOOKUP_FlightType { get; set; }

        public long? ID_GI_AircraftRegister { get; set; }

        public long? ID_GI_AircraftType_ACTUAL { get; set; }

        public long? ID_GI_AircraftType_SCHEDULED { get; set; }

        public long? ID_FX_TBEXT_FlightLeg { get; set; }

        public long? ID_GI_City_DEPARTURE { get; set; }

        public long? ID_GI_City_ARRIVAL { get; set; }

        public int? FlightDurationInMillisecond_SCHEDULED { get; set; }

        public int? FlightDurationInMillisecond_ESTIMATED { get; set; }

        public int? FlightDurationInMillisecond_ACTUAL { get; set; }

        public bool? ForceDuplicate { get; set; }

        public long? ID_GI_Airline { get; set; }

        public int? FlightDurationInSecond_SCHEDULED { get; set; }

        public int? FlightDurationInSecond_ESTIMATED { get; set; }

        public int? FlightDurationInSecond_ACTUAL { get; set; }
    }
}
