namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_GI_Aircraft")]
    public partial class C_GI_Aircraft
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_AircraftType { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string Register { get; set; }

        [StringLength(200)]
        public string SerialNo { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }
    }
}
