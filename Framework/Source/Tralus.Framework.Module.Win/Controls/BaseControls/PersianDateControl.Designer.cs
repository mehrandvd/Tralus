namespace Tralus.Framework.Module.Win.Controls.BaseControl
{
    partial class PersianDateControl
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
            this.dateTimeSelector = new Atf.UI.DateTimeSelector();
            this.SuspendLayout();
            // 
            // dateTimeSelector
            // 
            this.dateTimeSelector.Location = new System.Drawing.Point(0, 0);
            this.dateTimeSelector.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeSelector.Name = "dateTimeSelector";
            this.dateTimeSelector.Size = new System.Drawing.Size(100, 21);
            this.dateTimeSelector.TabIndex = 0;
            this.dateTimeSelector.UsePersianFormat = true;
            this.dateTimeSelector.ValueChanged += new System.EventHandler(this.dateTimeSelector_ValueChanged);
            // 
            // PersianDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimeSelector);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersianDateControl";
            this.Size = new System.Drawing.Size(100, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Atf.UI.DateTimeSelector dateTimeSelector;
    }
}
