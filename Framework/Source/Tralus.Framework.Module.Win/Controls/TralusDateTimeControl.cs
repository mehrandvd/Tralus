using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Tralus.Framework.BusinessModel.Utility;
using NodaTime;

namespace Tralus.Framework.Module.Win.Controls
{
    public partial class TralusDateTimeControl : UserControl
    {
        private TralusDateTime _selectedTralusDateTime;
        private EventHandler onValueChanged;
        private string calendarName;
        private bool disableEvent = false;
        private List<BarButtonItem> calenderBarButtonItems;
        private List<BarButtonItem> timeZoneBarButtonItems;
        private bool isTimeZoneControlFilled = false;
        
        public TralusDateTimeControl()
        {
            InitializeComponent();
            ShowGregorianCalendar();
            calenderBarButtonItems = new List<BarButtonItem>();
            timeZoneBarButtonItems = new List<BarButtonItem>();

            Calendars = new Dictionary<string, Calendar>();
            Calendars["EN"] = new GregorianCalendar();
            Calendars["FA"] = TralusDateTime.AltCalendar;

            DateTimeZones = new Dictionary<string, DateTimeZone>();
        }

        public void Initialize()
        {
            foreach (var calendar in Calendars)
            {
                var barButtonItem = new BarButtonItem(barManager, calendar.Key) { Tag = calendar.Value };
                barManager.Items.Add(barButtonItem);
                barButtonItem.ItemClick += barButtonItemCalendar_ItemClick;
                popupCalendarMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(barButtonItem));
                calenderBarButtonItems.Add(barButtonItem);
            }
        }

        void barButtonItemTimeZone_ItemClick(object sender, ItemClickEventArgs e)
        {
            string caption = e.Item.Caption;
            var dateTimeZone = (DateTimeZone)e.Item.Tag;
            SetTimeZone(dateTimeZone, caption);
        }

        private void SetTimeZone(DateTimeZone dateTimeZone, string caption)
        {
            SelectedDateTimeZone = dateTimeZone;
            dropDownButtonTimeZone.Text = caption;
            UpdateControlsValue();
        }

        void barButtonItemCalendar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var caption = e.Item.Caption;
            var calendar = (Calendar)e.Item.Tag;
            SetCalendar(calendar, caption);
        }

        private void SetCalendar(Calendar calendar, string caption)
        {
            SelectedCalendar = calendar;
            dropDownButtonCalendar.Text = caption;

            if (SelectedCalendar.GetType() == typeof (PersianCalendar))
            {
                ShowPersianCalender();
            }
            else
            {
                ShowGregorianCalendar();
            }
        }

        public string DefaultCalendar { get; set; }
        public string DefaultTimeZone { get; set; }

        public Calendar SelectedCalendar { get; set; }

        public DateTimeZone CurrentObjectLocalDateTimeZone { get; set; }

        public Dictionary<string, Calendar> Calendars { get; set; }

        public Dictionary<string, DateTimeZone> DateTimeZones { get; set; }

        [Bindable(true, BindingDirection.TwoWay)]
        public TralusDateTime SelectedTralusDateTime
        {
            get { return _selectedTralusDateTime; }
            set
            {
                if (value == null)
                {
                    SelectedTralusDateTime = new TralusDateTime();
                }
                else
                {
                    _selectedTralusDateTime = value;
                    if (!isTimeZoneControlFilled)
                    {
                        DateTimeZones.Clear();
                        
                        DateTimeZones[_selectedTralusDateTime.LocalTimeZone.Id] = _selectedTralusDateTime.LocalTimeZone;
                        DateTimeZones[DateTimeZone.Utc.Id] = DateTimeZone.Utc;
                        DateTimeZones[TralusDateTime.HomeTimeZoneId] = TralusDateTime.HomeTimeZone;
                        
                        foreach (var dateTimeZone in DateTimeZones)
                        {
                            var barButtonItem = new BarButtonItem(barManager, dateTimeZone.Key) { Tag = dateTimeZone.Value };
                            barManager.Items.Add(barButtonItem);
                            barButtonItem.ItemClick += barButtonItemTimeZone_ItemClick;
                            popupTimeZoneMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(barButtonItem));
                            timeZoneBarButtonItems.Add(barButtonItem);
                        }

                        Calendar calendar;
                        DateTimeZone timeZone;
                        
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
                                throw new Exception(string.Format("Default Calendar: {0} is Invalid",DefaultCalendar));
                            }
                        }

                        if (string.IsNullOrWhiteSpace(DefaultTimeZone)){
                            timeZone = TralusDateTime.HomeTimeZone;
                            DefaultTimeZone = TralusDateTime.HomeTimeZoneId;
                        }
                        else
                        {
                            var isValidTimeZone = DateTimeZones.ContainsKey(DefaultTimeZone);

                            if (isValidTimeZone)
                            {
                                timeZone = DateTimeZones[DefaultTimeZone];
                            }
                            else
                            {
                                throw new Exception(string.Format("Default TimeZone {0} is Invalid", DefaultTimeZone));
                            }    
                        }

                        SetCalendar(calendar, DefaultCalendar);
                        SetTimeZone(timeZone, DefaultTimeZone);

                        isTimeZoneControlFilled = true;
                    }

                    UpdateControlsValue();
                }
            }
        }

        public DateTimeZone SelectedDateTimeZone { get; set; }

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

        private void timeEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var convertedDateTime = ConverteToUtc(timeControl.Time);
                SelectedTralusDateTime.DateTimeUtc = convertedDateTime;
                UpdateControlsValue();
                OnValueChanged(e);
            }
        }

        private void dateControl_EditValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var convertedDateTime = ConverteToUtc((DateTime?)dateControl.EditValue);
                SelectedTralusDateTime.DateTimeUtc = convertedDateTime;
                UpdateControlsValue();
                OnValueChanged(e);
            }
        }

        private void persianDateControl_ValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var convertedDateTime = ConverteToUtc(persianDateControl.Value);
                SelectedTralusDateTime.DateTimeUtc = convertedDateTime;
                UpdateControlsValue();
                OnValueChanged(e);
            }
        }

        private DateTime? ConverteToUtc(DateTime? dateTime)
        {
            
            if (dateTime.HasValue)
            {
                var dt = dateTime.Value;
                var localDateTime = new LocalDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);

                var zonedDateTime = SelectedDateTimeZone.ResolveLocal(localDateTime, mapping =>
                {
                    if (mapping.Count == 1)
                        return mapping.First();
                    throw new Exception("Ambigious time conversion.");
                });

                return zonedDateTime.ToDateTimeUtc();
            }
            else
            {
                return null;
            }
        }

        private void UpdateControlsValue()
        {
            disableEvent = true;

            var timeZone = SelectedDateTimeZone;
            //var dateTime = SelectedTralusDateTime.DateTimeUtc;

            DateTime? convertedDate = null;
            if (SelectedTralusDateTime.Instant.HasValue && timeZone != null)
            {
                convertedDate =
                    new ZonedDateTime(SelectedTralusDateTime.Instant.Value, timeZone).ToDateTimeUnspecified();


                //TimeZoneInfo.ConvertTime(dateTime.Value,
                //timeZone == DateTimeZone.Utc
                //    ? TimeZoneInfo.Utc
                //    : TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time"));
            }

            SetPersianDate(convertedDate);
            SetDate(convertedDate);
            SetTime(convertedDate);


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

        private void SetTime(DateTime? dateTime)
        {
            timeControl.EditValue = dateTime;
        }
    }
}
