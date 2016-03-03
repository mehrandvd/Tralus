using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Security;
using Tralus.Framework.BusinessModel.Utility;
using Mahan.Infrastructure.BusinessModel;

namespace Mahan.Stations.BusinessModel
{
    [Table("FlightReport", Schema = "Stations")]
    [SecurityAvailablePermissions(new string[] { "ApproveFulingInvoice", "EditFlightLeg", "RegisterFuelingInvoice" })]
    [DefaultProperty("FlightLeg")]
    public partial class FlightReport : EntityBase
    {
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid? FlightLegId { get; set; }

        public virtual FlightReportState FlightReportState { get; set; }
        public Guid? FlightReportStateId { get; set; }

        public virtual FlightReportView FlightReportView { get; set; }

        [NotMapped]
        private bool IsDone
        {
            get
            {
                return FlightReportState == FlightReportState.Done;
            }
        }
    }
}
