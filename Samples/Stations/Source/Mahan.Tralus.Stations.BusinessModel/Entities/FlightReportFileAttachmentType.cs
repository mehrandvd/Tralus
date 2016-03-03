using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightReportFileAttachmentType", Schema = "Stations")]
    [DefaultProperty("Title")]
    public class FlightReportFileAttachmentType : EntityBase
    {
        public string Title { get; set; }

        public bool RequiresDescription { get; set; }
    }
}
