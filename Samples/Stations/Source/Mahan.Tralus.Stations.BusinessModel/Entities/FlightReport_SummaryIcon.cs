using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base;

namespace Mahan.Stations.BusinessModel
{
    public partial class FlightReport
    {

        [NotMapped]
        public FlightReportSummaryIcon Icon
        {
            get
            {
                if (FlightReportView != null)
                {
                    if (SummaryIcon_Opened_LightGray)
                        return FlightReportSummaryIcon.Opened_Grey;

                    if (SummaryIcon_Expected_Yellow)
                        return FlightReportSummaryIcon.Expected_Yellow;

                    if (SummaryIcon_Late_Red)
                        return FlightReportSummaryIcon.Late_Red;

                    if (SummaryIcon_ApprovedByOcc_Green)
                        return FlightReportSummaryIcon.ApprovedByOcc_Green;

                    if (SummaryIcon_Done_Tick)
                        return FlightReportSummaryIcon.Done_Tick;
                }

                return FlightReportSummaryIcon.None;

            }
        }

        [NotMapped]
        private bool SummaryIcon_Opened_LightGray
        {
            get
            {
                var std = FlightReportView.ExpectedDepartureDateTime.DateTimeUtc;

                if (std.HasValue)
                {
                    var now = DateTime.Now.ToUniversalTime();

                    if (now < std)
                        return true;
                }

                return false;
            }
        }

        [NotMapped]
        private bool SummaryIcon_Expected_Yellow
        {
            get
            {
                if (!IsDone)
                {
                    if (
                        ((FlightReportView.IsOnSchedule || FlightReportView.IsDelayed) && (FlightReportView.MinutesSinceDeparture > 0 && FlightReportView.MinutesSinceDeparture < 20))
                        ||
                        (FlightReportView.IsDeparted && FlightReportView.MinutesSinceTakeOff > 0 && FlightReportView.MinutesSinceTakeOff < 20)
                        )
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        [NotMapped]
        private bool SummaryIcon_Late_Red
        {
            get
            {
                if (!IsDone)
                {
                    if (
                        ((FlightReportView.IsOnSchedule || FlightReportView.IsDelayed) && (FlightReportView.MinutesSinceDeparture > 20))
                        ||
                        (FlightReportView.IsDeparted && FlightReportView.MinutesSinceTakeOff > 20)
                        )
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        [NotMapped]
        private bool SummaryIcon_ApprovedByOcc_Green
        {
            get
            {
                return IsDone;
            }
        }

        [NotMapped]
        private bool SummaryIcon_Done_Tick
        {
            get
            {
                //TODO  az fateme bepors
                return FlightReportView.IsLanded;
            }
        }



        public enum FlightReportSummaryIcon
        {
            //[ImageName("Error")]
            Error = 0,

            [ImageName("GrayCircle")]
            [XafDisplayName("")]
            Opened_Grey = 1,

            [ImageName("RedCircle")]
            [XafDisplayName("")]
            Late_Red = 2,

            [ImageName("YellowCircle")]
            [XafDisplayName("")]
            Expected_Yellow = 3,

            [ImageName("GreenCircle")]
            [XafDisplayName("")]
            ApprovedByOcc_Green = 4,

            [ImageName("Check")]
            [XafDisplayName("")]
            Done_Tick = 5,

            [XafDisplayName("")]
            None = 6
        }
    }
}
