using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Security;
using Tralus.Shell.Module.Security;

namespace Tralus.Shell.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if EASYTEST
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            ShellWindowsFormsApplication winApplication = new ShellWindowsFormsApplication();
            // Refer to the http://documentation.devexpress.com/#Xaf/CustomDocument2680 help article for more details on how to provide a custom splash form.
            //winApplication.SplashScreen = new DevExpress.ExpressApp.Win.Utils.DXSplashScreen("YourSplashImage.png");
            if(ConfigurationManager.ConnectionStrings["Default"] != null) {
                winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
#if EASYTEST
            if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
                winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
            }
#endif
            try {

                ConfigSecurity(winApplication);

                winApplication.Setup();
                EntityBase.SetApplication(winApplication);
                winApplication.Start();
            }
            catch(Exception e) {
                winApplication.HandleException(e);
            }
        }

        private static void ConfigSecurity(XafApplication application)
        {
            //if (application.Security != null)
            //    ((SecurityStrategy)winApplication.Security).CustomizeRequestProcessors +=
            //        (sender, e) => e.Processors.Add(typeof (BusinessLogicPermissionRequest<>), new BusinessLogicPermissionRequestProcessor(e.Permissions));

            var authenticationModeString = ConfigurationManager.AppSettings["AuthenticationMode"];
            var createUserAutomaticallyString = ConfigurationManager.AppSettings["CreateUserAutomatically"];
            
            if (string.IsNullOrWhiteSpace(authenticationModeString))
            {
                throw new Exception("No AuthenticationMode specified at configuration. In app.config or web.config, there should be a 'AuthenticationMode' key in appSettings.");
            }

            bool createUserAutomatically = false;
            if (!string.IsNullOrWhiteSpace(createUserAutomaticallyString))
                createUserAutomatically = createUserAutomaticallyString.ToLower() == "true";

            TralusAuthenticationBase authentication;

            switch (authenticationModeString)
            {
                case "ActiveDirectory":
                    authentication = new ActiveDirectoryAuthentication() { CreateUserAutomatically = createUserAutomatically };
                    break;

                default:
                    throw new Exception(string.Format("AuthenticationMode is not supported: '{0}'", authenticationModeString));
            }

            // ToDo: Select authentication method from config file.
            application.Security = new TralusSecurityStrategy(authentication);

        }
    }
}
