using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Security;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightReportView", Schema = "Stations")]
    [SecurityAvailablePermissions(new string[] { "ApproveFulingInvoice", "EditFlightLeg", "RegisterFuelingInvoice" })]
    [DefaultProperty("FlightLeg")]
    public partial class FlightReportView : EntityBase
    {
        public FlightReportView()
        {
            ScheduledDepartureDateTime = new TralusDateTime();
            ActualDepartureDateTime = new TralusDateTime();
            EstimatedDepartureDateTime = new TralusDateTime();
            ActualArrivalDateTime = new TralusDateTime();
            EstimatedArrivalDateTime = new TralusDateTime();
            AtaEventDateTime = new TralusDateTime();
            CctEventDateTime = new TralusDateTime();
            DctEventDateTime = new TralusDateTime();
            InEventDateTime = new TralusDateTime();
            OutEventDateTime = new TralusDateTime();
            OffEventDateTime = new TralusDateTime();
            TakeOffDateTime = new TralusDateTime();

            DestinationProfiles = new List<DestinationProfile>();
            FlightDelays = new List<FlightDelay>();
            FlightFuellings = new List<FlightFuelling>();

        }

        public virtual FlightLeg FlightLeg { get; set; }
        [Browsable(false)]
        public Guid? FlightLegId { get; set; }

        public virtual FlightReport FlightReport { get; set; }
        //public Guid? FlightReportId { get; set; }

        public virtual FlightReportState FlightReportState { get; set; }
        public Guid? FlightReportStateId { get; set; }

        [StringLength(200)]
        public string Status { get; set; }

        public virtual FlightNumber FlightNumber { get; set; }
        [Browsable(false)]
        public Guid? FlightNumberId { get; set; }

        public virtual FlightType FlightType { get; set; }
        [Browsable(false)]
        public Guid? FlightTypeId { get; set; }

        public virtual AircraftRegister AircraftRegister { get; set; }
        [Browsable(false)]
        public Guid? AircraftRegisterId { get; set; }

        public virtual AircraftType ScheduledAircraftType { get; set; }
        [Browsable(false)]
        public Guid? ScheduledAircraftTypeId { get; set; }

        public virtual Airport DepartureAirport { get; set; }
        [Browsable(false)]
        public Guid? DepartureAirportId { get; set; }

        public virtual Airport ArrivalAirport { get; set; }
        [Browsable(false)]
        public Guid? ArrivalAirportId { get; set; }

        public TralusDateTime ScheduledDepartureDateTime { get; set; }
        public TralusDateTime ActualDepartureDateTime { get; set; }
        private TralusDateTime EstimatedDepartureDateTime { get; set; }
        public TralusDateTime ActualArrivalDateTime { get; set; }
        private TralusDateTime EstimatedArrivalDateTime { get; set; }
        private TralusDateTime TakeOffDateTime { get; set; }

        private TralusDateTime AtaEventDateTime { get; set; }
        public TralusDateTime CctEventDateTime { get; set; }
        public TralusDateTime DctEventDateTime { get; set; }
        public TralusDateTime InEventDateTime { get; set; }
        public TralusDateTime OutEventDateTime { get; set; }
        public TralusDateTime OffEventDateTime { get; set; }

        private long? FuellingSum { get; set; }
        private bool HasFuelling { get; set; }

        public long? DelaySum { get; set; }
        private bool HasDelay { get; set; }

        private long? SpecialServicesCount { get; set; }
        public bool HasSpecialService { get; set; }

        public long? CargoPiecesCount { get; set; }
        public long? CargoWeightSum { get; set; }
        private bool HasCargo { get; set; }

        public long? PassengersCount { get; set; }
        private bool HasPassenger { get; set; }


        #region Flight List Details

        [Aggregated]
        public virtual ICollection<DestinationProfile> DestinationProfiles { get; set; }

        [Aggregated]
        public virtual ICollection<FlightFuelling> FlightFuellings
        {
            set; get;
            /*get
            {
                if (FlightLegId == null)
                    return new List<FlightFuelling>();

                return ((IObjectSpaceLink)this).ObjectSpace.GetObjects<FlightFuelling>(new BinaryOperator("FlightLegId", FlightLegId));
            }*/
        }

        [NotMapped]
        public virtual ICollection<FlightRemark> FlightRemarks
        {
            get
            {
                if (FlightLegId == null)
                    return new List<FlightRemark>();

                return ((IObjectSpaceLink)this).ObjectSpace.GetObjects<FlightRemark>(new BinaryOperator("FlightLegId", FlightLegId));
            }
        }

        [Aggregated]
        public virtual ICollection<FlightDelay> FlightDelays
        {
            set; get;
            
            /* get
            {
                if (FlightLegId == null)
                    return new List<FlightDelay>();

                return ((IObjectSpaceLink)this).ObjectSpace.GetObjects<FlightDelay>(new BinaryOperator("FlightLegId", FlightLegId));
            }
            set { }*/ 
        }

        [NotMapped]
        public virtual ICollection<FlightEvent> FlightEvents
        {
            get
            {
                if (FlightLegId == null)
                    return new List<FlightEvent>();

                return ((IObjectSpaceLink)this).ObjectSpace.GetObjects<FlightEvent>(new BinaryOperator("FlightLegId", FlightLegId));

            }
        }

        #endregion

        #region Calculated Fields

        [NotMapped]
        public bool IsDelayed
        {
            get { return FlightLeg.Status == "DEL"; }
        }

        [NotMapped]
        public bool IsOnSchedule
        {
            get { return FlightLeg.Status == "SCH"; }
        }

        [NotMapped]
        public bool IsDeparted
        {
            get { return FlightLeg.Status == "DEP"; }
        }

        [NotMapped]
        public bool IsCanceled
        {
            get { return FlightLeg.Status == "CNL" || FlightLeg.Status == "RTR"; }
        }

        [NotMapped]
        public bool IsLanded
        {
            get { return FlightLeg.Status == "ATA"; }

        }

        [NotMapped]
        public bool IsLate
        {
            get
            {
                if (IsOnSchedule || IsDelayed)
                {
                    if (ScheduledDepartureDateTime != null &&
                        (DateTime.Now.ToUniversalTime() > ScheduledDepartureDateTime.DateTimeUtc))
                    {
                        return true;
                    }
                }

                return false;
            }

        }

        [NotMapped]
        public bool IsNotTime
        {
            get
            {
                return MinutesTillDeparture.HasValue && MinutesTillDeparture > 60;
            }
        }

        [NotMapped]
        public bool IsSoon
        {
            get
            {
                return MinutesTillDeparture.HasValue && MinutesTillDeparture > 0 && MinutesTillDeparture < 60;
            }
        }


        [NotMapped]
        private bool ShouldUseEstimatedArrivalTime
        {
            get { return IsDeparted || IsOnSchedule || IsDelayed; }
        }

        [NotMapped]
        public TralusDateTime ExpectedDepartureDateTime
        {
            get
            {
                if (IsDelayed)
                    return EstimatedDepartureDateTime;

                if (IsOnSchedule)
                    return ScheduledDepartureDateTime;

                return TralusDateTime.Null;
            }
        }

        [NotMapped]
        public TralusDateTime ArrivalDateTime
        {
            get
            {
                if (ShouldUseEstimatedArrivalTime)
                    return EstimatedArrivalDateTime;

                if (IsLanded)
                    return ActualArrivalDateTime;

                return new TralusDateTime();
            }
        }

        [NotMapped]
        public int? MinutesTillDeparture
        {
            get
            {
                if (ExpectedDepartureDateTime.DateTimeUtc.HasValue)
                {

                    return (int)((ExpectedDepartureDateTime.DateTimeUtc.Value - DateTime.UtcNow).TotalMinutes);

                }

                return null;
            }
        }

        [NotMapped]
        public int? MinutesSinceDeparture
        {
            get
            {
                if (ExpectedDepartureDateTime.DateTimeUtc.HasValue)
                {

                    return (int)((DateTime.UtcNow - ExpectedDepartureDateTime.DateTimeUtc.Value).TotalMinutes);

                }

                return null;
            }
        }

        [NotMapped]
        public int? MinutesSinceTakeOff
        {
            get
            {
                if (TakeOffDateTime != null && TakeOffDateTime.DateTimeUtc.HasValue)
                    return (DateTime.UtcNow - TakeOffDateTime.DateTimeUtc.Value).Minutes;

                return null;
            }
        }

        [NotMapped]
        private FlightReportTimingStatus FlightReportTimingStatus
        {
            get
            {
                if (FlightReportState == null)
                    return FlightReportTimingStatus.Missing;

                if (FlightReportState == FlightReportState.Done)
                    return FlightReportTimingStatus.ReceivedByArrivalStation;

                if (FlightReportState == FlightReportState.ReceivedByArrSta)
                    return FlightReportTimingStatus.ReceivedByArrivalStation;

                if (FlightReportState == FlightReportState.ApprovedByOcc)
                    return FlightReportTimingStatus.ApprovedByOcc;

                if (IsLanded)
                    return FlightReportTimingStatus.Late;

                if (IsDeparted && MinutesSinceTakeOff.HasValue && MinutesSinceTakeOff > 25)
                    return FlightReportTimingStatus.Late;

                if (IsDeparted && MinutesSinceTakeOff.HasValue && MinutesSinceTakeOff <= 25)
                    return FlightReportTimingStatus.DueSoon;

                if (MinutesTillDeparture.HasValue && MinutesTillDeparture < 0)
                    return FlightReportTimingStatus.DueSoon;

                if (MinutesTillDeparture.HasValue && MinutesTillDeparture >= 0)
                    return FlightReportTimingStatus.NotTime;

                return FlightReportTimingStatus.Unknown;
            }
        }

        [NotMapped]
        public int RetractionStatus
        {
            get
            {
                if (FlightReportState == FlightReportState.RetractedByDepStaManager ||
                    FlightReportState == FlightReportState.RetractedByDepStaStaff)
                    return 1;

                if (FlightReportState == FlightReportState.RejectedByOcc)
                    return 2;

                return 0;
            }
        }

        [NotMapped]
        private bool IsOwnedByThisStationManager
        {
            get
            {
                if (FlightReportState.IsOwnedByDepartureStationManager ||
                    FlightReportState.IsOwnedByArrivalStation)
                    return true;

                return false;
            }
        }

        [NotMapped]
        private bool FR_IsOwnedByThisStationStaff
        {
            get
            {
                if (FlightReportState.IsOwnedByDepartureStationStaff ||
                    FlightReportState.IsOwnedByArrivalStation)
                    return true;

                return false;
            }
        }

        #endregion
    }

}
