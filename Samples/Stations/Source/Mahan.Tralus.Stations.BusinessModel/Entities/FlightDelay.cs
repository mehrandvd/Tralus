using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightDelay", Schema = "Stations")]
    [DefaultProperty("Duration")]
    public class FlightDelay : EntityBase
    {
        public virtual DelayCode DelayCode { get; set; }
        public Guid?  DelayCodeId { get; set; }

        [ForeignKey("FlightLegId")]
        public virtual FlightReportView FlightReportView { get; set; }
        
        [Required]
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid?  FlightLegId { get; set; }

        public long? Duration { get; set; }
        
        [StringLength(200)]
        public string RemarkDelay { get; set; }
        
       public string OverllDelayRemarks { get; set; }
    }
}
