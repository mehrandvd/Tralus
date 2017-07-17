using System;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors;
using DevExpress.ExpressApp.Web;
using System.Globalization;

namespace Tralus.Framework.Module.Web.Editors
{
    [PropertyEditor(typeof(DateTime), true)]
    [PropertyEditor(typeof(DateTime?), true)]
    public class PersianDateEditor : WebPropertyEditor
    {
        private DevExpress.Web.ASPxTextBox datePickerPersian;
        private static readonly System.Globalization.Calendar PersianCalendar = new PersianCalendar();

        public PersianDateEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model)
        {

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

        protected override void ReadEditModeValueCore()
        {
            if (SelectedDate != null)
            {
                datePickerPersian.Value = GetDateInPersianCalendar(SelectedDate.Value);
            }
        }

        protected override void ReadViewModeValueCore()
        {
            ((Label)InplaceViewModeEditor).Text = GetDateInPersianCalendar(SelectedDate.Value);// SelectedDate?.ToShortDateString();
        }

        public override void BreakLinksToControl(bool unwireEventsOnly)
        {

            if (datePickerPersian != null)
            {
                datePickerPersian.Validation -= TralusDateTimeControlPersian_Validation;
            }

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
            return $"{PersianCalendar.GetYear(dateTime):0000}/{PersianCalendar.GetMonth(dateTime):00}/{PersianCalendar.GetDayOfMonth(dateTime):00}";
        }
    }
}
