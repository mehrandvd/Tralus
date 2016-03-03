namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string mod1_ISOAlpha2 { get; set; }

        [StringLength(3)]
        public string ISOAlpha3 { get; set; }

        [StringLength(2)]
        public string ISOAlpha2 { get; set; }

        [StringLength(200)]
        public string Name_EN { get; set; }

        [StringLength(3)]
        public string UNNumeric3 { get; set; }

        [StringLength(2)]
        public string FIPS10_4 { get; set; }

        public long? ID_GI_IATARegionCode { get; set; }

        public long? ID_GI_Currency { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public long? ID_GI_Continent { get; set; }
    }
}
