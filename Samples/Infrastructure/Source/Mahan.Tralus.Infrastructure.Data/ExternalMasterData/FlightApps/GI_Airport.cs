namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_Airport
    {
        [StringLength(3)]
        public string IATA_AirportCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_City { get; set; }

        public long? ID_GI_LOOKUP_LocalityType { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Name_EN { get; set; }

        [StringLength(200)]
        public string NickName { get; set; }

        public long? NoDB_ID_GI_Country { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public DateTime? Timestamp { get; set; }

        
    }
}
