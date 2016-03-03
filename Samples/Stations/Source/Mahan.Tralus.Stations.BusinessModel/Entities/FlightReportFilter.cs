using DevExpress.ExpressApp.DC;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Utility;
using Mahan.Infrastructure.BusinessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahan.Stations.BusinessModel
{
    
    [Table("FlightReportFilters", Schema = "Stations")]
    public class FlightReportFilter  : EntityBase
    {
        public FlightReportFilter()
        {
            StartDate = new TralusDateTime();
            EndDate = new TralusDateTime();
        }

        public string FlightNumber { get; set; }
        public TralusDateTime StartDate { get; set; }
        public TralusDateTime EndDate { get; set; }
        public Airport ArrivalAirport { get; set; }
        public Airport DepartureAirport { get; set; }
        public AircraftRegister AircraftRegister { get; set; }

        public Guid? ArrivalAirportId { get; set; }
        public Guid? DepartureAirportId { get; set; }
        public Guid? AircraftRegisterId { get; set; }
    }
}
