using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Security;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
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
