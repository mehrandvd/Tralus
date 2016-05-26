using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.EF;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class OrderedEntityViewController : ViewController
    {
        public OrderedEntityViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            TargetObjectType = typeof (IOrderedEntity);
        }

        DeleteObjectsViewController _deleteController;
        private NewObjectViewController _newObjectController;

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.

            _deleteController = Frame.GetController<DeleteObjectsViewController>();
            _deleteController.Deleting += DeleteController_Deleting;

            _newObjectController = Frame.GetController<NewObjectViewController>();

            var objectSpace = ObjectSpace as EFObjectSpace;
            if (objectSpace != null)
            {
                objectSpace.ObjectChanged += ObjectSpaceOnObjectChanged;
            }
        }

        private void ObjectSpaceOnObjectChanged(object sender, ObjectChangedEventArgs objectChangedEventArgs)
        {
            var newEntity = objectChangedEventArgs.Object as IOrderedEntity;
            
            if (newEntity?.RefList == null || newEntity?.RowNoProperty != default(int))
                return;

            var refList = newEntity.RefList.Cast<IOrderedEntity>().ToList();

            var newRowNo = refList.Any()
                ? refList.Max(o => o.RowNoProperty) + 1
                : 1;

            newEntity.SetRowNo(newRowNo);
        }

        private void DeleteController_Deleting(object sender, DeletingEventArgs e)
        {
            var toRemoveList =
                e.Objects.Cast<IOrderedEntity>()
                .OrderBy(o => o.RowNoProperty)
                .ToList();

            if (toRemoveList.Any())
            {
                var refList = toRemoveList.First().RefList.Cast<IOrderedEntity>();
                var orderedRefList =
                    refList
                    .OrderBy(o => o.RowNoProperty).ToList();

                var minToRemove = toRemoveList.First().RowNoProperty;
                var current = minToRemove;
                for (var i = minToRemove - 1; i < orderedRefList.Count(); i++)
                {
                    if (!toRemoveList.Contains(orderedRefList[i]))
                    {
                        orderedRefList[i].SetRowNo(current++);
                    }
                }
            }
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            _deleteController.Deleting -= DeleteController_Deleting;

        }

        private void simpleActionMoveUp_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var listView = View as ListView;
            if (listView == null)
                return;

            var toMoveList =
                e.SelectedObjects
                .Cast<IOrderedEntity>()
                .OrderBy(o => o.RowNoProperty)
                .ToList();

            if (toMoveList.Any())
            {
                var refList = toMoveList.First().RefList.Cast<IOrderedEntity>();
                var orderedRefList =
                    refList
                        .OrderBy(o => o.RowNoProperty)
                        .ToList();

                var minToMove = toMoveList.First().RowNoProperty;
                var maxToMove = toMoveList.Last().RowNoProperty;

                if (minToMove == 1)
                    return;

                if (maxToMove - minToMove + 1 != e.SelectedObjects.Count)
                    return;

                var current = minToMove - 1;
                orderedRefList[minToMove - 2].SetRowNo(maxToMove);

                for (var i = minToMove - 1; i < maxToMove; i++)
                {
                    orderedRefList[i].SetRowNo(current++);
                }

                listView.Editor.Refresh();
            }
        }

        private void simpleActionMoveDown_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var listView = View as ListView;
            if (listView == null)
                return;

            var toMoveList =
                e.SelectedObjects
                .Cast<IOrderedEntity>()
                .OrderBy(o => o.RowNoProperty)
                .ToList();

            if (toMoveList.Any())
            {
                var refList = toMoveList.First().RefList.Cast<IOrderedEntity>();

                var orderedRefList =
                    refList
                    .OrderBy(o => o.RowNoProperty)
                    .ToList();

                var minToMove = toMoveList.First().RowNoProperty;
                var maxToMove = toMoveList.Last().RowNoProperty;

                if (maxToMove == orderedRefList.Count)
                    return;

                if (maxToMove - minToMove + 1 != e.SelectedObjects.Count)
                    return;

                var current = minToMove + 1;
                orderedRefList[maxToMove].SetRowNo(minToMove);

                for (var i = minToMove - 1; i < maxToMove; i++)
                {
                    orderedRefList[i].SetRowNo(current++);
                }

                listView.Editor.Refresh();

            }
        }
    }
}
