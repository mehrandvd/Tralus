using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
{
    [Table("DestinationSpecialService", Schema = "Stations")]
    [DefaultProperty("SpecialServiceCount")]
    public class DestinationSpecialService : EntityBase
    {
        public DestinationSpecialService()
        {

        }

        public DestinationSpecialService(bool initialize)
            : base(initialize)
        {

        }
        public virtual DestinationProfile DestinationProfile { get; set; }
        public Guid DestinationProfileId { get; set; }

        public virtual SpecialServiceType SpecialServiceType { get; set; }
        public Guid SpecialServiceTypeId { get; set; }

        public long? SpecialServiceCount { get; set; }
    }
}
