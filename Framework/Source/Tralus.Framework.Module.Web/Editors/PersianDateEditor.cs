using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors;
using DevExpress.ExpressApp.Web;
using System.Globalization;
using NodaTime;
using Tralus.Framework.BusinessModel.Utility;

namespace Tralus.Framework.Module.Web.Editors
{
    [PropertyEditor(typeof(DateTime), true)]
    [PropertyEditor(typeof(DateTime?), true)]
    public class PersianDateEditor : WebPropertyEditor{
        private DevExpress.Web.ASPxTextBox datePickerPersian;
        private DevExpress.Web.ASPxTextBox datePickerGregorian;
        private DevExpress.Web.ASPxComboBox comboBoxTimeZone;
        private DevExpress.Web.ASPxComboBox comboBoxCalendar;
        public string mask = "d";
        private static readonly System.Globalization.Calendar PersianCalendar = new PersianCalendar();

        public PersianDateEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model)
        {
            mask = model.EditMask;
        }

        public DateTime? SelectedDate
        {
            get
            {
                return (DateTime?)PropertyValue;
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

            var datePickePersianrId = $"DatePickerPersian{PropertyName}";
            var persianGotFocusGuid = System.Guid.NewGuid().ToString();
            datePickerPersian = RenderHelper.CreateASPxTextBox();
            datePickerPersian.ID = datePickePersianrId;
            datePickerPersian.ValueChanged += DatePickerPersian_ValueChanged;
            datePickerPersian.Validation += TralusDateTimeControlPersian_Validation;
            datePickerPersian.ValidationSettings.EnableCustomValidation = true;
            datePickerPersian.ValidationSettings.ValidateOnLeave = false;
            datePickerPersian.CssClass = "input-date-picker datepicker-rtl";
            datePickerPersian.SetClientSideEventHandler("GotFocus", string.Format("/*{0}*/ function(s, e) {{document.isMenuClicked = false; }} /*{0}*/", persianGotFocusGuid));
            datePickerPersian.ClientSideEvents.Init = string.Format("function Init(s,e) {{ var input = s.GetInputElement(); jQuery(input).datepicker({{ autoclose: true, language: 'fa', rtl: false, weekStart: 1, calendar: 'persian', todayBtn: true, format:'yyyy/mm/dd' }});  }}");

            return datePickerPersian;
        }
        private void DatePickerPersian_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = ConvertePersianDateToDateTime();
        }

        protected override object GetControlValueCore()
        {
            return SelectedDate;
        }

