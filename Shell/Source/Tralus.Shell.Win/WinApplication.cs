using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Win;
using System.Collections.Generic;
using System.Configuration;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using System.Data.Common;
using System.Data.Entity;
using DevExpress.Persistent.BaseImpl.EF;
using Tralus.Framework.BusinessModel.Entities.StateMachines;
using Tralus.Framework.Data;
using Tralus.Framework.Utility.ReflectionHelpers;
using Tralus.Shell.Module.BusinessObjects;
using Tralus.Shell.Module.Utility;
using User = Tralus.Framework.BusinessModel.Entities.User;

namespace Tralus.Shell.Win
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWinWinApplicationMembersTopicAll
    public partial class ShellWindowsFormsApplication : WinApplication
    {
        public ShellWindowsFormsApplication()
        {
            IEnumerable<Type> loadedModuleTypes;
            InitializeComponent();

            stateMachineModule1.StateMachineStorageType = typeof(StateMachine);
            try
            {

                securityModule1.UserType = typeof(User);

                ReflectionHelper.GetImportedModules(out loadedModuleTypes, out _loadedContextTypes);

                foreach (var loadedModuleType in loadedModuleTypes)
                {
                    var loadedModule = (ModuleBase)Activator.CreateInstance(loadedModuleType);
                    Modules.Insert(0, loadedModule);
                }

            }
            catch
            {
            }

            var layoutDirection = ConfigurationManager.AppSettings["LayoutDirection"];
            if (layoutDirection.ToLower() == "rtl")
            {
                IsRightToLeft = true;
            }
        }

        public bool IsRightToLeft { get; set; }

        private readonly IEnumerable<Type> _loadedContextTypes;

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args)
        {
            //foreach (var dbContext in _loadedContextTypes)
            //{
            //    args.ObjectSpaceProviders.Add(
            //        args.Connection != null ?
            //            new EFObjectSpaceProvider(dbContext, TypesInfo, null, (DbConnection)args.Connection) :
            //            new EFObjectSpaceProvider(dbContext, TypesInfo, null, args.ConnectionString));
            //}

            Database.SetInitializer<ShellDbContext>(null);
            Type dbContext = typeof(ShellDbContext);
            var objectSpaceProvider = args.Connection != null ?
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, (DbConnection)args.Connection) :
                        new EFObjectSpaceProvider(dbContext, TypesInfo, null, args.ConnectionString);

            args.ObjectSpaceProvider = objectSpaceProvider;
            //args.ObjectSpaceProviders.Add(objectSpaceProvider);

        }
        private void ShellWindowsFormsApplication_CustomizeLanguagesList(object sender, CustomizeLanguagesListEventArgs e)
        {
            string userLanguageName = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            if (userLanguageName != "en-US" && e.Languages.IndexOf(userLanguageName) == -1)
            {
                e.Languages.Add(userLanguageName);
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

        public void ApplyRightToLeft(System.Windows.Forms.Form form)
        {
            if (IsRightToLeft)
            {
                if (form != null)
                {
                    form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    form.RightToLeftLayout = true;
                }
            }
        }
        protected override void OnCustomizeTemplate(DevExpress.ExpressApp.Templates.IFrameTemplate frameTemplate, string templateContextName)
        {
            base.OnCustomizeTemplate(frameTemplate, templateContextName);
            ApplyRightToLeft(frameTemplate as System.Windows.Forms.Form);
        }
        protected override System.Windows.Forms.Form CreateModelEditorForm()
        {
            System.Windows.Forms.Form form = base.CreateModelEditorForm();
            ApplyRightToLeft(form);
            return form;
        }
    }
}
