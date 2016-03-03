using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("Leg", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Leg : EntityBase
    {
        public virtual Airport ArrivalAirport { get; set; }
        public Guid? ArrivalAirportId { get; set; }
        
        public virtual Airport DepartureAirport { get; set; }
        public Guid? DepartureAirportId { get; set; }
        
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(20)]
        public string Status { get; set; }

        public virtual LocalityType LocalityType { get; set; }
        public Guid? LocalityTypeId { get; set; }
    }
}
