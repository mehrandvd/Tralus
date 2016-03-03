namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_Airline
    {
        [StringLength(200)]
        public string Abv { get; set; }

        [StringLength(200)]
        public string IATACode { get; set; }

        [StringLength(200)]
        public string ICAOCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Country { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Name_Full { get; set; }

        [StringLength(200)]
        public string Name_Short { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public DateTime? Timestamp { get; set; }

        [ForeignKey("ID_GI_Country")]
        public GI_Country Country { get; set; }
    }
}
