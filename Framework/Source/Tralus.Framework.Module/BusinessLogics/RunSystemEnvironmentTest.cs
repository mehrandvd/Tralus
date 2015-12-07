using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Data;

namespace Tralus.Framework.Module.BusinessLogics
{
    public class RunSystemEnvironmentTest : TralusEntityBusinessLogic<SystemEnvironmentTest>
    {
        private Stopwatch stopwatch;

        protected override void ExecuteImpl()
        {
            base.ExecuteImpl();

            var testPack = SelectedObject.Id;
            var test = SelectedObject;
            

            stopwatch = Stopwatch.StartNew();
            

            int packSize = 100;
            test.PackSize = packSize;

            Log(string.Format("Creating test objects. Size: {0}", packSize));

            
            var pack1B =
                Enumerable.Range(1, packSize)
                    .Select((i) => DummyObject.Create1B(testPack))
                    .ToList();

            var pack1K =
                Enumerable.Range(1, packSize)
                    .Select((i) => DummyObject.Create1K(testPack))
                    .ToList();
            var pack10K =
                Enumerable.Range(1, packSize)
                    .Select((i) => DummyObject.Create10K(testPack))
                    .ToList();

            var pack100K =
                Enumerable.Range(1, packSize)
                    .Select((i) => DummyObject.Create100K(testPack))
                    .ToList();

            var pack1000K =
                Enumerable.Range(1, packSize)
                    .Select((i) => DummyObject.Create1000K(testPack))
                    .ToList();

            LogTime("Objects ready.");

            using (var db = new FrameworkDbContext())
            {
                test.AverageTime1B = RunTest("1B", pack1B, db);
                test.AverageTime1K = RunTest("1K", pack1K, db);
                test.AverageTime10K = RunTest("10K", pack10K, db);
                test.AverageTime100K = RunTest("100K", pack100K, db);
                test.AverageTime1000K = RunTest("1000K", pack1000K, db);

                var queryAll =
                    db.Set<DummyObject>()
                        .Where(d => d.TestPack == testPack);

                LogLine("");
                LogTime("Loading All started.");
                var list = queryAll.ToList();
                long loadTime = stopwatch.ElapsedMilliseconds;
                
                LogLine(string.Format("\tLoad Time:\t{0} ms", loadTime));
                test.LoadAllTime = loadTime;

                LogLine(string.Format("\tCount:\t{0}", list.Count));
                test.LoadAllCount = list.Count;
            }
        }

        private long RunTest(string testName, List<DummyObject> pack, FrameworkDbContext db)
        {
            LogLine("");
            LogTime(string.Format("{0} test started for {1} items.", testName, pack.Count));
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            for (var i = 0; i < pack.Count; i++)
            {
                var p = pack[i];
                db.Set<DummyObject>().Add(p);
                db.SaveChanges();
            }
            
            var total = stopwatch.ElapsedMilliseconds;

            long average = total / pack.Count;
            LogLine(string.Format("\tAverage: {0} ms.", average));

            return average;
        }

        private void Log(string msg)
        {
            var log = string.Format("[{0}]: {1}", DateTime.Now.ToString("O"), msg);
            LogLine(log);
        }

        private void LogLine(string msg)
        {
            SelectedObject.TestLog += msg + Environment.NewLine;
        }

        private void LogTime(string msg)
        {
            var time = stopwatch.ElapsedMilliseconds;
            var log = string.Format("[{0:N} ms] {1}", time, msg);
            Log(log);
            stopwatch.Restart();
        }
    }
}
