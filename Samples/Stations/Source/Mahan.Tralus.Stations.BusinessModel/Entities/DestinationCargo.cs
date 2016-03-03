using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;
using Mahan.Infrastructure.BusinessModel;

namespace Mahan.Stations.BusinessModel
{
    [Table("DestinationCargo", Schema = "Stations")]
    [DefaultProperty("CargoType")]
    public class DestinationCargo : EntityBase
    {
        public DestinationCargo()
        {

        }

        public DestinationCargo(bool initialize)
            : base(initialize)
        {

        }

        public virtual DestinationProfile DestinationProfile { get; set; }
        public Guid DestinationProfileId { get; set; }

        public virtual CargoType CargoType { get; set; }
        public Guid CargoTypeId { get; set; }

        public long? CargoPieces { get; set; }

        public long? CargoWeight { get; set; }
    }
}
