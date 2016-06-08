using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.EF;

namespace Tralus.Shell.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWindowControllertopic.
    public partial class AboutInfoController : ViewController
    {
        public AboutInfoController()
        {
            InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target Window.

            var connection = (ObjectSpace as EFObjectSpace)?.Connection;
            if (connection == null)
                return;

            var dataBase = ((System.Data.SqlClient.SqlConnection)((System.Data.Entity.Core.EntityClient.EntityConnection)connection).StoreConnection).Database;
            var dataSource = ((System.Data.SqlClient.SqlConnection)((System.Data.Entity.Core.EntityClient.EntityConnection)connection).StoreConnection).DataSource;
            
            AboutInfo.Instance.AboutInfoString = $"[{dataBase}]";

        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
