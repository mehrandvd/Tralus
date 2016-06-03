using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Tralus.Shell.Module.BusinessObjects;

namespace Tralus.Shell.WorkflowService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Database.SetInitializer<ShellDbContext>(null);
            //if (Environment.UserInteractive)
            //{ 
            //    new WorkflowServiceWorkflowServer().Test(null);
            //}
            //else
            //{
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new WorkflowServiceWorkflowServer()
                };
                ServiceBase.Run(ServicesToRun);
            //}


        }
    }
}
