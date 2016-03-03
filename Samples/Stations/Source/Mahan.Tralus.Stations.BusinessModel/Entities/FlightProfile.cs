using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightSummary", Schema = "Stations")]
    [DefaultProperty("FlightLeg")]
    public class FlightSummary : EntityBase
    {
        public DateTime? TotalDelay { get; set; }

        public int? TotalLoadPieces { get; set; }

        public int? TotalLoadWeight { get; set; }

        public int? TotalPassengers { get; set; }

        public int? TotalSpecialServiceCount { get; set; }

        public long? TotalFuel { get; set; }

        [NotMapped]
        public string WorkFlowStatusDescroption { get; set; }

        public virtual FlightLeg FlightLeg { get; set; }
        public Guid?  FlightLegId { get; set; }
    }
}
