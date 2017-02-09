using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;
using System.Collections.Generic;
using DevExpress.ExpressApp.EF;
using System.Data.Common;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl.EF;
using Tralus.Framework.BusinessModel.Entities.StateMachines;
using Tralus.Framework.Data;
using Tralus.Shell.Module.Utility;

namespace Tralus.Shell.Web
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    public partial class ShellAspNetApplication : WebApplication
    {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private Tralus.Shell.Module.ShellModule module3;
        private Tralus.Shell.Module.Web.ShellAspNetModule module4;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule1;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule1;
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV21;
        private DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2 reportsAspNetModuleV21;
        private DevExpress.ExpressApp.TreeListEditors.Web.TreeListEditorsAspNetModule treeListEditorsAspNetModule1;
        private DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase treeListEditorsModuleBase1;
        private DevExpress.ExpressApp.Chart.ChartModule chartModule1;
        private DevExpress.ExpressApp.Chart.Web.ChartAspNetModule chartAspNetModule1;
        private DevExpress.ExpressApp.PivotGrid.PivotGridModule pivotGridModule1;
        private DevExpress.ExpressApp.PivotGrid.Web.PivotGridAspNetModule pivotGridAspNetModule1;
        private DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule pivotChartAspNetModule1;
        private DevExpress.ExpressApp.PivotChart.PivotChartModuleBase pivotChartModuleBase1;
        private DevExpress.ExpressApp.Workflow.WorkflowModule workflowModule1;
        private Module.ShellModule shellModule1;
        private DevExpress.ExpressApp.Maps.Web.MapsAspNetModule mapsAspNetModule1;
        private DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule viewVariantsModule1;
        private DevExpress.ExpressApp.Dashboards.DashboardsModule dashboardsModule1;
        private DevExpress.ExpressApp.Dashboards.Web.DashboardsAspNetModule dashboardsAspNetModule1;
        private DevExpress.ExpressApp.Kpi.KpiModule kpiModule1;
        private DevExpress.ExpressApp.StateMachine.StateMachineModule stateMachineModule;

        public ShellAspNetApplication()
        {
            InitializeComponent();
            stateMachineModule.StateMachineStorageType = typeof(StateMachine);

           

            //try
            //{
            //    AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            //    {
            //        var location = Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath,
            //            args.Name.Split(',')[0] + ".dll");
            //        if (File.Exists(location))
            //        {
            //            var assembly = Assembly.LoadFrom(location);
            //            return assembly;
            //        }
            //        return null;
            //    };

            //    ReflectionHelper.GetImportedModules(out _loadedModuleTypes, out _loadedContextTypes);
            foreach (var loadedModuleType in Global.LoadedModuleTypes)
            {
                var loadedModule = (ModuleBase)Activator.CreateInstance(loadedModuleType);
                Modules.Add(loadedModule);
            }
            //}
            //catch
            //{
            //    Trace.WriteLine(string.Format("Unable to load modules."));
            //}

        }

        //private IEnumerable<Type> _loadedModuleTypes;
        //private IEnumerable<Type> _loadedContextTypes;

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args)
        {
            foreach (var dbContext in Global.LoadedContextTypes)
            {
                args.ObjectSpaceProviders.Add(
                    args.Connection != null ?
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, (DbConnection)args.Connection) :
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, args.ConnectionString));
            }
        }

        protected override void CheckCompatibilityCore()
        {

        }

        //private void ShellWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e)
        //{
        //    e.Handled = true;
        //    //#if EASYTEST
        //    //            e.Updater.Update();
        //    //            e.Handled = true;
        //    //#else
        //    //            if (System.Diagnostics.Debugger.IsAttached)
        //    //            {
        //    //                e.Updater.Update();
        //    //                e.Handled = true;
        //    //            }
        //    //            else
        //    //            {
        //    //                throw new InvalidOperationException(
        //    //                    "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application.\r\n" +
        //    //                    "This error occurred  because the automatic database update was disabled when the application was started without debugging.\r\n" +
        //    //                    "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " +
        //    //                    "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " +
        //    //                    "or manually create a database using the 'DBUpdater' tool.\r\n" +
        //    //                    "Anyway, refer to the 'Update Application and Database Versions' help topic at http://help.devexpress.com/#Xaf/CustomDocument2795 " +
        //    //                    "for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/");
        //    //            }
        //    //#endif
        //}

        private void ShellWindowsFormsApplication_CustomCheckCompatibility(object sender, CustomCheckCompatibilityEventArgs e)
        {
            e.Handled = true;
        }
        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new Tralus.Shell.Module.ShellModule();
            this.module4 = new Tralus.Shell.Module.Web.ShellAspNetModule();
            this.securityModule = new DevExpress.ExpressApp.Security.SecurityModule();
            this.stateMachineModule = new DevExpress.ExpressApp.StateMachine.StateMachineModule();
            this.validationModule1 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.conditionalAppearanceModule1 = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.reportsModuleV21 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.reportsAspNetModuleV21 = new DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2();
            this.treeListEditorsAspNetModule1 = new DevExpress.ExpressApp.TreeListEditors.Web.TreeListEditorsAspNetModule();
            this.treeListEditorsModuleBase1 = new DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase();
            this.chartModule1 = new DevExpress.ExpressApp.Chart.ChartModule();
            this.chartAspNetModule1 = new DevExpress.ExpressApp.Chart.Web.ChartAspNetModule();
            this.pivotGridModule1 = new DevExpress.ExpressApp.PivotGrid.PivotGridModule();
            this.pivotGridAspNetModule1 = new DevExpress.ExpressApp.PivotGrid.Web.PivotGridAspNetModule();
            this.pivotChartAspNetModule1 = new DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule();
            this.pivotChartModuleBase1 = new DevExpress.ExpressApp.PivotChart.PivotChartModuleBase();
            this.workflowModule1 = new DevExpress.ExpressApp.Workflow.WorkflowModule();
            this.shellModule1 = new Tralus.Shell.Module.ShellModule();
            this.mapsAspNetModule1 = new DevExpress.ExpressApp.Maps.Web.MapsAspNetModule();
            this.viewVariantsModule1 = new DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule();
            this.dashboardsModule1 = new DevExpress.ExpressApp.Dashboards.DashboardsModule();
            this.dashboardsAspNetModule1 = new DevExpress.ExpressApp.Dashboards.Web.DashboardsAspNetModule();
            this.kpiModule1 = new DevExpress.ExpressApp.Kpi.KpiModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // stateMachineModule
            // 
            this.stateMachineModule.StateMachineStorageType = typeof(Tralus.Framework.BusinessModel.Entities.StateMachines.StateMachine);
            // 
            // validationModule1
            // 
            this.validationModule1.AllowValidationDetailsAccess = true;
            this.validationModule1.IgnoreWarningAndInformationRules = false;
            // 
            // reportsModuleV21
            // 
            this.reportsModuleV21.EnableInplaceReports = true;
            this.reportsModuleV21.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.EF.ReportDataV2);
            this.reportsModuleV21.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML;
            this.reportsModuleV21.ShowAdditionalNavigation = true;
            // 
            // reportsAspNetModuleV21
            // 
            this.reportsAspNetModuleV21.DesignAndPreviewDisplayMode = DevExpress.ExpressApp.ReportsV2.Web.DesignAndPreviewDisplayModes.DetailView;
            // 
            // pivotChartModuleBase1
            // 
            this.pivotChartModuleBase1.DataAccessMode = DevExpress.ExpressApp.CollectionSourceDataAccessMode.Client;
            this.pivotChartModuleBase1.ShowAdditionalNavigation = true;
            // 
            // workflowModule1
            // 
            this.workflowModule1.RunningWorkflowInstanceInfoType = typeof(DevExpress.ExpressApp.Workflow.EF.EFRunningWorkflowInstanceInfo);
            this.workflowModule1.StartWorkflowRequestType = typeof(DevExpress.ExpressApp.Workflow.EF.EFStartWorkflowRequest);
            this.workflowModule1.UserActivityVersionType = typeof(DevExpress.ExpressApp.Workflow.Versioning.EFUserActivityVersion);
            this.workflowModule1.WorkflowControlCommandRequestType = typeof(DevExpress.ExpressApp.Workflow.EF.EFWorkflowInstanceControlCommandRequest);
            this.workflowModule1.WorkflowDefinitionType = typeof(DevExpress.ExpressApp.Workflow.EF.EFWorkflowDefinition);
            this.workflowModule1.WorkflowInstanceKeyType = typeof(DevExpress.Workflow.EF.EFInstanceKey);
            this.workflowModule1.WorkflowInstanceType = typeof(DevExpress.Workflow.EF.EFWorkflowInstance);
            // 
            // dashboardsModule1
            // 
            this.dashboardsModule1.DashboardDataType = typeof(DevExpress.Persistent.BaseImpl.EF.DashboardData);
            // 
            // ShellAspNetApplication
            // 
            this.ApplicationName = "Tralus.Shell";
            this.CollectionsEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.reportsModuleV21);
            this.Modules.Add(this.conditionalAppearanceModule1);
            this.Modules.Add(this.validationModule1);
            this.Modules.Add(this.viewVariantsModule1);
            this.Modules.Add(this.treeListEditorsModuleBase1);
            this.Modules.Add(this.chartModule1);
            this.Modules.Add(this.pivotGridModule1);
            this.Modules.Add(this.pivotChartModuleBase1);
            this.Modules.Add(this.workflowModule1);
            this.Modules.Add(this.dashboardsModule1);
            this.Modules.Add(this.kpiModule1);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.securityModule);
            this.Modules.Add(this.stateMachineModule);
            this.Modules.Add(this.reportsAspNetModuleV21);
            this.Modules.Add(this.treeListEditorsAspNetModule1);
            this.Modules.Add(this.chartAspNetModule1);
            this.Modules.Add(this.pivotGridAspNetModule1);
            this.Modules.Add(this.pivotChartAspNetModule1);
            this.Modules.Add(this.mapsAspNetModule1);
            this.Modules.Add(this.dashboardsAspNetModule1);
            this.CustomCheckCompatibility += new System.EventHandler<DevExpress.ExpressApp.CustomCheckCompatibilityEventArgs>(this.ShellWindowsFormsApplication_CustomCheckCompatibility);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
