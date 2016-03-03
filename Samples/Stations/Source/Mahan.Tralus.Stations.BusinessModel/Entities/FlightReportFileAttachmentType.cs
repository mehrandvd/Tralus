using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
{
    [Table("FlightReportFileAttachmentType", Schema = "Stations")]
    [DefaultProperty("Title")]
    public class FlightReportFileAttachmentType : EntityBase
    {
        public string Title { get; set; }

        public bool RequiresDescription { get; set; }
    }
}
