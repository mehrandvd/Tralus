namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_AircraftType
    {
        [StringLength(200)]
        public string FullTypeName { get; set; }

        [StringLength(3)]
        public string FW_Name { get; set; }

        [StringLength(3)]
        public string IATACode { get; set; }

        [StringLength(4)]
        public string ICAOCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string Manufacturer { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public DateTime? Timestamp { get; set; }

        [StringLength(200)]
        public string TypeVariation { get; set; }
    }
}
