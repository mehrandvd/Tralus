namespace Tralus.Framework.Module.Controllers
{
    partial class OrderedEntityViewController
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
            this.simpleActionMoveUp.Caption = null;
            this.simpleActionMoveUp.ConfirmationMessage = null;
            this.simpleActionMoveUp.Id = "c520aaa6-5a87-4dcf-8502-9956a2c819d8";
            this.simpleActionMoveUp.ImageName = "Action_Sorting_Ascending";
            this.simpleActionMoveUp.ToolTip = null;
            this.simpleActionMoveUp.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionMoveUp_Execute);
            // 
            // simpleActionMoveDown
            // 
            this.simpleActionMoveDown.Caption = null;
            this.simpleActionMoveDown.ConfirmationMessage = null;
            this.simpleActionMoveDown.Id = "f2f15138-c1fb-46e4-8516-a603bbd3ca9a";
            this.simpleActionMoveDown.ImageName = "Action_Sorting_Descending";
            this.simpleActionMoveDown.ToolTip = null;
            this.simpleActionMoveDown.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionMoveDown_Execute);
            // 
            // OrderedEntityViewController
            // 
            this.Actions.Add(this.simpleActionMoveUp);
            this.Actions.Add(this.simpleActionMoveDown);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.ListView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionMoveUp;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionMoveDown;
    }
}
