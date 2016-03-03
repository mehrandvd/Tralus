using System;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors;
using Tralus.Framework.BusinessModel.Utility;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.ExpressApp.Model;
using NodaTime;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Tralus.Framework.Module.Web.Editors
{
    [PropertyEditor(typeof(TralusDateTime), true)]
    public class TralusDateTimeEditor : ASPxPropertyEditor
    {
        private DevExpress.Web.ASPxTextBox datePickerGregorian;
        private DevExpress.Web.ASPxTextBox datePickerPersian;
        private DevExpress.Web.ASPxTextBox clockPicker;
        private DevExpress.Web.ASPxComboBox comboBoxTimeZone;
        private DevExpress.Web.ASPxComboBox comboBoxCalendar;
        private const string cpUTCTime = "cpUTC";
        private const string cpLocalTime = "cpTHR";

        public TralusDateTimeEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model)
        {

        }

        public System.Globalization.Calendar SelectedCalendar
        {
            get
            {
                if (comboBoxCalendar != null && comboBoxCalendar.SelectedItem != null)
                {
                    return Calendars[comboBoxCalendar.SelectedItem.Text];
                }

                return null;
            }
        }

        public DateTimeZone SelectedDateTimeZone
        {
            get
            {
                if (comboBoxTimeZone != null && comboBoxTimeZone.SelectedItem != null)
                {
                    return DateTimeZones[comboBoxTimeZone.SelectedItem.Text];
                }

                return null;
            }
        }

        public Dictionary<string, System.Globalization.Calendar> Calendars { get; set; }
        public Dictionary<string, DateTimeZone> DateTimeZones { get; set; }
        public TralusDateTime SelectedTralusDateTime
        {
            get
            {
                return (TralusDateTime)PropertyValue;
            }
            set
            {
                PropertyValue = value;
            }
        }

        protected override WebControl CreateViewModeControlCore()
        {
            return new Label();
        }

        protected override WebControl CreateEditModeControlCore()
        {
            //$('#Vertical_v1_50539512_MainLayoutEdit_xaf_l19_PersianDatePickerScheduledOnDateTime_I').data('datepicker').getDate()

            Calendars = new Dictionary<string, System.Globalization.Calendar>();
            Calendars["EN"] = new GregorianCalendar();
            Calendars["FA"] = TralusDateTime.AltCalendar;
            DateTimeZones = new Dictionary<string, DateTimeZone>();
            DateTimeZones["UTC"] = DateTimeZone.Utc;
            DateTimeZones["THR"] = TralusDateTime.HomeTimeZone;

            var datePickePersianrId = string.Format("DatePickerPersian{0}", PropertyName);
            var datePickerGregorianId = string.Format("DatePickerGregorian{0}", PropertyName);
            var clockPickerId = string.Format("ClockPicker{0}", propertyName);
            var comboBoxCalendarId = string.Format("ComboBoxCalendar{0}", propertyName);
            var comboBoxTimeZoneId = string.Format("ComboBoxTimeZone{0}", propertyName);
            var gregorianGotFocusGuid = System.Guid.NewGuid().ToString();
            var gregorianGotFocusValueChangedGuid = System.Guid.NewGuid().ToString();
            var persianGotFocusGuid = System.Guid.NewGuid().ToString();
            var persianGotValueChangedGuid = System.Guid.NewGuid().ToString();
            var clockPickerGotFocusGuid = System.Guid.NewGuid().ToString();
            var clockPickerGotValueChangedGuid = System.Guid.NewGuid().ToString();

            datePickerGregorian = RenderHelper.CreateASPxTextBox();
            datePickerGregorian.ID = datePickerGregorianId;
            datePickerGregorian.Validation += TralusDateTimeControlGregorian_Validation;
            datePickerGregorian.ValidationSettings.EnableCustomValidation = true;
            datePickerGregorian.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Enabled;
            datePickerGregorian.ValidationSettings.ValidateOnLeave = true;
            datePickerGregorian.CssClass = "input-date-picker datepicker-ltr";
            datePickerGregorian.SetClientSideEventHandler("GotFocus", string.Format(" /*{0}*/ function(s, e) {{ document.isMenuClicked = false; }} /*{0}*/", gregorianGotFocusGuid));
            datePickerGregorian.SetClientSideEventHandler("ValueChanged", string.Format(" /*{0}*/ function(s,e) {{ window.setTimeout(function() {{ if(!document.isMenuClicked) {{ RaiseXafCallback(globalCallbackControl, '', '', '', false); }}document.isMenuClicked = false;}}, 500); }} /*{0}*/", gregorianGotFocusValueChangedGuid));
            datePickerGregorian.ClientSideEvents.Init = string.Format("function Init(s,e) {{  jQuery('[name$={0}]').datepicker({{ autoclose: true, language: 'en', rtl: false, weekStart: 1, calendar: 'gregorian', todayBtn: true, format:'yyyy/mm/dd' }});  function {1}GregorianCalendarViewModel () {{  {0} = ko.computed( function() {{  return s['cp' + {1}SelectedTimeZone()]; }} ); }}; var input = s.GetInputElement(); $(input).attr('data-bind', 'value: {0}');  ko.applyBindings(new {1}GregorianCalendarViewModel(),input); }}", datePickerGregorianId, PropertyName);


            datePickerPersian = RenderHelper.CreateASPxTextBox();
            datePickerPersian.ID = datePickePersianrId;
            datePickerPersian.Validation += TralusDateTimeControlPersian_Validation;
            datePickerPersian.ValidationSettings.EnableCustomValidation = true;
            datePickerPersian.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Enabled;
            datePickerPersian.ValidationSettings.ValidateOnLeave = true;
            datePickerPersian.CssClass = "input-date-picker datepicker-rtl";
            datePickerPersian.SetClientSideEventHandler("GotFocus", string.Format("/*{0}*/ function(s, e) {{document.isMenuClicked = false; }} /*{0}*/", persianGotFocusGuid));
            datePickerPersian.SetClientSideEventHandler("ValueChanged", string.Format(" /*{0}*/ function(s,e) {{ var selectedDate = $('#'+s.GetInputElement().id).data('datepicker').getDate(); window.setTimeout(function() {{  if(!document.isMenuClicked) {{ RaiseXafCallback(globalCallbackControl, '', selectedDate, '', false); }} document.isMenuClicked = false;}}, 500); }} /*{0}*/", persianGotValueChangedGuid));
            datePickerPersian.ClientSideEvents.Init = string.Format("function Init(s,e) {{  jQuery('[name$={0}]').datepicker({{ autoclose: true, language: 'fa', rtl: false, weekStart: 1, calendar: 'persian', todayBtn: true, format:'yyyy/mm/dd' }});  function {1}PersianCalendarViewModel () {{  {0} = ko.computed( function() {{  return s['cp' + {1}SelectedTimeZone()]; }} ); }}; var input = s.GetInputElement(); $(input).attr('data-bind', 'value: {0}');  ko.applyBindings(new {1}PersianCalendarViewModel(),input); }}", datePickePersianrId, PropertyName);


            clockPicker = RenderHelper.CreateASPxTextBox();
            clockPicker.ID = clockPickerId;
            clockPicker.Validation += clockPicker_Validation;
            clockPicker.ValidationSettings.EnableCustomValidation = true;
            clockPicker.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Enabled;
            clockPicker.ValidationSettings.ValidateOnLeave = true;
            clockPicker.SetClientSideEventHandler("GotFocus", string.Format("/*{0}*/ function(s, e) {{document.isMenuClicked = false; }} /*{0}*/", clockPickerGotFocusGuid));
            clockPicker.SetClientSideEventHandler("ValueChanged", string.Format(" /*{0}*/ function(s,e) {{ window.setTimeout(function() {{ if(!document.isMenuClicked) {{ RaiseXafCallback(globalCallbackControl, '', '', '', false); }} document.isMenuClicked = false;}}, 500); }} /*{0}*/", clockPickerGotValueChangedGuid));
            clockPicker.ClientSideEvents.Init = string.Format("function OnInit(s,e){{ jQuery('[name$={0}]').clockpicker(); function {1}ClockViewModel() {{  {0} =  ko.computed(function() {{  return s['cp' + {1}SelectedTimeZone()];  }})  }}; var input = s.GetInputElement(); $(input).attr('data-bind', 'value: {0}');  ko.applyBindings(new {1}ClockViewModel(),input);}}", clockPickerId, PropertyName);

            comboBoxCalendar = RenderHelper.CreateASPxComboBox();
            comboBoxCalendar.ID = comboBoxCalendarId;
            comboBoxCalendar.Items.Add("EN", "EN");
            comboBoxCalendar.Items.Add("FA", "FA");
            comboBoxCalendar.SelectedIndex = 0;
            comboBoxCalendar.ClientSideEvents.SelectedIndexChanged = string.Format("function(combo) {{  {0}SelectedCalendar(combo.lastSuccessValue); }}", PropertyName);
            comboBoxCalendar.ClientSideEvents.Init = string.Format("function OnInit(s,e){{  {0}SelectedCalendar(s.lastSuccessValue); }}", PropertyName);

            comboBoxTimeZone = RenderHelper.CreateASPxComboBox();
            comboBoxTimeZone.ID = comboBoxTimeZoneId;
            comboBoxTimeZone.Items.Add("UTC", "UTC");
            comboBoxTimeZone.Items.Add("THR", "THR");
            comboBoxTimeZone.SelectedIndex = 0;
            comboBoxTimeZone.ClientSideEvents.SelectedIndexChanged = string.Format("function(combo) {{ {0}SelectedTimeZone(combo.lastSuccessValue); }}", PropertyName);
            comboBoxTimeZone.ClientSideEvents.Init = string.Format("function Init(s,e){{ {0}SelectedTimeZone(s.lastSuccessValue); }}", PropertyName);

            var table = RenderHelper.CreateTable();
            var row = new TableRow();

            var tableCellDatePickerPersian = new TableCell();
            var tableCellDatePickerGregorian = new TableCell();
            var tableCellClockPicker = new TableCell();
            var tableCellComboBoxCalendar = new TableCell();
            var tableCellComboBoxTimeZone = new TableCell();

            tableCellDatePickerPersian.Controls.Add(datePickerPersian);
            tableCellDatePickerPersian.Attributes.Add("data-bind", string.Format("visible: {0}SelectedCalendar() === 'FA'", PropertyName));

            tableCellDatePickerGregorian.Controls.Add(datePickerGregorian);
            tableCellDatePickerGregorian.Attributes.Add("data-bind", string.Format("visible: {0}SelectedCalendar() === 'EN'", PropertyName));

            tableCellClockPicker.Controls.Add(clockPicker);

            tableCellComboBoxCalendar.Controls.Add(comboBoxCalendar);

            tableCellComboBoxTimeZone.Controls.Add(comboBoxTimeZone);

            var selectedModelContainer = RenderHelper.CreateASPxTextBox();

            selectedModelContainer.ClientSideEvents.Init = string.Format("function OnInit(s,e){{   function {0}DateTimeViewModel () {{ {0}SelectedTimeZone =  ko.observable(); {0}SelectedCalendar = ko.observable('EN');   }}; var input = s.GetInputElement(); ko.applyBindings(new {0}DateTimeViewModel(),input); ko.applyBindings({{}},jQuery('div[id*={0}]')[0]); }}", PropertyName);

            var tableCellSelectedModelContainer = new TableCell();
            tableCellSelectedModelContainer.Controls.Add(selectedModelContainer);
            tableCellSelectedModelContainer.Style.Add("display", "none");

            row.Cells.Add(tableCellSelectedModelContainer);
            row.Cells.Add(tableCellComboBoxCalendar);
            row.Cells.Add(tableCellDatePickerPersian);
            row.Cells.Add(tableCellDatePickerGregorian);
            row.Cells.Add(tableCellClockPicker);
            row.Cells.Add(tableCellComboBoxTimeZone);

            table.Rows.Add(row);

            table.Style.Add("width", "auto");
            table.Style.Add("border-spacing", "1px");

            UpdateControlsValue();

            return table;
        }

        protected override object GetControlValueCore()
        {
            return SelectedTralusDateTime;
        }

        private void UpdateControlsValue()
        {
            var timeZone = SelectedDateTimeZone;

            DateTime? selectedCalendarAndTimeZone = null;
            if (SelectedTralusDateTime != null && SelectedTralusDateTime.Instant.HasValue && timeZone != null)
            {
                selectedCalendarAndTimeZone =
                    new ZonedDateTime(SelectedTralusDateTime.Instant.Value, timeZone).ToDateTimeUnspecified();

                clockPicker.JSProperties[cpLocalTime] = SelectedTralusDateTime.DateTimeLocal.Value.ToString("HH:mm");
                clockPicker.JSProperties[cpUTCTime] = SelectedTralusDateTime.DateTimeUtc.Value.ToString("HH:mm");

                foreach (var dateTimeZone in DateTimeZones)
                {
                    var dateTimeInZone = new ZonedDateTime(SelectedTralusDateTime.Instant.Value, dateTimeZone.Value).ToDateTimeUnspecified();

                    foreach (var calendar in Calendars)
                    {
                        var dateInCalendar = GetDateInCalendar(calendar.Value, dateTimeInZone);
                        var keyName = string.Format("cp{0}", dateTimeZone.Key);

                        if (calendar.Value.GetType() == typeof(PersianCalendar))
                        {
                            datePickerPersian.JSProperties[keyName] = dateInCalendar;
                        }
                        else
                        {
                            datePickerGregorian.JSProperties[keyName] = dateInCalendar;
                        }
                    }
                }
            }

            SetPersianDate(selectedCalendarAndTimeZone);
            SetGregorianDate(selectedCalendarAndTimeZone);
            SetTime(selectedCalendarAndTimeZone);
        }

        private string GetDateInCalendar(System.Globalization.Calendar calendar, DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
                calendar.GetYear(dateTime),
                calendar.GetMonth(dateTime),
                calendar.GetDayOfMonth(dateTime));
        }

        private void SetPersianDate(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                //var p = new PersianCalendar();
                //datePickerPersian.Value = string.Format("{0:0000}/{1:00}/{2:00}",
                //    p.GetYear(dateTime.Value),
                //    p.GetMonth(dateTime.Value),
                //    p.GetDayOfMonth(dateTime.Value));
            }
            else
            {
                datePickerPersian.Value = string.Empty;
            }
        }

        private void SetGregorianDate(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                //datePickerGregorian.Value = dateTime.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                datePickerGregorian.Value = string.Empty;
            }
        }

        private void SetTime(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                //clockPicker.Value = dateTime.Value.ToString("HH:mm");
            }
            else
            {
                clockPicker.Value = string.Empty;
            }
        }

        void clockPicker_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            try
            {
                ConverteSelectedTimeToUtcAndUpdateControlsValue();
            }
            catch (Exception ex)
            {
                e.ErrorText = ex.Message;
                e.IsValid = false;
            }
        }

        void TralusDateTimeControlPersian_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            if (SelectedCalendar.GetType() == typeof(PersianCalendar))
            {
                try
                {
                    ConverteSelectedTimeToUtcAndUpdateControlsValue();
                }
                catch (Exception ex)
                {
                    e.ErrorText = ex.Message;
                    e.IsValid = false;
                }
            }
        }

        void TralusDateTimeControlGregorian_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            if (SelectedCalendar.GetType() != typeof(PersianCalendar))
            {
                try
                {
                    ConverteSelectedTimeToUtcAndUpdateControlsValue();
                }
                catch (Exception ex)
                {
                    e.ErrorText = ex.Message;
                    e.IsValid = false;
                }
            }
        }

        private void ConverteSelectedTimeToUtcAndUpdateControlsValue()
        {
            var convertedDateTime = ConverteToUtc();
            SelectedTralusDateTime.DateTimeUtc = convertedDateTime;
            UpdateControlsValue();
        }

        protected override void ReadEditModeValueCore()
        {
            if (PropertyValue == null)
            {
                PropertyValue = new TralusDateTime();
            }

            UpdateControlsValue();
        }

        protected override void ReadViewModeValueCore()
        {
            if (PropertyValue != null)
            {
                ((Label)InplaceViewModeEditor).Text = (((TralusDateTime)PropertyValue)).ToString();
            }
        }

        public override void BreakLinksToControl(bool unwireEventsOnly)
        {
            if (clockPicker != null)
            {
                clockPicker.Validation -= clockPicker_Validation;
            }

            if (datePickerPersian != null)
            {
                datePickerPersian.Validation -= TralusDateTimeControlPersian_Validation;
            }

            if (datePickerGregorian != null)
            {
                datePickerGregorian.Validation -= TralusDateTimeControlGregorian_Validation;
            }

            base.BreakLinksToControl(unwireEventsOnly);
        }

        private DateTime? ConverteToUtc()
        {
            var gregorianDate = datePickerGregorian.Value;
            var persianDate = datePickerPersian.Value;
            var time = clockPicker.Value;
            int hour = 0;
            int minute = 0;
            int year = 0;
            int month = 0;
            int day = 0;

            if (time != null && !string.IsNullOrWhiteSpace(time.ToString()))
            {
                hour = int.Parse(time.ToString().Split(':')[0]);
                minute = int.Parse(time.ToString().Split(':')[1]);
            }

            if (SelectedCalendar.GetType() == typeof(PersianCalendar))
            {
                if (datePickerPersian.Value != null && !string.IsNullOrWhiteSpace(datePickerPersian.Value.ToString()))
                {
                    var splitedPersianDate = datePickerPersian.Value.ToString().Split('/');

                    year = int.Parse(splitedPersianDate[0]);
                    month = int.Parse(splitedPersianDate[1]);
                    day = int.Parse(splitedPersianDate[2]);
                }
            }
            else
            {
                if (datePickerGregorian.Value != null && !string.IsNullOrWhiteSpace(datePickerGregorian.Value.ToString()))
                {
                    var dateTime = DateTime.Parse(datePickerGregorian.Value.ToString());
                    year = dateTime.Year;
                    month = dateTime.Month;
                    day = dateTime.Day;
                }
            }

            DateTime datetime = SelectedCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            var localDateTime = new LocalDateTime(datetime.Year, datetime.Month, datetime.Day, hour, minute, 0);

            var zonedDateTime = SelectedDateTimeZone.ResolveLocal(localDateTime, mapping =>
            {
                if (mapping.Count == 1)
                    return mapping.First();
                throw new Exception("Ambigious time conversion.");
            });

            return zonedDateTime.ToDateTimeUtc();

        }
    }
}
