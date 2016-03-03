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

namespace Tralus.Shell.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWindowControllertopic.
    public partial class CurrentUserWindowController : WindowController
    {
        private SimpleAction currentUserSimpleAction;
        public CurrentUserWindowController()
        {
            InitializeComponent();
            var userName = SecuritySystem.CurrentUserName;

            this.currentUserSimpleAction = new SimpleAction((Controller)this, "CurrentUserWindowController", "Security");
            this.currentUserSimpleAction.ImageName = "BO_MyDetails";
            this.currentUserSimpleAction.ToolTip = "Current User";

            this.TargetWindowType = WindowType.Main;

            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            currentUserSimpleAction.Caption = SecuritySystem.CurrentUserName;
            // Perform various tasks depending on the target Window.
        }



        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
