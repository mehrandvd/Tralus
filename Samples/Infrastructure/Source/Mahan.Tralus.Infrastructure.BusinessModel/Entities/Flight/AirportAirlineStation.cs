using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("AirportAirlineStation", Schema = "Infrastructure")]
    [DefaultProperty("AirlineStation")]
    public class AirportAirlineStation : EntityBase
    {
        public virtual AirlineStation AirlineStation { get; set; }
        public Guid? AirlineStationId { get; set; }
        
        public virtual Airport Airport { get; set; }
        public Guid? AirportId { get; set; }
        
        [StringLength(200)]
        public string Email { get; set; }
    }
}