namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLT_DelayCode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(200)]
        public string mod1_Code { get; set; }

        public long? ID_FLT_DelayType { get; set; }

        public string Description { get; set; }

        [StringLength(200)]
        public string mod2_Code { get; set; }

        public string Description_EN { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public bool? IsEnabled { get; set; }
    }
}
