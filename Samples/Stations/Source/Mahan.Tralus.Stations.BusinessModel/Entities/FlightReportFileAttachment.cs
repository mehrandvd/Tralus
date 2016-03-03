using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Utility;

namespace Mahan.Stations.BusinessModel
{
    [Table("FlightReportFileAttachment", Schema = "Stations")]
    [DefaultProperty("Description")]
    public class FlightReportFileAttachment : EntityBase
    {
        public FlightReportFileAttachment()
        {
            AttachedDate = new TralusDateTime();
        }

        public virtual FlightReport FlightReport { get; set; }
        public Guid?  FlightReportId { get; set; }

        public virtual FlightReportFileAttachmentType FlightReportFileAttachmentType { get; set; }
        public Guid?  FlightReportFileAttachmentTypeId { get; set; }

        public string Description { get; set; }
        
        public TralusDateTime AttachedDate { get; set; }
        
        public string AttachedBy { get; set; }
        
        public string  AttachmentFile { get; set; }
    }
}
