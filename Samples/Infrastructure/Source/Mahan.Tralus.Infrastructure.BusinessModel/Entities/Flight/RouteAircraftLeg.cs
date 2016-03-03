using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("RouteAircraftLeg", Schema = "Infrastructure")]
    [DefaultProperty("LegNo")]
    public class RouteAircraftLeg : EntityBase
    {
        public virtual RouteAircraft RouteAircraft { get; set; }
        public Guid? RouteAircraftId { get; set; }

        public virtual Leg Leg { get; set; }
        public Guid? LegId { get; set; }
        
        public long? LegNo { get; set; }
    }
}
