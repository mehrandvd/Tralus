using System;

namespace Tralus.Framework.Module.Win.Controls
{
    partial class TralusBaseDateControl
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
                this.tralusDateTimeBindingSource.CurrentItemChanged -= this.tralusDateTimeBindingSource_CurrentItemChanged;
                this.tralusDateTimeBindingSource.DataSourceChanged -= this.tralusDateTimeBindingSource_DataSourceChanged;
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.persianDateControl = new Tralus.Framework.Module.Win.Controls.BaseControl.PersianDateControl();
            this.tralusDateTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateControl = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tralusDateTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.persianDateControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dateControl, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(200, 21);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // persianDateControl
            // 
            this.persianDateControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tralusDateTimeBindingSource, "DateTimeUtc", true));
            this.persianDateControl.Location = new System.Drawing.Point(0, 0);
            this.persianDateControl.Margin = new System.Windows.Forms.Padding(0);
            this.persianDateControl.Name = "persianDateControl";
            this.persianDateControl.Size = new System.Drawing.Size(100, 21);
            this.persianDateControl.TabIndex = 0;
            this.persianDateControl.Value = null;
            // 
            // tralusDateTimeBindingSource
            // 
            this.tralusDateTimeBindingSource.DataSource = typeof(Tralus.Framework.BusinessModel.Utility.TralusDateTime);
            this.tralusDateTimeBindingSource.DataSourceChanged += new System.EventHandler(this.tralusDateTimeBindingSource_DataSourceChanged);
            // 
            // dateControl
            // 
            this.dateControl.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tralusDateTimeBindingSource, "DateTimeUtc", true));
            this.dateControl.EditValue = null;
            this.dateControl.Location = new System.Drawing.Point(100, 0);
            this.dateControl.Margin = new System.Windows.Forms.Padding(0);
            this.dateControl.Name = "dateControl";
            this.dateControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateControl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateControl.Size = new System.Drawing.Size(100, 20);
            this.dateControl.TabIndex = 1;
            // 
            // TralusBaseDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TralusBaseDateControl";
            this.Size = new System.Drawing.Size(200, 21);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tralusDateTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private BaseControl.PersianDateControl persianDateControl;
        private DevExpress.XtraEditors.DateEdit dateControl;
        private System.Windows.Forms.BindingSource tralusDateTimeBindingSource;
    }
}
