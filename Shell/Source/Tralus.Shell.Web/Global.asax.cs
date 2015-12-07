using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Web;
using DevExpress.Web;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Shell.Module.Security;
using Tralus.Shell.Web.Security;

namespace Tralus.Shell.Web {
    public class Global : System.Web.HttpApplication {
        public Global() {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["ApplicationStyle"] == "New")
                WebApplication.Instance.SwitchToNewStyle();
        }
        protected void Application_Start(Object sender, EventArgs e) {
            ASPxWebControl.CallbackError += new EventHandler(Application_Error);
#if EASYTEST
            DevExpress.ExpressApp.Web.TestScripts.TestScriptsManager.EasyTestEnabled = true;
#endif
        }
        protected void Session_Start(Object sender, EventArgs e) {
            var webApplication = new ShellAspNetApplication();
            ConfigSecurity(webApplication);
            
            WebApplication.SetInstance(Session, webApplication);



            if(ConfigurationManager.ConnectionStrings["Default"] != null) {
                WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
#if EASYTEST
            if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
                WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
            }
#endif
            
            //WebApplication.Instance.Security = new TralusSecurityStrategy(new AdfsAuthentication());
            WebApplication.Instance.Setup();
            WebApplication.Instance.Start();
        }

        private static void ConfigSecurity(XafApplication application)
        {
            //if (application.Security != null)
            //    ((SecurityStrategy)winApplication.Security).CustomizeRequestProcessors +=
            //        (sender, e) => e.Processors.Add(typeof (BusinessLogicPermissionRequest<>), new BusinessLogicPermissionRequestProcessor(e.Permissions));

            var authenticationModeString = ConfigurationManager.AppSettings["AuthenticationMode"];
            var createUserAutomaticallyString = ConfigurationManager.AppSettings["CreateUserAutomatically"];
            var createUserAutomatically = createUserAutomaticallyString.ToLower() == "true";

            if (string.IsNullOrWhiteSpace(authenticationModeString))
            {
                throw new Exception("No AuthenticationMode specified at configuration. In app.config or web.config, there should be a 'AuthenticationMode' key in appSettings.");
            }

            TralusAuthenticationBase authentication;

            switch (authenticationModeString)
            {
                case "ActiveDirectory":
                    authentication = new ActiveDirectoryAuthentication() { CreateUserAutomatically = createUserAutomatically };
                    break;

                case "ADFS":
                    authentication = new AdfsAuthentication() { CreateUserAutomatically = createUserAutomatically };
                    break;

                case "None":
                    authentication = (TralusAuthenticationBase)null;
                    break;

                default:
                    throw new Exception(string.Format("AuthenticationMode is not supported: '{0}'", authenticationModeString));
            }

            if (authentication != null)
            {
                application.Security = new TralusSecurityStrategy(authentication);
            }

        }

        protected void Application_BeginRequest(Object sender, EventArgs e) {
        }
        protected void Application_EndRequest(Object sender, EventArgs e) {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e) {
        }
        protected void Application_Error(Object sender, EventArgs e) {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e) {
            WebApplication.LogOff(Session);
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e) {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        }
        #endregion
    }

   
}
