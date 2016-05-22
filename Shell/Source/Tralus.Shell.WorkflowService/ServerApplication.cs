using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.EF;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Entities.StateMachines;
using Tralus.Shell.Module.BusinessObjects;
using Tralus.Shell.Module.Utility;

namespace Tralus.Shell.WorkflowService
{
    public class ServerApplication : XafApplication
    {
        public ServerApplication()
        {
            IEnumerable<Type> loadedModuleTypes;

            //stateMachineModule1.StateMachineStorageType = typeof(StateMachine);
            try
            {

                //securityModule1.UserType = typeof(User);

                ReflectionHelper.GetImportedModules(out loadedModuleTypes, out _loadedContextTypes);

                //foreach (var loadedModuleType in loadedModuleTypes)
                //{
                //    var loadedModule = (ModuleBase)Activator.CreateInstance(loadedModuleType);
                //    Modules.Insert(0, loadedModule);
                //}

            }
            catch (Exception exception)
            {
            }
        }

        private readonly IEnumerable<Type> _loadedContextTypes;

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args)
        {
            //args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
            //foreach (var dbContext in _loadedContextTypes)
            //{
            //    args.ObjectSpaceProviders.Add(
            //        args.Connection != null ?
            //            new EFObjectSpaceProvider(dbContext, TypesInfo, null, (DbConnection)args.Connection) :
            //            new EFObjectSpaceProvider(dbContext, TypesInfo, null, args.ConnectionString));
            //}

            Type dbContext = typeof(ShellDbContext);
            var objectSpaceProvider = args.Connection != null ?
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, (DbConnection)args.Connection) :
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, args.ConnectionString);

            args.ObjectSpaceProvider = objectSpaceProvider;

        }

        protected override void CheckCompatibilityCore()
        {
            
        }

        protected override DevExpress.ExpressApp.Layout.LayoutManager CreateLayoutManagerCore(bool simple)
        {
            throw new NotImplementedException();
        }
        public void Logon()
        {
            base.Logon(null);
        }
    }
}