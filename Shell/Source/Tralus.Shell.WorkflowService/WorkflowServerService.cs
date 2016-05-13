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

                try
                {
                    serverApplication = new ServerApplication();

                }
                catch (Exception)
                {

                    throw new Exception("Error i creating server application.");
                }

                try
                {
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
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in creating server", ex);
                }

                try
                {
                    IEnumerable<Type> loadedModuleTypes;
                    ReflectionHelper.GetImportedModules(out loadedModuleTypes, out _loadedContextTypes);

                    foreach (var loadedModuleType in loadedModuleTypes)
                    {
                        var loadedModule = (ModuleBase)Activator.CreateInstance(loadedModuleType);
                        serverApplication.Modules.Insert(0, loadedModule);
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error in loading modules", ex);
                }


                try
                {
                    if (ConfigurationManager.ConnectionStrings["Default"] != null)
                    {
                        serverApplication.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                    }
                    serverApplication.Setup();
                    serverApplication.Logon();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in setting up.", ex);
                }

                try
                {
                    IObjectSpaceProvider objectSpaceProvider = serverApplication.ObjectSpaceProvider;

                    //WorkflowCreationKnownTypesProvider.AddKnownType(typeof(DevExpress.Xpo.Helpers.IdList));

                    try
                    {
                        server = new WorkflowServer("http://localhost:46232", objectSpaceProvider, objectSpaceProvider);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error in creating WorkflowServer.", e);
                    }

                    try
                    {
                        server.StartWorkflowListenerService.DelayPeriod = TimeSpan.FromSeconds(15);
                        server.StartWorkflowByRequestService.DelayPeriod = TimeSpan.FromSeconds(15);
                        server.RefreshWorkflowDefinitionsService.DelayPeriod = TimeSpan.FromMinutes(15);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(
                            $"Error in configuring WorkflowServer. Server={server}, StartWorkflowListenerService={server.StartWorkflowListenerService}, StartWorkflowByRequestService={server.StartWorkflowByRequestService}, RefreshWorkflowDefinitionsService={server.RefreshWorkflowDefinitionsService}", e);
                    }

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
                catch (Exception ex)
                {
                    throw new Exception("Error in configuring server", ex);
                }
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
    }
}
