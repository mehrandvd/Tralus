using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Infrastructure.Data;
using Mahan.Tralus.Infrastructure.Module.BusinessLogics;

namespace Mahan.Tralus.Infrastructure.Module.EventManagementLogics
{
    public class ImportMasterDataFromFlightAppsIntervalWorker : IntervalWorker<InfrastructureDbContext>
    {
        protected override WorkerResult ExecuteImpl()
        {
            var now = DateTime.UtcNow;

            var importLog = new ImportMasterDataLog
            {
                Id = Guid.NewGuid(),
                Creator = SecuritySystem.CurrentUserName,
                LogDateTime = now
            };

            using (var db = GetDbContext())
            {
                db.Set<ImportMasterDataLog>().Add(importLog);
                db.SaveChanges();


                var logic = new ImportMasterDataFromFlightAppsBusinessLogic(now.AddDays(-1), now.AddDays(2))
                {
                    SelectedObject = importLog
                };

                try
                {
                    var sw = Stopwatch.StartNew();
                    logic.Execute();
                    importLog.Log(string.Format("Execution time: {0} seconds.", sw.Elapsed.TotalSeconds));
                    return new WorkerResult("Done.");
                }
                catch (Exception exception)
                {
                    importLog.Log(exception.ToString());
                    return new WorkerResult("Failed.");
                }
                finally
                {
                    db.SaveChanges();
                }

            }

        }

        public override long Interval
        {
            get
            {
                return (long) TimeSpan.FromMinutes(5).TotalMilliseconds;
            }
        }
    }
}
