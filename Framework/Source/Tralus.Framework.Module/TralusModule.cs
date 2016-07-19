using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Chart;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.PivotChart;
using DevExpress.ExpressApp.PivotGrid;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.TreeListEditors;
using DevExpress.ExpressApp.Validation;
using DevExpress.ExpressApp.ViewVariantsModule;
using DevExpress.ExpressApp.Workflow;
using DevExpress.Persistent.BaseImpl.EF;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Interface;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.Module
{
    public class TralusModule : ModuleBase
    {
        protected TralusModule()
        {
            var entityTypes =
                GetModuleExportedTypes();

            AdditionalExportedTypes.Add(typeof(EntityBase));
            AdditionalExportedTypes.Add(typeof(FixedEntityBase));

            foreach (var entity in entityTypes)
            {
                AdditionalExportedTypes.Add(entity);
            }

            this.RequiredModuleTypes.Add(typeof(ConditionalAppearanceModule));
            this.RequiredModuleTypes.Add(typeof(ValidationModule));
            this.RequiredModuleTypes.Add(typeof(ViewVariantsModule));
            this.RequiredModuleTypes.Add(typeof(ReportsModuleV2));
            this.RequiredModuleTypes.Add(typeof(TreeListEditorsModuleBase));
            this.RequiredModuleTypes.Add(typeof(ChartModule));
            this.RequiredModuleTypes.Add(typeof(PivotGridModule));
            this.RequiredModuleTypes.Add(typeof(PivotChartModuleBase));
            this.RequiredModuleTypes.Add(typeof(WorkflowModule));
        }

        protected virtual IEnumerable<Type> GetModuleExportedTypes()
        {
            return AssemblyResolver.GetCurrentModuleTypes(GetType())
                .Where(e => e.IsSubclassOf(typeof(EntityBase)) && !e.IsAbstract);
        }

        //private void Application_CreateCustomModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e)
        //{
        //    e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), true, "Win");
        //    e.Handled = true;
        //}
        //private void Application_CreateCustomUserModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e)
        //{
        //    e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), false, "Win");
        //    e.Handled = true;
        //}

        //public override void Setup(XafApplication application)
        //{
        //    base.Setup(application);
        //    // Manage various aspects of the application UI and behavior at the module level.

        //    application.CreateCustomModelDifferenceStore += Application_CreateCustomModelDifferenceStore;
        //    application.CreateCustomUserModelDifferenceStore += Application_CreateCustomUserModelDifferenceStore;

        //}
    }
}
