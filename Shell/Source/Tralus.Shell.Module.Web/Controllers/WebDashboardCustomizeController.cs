using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Dashboards.Web;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.DB.Helpers;

namespace Tralus.Shell.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class WebDashboardCustomizeController : ViewController<DetailView>
    {
        public WebDashboardCustomizeController()
        {
            TargetObjectType = typeof(IDashboardData);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            WebDashboardViewerViewItem dashboardViewerViewItem = View.FindItem("DashboardViewer") as WebDashboardViewerViewItem;
            if (dashboardViewerViewItem != null)
            {
                dashboardViewerViewItem.ControlCreated += DashboardViewerViewItem_ControlCreated;
            }
        }
        private void DashboardViewerViewItem_ControlCreated(object sender, EventArgs e)
        {
            WebDashboardViewerViewItem dashboardViewerViewItem = sender as WebDashboardViewerViewItem;
            dashboardViewerViewItem.DashboardDesigner.Height = 760;
            dashboardViewerViewItem.DashboardDesigner.ConfigureDataConnection += DashboardDesigner_ConfigureDataConnection;
            //You can prevent setting direct Database connections using the following commented code in versions prior to 16.2.6. In the next versions, use the DashboardsModule.HideDirectDataSourceConnections property.
            //dashboardViewerViewItem.DashboardDesigner.ClientSideEvents.BeforeRender = "function onBeforeRender(s, e) { s.dashboardDesigner.unregisterExtension('dxdde-data-source-wizard'); }";
        }
        private void DashboardDesigner_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
        {
            // ToDo: Complete the connection string resolving process. 2F4D197A-9BF1-4DEE-A1DC-52447F969889
            // Detail link: https://www.devexpress.com/Support/Center/Question/Details/T473885

            SetupConnectionString(e);
        }
        protected override void OnDeactivated()
        {
            WebDashboardViewerViewItem dashboardViewerViewItem = View.FindItem("DashboardViewer") as WebDashboardViewerViewItem;
            if (dashboardViewerViewItem != null)
            {
                dashboardViewerViewItem.ControlCreated -= DashboardViewerViewItem_ControlCreated;
            }
            base.OnDeactivated();
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
                sqlConnectionParameters.ServerName = parser.GetPartByName("Data Source");
                sqlConnectionParameters.DatabaseName = parser.GetPartByName("Initial Catalog");
                sqlConnectionParameters.AuthorizationType =
                    parser.GetPartByName("Integrated Security").ToLower() == "true"
                        ? MsSqlAuthorizationType.Windows
                        : MsSqlAuthorizationType.SqlServer;

                sqlConnectionParameters.UserName = parser.GetPartByName("User ID");
                sqlConnectionParameters.Password = "Password";

                e.ConnectionParameters = sqlConnectionParameters;
            }
        }
    }


}