        void TralusDateTimeControlPersian_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            try
            {
                ConvertePersianDateToDateTime();
            }
            catch (Exception ex)
            {
                e.ErrorText = ex.Message;
                e.IsValid = false;
            }

        }
        public Dictionary<string, System.Globalization.Calendar> Calendars { get; set; }
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
        //void TralusDateTimeControlGregorian_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        //{
        //    if (SelectedCalendar.GetType() != typeof(PersianCalendar))
        //    {
        //        try
        //        {
        //            ConverteSelectedTimeToUtcAndUpdateControlsValue();
        //        }
        //        catch (Exception ex){
        //            e.ErrorText = ex.Message;
        //            e.IsValid = false;
        //        }
        //    }
        //}
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
        //private void ConverteSelectedTimeToUtcAndUpdateControlsValue()
        //{
        //    var convertedDateTime = ConverteToUtc();
        //    SelectedTralusDateTime.DateTimeUtc = convertedDateTime;
        //  //  UpdateControlsValue();
        //}
        public DateTimeZone SelectedDateTimeZone
        {
            get{
                if (comboBoxTimeZone != null && comboBoxTimeZone.SelectedItem != null)
                {
                   // return DateTimeZones[comboBoxTimeZone.SelectedItem.Text];
                }

                return null;
            }
        }
        //private DateTime? ConverteToUtc()
        //{
        //    var gregorianDate = datePickerGregorian.Value;
        //    var persianDate = datePickerPersian.Value;
        //    //var time = clockPicker.Value;
        //    int hour = 0;
        //    int minute = 0;
        //    int year = 0;
        //    int month = 0;
        //    int day = 0;

        //    //if (time != null && !string.IsNullOrWhiteSpace(time.ToString()))
        //    //{//    hour = int.Parse(time.ToString().Split(':')[0]);
        //    //    minute = int.Parse(time.ToString().Split(':')[1]);
        //    //}
        //    if (SelectedCalendar.GetType() == typeof(PersianCalendar))
        //    {
        //        if (datePickerPersian.Value != null && !string.IsNullOrWhiteSpace(datePickerPersian.Value.ToString()))
        //        {
        //            var splitedPersianDate = datePickerPersian.Value.ToString().Split('/');

        //            year = int.Parse(splitedPersianDate[0]);
        //            month = int.Parse(splitedPersianDate[1]);
        //            day = int.Parse(splitedPersianDate[2]);
        //        }
        //    }
        //    else
        //    {
        //        if (datePickerGregorian.Value != null && !string.IsNullOrWhiteSpace(datePickerGregorian.Value.ToString()))
        //        {
        //            var dateTime = DateTime.Parse(datePickerGregorian.Value.ToString());
        //            year = dateTime.Year;
        //            month = dateTime.Month;
        //            day = dateTime.Day;
        //        }
        //    }
        //    DateTime datetime = SelectedCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        //    var localDateTime = new LocalDateTime(datetime.Year, datetime.Month, datetime.Day, hour, minute, 0);

        //    var zonedDateTime = SelectedDateTimeZone.ResolveLocal(localDateTime, mapping =>
        //    {
        //        if (mapping.Count == 1)
        //            return mapping.First();
        //        throw new Exception("Ambigious time conversion.");
        //    });

        //    return zonedDateTime.ToDateTimeUtc();

        //}
        protected override void ReadEditModeValueCore()
        {if (SelectedDate != null)
            {
                datePickerPersian.Value = GetDateInPersianCalendar(SelectedDate.Value);
            }}

        protected override void ReadViewModeValueCore()
        {
            if (SelectedDate != null)
            {
             
                if (EditMask == "d")
                {
                    ((Label)InplaceViewModeEditor).Text = GetDateInPersianCalendar(SelectedDate.Value);
                }
                else
                {
                    ((Label)InplaceViewModeEditor).Text = GetDateTimeInPersianCalendar(SelectedDate.Value);
                }
            }
            //((Label)InplaceViewModeEditor).Text = SelectedDate?.ToLongDateString();
        }

        public override void BreakLinksToControl(bool unwireEventsOnly)
        {

            if (datePickerPersian != null)
            {datePickerPersian.Validation -= TralusDateTimeControlPersian_Validation;
            }
            //if (datePickerGregorian != null)
            //{
            //    datePickerGregorian.Validation -= TralusDateTimeControlGregorian_Validation;
            //}
            base.BreakLinksToControl(unwireEventsOnly);
        }

        private DateTime? ConvertePersianDateToDateTime()
        {
            var persianDate = datePickerPersian.Value;

            int year = 0;
            int month = 0;
            int day = 0;
            
            DateTime? datetime = null;
            
            if (!string.IsNullOrWhiteSpace(persianDate?.ToString()))
            {
                var splitedPersianDate = persianDate.ToString().Split('/');

                year = int.Parse(splitedPersianDate[0]);
                month = int.Parse(splitedPersianDate[1]);
                day = int.Parse(splitedPersianDate[2]);
               
            }

            if (year != 0 && month != 0 && day != 0)
            {
                datetime = PersianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
               
            }

            return datetime;
        }


        private string GetDateInPersianCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
                PersianCalendar.GetYear(dateTime),
                PersianCalendar.GetMonth(dateTime),
                PersianCalendar.GetDayOfMonth(dateTime));
        }
        private string GetDateTimeInPersianCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}-{3:00}:{4:00}",
                PersianCalendar.GetYear(dateTime),
                PersianCalendar.GetMonth(dateTime),
                PersianCalendar.GetDayOfMonth(dateTime),
                PersianCalendar.GetHour(dateTime), PersianCalendar.GetMinute(dateTime));
        }
    }
}
