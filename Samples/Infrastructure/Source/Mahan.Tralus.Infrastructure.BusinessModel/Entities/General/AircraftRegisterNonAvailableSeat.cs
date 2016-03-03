using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Utility;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("AircraftRegisterNonAvailableSeat", Schema = "Infrastructure")]
    [DefaultProperty("AircraftRegister")]
    public class AircraftRegisterNonAvailableSeat : EntityBase
    {
        public TralusDate StartDate { get; set; }

        public TralusDate EndDate { get; set; }
        
        public virtual AircraftRegister AircraftRegister { get; set; }
        public Guid? AircraftRegisterId { get; set; }
        
        public long? SeatCountBusiness { get; set; }
        
        public long? SeatCountBusinessPlus { get; set; }
        
        public long? SeatCountEconomy { get; set; }
        
        [StringLength(200)]
        public string SeatNumberBusiness { get; set; }
        
        [StringLength(200)]
        public string SeatNumberBusinessPlus { get; set; }
        [StringLength(200)]
        
        public string SeatNumberEconomy { get; set; }
    }
}
