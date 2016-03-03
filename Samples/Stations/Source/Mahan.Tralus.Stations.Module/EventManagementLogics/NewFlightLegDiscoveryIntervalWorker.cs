using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.EF;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Stations.BusinessModel;
using Mahan.Tralus.Stations.Data;

namespace Mahan.Tralus.Stations.Module.EventManagementLogics
{
    public class NewFlightLegDiscoveryIntervalWorker : IntervalWorker<StationsDbContext>
    {
        protected override WorkerResult ExecuteImpl()
        {
            using (var db = GetDbContext())
            {
                var newFlightLegsQuery =
                    from flightLeg in db.Set<FlightLeg>()
                    join flightReport in db.Set<FlightReport>()
                        on flightLeg.Id equals flightReport.FlightLegId into flightReports
                    where !flightReports.Any()
                    select flightLeg;

                var newFlightLegs = newFlightLegsQuery.ToList();

                foreach (var flightLeg in newFlightLegs)
                {
                    var flightReport = new FlightReport()
                    {
                        FlightLegId = flightLeg.Id,
                        FlightReportStateId = FlightReportState.Blank.Id
                    };

                    ((IXafEntityObject)flightReport).OnCreated();


                    db.Set<FlightReport>().Add(flightReport);

                    //var hasMainRoute =
                    //    db.Set<DestinationProfile>()
                    //        .Any(dp => dp.FlightLegId == flightLeg.Id && dp.IsMainRoute == true);

                    //if (!hasMainRoute)
                    //{
                    //    var mainRoute = new DestinationProfile()
                    //    {
                    //        IsMainRoute = true,
                    //        AirportId = flightLeg.ArrivalAirportId,
                    //        FlightLegId = flightLeg.Id
                    //    };

                    //    ((IXafEntityObject)mainRoute).OnCreated();

                    //    db.Set<DestinationProfile>().Add(mainRoute);
                    //}

                    db.SaveChanges();
                }
            }

            return new WorkerResult("Done.");
        }

        public override long Interval
        {
            get { return (long) TimeSpan.FromMinutes(1).TotalMilliseconds; }
        }
    }
}
