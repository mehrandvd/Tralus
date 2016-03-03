using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Utility;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("FlightLeg", Schema = "Infrastructure")]
    [DefaultProperty("FlightNumber")]
    public class FlightLeg : EntityBase
    {
        public FlightLeg()
        {
            ScheduledDepartureDateTime = new TralusDateTime();
            EstimatedDepartureDateTime = new TralusDateTime();
            ActualDepartureDateTime = new TralusDateTime();
            EstimatedArrivalDateTime = new TralusDateTime();
            ActualArrivalDateTime = new TralusDateTime();
            TakeOffDateTime = new TralusDateTime();
        }

        public virtual FlightNumber FlightNumber { get; set; }
        public Guid? FlightNumberId { get; set; }

        public virtual FlightType FlightType { get; set; }
        public Guid? FlightTypeId { get; set; }

        [StringLength(200)]
        public string Status { get; set; }

        public TralusDateTime ScheduledDepartureDateTime { get; set; }
        public TralusDateTime EstimatedDepartureDateTime { get; set; }
        public TralusDateTime ActualDepartureDateTime { get; set; }
        public TralusDateTime EstimatedArrivalDateTime { get; set; }
        public TralusDateTime ActualArrivalDateTime { get; set; }
        public TralusDateTime TakeOffDateTime { get; set; }

        public virtual AircraftRegister AircraftRegister { get; set; }
        public Guid? AircraftRegisterId { get; set; }

        public virtual Leg Leg { get; set; }
        public Guid? LegId { get; set; }

        public virtual AircraftType ScheduledAircraftType { get; set; }
        public Guid? ScheduledAircraftTypeId { get; set; }

        public virtual Airport ArrivalAirport { get; set; }
        public Guid? ArrivalAirportId { get; set; }

        public virtual Airport DepartureAirport { get; set; }
        public Guid? DepartureAirportId { get; set; }

        public long? RepetitionReasonCode { get; set; }

        // ToDo: I should check with Mahiar.
        //        public TralusDateTime EstimatedDepartureDate { get; set; }
        //        public TralusDateTime ActualDepartureDate { get; set; }
    }
}
