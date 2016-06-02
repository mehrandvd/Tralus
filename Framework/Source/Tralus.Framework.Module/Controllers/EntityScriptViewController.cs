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
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Utility;

namespace Tralus.Framework.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class EntityScriptViewController : ViewController
    {
        public EntityScriptViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        private NewObjectViewController _newObjectViewController;


        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.

            _newObjectViewController = Frame.GetController<NewObjectViewController>();
            
            if (_newObjectViewController != null)
                _newObjectViewController.ObjectCreated += _newObjectViewController_ObjectCreated;

            ObjectSpace.ObjectSaving += ObjectSpace_ObjectSaving;
            ObjectSpace.ObjectSaved += ObjectSpace_ObjectSaved;
            ObjectSpace.ObjectDeleting += ObjectSpaceOnObjectDeleting;
            ObjectSpace.ObjectDeleted += ObjectSpaceOnObjectDeleted;
            ObjectSpace.ObjectChanged += ObjectSpace_ObjectChanged;
            ObjectSpace.ObjectEndEdit += ObjectSpace_ObjectEndEdit;
        }

        private void _newObjectViewController_ObjectCreated(object sender, ObjectCreatedEventArgs e)
        {
            EntityScriptUtil.RunScriptsFor(e.CreatedObject, WhenToRun.OnNew, e.ObjectSpace);
        }

        private void ObjectSpace_ObjectEndEdit(object sender, ObjectManipulatingEventArgs e)
        {
            EntityScriptUtil.RunScriptsFor(e.Object, WhenToRun.OnEndEdit, ObjectSpace);
        }

        private void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            EntityScriptUtil.RunScriptsFor(e.Object, WhenToRun.OnChanged, ObjectSpace);
        }

        private void ObjectSpace_ObjectSaved(object sender, ObjectManipulatingEventArgs e)
        {
            EntityScriptUtil.RunScriptsFor(e.Object, WhenToRun.OnSaved, ObjectSpace);
        }

        private void ObjectSpace_ObjectSaving(object sender, ObjectManipulatingEventArgs e)
        {
            EntityScriptUtil.RunScriptsFor(e.Object, WhenToRun.OnSaving, ObjectSpace);
        }

        private void ObjectSpaceOnObjectDeleting(object sender, ObjectsManipulatingEventArgs e)
        {
            foreach (var obj in e.Objects)
            {
                EntityScriptUtil.RunScriptsFor(obj, WhenToRun.OnDeleting, ObjectSpace);
            }
        }

        private void ObjectSpaceOnObjectDeleted(object sender, ObjectsManipulatingEventArgs e)
        {
            foreach (var obj in e.Objects)
            {
                EntityScriptUtil.RunScriptsFor(obj, WhenToRun.OnDeleted, ObjectSpace);
            }
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            ObjectSpace.ObjectSaving -= ObjectSpace_ObjectSaving;
            ObjectSpace.ObjectSaved -= ObjectSpace_ObjectSaved;
            ObjectSpace.ObjectDeleting -= ObjectSpaceOnObjectDeleting;
            ObjectSpace.ObjectDeleted -= ObjectSpaceOnObjectDeleted;
            // Unsubscribe from previously subscribed events and release other references and resources.

            if (_newObjectViewController != null)
                _newObjectViewController.ObjectCreated -= _newObjectViewController_ObjectCreated;
            base.OnDeactivated();
        }
    }
}
