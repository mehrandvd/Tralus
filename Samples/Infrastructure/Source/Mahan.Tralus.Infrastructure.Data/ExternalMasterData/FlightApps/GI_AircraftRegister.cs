namespace Mahan.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_AircraftRegister
    {
        [StringLength(200)]
        public string CALC_AircraftType { get; set; }

        [StringLength(200)]
        public string Code { get; set; }

        public bool? HasFirstClassSeat { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Aircraft { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_GI_LIRRegisterGroup { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(3)]
        public string Short_Register_Code { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Tag { get; set; }

        public DateTime? Timestamp { get; set; }
    }

    
}
