using System;
using System.ComponentModel;
using System.Globalization;
using DevExpress.Accessibility;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Tralus.Framework.Module.Win.Controls.BaseControl;

namespace Tralus.Framework.Module.Win.Editors
{
    [UserRepositoryItem("RegisterPersianDateTimeEditor")]
    public class RepositoryItemPersianDateTime : RepositoryItem
    {
        private Controls.BaseControl.PersianDateControl persianDateControl;
        private static RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit();
        public static readonly Calendar PersianCalendar = new PersianCalendar();
        public const string CustomEditName = "PersianDateTimeEditor";
        private static object dateTimeChanged = new object();

        static RepositoryItemPersianDateTime()
        {
            RegisterPersianDateEditor();
            repositoryItemTextEdit.CustomDisplayText += RepositoryItemTextEdit_CustomDisplayText;
        }

        public static void RegisterPersianDateEditor()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
               typeof(TextEdit), typeof(RepositoryItemPersianDateTime),
               typeof(DevExpress.XtraEditors.ViewInfo.BaseEditViewInfo), new DevExpress.XtraEditors.Drawing.BaseEditPainter(), true, null, typeof(BaseEditAccessible)));
        }

        public override string EditorTypeName { get { return CustomEditName; } }

        public override BaseEdit CreateEditor()
        {
            var dateControl = new PersianDateControl();
            return dateControl;
        }

        public override BaseEditViewInfo CreateViewInfo()
        {
            var persianDateEditViewInfo = new TextEditViewInfo(repositoryItemTextEdit);
            return persianDateEditViewInfo;
        }

        private static void RepositoryItemTextEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            e.DisplayText = GetPersianDate(e.Value);
        }

        public override BaseEditPainter CreatePainter()
        {
            return new TextEditPainter();
        }

        protected override BaseAccessible CreateAccessibleInstance()
        {
            return new TextEditAccessible(repositoryItemTextEdit);
        }

        private static string GetPersianDate(object editValue)
        {
            var dateTime = editValue as DateTime?;
            if (dateTime != null)
            {
                return GetDateInAltCalendar(dateTime.Value);
            }

            return null;
        }

        private static string GetDateInAltCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}-{3:00}:{4:00}",
                PersianCalendar.GetYear(dateTime),
                PersianCalendar.GetMonth(dateTime),
                PersianCalendar.GetDayOfMonth(dateTime),
                PersianCalendar.GetHour(dateTime),
                PersianCalendar.GetMinute(dateTime));
        }

        public override void Assign(RepositoryItem item)
        {
            var repositoryItemPersianDate = item as RepositoryItemPersianDateTime;
            this.BeginUpdate();
            base.Assign(item);
            this.EndUpdate();
            this.Events.AddHandler(RepositoryItemPersianDateTime.dateTimeChanged, repositoryItemPersianDate.Events[RepositoryItemPersianDateTime.dateTimeChanged]);
        }


        [DXCategory("Events")]
        public event EventHandler DateTimeChanged
        {
            add
            {
                this.Events.AddHandler(RepositoryItemPersianDateTime.dateTimeChanged, (Delegate)value);
            }

            remove
            {
                this.Events.RemoveHandler(RepositoryItemPersianDateTime.dateTimeChanged, (Delegate)value);
            }
        }


        protected override void RaiseEditValueChangedCore(EventArgs e)
        {
            base.RaiseEditValueChangedCore(e);
            this.RaiseDateTimeChanged(e);
        }

        protected internal virtual void RaiseDateTimeChanged(EventArgs e)
        {
            EventHandler eventHandler = (EventHandler)this.Events[RepositoryItemPersianDateTime.dateTimeChanged];
            eventHandler?.Invoke(this.GetEventSender(), e);
        }

        protected override void Dispose(bool disposing)
        {
            repositoryItemTextEdit.CustomDisplayText -= RepositoryItemTextEdit_CustomDisplayText;
            base.Dispose(disposing);
        }
    }
}
