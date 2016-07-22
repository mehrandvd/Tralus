using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using System.Data.Entity;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl.EF;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module;
using Tralus.Framework.Utility.ReflectionHelpers;
using Tralus.Shell.Module.BusinessObjects;
using Role = Tralus.Framework.BusinessModel.Entities.Role;
using User = Tralus.Framework.BusinessModel.Entities.User;

namespace Tralus.Shell.Module
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic.
    public sealed partial class ShellModule : TralusModule
    {
        static ShellModule()
        {
            DevExpress.Data.Linq.CriteriaToEFExpressionConverter.SqlFunctionsType = typeof(System.Data.Entity.SqlServer.SqlFunctions);
            // Uncomment this code to delete and recreate the database each time the data model has changed.
            // Do not use this code in a production environment to avoid data loss.
            // #if DEBUG
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ShellDbContext>());
            // #endif 
        }

        public ShellModule()
        {

            InitializeComponent();

            this.AdditionalExportedTypes.Add(typeof(User));
            this.AdditionalExportedTypes.Add(typeof(Role));
            this.AdditionalExportedTypes.Add(typeof(ReportDataV2));
            this.AdditionalExportedTypes.Add(typeof(Analysis));
            this.AdditionalExportedTypes.Add(typeof(ModelDifference));
            this.AdditionalExportedTypes.Add(typeof(ModelDifferenceAspect));

            RequiredModuleTypes.Add(typeof(ReportsModuleV2));
        }

        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }

        protected override IEnumerable<Type> GetModuleExportedTypes()
        {
            return typeof(EntityBase).Assembly.GetTypes()
                .Where(e => e.IsSubclassOf(typeof(EntityBase)));
        }
    }
}
