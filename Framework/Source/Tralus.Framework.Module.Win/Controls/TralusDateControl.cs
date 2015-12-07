using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Calendar;
using Tralus.Framework.BusinessModel.Utility;
using NodaTime;

namespace Tralus.Framework.Module.Win.Controls
{
    public partial class TralusDateControl : UserControl
    {
        private List<BarButtonItem> calenderBarButtonItems;

        private TralusDate _selectedTralusDate;
        private EventHandler onValueChanged;
        private bool disableEvent;
        private bool isCalendarControlFilled = false;

        public TralusDateControl()
        {
            InitializeComponent();

            ShowGregorianCalendar();
            calenderBarButtonItems = new List<BarButtonItem>();

            Calendars = new Dictionary<string, Calendar>();
            Calendars["EN"] = new GregorianCalendar();
            Calendars["FA"] = TralusDateTime.AltCalendar;
        }

        public void Initialize()
        {
            foreach (var calendar in Calendars)
            {
                var barButtonItem = new BarButtonItem(barManager, calendar.Key) { Tag = calendar.Value };
                barManager.Items.Add(barButtonItem);
                barButtonItem.ItemClick += barButtonItemCalendar_ItemClick;
                popupMenuCalendar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(barButtonItem));
                calenderBarButtonItems.Add(barButtonItem);
            }
        }

        void barButtonItemCalendar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var caption = e.Item.Caption;
            var calendar = (Calendar)e.Item.Tag;
            SetCalendar(calendar, caption);
        }

        public string DefaultCalendar { get; set; }

        public Calendar SelectedCalendar { get; set; }

        public DateTimeZone CurrentObjectLocalDateTimeZone { get; set; }

        public Dictionary<string, Calendar> Calendars { get; set; }

        [Bindable(true, BindingDirection.TwoWay)]
        public TralusDate SelectedTralusDate
        {
            get { return _selectedTralusDate; }
            set
            {
                if (value == null)
                {
                    SelectedTralusDate = new TralusDate();
                }
                else
                {
                    _selectedTralusDate = value;
                    if (!isCalendarControlFilled)
                    {
                        Calendar calendar;
                        
                        if (string.IsNullOrWhiteSpace(DefaultCalendar))
                        {
                            calendar = TralusDateTime.AltCalendar;
                            DefaultCalendar = Calendars.First(v => v.Value == calendar).Key;
                        }
                        else
                        {
                            var isValidCalendar = Calendars.ContainsKey(DefaultCalendar);

                            if (isValidCalendar)
                            {
                                calendar = Calendars[DefaultCalendar];
                            }
                            else
                            {
                                throw new Exception(string.Format("Default Calendar: {0} is Invalid", DefaultCalendar));
                            }
                        }

                        SetCalendar(calendar, DefaultCalendar);


                        isCalendarControlFilled = true;
                    }

                    UpdateControlsValue();
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
            if (onValueChanged != null)
            {
                onValueChanged(this, e);
            }
        }

        public void ShowGregorianCalendar()
        {
            ShowPersianCalendarAndHideGregorianCalendar(false);
        }

        public void ShowPersianCalender()
        {
            ShowPersianCalendarAndHideGregorianCalendar(true);
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

        private void dateControl_EditValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                SelectedTralusDate.Date = (DateTime?)dateControl.EditValue;
                UpdateControlsValue();
                OnValueChanged(e);
            }
        }

        private void persianDateControl_ValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                SelectedTralusDate.Date = persianDateControl.Value;
                UpdateControlsValue();
                OnValueChanged(e);
            }
        }

        private void UpdateControlsValue()
        {
            disableEvent = true;


            var dateTime = SelectedTralusDate.Date;
            if (dateTime != null)
            {
                SetPersianDate(dateTime.Value);
                SetDate(dateTime.Value);
            }

            disableEvent = false;

        }
        private void SetPersianDate(DateTime? dateTime)
        {
            persianDateControl.Value = dateTime;
        }

        private void SetDate(DateTime? dateTime)
        {
            dateControl.EditValue = dateTime;
        }

        private void SetCalendar(Calendar calendar, string caption)
        {
            SelectedCalendar = calendar;
            dropDownButtonCalendar.Text = caption;

            if (SelectedCalendar.GetType() == typeof(PersianCalendar))
            {
                ShowPersianCalender();
            }
            else
            {
                ShowGregorianCalendar();
            }
        }
    }
}
