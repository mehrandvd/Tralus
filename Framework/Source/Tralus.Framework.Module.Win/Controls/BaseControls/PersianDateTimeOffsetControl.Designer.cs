using System.Windows.Forms;

namespace Tralus.Framework.Module.Win.Controls.BaseControl
{
    partial class PersianDateTimeOffsetControl
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
                this.dateTimeSelector.ValueChanged -= this.dateTimeSelector_ValueChanged;
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
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItem();
            this.dateTimeSelector = new Atf.UI.DateTimeSelector();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Name = "fProperties";
            // 
            // dateTimeSelector
            // 
            this.dateTimeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeSelector.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeSelector.Name = "dateTimeSelector";
            this.dateTimeSelector.Size = new System.Drawing.Size(80, 22);
            this.dateTimeSelector.UsePersianFormat = true;
            this.dateTimeSelector.ValueChanged += new System.EventHandler(this.dateTimeSelector_ValueChanged);
            this.dateTimeSelector.RightToLeft = RightToLeft.No;
            this.dateTimeSelector.Format = Atf.UI.DateTimeSelectorFormat.Custom;
            this.dateTimeSelector.CustomFormat = "yyyy/MM/dd HH:mm";
            // 
            // PersianDateControl
            // 
            this.Controls.Add(this.dateTimeSelector);
            this.ClientSize = new System.Drawing.Size(80, 22);
            this.MinimumSize = new System.Drawing.Size(80, 22);
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Atf.UI.DateTimeSelector dateTimeSelector;
        private DevExpress.XtraEditors.Repository.RepositoryItem fProperties;
    }
}
