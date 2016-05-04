namespace Selonia.Accounting.Module.Controllers
{
    partial class CustomizeDeleteVoucherItemViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleActionMoveUp = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.simpleActionMoveDown = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleActionMoveUp
            // 
            this.simpleActionMoveUp.ConfirmationMessage = null;
            this.simpleActionMoveUp.Id = "9c196eb5-09ac-449a-83b9-40fef517234c";
            this.simpleActionMoveUp.ImageName = "Action_Sorting_Ascending";
            this.simpleActionMoveUp.TargetObjectType = typeof(Selonia.Accounting.BusinessModel.Entities.VoucherItem);
            this.simpleActionMoveUp.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.simpleActionMoveUp.ToolTip = "Move Up";
            this.simpleActionMoveUp.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.simpleActionMoveUp.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionMoveUp_Execute);
            // 
            // simpleActionMoveDown
            // 
            this.simpleActionMoveDown.ConfirmationMessage = null;
            this.simpleActionMoveDown.Id = "17577085-d0c2-4ab9-8e64-0ac54542d4b6";
            this.simpleActionMoveDown.ImageName = "Action_Sorting_Descending";
            this.simpleActionMoveDown.TargetObjectType = typeof(Selonia.Accounting.BusinessModel.Entities.VoucherItem);
            this.simpleActionMoveDown.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.simpleActionMoveDown.ToolTip = "Move Down";
            this.simpleActionMoveDown.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.simpleActionMoveDown.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionMoveDown_Execute);
            // 
            // CustomizeDeleteVoucherItemViewController
            // 
            this.Actions.Add(this.simpleActionMoveUp);
            this.Actions.Add(this.simpleActionMoveDown);
            this.TargetObjectType = typeof(Selonia.Accounting.BusinessModel.Entities.VoucherItem);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionMoveUp;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionMoveDown;
    }
}
