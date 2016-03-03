using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
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
