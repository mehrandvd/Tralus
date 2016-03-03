using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Tralus.Shell.Module.Utility;

namespace Tralus.Shell.WindowsService
{
    static class Program
    {
        public static IEnumerable<Type> Modules, Contexts;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            ReflectionHelper.GetImportedModules(out Modules, out Contexts);
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new EventRunnerService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
