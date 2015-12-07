using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Utility;

namespace Tralus.Framework.Module.Win.Controls
{
    public partial class TralusBaseDateControl : UserControl
    {
        private TralusDate _selectedDate;
        private EventHandler onValueChanged;
        private bool _showGregorianCalendar;
        private bool _showPersianCalender;

        public TralusBaseDateControl()
        {
            InitializeComponent();
        }

        [Bindable(true)]
        public TralusDate SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                if (value != null)
                {
                    this.tralusDateTimeBindingSource.DataSource = value;
                }
                else
                {
                    SelectedDate = new TralusDate();
                }
            }
        }

        public event EventHandler ValueChanged
        {
            add
            {
                onValueChanged += value;
            }
            remove
            {
                onValueChanged -= value;
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {

            // Call the event handler
            if (onValueChanged != null)
            {
                onValueChanged(this, e);
            }
        }

        private void tralusDateTimeBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            OnValueChanged(e);
        }

        private void tralusDateTimeBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.tralusDateTimeBindingSource.CurrentItemChanged -= this.tralusDateTimeBindingSource_CurrentItemChanged;
            this.tralusDateTimeBindingSource.CurrentItemChanged += new System.EventHandler(this.tralusDateTimeBindingSource_CurrentItemChanged);
        }

        public bool ShowGregorianCalendar
        {
            get { return _showGregorianCalendar; }
            set
            {
                _showGregorianCalendar = value;
                ShowPersianCalendarAndHideGregorianCalendar(!value);
            }
        }

        public bool ShowPersianCalender
        {
            get { return _showPersianCalender; }
            set
            {
                _showPersianCalender = value;
                ShowPersianCalendarAndHideGregorianCalendar(value);
            }
        }

        private void ShowPersianCalendarAndHideGregorianCalendar(bool value)
        {
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
           
            SetPersianDateControlVisibility(value);
            SetDateControlVisibility(!value);
           
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void SetPersianDateControlVisibility(bool visibility)
        {
            persianDateControl.Visible = visibility;
        }

        private void SetDateControlVisibility(bool visibility)
        {
            dateControl.Visible = visibility;
            
        }

    }
}
