using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightFuelling", Schema = "Stations")]
    [DefaultProperty("Amount")]
    public class FlightFuelling : EntityBase
    {
        public virtual FuellingType FuellingType { get; set; }
        public Guid?  FuellingTypeId { get; set; }

        [ForeignKey("FlightLegId")]
        public virtual FlightReportView FlightReportView { get; set; }

        [Required]
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid? FlightLegId { get; set; }

        public long? Amount { get; set; }

       
       

    }
}