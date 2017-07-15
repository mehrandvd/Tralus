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
    [PropertyEditor(typeof(TralusDate), true)]
    public class TralusDateEditor : ASPxPropertyEditor
    {
        private DevExpress.Web.ASPxTextBox datePickerGregorian;
        private DevExpress.Web.ASPxTextBox datePickerPersian;
        private DevExpress.Web.ASPxComboBox comboBoxCalendar;

        public TralusDateEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model)
        {

        }

        public System.Globalization.Calendar SelectedCalendar
        {
            get
            {
                if (comboBoxCalendar?.SelectedItem != null)
                {
                    return Calendars[comboBoxCalendar.SelectedItem.Text];
                }

                return null;
            }
        }

        public Dictionary<string, System.Globalization.Calendar> Calendars { get; set; }

        public TralusDate SelectedTralusDate
        {
            get
            {
                return (TralusDate)PropertyValue;
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
            datePickerGregorian.ClientSideEvents.Init = string.Format("function Init(s,e) {{ var input = s.GetInputElement(); jQuery(input).datepicker({{ autoclose: true, language: 'en', rtl: false, weekStart: 1, calendar: 'gregorian', todayBtn: true, format:'yyyy/mm/dd' }}); }}");


            datePickerPersian = RenderHelper.CreateASPxTextBox();
            datePickerPersian.ID = datePickePersianrId;
            datePickerPersian.Validation += TralusDateTimeControlPersian_Validation;
            datePickerPersian.ValidationSettings.EnableCustomValidation = true;
            datePickerPersian.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Enabled;
            datePickerPersian.ValidationSettings.ValidateOnLeave = true;
            datePickerPersian.CssClass = "input-date-picker datepicker-rtl";
            datePickerPersian.SetClientSideEventHandler("GotFocus", string.Format("/*{0}*/ function(s, e) {{document.isMenuClicked = false; }} /*{0}*/", persianGotFocusGuid));
            datePickerPersian.SetClientSideEventHandler("ValueChanged", string.Format(" /*{0}*/ function(s,e) {{ var selectedDate = $('#'+s.GetInputElement().id).data('datepicker').getDate(); window.setTimeout(function() {{  if(!document.isMenuClicked) {{ RaiseXafCallback(globalCallbackControl, '', selectedDate, '', false); }} document.isMenuClicked = false;}}, 500); }} /*{0}*/", persianGotValueChangedGuid));
            datePickerPersian.ClientSideEvents.Init = string.Format("function Init(s,e) {{ var input = s.GetInputElement(); jQuery(input).datepicker({{ autoclose: true, language: 'fa', rtl: false, weekStart: 1, calendar: 'persian', todayBtn: true, format:'yyyy/mm/dd' }});  }}");

            comboBoxCalendar = RenderHelper.CreateASPxComboBox();
            comboBoxCalendar.ID = comboBoxCalendarId;
            comboBoxCalendar.Items.Add("EN", "EN");
            comboBoxCalendar.Items.Add("FA", "FA");
            comboBoxCalendar.SelectedIndex = 0;
            comboBoxCalendar.ClientSideEvents.SelectedIndexChanged = string.Format("function(combo) {{  {0}SelectedCalendar(combo.lastSuccessValue); }}", PropertyName);
            comboBoxCalendar.ClientSideEvents.Init = string.Format("function OnInit(s,e){{  {0}SelectedCalendar(s.lastSuccessValue); }}", PropertyName);

            var table = RenderHelper.CreateTable();
            var row = new TableRow();

            var tableCellDatePickerPersian = new TableCell();
            var tableCellDatePickerGregorian = new TableCell();
            var tableCellComboBoxCalendar = new TableCell();


            tableCellDatePickerPersian.Controls.Add(datePickerPersian);
            tableCellDatePickerPersian.Attributes.Add("data-bind", string.Format("visible: {0}SelectedCalendar() === 'FA'", PropertyName));

            tableCellDatePickerGregorian.Controls.Add(datePickerGregorian);
            tableCellDatePickerGregorian.Attributes.Add("data-bind", string.Format("visible: {0}SelectedCalendar() === 'EN'", PropertyName));

            tableCellComboBoxCalendar.Controls.Add(comboBoxCalendar);

            var selectedModelContainer = RenderHelper.CreateASPxTextBox();

            selectedModelContainer.ClientSideEvents.Init = string.Format("function OnInit(s,e){{   function {0}DateTimeViewModel () {{ {0}SelectedCalendar = ko.observable('EN');   }}; var input = s.GetInputElement(); ko.applyBindings(new {0}DateTimeViewModel(),input); ko.applyBindings({{}},jQuery('[id*=dvi{0}]')[0]); }}", PropertyName);

            var tableCellSelectedModelContainer = new TableCell();
            tableCellSelectedModelContainer.Controls.Add(selectedModelContainer);
            tableCellSelectedModelContainer.Style.Add("display", "none");

            row.Cells.Add(tableCellSelectedModelContainer);
            row.Cells.Add(tableCellComboBoxCalendar);
            row.Cells.Add(tableCellDatePickerPersian);
            row.Cells.Add(tableCellDatePickerGregorian);

            table.Rows.Add(row);

            table.Style.Add("width", "auto");
            table.Style.Add("border-spacing", "1px");

            UpdateControlsValue();

            return table;
        }

        protected override object GetControlValueCore()
        {
            return SelectedTralusDate;
        }

        private void UpdateControlsValue()
        {
            if (SelectedTralusDate != null && SelectedTralusDate.Date.HasValue)
            {
                SetGregorianDate(SelectedTralusDate.Date);
                SetPersianDate(SelectedTralusDate.DateInAltCalendar);
            }
        }

        private void SetPersianDate(string dateTime)
        {
            datePickerPersian.Value = dateTime;
        }

        private void SetGregorianDate(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                datePickerGregorian.Value = dateTime.Value.ToString("yyyy/MM/dd");
            }
            else
            {
                datePickerGregorian.Value = string.Empty;
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
            SelectedTralusDate.Date = convertedDateTime;
            UpdateControlsValue();
        }

        protected override void ReadEditModeValueCore()
        {
            if (PropertyValue == null)
            {
                PropertyValue = new TralusDate();
            }

            UpdateControlsValue();
        }

        protected override void ReadViewModeValueCore()
        {
            if (PropertyValue != null)
            {
                ((Label)InplaceViewModeEditor).Text = (((TralusDate)PropertyValue)).ToString();
            }
        }

        public override void BreakLinksToControl(bool unwireEventsOnly)
        {

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

            int year = 0;
            int month = 0;
            int day = 0;

            DateTime? datetime = null;

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

            if (year != 0 && month != 0 && day != 0)
            {
                datetime = SelectedCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            }

            return datetime;
        }
    }
}
