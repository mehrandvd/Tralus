using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Utility;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("AircraftRegisterSeatInfo", Schema = "Infrastructure")]
    [DefaultProperty("AircraftRegister")]
    public class AircraftRegisterSeatInfo : EntityBase
    {
        public AircraftRegisterSeatInfo()
        {
            StartDate = new TralusDate();
            EndDate = new TralusDate();
        }

        public TralusDate StartDate { get; set; }
        
        public TralusDate EndDate { get; set; }
        
        public long? SeatCountBusiness { get; set; }
        
        public long? SeatCountEconomy { get; set; }
        
        public virtual AircraftRegister AircraftRegister { get; set; }
        public Guid? AircraftRegisterId { get; set; }
    }
}
