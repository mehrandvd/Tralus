namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLT_FlightNumber
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Airline { get; set; }

        [StringLength(200)]
        public string FlightNumber_AbvNumber { get; set; }

        [StringLength(200)]
        public string FlightNumber_AirlineAbvNumber { get; set; }

        public long? mod1_FlightNumber_Number { get; set; }

        public double? mod1_FlightNumber_Numeric { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        [StringLength(200)]
        public string FlightNumber_Number { get; set; }

        public long? FlightNumber_Numeric { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public DateTime? Timestamp { get; set; }
    }
}
