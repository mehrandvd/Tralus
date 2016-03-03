using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightEvent", Schema = "Stations")]
    [DefaultProperty("EventDateTime")]
    public class FlightEvent : EntityBase
    {
        public FlightEvent()
        {
            EventDateTime = new TralusDateTime();
        }

        public virtual FlightEventType FlightEventType { get; set; }
        public Guid?  FlightEventTypeId { get; set; }
        
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid?  FlightLegId { get; set; }
        
        public TralusDateTime EventDateTime { get; set; }
    }
}
