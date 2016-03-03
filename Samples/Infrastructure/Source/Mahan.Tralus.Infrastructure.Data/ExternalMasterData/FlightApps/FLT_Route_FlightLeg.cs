namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLT_Route_FlightLeg
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(200)]
        public string mod1_LegNo { get; set; }

        public long? ID_GI_Route_Leg_Airports { get; set; }

        public long? ID_FLT_Route_Flight { get; set; }

        public long? LegNo { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public long? ID_GI_LOOKUP_LocalityType { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public DateTime? Timestamp { get; set; }
    }
}
