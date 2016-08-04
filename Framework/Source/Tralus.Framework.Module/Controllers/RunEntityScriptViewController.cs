//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DevExpress.Data.Filtering;
//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Actions;
//using DevExpress.ExpressApp.Editors;
//using DevExpress.ExpressApp.Layout;
//using DevExpress.ExpressApp.Model.NodeGenerators;
//using DevExpress.ExpressApp.SystemModule;
//using DevExpress.ExpressApp.Templates;
//using DevExpress.ExpressApp.Utils;
//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.Validation;
//using Tralus.Framework.BusinessModel.Entities;
//using Tralus.Framework.Module.Utility;

//namespace Tralus.Framework.Module.Controllers
//{
//    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
//    public partial class RunEntityScriptViewController : ViewController
//    {
//        public RunEntityScriptViewController()
//        {
//            InitializeComponent();
//            // Target required Views (via the TargetXXX properties) and create their Actions.
//        }
//        protected override void OnActivated()
//        {
//            base.OnActivated();
//            // Perform various tasks depending on the target View.
//        }
//        protected override void OnViewControlsCreated()
//        {
//            base.OnViewControlsCreated();
//            // Access and customize the target View control.
//        }
//        protected override void OnDeactivated()
//        {
//            // Unsubscribe from previously subscribed events and release other references and resources.
//            base.OnDeactivated();
//        }

//        private void RunEntityScriptAction_Execute(object sender, SimpleActionExecuteEventArgs e)
//        {
//            var entities = new List<EntityBase>();
//            if (e.SelectedObjects != null)
//                entities.AddRange(e.SelectedObjects.Cast<EntityBase>());
//            else
//            {
//                entities.Add((EntityBase) e.CurrentObject);
//            }

//            if (!entities.Any())
//                return;

//            var targetType = ObjectSpace.GetObjectType(entities.First());

//            foreach (var entity in entities)
//            {
//                var scripts = EntityScriptUtil.GetScriptsFor(targetType);

//                if (scripts != null)
//                {
//                    foreach (var entityScript in scripts)
//                    {
//                        EntityScriptUtil.Run(entityScript, entity, ObjectSpace);
//                    }
//                }
//            }

            
//        }
//    }
//}
