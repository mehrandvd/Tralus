namespace Mahan.Stations.Module.Controllers
{
    partial class ReportViewListFilter
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
            this.popupWindowShowAction = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popupWindowShowAction
            // 
            this.popupWindowShowAction.AcceptButtonCaption = "Search";
            this.popupWindowShowAction.Caption = "Search";
            this.popupWindowShowAction.ConfirmationMessage = null;
            this.popupWindowShowAction.Id = "254c0f78-6fa3-44ae-884a-47cfaecdc401";
            this.popupWindowShowAction.ToolTip = null;
            this.popupWindowShowAction.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction_CustomizePopupWindowParams);
            this.popupWindowShowAction.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupWindowShowAction_Execute);
            this.popupWindowShowAction.Cancel += PopupWindowShowAction_Cancel;
            this.popupWindowShowAction.ExecuteCanceled += PopupWindowShowAction_ExecuteCanceled;
            // 
            // ReportViewListFilter
            // 
            this.Actions.Add(this.popupWindowShowAction);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction;
    }
}
