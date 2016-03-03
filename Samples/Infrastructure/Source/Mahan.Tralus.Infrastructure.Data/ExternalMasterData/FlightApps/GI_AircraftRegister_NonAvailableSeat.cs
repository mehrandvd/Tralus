namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_AircraftRegister_NonAvailableSeat
    {
        public DateTime? EndDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_AircraftRegister { get; set; }

        public long? SeatCount_Business { get; set; }

        public long? SeatCount_BusinessPlus { get; set; }

        public long? SeatCount_Economy { get; set; }

        [StringLength(200)]
        public string SeatNumber_Business { get; set; }

        [StringLength(200)]
        public string SeatNumber_BusinessPlus { get; set; }

        [StringLength(200)]
        public string SeatNumber_Economy { get; set; }

        public DateTime? StartDate { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }
    }
}
