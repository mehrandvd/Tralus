using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahan.Tralus.Stations.BusinessModel
{
    public partial class FlightReport
    {
        [NotMapped]
        public bool ConditionalAppearance_Cancelled_RedCrossOut
        {
            get
            {
                return FlightReportView.IsCanceled;
            }
        }

        [NotMapped]
        public bool ConditionalAppearance_Landed_LightBlue
        {
            get
            {
                return FlightReportView.IsLanded;
            }
        }

        [NotMapped]
        public bool ConditionalAppearance_Departed_LightGreen
        {
            get
            {
                return FlightReportView.IsDeparted && !FlightReportView.IsLate;
            }
        }

        [NotMapped]
        public bool ConditionalAppearance_Late_LightRed
        {
            get
            {
                return FlightReportView.IsLate;
            }
        }

        [NotMapped]
        public bool ConditionalAppearance_Near_LightYellow
        {
            get
            {
                return FlightReportView.IsSoon;
            }
        }

        [NotMapped]
        public bool ConditionalAppearance_NotNear_White
        {
            get
            {
                return FlightReportView.IsNotTime;
            }
        }
    }
}
