using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Tralus.Framework.BusinessModel.Utility;
using Timer = System.Timers.Timer;

namespace Tralus.Shell.WindowsService
{
    public partial class EventRunnerService : ServiceBase
    {
        public EventRunnerService()
        {
            InitializeComponent();
        }

        readonly Dictionary<Timer, IntervalWorker> _timers = new Dictionary<Timer, IntervalWorker>();

        protected override void OnStart(string[] args)
        {
            try
            {
                var intervalWorkerTypes = GetIntervalWorkers();
                var workers = intervalWorkerTypes.Select(type => (IntervalWorker)Activator.CreateInstance(type));

                foreach (var worker in workers)
                {
                    try
                    {
                        var timer = new Timer();

                        timer.Interval = worker.Interval;
                        timer.Elapsed += timer_Elapsed;
                        
                        _timers.Add(timer, worker);
                        timer.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        EventLogger.Log(string.Format("Unable to enable worker: {0}\n{1}", worker, exception));
                    }
                }
            }
            catch (Exception exception)
            {
                EventLogger.Log(exception.ToString());
            }

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var timer = (Timer) sender;
            var worker = _timers[timer];

            timer.Enabled = false;
            try
            {
                worker.Execute();
            }
            catch (Exception exception)
            {
                EventLogger.Log(exception.ToString());
            }
            finally
            {
                timer.Enabled = true;
            }

        }

        protected override void OnStop()
        {
            foreach (var timer in _timers)
            {
                timer.Key.Enabled = false;
            }
        }

        private List<Type> GetIntervalWorkers()
        {
            var workerTypes = new List<Type>();

            foreach (var module in Program.Modules)
            {
                var moduleWorkers =
                    module.Assembly
                    .GetTypes()
                    .Where(t => t.IsSubclassOf(typeof (IntervalWorker)) && !t.IsAbstract)
                    .ToList();

                workerTypes.AddRange(moduleWorkers);
            }

            return workerTypes;
        }
    }
}
