using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using DevExpress.DashboardCommon;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Dashboards.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.DB.Helpers;

namespace Tralus.Shell.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class WinDashboardCustomizeController : ViewController<DetailView>
    {
        WinShowDashboardDesignerController desingerController;
        WinDashboardViewerViewItem dashboardViewerViewItem;
        public WinDashboardCustomizeController()
        {
            TargetObjectType = typeof(IDashboardData);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            dashboardViewerViewItem = View.FindItem("DashboardViewer") as WinDashboardViewerViewItem;
            if (dashboardViewerViewItem != null)
            {
                dashboardViewerViewItem.ControlCreated += DashboardViewerViewItem_ControlCreated;
            }
            desingerController = Frame.GetController<WinShowDashboardDesignerController>();
            if (desingerController != null)
            {
                desingerController.DashboardDesignerManager.DashboardDesignerCreated += DashboardDesignerManager_DashboardDesignerCreated;
            }
        }
        protected override void OnDeactivated()
        {
            if (dashboardViewerViewItem != null)
            {
                dashboardViewerViewItem.ControlCreated -= DashboardViewerViewItem_ControlCreated;
            }
            if (desingerController != null)
            {
                desingerController.DashboardDesignerManager.DashboardDesignerCreated -= DashboardDesignerManager_DashboardDesignerCreated;
            }
            base.OnDeactivated();
        }
        private void DashboardDesignerManager_DashboardDesignerCreated(object sender, DashboardDesignerShownEventArgs e)
        {
            e.DashboardDesigner.ConfigureDataConnection += DashboardDesigner_ConfigureDataConnection;
        }
        private void DashboardDesigner_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            ConfigureDataConnection(e);
        }
        private void DashboardViewerViewItem_ControlCreated(object sender, EventArgs e)
        {
            WinDashboardViewerViewItem dashboardViewerViewItem = View.FindItem("DashboardViewer") as WinDashboardViewerViewItem;
            if (dashboardViewerViewItem != null)
            {
                dashboardViewerViewItem.Viewer.ConfigureDataConnection += Viewer_ConfigureDataConnection;
            }
        }
        private void Viewer_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            ConfigureDataConnection(e);
        }

        private void ConfigureDataConnection(DashboardConfigureDataConnectionEventArgs e)
        {
            // ToDo: Complete the connection string resolving process. 2F4D197A-9BF1-4DEE-A1DC-52447F969889
            // Detail link: https://www.devexpress.com/Support/Center/Question/Details/T473885

            SetupConnectionString(e);
        }

        private void SetupConnectionString(DashboardConfigureDataConnectionEventArgs e)
        {
            // There is a duplicate code in Module.Web too.. Dont forget to change it.

            var connectionStringSettings = ConfigurationManager.ConnectionStrings[e.ConnectionName];
            ConnectionStringParser parser;
            if (connectionStringSettings != null)
            {
                parser = new ConnectionStringParser(connectionStringSettings.ConnectionString);
            }
            else
            {
                parser = new ConnectionStringParser(Application.ConnectionString);
            }

            var connectionParameters = e.ConnectionParameters as CustomStringConnectionParameters;

            if (connectionParameters != null && connectionParameters.ConnectionString.Contains("XpoProvider=MSSqlServer"))
                // SqlServer
            {
                var sqlConnectionParameters = new MsSqlConnectionParameters();
                sqlConnectionParameters.ServerName = !string.IsNullOrWhiteSpace(parser.GetPartByName("Data Source")) ? parser.GetPartByName("Data Source") : parser.GetPartByName("Server");
                sqlConnectionParameters.DatabaseName = parser.GetPartByName("Initial Catalog");
                sqlConnectionParameters.AuthorizationType =
                    parser.GetPartByName("Integrated Security").ToLower() == "true"
                        ? MsSqlAuthorizationType.Windows
                        : MsSqlAuthorizationType.SqlServer;

                sqlConnectionParameters.UserName = parser.GetPartByName("User ID");
                sqlConnectionParameters.Password = parser.GetPartByName("Password");

                e.ConnectionParameters = sqlConnectionParameters;
            }
        }
    }
    
}
