namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STA_AirportAirlineStation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_STA_AirlineStation { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_GI_Airport { get; set; }

        [StringLength(200)]
        public string Email { get; set; }
    }
}
