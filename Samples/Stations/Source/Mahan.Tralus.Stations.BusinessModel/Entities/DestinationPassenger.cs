using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;
using Mahan.Infrastructure.BusinessModel;

namespace Mahan.Stations.BusinessModel
{
    [Table("DestinationPassenger", Schema = "Stations")]
    [DefaultProperty("PassengerCount")]
    public class DestinationPassenger : EntityBase
    {
        public DestinationPassenger()
        {

        }

        public DestinationPassenger(bool initialize)
            : base(initialize)
        {

        }
        public virtual DestinationProfile DestinationProfile { get; set; }
        public Guid DestinationProfileId { get; set; }

        public virtual SeatClass SeatClass { get; set; }
        public Guid SeatClassId { get; set; }

        public virtual PassengerType PassengerType { get; set; }
        public Guid PassengerTypeId { get; set; }

        public virtual TicketType TicketType { get; set; }
        public Guid TicketTypeId { get; set; }

        public long? PassengerCount { get; set; }
    }
}
