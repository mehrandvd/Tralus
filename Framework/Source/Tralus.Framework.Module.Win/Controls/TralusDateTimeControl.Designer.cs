using DevExpress.XtraBars;

namespace Tralus.Framework.Module.Win.Controls
{
    partial class TralusDateTimeControl
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
                this.timeControl.EditValueChanged -= this.timeEdit_EditValueChanged;
                
                foreach (var calendarBarButtonItem in calenderBarButtonItems)
                {
                    calendarBarButtonItem.ItemClick -= barButtonItemCalendar_ItemClick;
                }

                foreach (var timeZoneBarButtonItem in timeZoneBarButtonItems)
                {
                    timeZoneBarButtonItem.ItemClick -= barButtonItemTimeZone_ItemClick;
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
            this.dropDownButtonTimeZone = new DevExpress.XtraEditors.DropDownButton();
            this.popupTimeZoneMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.timeControl = new DevExpress.XtraEditors.TimeEdit();
            this.dropDownButtonCalendar = new DevExpress.XtraEditors.DropDownButton();
            this.popupCalendarMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupTimeZoneMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCalendarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.persianDateControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dateControl, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.dropDownButtonTimeZone, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.timeControl, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.dropDownButtonCalendar, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(403, 24);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // persianDateControl
            // 
            this.persianDateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persianDateControl.Location = new System.Drawing.Point(48, 1);
            this.persianDateControl.Margin = new System.Windows.Forms.Padding(1);
            this.persianDateControl.Name = "persianDateControl";
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
            this.dateControl.Size = new System.Drawing.Size(100, 20);
            this.dateControl.TabIndex = 1;
            this.dateControl.EditValueChanged += new System.EventHandler(this.dateControl_EditValueChanged);
            // 
            // dropDownButtonTimeZone
            // 
            this.dropDownButtonTimeZone.DropDownControl = this.popupTimeZoneMenu;
            this.dropDownButtonTimeZone.Location = new System.Drawing.Point(354, 1);
            this.dropDownButtonTimeZone.Margin = new System.Windows.Forms.Padding(1);
            this.dropDownButtonTimeZone.Name = "dropDownButtonTimeZone";
            this.dropDownButtonTimeZone.Size = new System.Drawing.Size(45, 20);
            this.dropDownButtonTimeZone.TabIndex = 3;
            // 
            // popupTimeZoneMenu
            // 
            this.popupTimeZoneMenu.Manager = this.barManager;
            this.popupTimeZoneMenu.Name = "popupTimeZoneMenu";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager.MaxItemId = 8;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(403, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 24);
            this.barDockControlBottom.Size = new System.Drawing.Size(403, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(403, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 24);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // timeControl
            // 
            this.timeControl.EditValue = null;
            this.timeControl.Location = new System.Drawing.Point(252, 1);
            this.timeControl.Margin = new System.Windows.Forms.Padding(1);
            this.timeControl.Name = "timeControl";
            this.timeControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeControl.Size = new System.Drawing.Size(100, 20);
            this.timeControl.TabIndex = 4;
            this.timeControl.EditValueChanged += new System.EventHandler(this.timeEdit_EditValueChanged);
            // 
            // dropDownButtonCalendar
            // 
            this.dropDownButtonCalendar.DropDownControl = this.popupCalendarMenu;
            this.dropDownButtonCalendar.Location = new System.Drawing.Point(1, 1);
            this.dropDownButtonCalendar.Margin = new System.Windows.Forms.Padding(1);
            this.dropDownButtonCalendar.Name = "dropDownButtonCalendar";
            this.dropDownButtonCalendar.Size = new System.Drawing.Size(45, 20);
            this.dropDownButtonCalendar.TabIndex = 5;
            // 
            // popupCalendarMenu
            // 
            this.popupCalendarMenu.Manager = this.barManager;
            this.popupCalendarMenu.Name = "popupCalendarMenu";
            // 
            // TralusDateTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TralusDateTimeControl";
            this.Size = new System.Drawing.Size(403, 24);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupTimeZoneMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCalendarMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private BaseControl.PersianDateControl persianDateControl;
        private DevExpress.XtraEditors.DateEdit dateControl;
        private DevExpress.XtraEditors.DropDownButton dropDownButtonTimeZone;
        //private System.Windows.Forms.BindingSource tralusDateTimeBindingSource;
        private DevExpress.XtraBars.PopupMenu popupTimeZoneMenu;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TimeEdit timeControl;
        private DevExpress.XtraEditors.DropDownButton dropDownButtonCalendar;
        private DevExpress.XtraBars.PopupMenu popupCalendarMenu;
        private BarButtonItem barButtonItem1;

    }
}
