using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    public partial class GI_Airport
    {
        [ForeignKey("ID_GI_City")]
        public GI_City City { get; set; }

        [ForeignKey("ID_GI_LOOKUP_LocalityType")]
        public GI_LOOKUP_LocalityType LocalityType { get; set; }
    }

    public partial class GI_AircraftRegister
    {
        [ForeignKey("ID_GI_Aircraft")]
        public GI_Aircraft Aircraft { get; set; }
    }

    public partial class FLT_FlightNumber
    {
        [ForeignKey("ID_GI_Airline")]
        public GI_Airline Airline { get; set; }
    }

    public partial class GI_Route_Leg_Airports
    {
        [ForeignKey("ID_GI_Airport_DEPARTURE")]
        public GI_Airport DepartureAirport { get; set; }

        [ForeignKey("ID_GI_Airport_ARRIVAL")]
        public GI_Airport ArrivalAirport { get; set; }
    }

    public partial class VW_OperationsMaster
    {
        [ForeignKey("ID_GI_AirLine")]
        public virtual GI_Airline GI_Airline { get; set; }

        [ForeignKey("ID_FLT_FlightNumber")]
        public virtual FLT_FlightNumber FLT_FlightNumber { get; set; }

        [ForeignKey("ID_FLT_LOOKUP_FlightType")]
        public virtual FLT_LOOKUP_FlightType FLT_FlightType { get; set; }

        [ForeignKey("ID_GI_AircraftRegister")]
        public virtual GI_AircraftRegister GI_AircraftRegister { get; set; }

        [ForeignKey("ID_FLT_Route_FlightLeg")]
        public virtual FLT_Route_FlightLeg FLT_Route_FlightLeg { get; set; }

        [ForeignKey("ID_GI_AircraftType")]
        public virtual GI_AircraftType GI_AircraftType { get; set; }

        [ForeignKey("ID_GI_Airport_ARRIVAL")]
        public virtual GI_Airport GI_Airport_ARRIVAL { get; set; }

        [ForeignKey("ID_GI_Airport_DEPARTURE")]
        public virtual GI_Airport GI_Airport_DEPARTURE { get; set; }

        [ForeignKey("ID_GI_City_DEPARTURE")]
        public virtual GI_City GI_City_DEPARTURE { get; set; }

        [ForeignKey("ID_GI_City_ARRIVAL")]
        public virtual GI_City GI_City_ARRIVAL { get; set; }
    }
}
