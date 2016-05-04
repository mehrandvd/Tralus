using System;
using System.Collections;
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
using Selonia.Accounting.BusinessModel.Entities;

namespace Selonia.Accounting.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CustomizeDeleteVoucherItemViewController : ViewController
    {
        public CustomizeDeleteVoucherItemViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        DeleteObjectsViewController deleteController;

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            
            deleteController = Frame.GetController<DeleteObjectsViewController>();
            deleteController.Deleting += DeleteController_Deleting;
        }

        private void DeleteController_Deleting(object sender, DeletingEventArgs e)
        {
            var toRemoveList = 
                e.Objects.Cast<VoucherItem>()
                .OrderBy(o=>o.RowNo)
                .ToList();

            if (toRemoveList.Any())
            {
                var voucher = toRemoveList.First().Voucher;
                var voucherItems = 
                    voucher.VoucherItems
                    .OrderBy(o => o.RowNo).ToList();

                var minToRemove = toRemoveList.First().RowNo;
                var current = minToRemove;
                for (var i = minToRemove - 1; i < voucherItems.Count(); i++)
                {
                    if (!toRemoveList.Contains(voucherItems[i]))
                    {
                        voucherItems[i].SetRowNo(current++);
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
            deleteController.Deleting -= DeleteController_Deleting;
        }

        private void simpleActionMoveUp_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var listView = View as ListView;
            if (listView == null)
                return;

            var toMoveList =
                e.SelectedObjects
                .Cast<VoucherItem>()
                .OrderBy(o => o.RowNo)
                .ToList();

            if (toMoveList.Any())
            {
                var voucher = toMoveList.First().Voucher;
                var voucherItems =
                    voucher.VoucherItems
                        .OrderBy(o => o.RowNo)
                        .ToList();

                var minToMove = toMoveList.First().RowNo;
                var maxToMove = toMoveList.Last().RowNo;

                if (minToMove == 1)
                    return;

                if (maxToMove - minToMove + 1 != e.SelectedObjects.Count)
                    return;

                var current = minToMove - 1;
                voucherItems[minToMove - 2].SetRowNo(maxToMove);

                for (var i = minToMove - 1; i < maxToMove; i++)
                {
                    voucherItems[i].SetRowNo(current++);
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
                .Cast<VoucherItem>()
                .OrderBy(o => o.RowNo)
                .ToList();

            if (toMoveList.Any())
            {
                

                var voucher = toMoveList.First().Voucher;
                var voucherItems =
                    voucher.VoucherItems
                    .OrderBy(o => o.RowNo)
                    .ToList();

                var minToMove = toMoveList.First().RowNo;
                var maxToMove = toMoveList.Last().RowNo;

                if (maxToMove == voucherItems.Count)
                    return;

                if (maxToMove - minToMove + 1 != e.SelectedObjects.Count)
                    return;

                var current = minToMove + 1;
                voucherItems[maxToMove].SetRowNo(minToMove);

                for (var i = minToMove - 1; i < maxToMove; i++)
                {
                    voucherItems[i].SetRowNo(current++);
                }

                listView.Editor.Refresh();

            }
        }
    }
}
