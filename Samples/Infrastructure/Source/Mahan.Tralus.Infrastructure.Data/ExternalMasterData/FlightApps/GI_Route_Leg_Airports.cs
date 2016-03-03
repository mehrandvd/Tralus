namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_Route_Leg_Airports
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_GI_Airport_ARRIVAL { get; set; }

        public long? ID_GI_Airport_DEPARTURE { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string mod1_Tag { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(7)]
        public string Tag { get; set; }

        public DateTime? Timestamp { get; set; }
    }
}
