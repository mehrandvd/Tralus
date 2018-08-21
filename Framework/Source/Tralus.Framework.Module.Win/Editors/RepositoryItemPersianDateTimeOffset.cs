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
    [UserRepositoryItem("RegisterPersianDateTimeOffsetEditor")]
    public class RepositoryItemPersianDateTimeOffset : RepositoryItem
    {
        //private Controls.BaseControl.PersianDateTimeOffsetControl persianDateControl;
        private RepositoryItemTextEdit repositoryItemTextEdit ;
        public static readonly Calendar PersianCalendar = new PersianCalendar();
        public const string CustomEditName = "PersianDateTimeOffsetEditor";
        private static object dateTimeOffsetChanged = new object();

        public RepositoryItemPersianDateTimeOffset()
        {
            repositoryItemTextEdit = new RepositoryItemTextEdit();
            repositoryItemTextEdit.CustomDisplayText += RepositoryItemTextEdit_CustomDisplayText;
        }

        static RepositoryItemPersianDateTimeOffset()
        {
            RegisterPersianDateTimeOffsetEditor();
        }

        public static void RegisterPersianDateTimeOffsetEditor()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
               typeof(TextEdit), typeof(RepositoryItemPersianDateTimeOffset),
               typeof(DevExpress.XtraEditors.ViewInfo.BaseEditViewInfo), new DevExpress.XtraEditors.Drawing.BaseEditPainter(), true, null, typeof(BaseEditAccessible)));
        }

        public override string EditorTypeName { get { return CustomEditName; } }

        public override BaseEdit CreateEditor()
        {
            //throw new NotImplementedException();
            var dateControl = new PersianDateTimeOffsetControl();
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
            var dateTime = editValue as DateTimeOffset?;
            if (dateTime.HasValue)
            {
                return GetDateInAltCalendar(dateTime.Value);
            }

            return string.Empty;
        }

        private static string GetDateInAltCalendar(DateTimeOffset dateTimeOffset)
        {
            var dateTime = dateTimeOffset.DateTime;
            return string.Format("{0:0000}/{1:00}/{2:00}-{3:00}:{4:00}",
                PersianCalendar.GetYear(dateTime),
                PersianCalendar.GetMonth(dateTime),
                PersianCalendar.GetDayOfMonth(dateTime),
                dateTime.ToLocalTime().Hour,
                dateTime.ToLocalTime().Minute);
        }

        public override void Assign(RepositoryItem item)
        {
            var repositoryItemPersianDateTimeOffset = item as RepositoryItemPersianDateTimeOffset;
            this.BeginUpdate();
            base.Assign(item);
            this.EndUpdate();
            this.Events.AddHandler(RepositoryItemPersianDateTimeOffset.dateTimeOffsetChanged, repositoryItemPersianDateTimeOffset.Events[RepositoryItemPersianDateTimeOffset.dateTimeOffsetChanged]);
        }


        [DXCategory("Events")]
        public event EventHandler DateTimeChanged
        {
            add
            {
                this.Events.AddHandler(RepositoryItemPersianDateTimeOffset.dateTimeOffsetChanged, (Delegate)value);
            }

            remove
            {
                this.Events.RemoveHandler(RepositoryItemPersianDateTimeOffset.dateTimeOffsetChanged, (Delegate)value);
            }
        }


        protected override void RaiseEditValueChangedCore(EventArgs e)
        {
            base.RaiseEditValueChangedCore(e);
            this.RaiseDateTimeChanged(e);
        }

        protected internal virtual void RaiseDateTimeChanged(EventArgs e)
        {
            EventHandler eventHandler = (EventHandler)this.Events[RepositoryItemPersianDateTimeOffset.dateTimeOffsetChanged];
            eventHandler?.Invoke(this.GetEventSender(), e);
        }

        protected override void Dispose(bool disposing)
        {
            repositoryItemTextEdit.CustomDisplayText -= RepositoryItemTextEdit_CustomDisplayText;
            base.Dispose(disposing);
        }
    }
}
