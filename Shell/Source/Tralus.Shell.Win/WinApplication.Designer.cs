using DevExpress.Persistent.BaseImpl.EF;

namespace Tralus.Shell.Win {
    partial class ShellWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.businessClassLibraryCustomizationModule1 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.conditionalAppearanceModule1 = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.validationModule1 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.stateMachineModule1 = new DevExpress.ExpressApp.StateMachine.StateMachineModule();
            this.validationWindowsFormsModule1 = new DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule();
            this.reportsModuleV21 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.reportsWindowsFormsModuleV21 = new DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2();
            this.treeListEditorsWindowsFormsModule1 = new DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule();
            this.treeListEditorsModuleBase1 = new DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase();
            this.pivotGridModule1 = new DevExpress.ExpressApp.PivotGrid.PivotGridModule();
            this.pivotGridWindowsFormsModule1 = new DevExpress.ExpressApp.PivotGrid.Win.PivotGridWindowsFormsModule();
            this.chartModule1 = new DevExpress.ExpressApp.Chart.ChartModule();
            this.chartWindowsFormsModule1 = new DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule();
            this.pivotChartWindowsFormsModule1 = new DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule();
            this.pivotChartModuleBase1 = new DevExpress.ExpressApp.PivotChart.PivotChartModuleBase();
            this.workflowModule1 = new DevExpress.ExpressApp.Workflow.WorkflowModule();
            this.workflowWindowsFormsModule1 = new DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule();
            this.module3 = new Tralus.Shell.Module.ShellModule();
            this.module4 = new Tralus.Shell.Module.Win.ShellWindowsFormsModule();
            this.viewVariantsModule1 = new DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // validationModule1
            // 
            this.validationModule1.AllowValidationDetailsAccess = true;
            this.validationModule1.IgnoreWarningAndInformationRules = false;
            // 
            // stateMachineModule1
            // 
            this.stateMachineModule1.StateMachineStorageType = typeof(Tralus.Framework.BusinessModel.Entities.StateMachines.StateMachine);
            // 
            // reportsModuleV21
            // 
            this.reportsModuleV21.EnableInplaceReports = true;
            this.reportsModuleV21.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.EF.ReportDataV2);
            this.reportsModuleV21.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML;
            this.reportsModuleV21.ShowAdditionalNavigation = true;
            // 
            // pivotChartModuleBase1
            // 
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
            // ShellWindowsFormsApplication
            // 
            this.ApplicationName = "Tralus.Shell";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.conditionalAppearanceModule1);
            this.Modules.Add(this.validationModule1);
            this.Modules.Add(this.reportsModuleV21);
            this.Modules.Add(this.viewVariantsModule1);
            this.Modules.Add(this.treeListEditorsModuleBase1);
            this.Modules.Add(this.chartModule1);
            this.Modules.Add(this.pivotGridModule1);
            this.Modules.Add(this.pivotChartModuleBase1);
            this.Modules.Add(this.workflowModule1);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.securityModule1);
            this.Modules.Add(this.businessClassLibraryCustomizationModule1);
            this.Modules.Add(this.stateMachineModule1);
            this.Modules.Add(this.validationWindowsFormsModule1);
            this.Modules.Add(this.reportsWindowsFormsModuleV21);
            this.Modules.Add(this.treeListEditorsWindowsFormsModule1);
            this.Modules.Add(this.pivotGridWindowsFormsModule1);
            this.Modules.Add(this.chartWindowsFormsModule1);
            this.Modules.Add(this.pivotChartWindowsFormsModule1);
            this.Modules.Add(this.workflowWindowsFormsModule1);
            this.UseOldTemplates = false;
            this.CustomCheckCompatibility += new System.EventHandler<DevExpress.ExpressApp.CustomCheckCompatibilityEventArgs>(this.ShellWindowsFormsApplication_CustomCheckCompatibility);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.ShellWindowsFormsApplication_CustomizeLanguagesList);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private Tralus.Shell.Module.ShellModule module3;
        private Tralus.Shell.Module.Win.ShellWindowsFormsModule module4;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule businessClassLibraryCustomizationModule1;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule1;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule1;
        private DevExpress.ExpressApp.StateMachine.StateMachineModule stateMachineModule1;
        private DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule validationWindowsFormsModule1;
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV21;
        private DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2 reportsWindowsFormsModuleV21;
        private DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule treeListEditorsWindowsFormsModule1;
        private DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase treeListEditorsModuleBase1;
        private DevExpress.ExpressApp.PivotGrid.PivotGridModule pivotGridModule1;
        private DevExpress.ExpressApp.PivotGrid.Win.PivotGridWindowsFormsModule pivotGridWindowsFormsModule1;
        private DevExpress.ExpressApp.Chart.ChartModule chartModule1;
        private DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule chartWindowsFormsModule1;
        private DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule pivotChartWindowsFormsModule1;
        private DevExpress.ExpressApp.PivotChart.PivotChartModuleBase pivotChartModuleBase1;
        private DevExpress.ExpressApp.Workflow.WorkflowModule workflowModule1;
        private DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule workflowWindowsFormsModule1;
        private DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule viewVariantsModule1;
    }
}
