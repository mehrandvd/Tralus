using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("DestinationProfile", Schema = "Stations")]
    [DefaultProperty("Airport")]
    public partial class DestinationProfile : EntityBase
    {
        public DestinationProfile()
        {
            DestinationPassengers = new List<DestinationPassenger>();
            DestinationCargos = new List<DestinationCargo>();
            DestinationSpecialServices = new List<DestinationSpecialService>();

        }


        protected override void OnInitialize()
        {
            base.OnInitialize();

            InitializeDestinationPassengers();
            InitializeDestinationSpecialServices();
            InitializeDestinationCargos();

        }

        /*Create 3 DestinationCargoType*/
        private void InitializeDestinationCargos()
        {

            var cargoTypes = ((IObjectSpaceLink)this).ObjectSpace.GetObjects<CargoType>();

            DestinationCargos = (from cargoType in cargoTypes
                                 select new DestinationCargo(true)
                                 {
                                     DestinationProfile = this,
                                     CargoTypeId = cargoType.Id,
                                 }).ToList();
        }

        /*Create 8 DestinationSpecialServices*/
        private void InitializeDestinationSpecialServices()
        {
            var specialServiceTypes = ((IObjectSpaceLink)this).ObjectSpace.GetObjects<SpecialServiceType>();

            DestinationSpecialServices = (from specialServiceType in specialServiceTypes
                                          select new DestinationSpecialService(true)
                                          {
                                              DestinationProfile = this,
                                              SpecialServiceTypeId = specialServiceType.Id
                                          }).ToList();
        }

        /*Create 27 DestinationPassengers*/
        private void InitializeDestinationPassengers()
        {
            var passengerTypeList = ((IObjectSpaceLink)this).ObjectSpace.GetObjects<PassengerType>();
            var seatClassList = ((IObjectSpaceLink)this).ObjectSpace.GetObjects<SeatClass>();
            var ticketTypeList = ((IObjectSpaceLink)this).ObjectSpace.GetObjects<TicketType>();

            DestinationPassengers = (from passengerType in passengerTypeList
                                     from ticketType in ticketTypeList
                                     from seatClass in seatClassList
                                     select new DestinationPassenger(true)
                                     {
                                         DestinationProfile = this,
                                         PassengerTypeId = passengerType.Id,
                                         TicketTypeId = ticketType.Id,
                                         SeatClassId = seatClass.Id
                                     }).ToList();
        }

        public bool? IsMainRoute { get; set; }

        public virtual Airport Airport { get; set; }
        public Guid? AirportId { get; set; }

        public long? ExtraBaggageAmount { get; set; }

        public double? ExtraBaggageWeight { get; set; }

        [ForeignKey("FlightLegId")]
        public virtual FlightReportView FlightReportView { get; set; }

        
        [Required]
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid? FlightLegId { get; set; }

        public virtual ICollection<DestinationPassenger> DestinationPassengers { get; set; }
        public virtual ICollection<DestinationCargo> DestinationCargos { get; set; }
        public virtual ICollection<DestinationSpecialService> DestinationSpecialServices { get; set; }
    }
}
