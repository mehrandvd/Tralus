namespace Tralus.Framework.Module.Win.Controls
{
    partial class TralusDateControl
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
                this.persianDateControl.ValueChanged -= this.persianDateControl_ValueChanged;
                this.dateControl.EditValueChanged -= this.dateControl_EditValueChanged;
                
                foreach (var calendarBarButtonItem in calenderBarButtonItems)
                {
                    calendarBarButtonItem.ItemClick -= barButtonItemCalendar_ItemClick;
                }

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
            this.dateControl = new DevExpress.XtraEditors.DateEdit();
            this.dropDownButtonCalendar = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuCalendar = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel.Controls.Add(this.persianDateControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dateControl, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.dropDownButtonCalendar, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(262, 24);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // persianDateControl
            // 
            this.persianDateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persianDateControl.Location = new System.Drawing.Point(48, 1);
            this.persianDateControl.Margin = new System.Windows.Forms.Padding(1);
            this.persianDateControl.Name = "persianDateControl";
            this.barManager.SetPopupContextMenu(this.persianDateControl, this.popupMenuCalendar);
            this.persianDateControl.Size = new System.Drawing.Size(100, 20);
            this.persianDateControl.TabIndex = 0;
            this.persianDateControl.Value = null;
            this.persianDateControl.ValueChanged += new System.EventHandler(this.persianDateControl_ValueChanged);
            // 
            // dateControl
            // 
            this.dateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateControl.EditValue = null;
            this.dateControl.Location = new System.Drawing.Point(150, 1);
            this.dateControl.Margin = new System.Windows.Forms.Padding(1);
            this.dateControl.Name = "dateControl";
            this.dateControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateControl.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateControl.Size = new System.Drawing.Size(111, 20);
            this.dateControl.TabIndex = 1;
            this.dateControl.EditValueChanged += new System.EventHandler(this.dateControl_EditValueChanged);
            // 
            // dropDownButtonCalendar
            // 
            this.dropDownButtonCalendar.DropDownControl = this.popupMenuCalendar;
            this.dropDownButtonCalendar.Location = new System.Drawing.Point(1, 1);
            this.dropDownButtonCalendar.Margin = new System.Windows.Forms.Padding(1);
            this.dropDownButtonCalendar.Name = "dropDownButtonCalendar";
            this.dropDownButtonCalendar.Size = new System.Drawing.Size(45, 20);
            this.dropDownButtonCalendar.TabIndex = 5;
            // 
            // popupMenuCalendar
            // 
            this.popupMenuCalendar.Manager = this.barManager;
            this.popupMenuCalendar.Name = "popupMenuCalendar";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(262, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 24);
            this.barDockControlBottom.Size = new System.Drawing.Size(262, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 24);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(262, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 24);
            // 
            // TralusDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TralusDateControl";
            this.Size = new System.Drawing.Size(262, 24);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private BaseControl.PersianDateControl persianDateControl;
        private DevExpress.XtraEditors.DateEdit dateControl;
        private DevExpress.XtraEditors.DropDownButton dropDownButtonCalendar;
        private DevExpress.XtraBars.PopupMenu popupMenuCalendar;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}
