using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightReportActivityTimingSetup", Schema = "Stations")]
    [DefaultProperty("TimeBeforeStdSendToOccMinute")]
    public class FlightReportActivityTimingSetup : EntityBase
    {
        public long? TimeBeforeStdStationStaffMinute { get; set; }

        public long? TimeBeforeStdStationManagerMinute { get; set; }

        public long? TimeBeforeStdSendToOccMinute { get; set; }
    }
}
