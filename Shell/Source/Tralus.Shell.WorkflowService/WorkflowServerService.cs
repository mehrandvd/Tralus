using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using DevExpress.ExpressApp.Workflow.Server;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Workflow;
using DevExpress.Workflow;
using DevExpress.ExpressApp.MiddleTier;
using Tralus.Shell.Module;
using ReflectionHelper = Tralus.Shell.Module.Utility.ReflectionHelper;

namespace Tralus.Shell.WorkflowService
{
    public partial class WorkflowServiceWorkflowServer : System.ServiceProcess.ServiceBase
    {
        private WorkflowServer server;
        private IEnumerable<Type> _loadedContextTypes;

        protected override void OnStart(string[] args)
        {
            if (server == null)
            {
                ServerApplication serverApplication;

                serverApplication = new ServerApplication();

                serverApplication.ApplicationName = "Tralus.Shell.WorkflowService";
                // The service can only manage workflows for those business classes that are contained in Modules specified by the serverApplication.Modules collection.
                // So, do not forget to add the required Modules to this collection via the serverApplication.Modules.Add method.
                serverApplication.Modules.BeginInit();

                var workflowModule = new WorkflowModule();

                workflowModule.RunningWorkflowInstanceInfoType = typeof(DevExpress.ExpressApp.Workflow.EF.EFRunningWorkflowInstanceInfo);
                workflowModule.StartWorkflowRequestType = typeof(DevExpress.ExpressApp.Workflow.EF.EFStartWorkflowRequest);
                workflowModule.UserActivityVersionType = typeof(DevExpress.ExpressApp.Workflow.Versioning.EFUserActivityVersion);
                workflowModule.WorkflowControlCommandRequestType = typeof(DevExpress.ExpressApp.Workflow.EF.EFWorkflowInstanceControlCommandRequest);
                workflowModule.WorkflowDefinitionType = typeof(DevExpress.ExpressApp.Workflow.EF.EFWorkflowDefinition);
                workflowModule.WorkflowInstanceKeyType = typeof(DevExpress.Workflow.EF.EFInstanceKey);
                workflowModule.WorkflowInstanceType = typeof(DevExpress.Workflow.EF.EFWorkflowInstance);

                serverApplication.Modules.Add(workflowModule);
                serverApplication.Modules.Add(new ShellModule());

                IEnumerable<Type> loadedModuleTypes;
                ReflectionHelper.GetImportedModules(out loadedModuleTypes, out _loadedContextTypes);

                foreach (var loadedModuleType in loadedModuleTypes)
                {
                    var loadedModule = (ModuleBase)Activator.CreateInstance(loadedModuleType);
                    serverApplication.Modules.Insert(0, loadedModule);
                }



                if (ConfigurationManager.ConnectionStrings["Default"] != null)
                {
                    serverApplication.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                }
                serverApplication.Setup();
                serverApplication.Logon();
                IObjectSpaceProvider objectSpaceProvider = serverApplication.ObjectSpaceProvider;

                //WorkflowCreationKnownTypesProvider.AddKnownType(typeof(DevExpress.Xpo.Helpers.IdList));

                server = new WorkflowServer("http://localhost:46232", objectSpaceProvider, objectSpaceProvider);
                server.StartWorkflowListenerService.DelayPeriod = TimeSpan.FromSeconds(15);
                server.StartWorkflowByRequestService.DelayPeriod = TimeSpan.FromSeconds(15);
                server.RefreshWorkflowDefinitionsService.DelayPeriod = TimeSpan.FromMinutes(15);

                server.CustomizeHost += delegate (object sender, CustomizeHostEventArgs e)
                {
                    e.WorkflowInstanceStoreBehavior.WorkflowInstanceStore.RunnableInstancesDetectionPeriod = TimeSpan.FromSeconds(15);
                };

                server.CustomHandleException += delegate (object sender, CustomHandleServiceExceptionEventArgs e)
                {
                    Tracing.Tracer.LogError(e.Exception);
                    e.Handled = false;
                };

            }

            try
            {
                server.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in starting server", ex);
            }


        }
        protected override void OnStop()
        {
            server.Stop();
        }
        public WorkflowServiceWorkflowServer()
        {
            InitializeComponent();
        }

        internal void Test(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}
