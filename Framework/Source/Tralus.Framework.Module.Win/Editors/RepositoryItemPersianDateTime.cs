using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Accessibility;
using DevExpress.ExpressApp.Model;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Tralus.Framework.Module.Win.Controls.BaseControl;

namespace Tralus.Framework.Module.Win.Editors
{
    [UserRepositoryItem("RegisterPersianDateEditor")]
    public class RepositoryItemPersianDateTime : RepositoryItem
    {
        private Controls.BaseControl.PersianDateControl persianDateControl;
        private static RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit();
        public static readonly Calendar PersianCalendar = new PersianCalendar();
        public const string CustomEditName = "PersianDateEditor";
        private static object dateTimeChanged = new object();
        public static List<IModelMemberViewItem> CurrentModels=new List<IModelMemberViewItem>();
        public static List<DateTime> DatesList=new List<DateTime>();
        public static List<string> MaskList = new List<string>();
        public static int NumbersofDates = 0;
        public static int Counter = 0;
        public static string LastParentView = "";
        static RepositoryItemPersianDateTime()
        {
            RegisterPersianDateEditor();
            repositoryItemTextEdit.CustomDisplayText += RepositoryItemTextEdit_CustomDisplayText;
        }



        public RepositoryItemPersianDateTime(IModelMemberViewItem model)
        {
            if (LastParentView != model.ParentView.Caption)
            {
                DatesList.Clear();
                MaskList.Clear();
                CurrentModels.Clear();
                LastParentView = model.ParentView.Caption;
            }
            IModelMemberViewItem imodel = model;
            CurrentModels.Add(imodel);
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
            
            int number = 0;
            for (int i = 0; i < DatesList.Count; i++)
            {
                if (DatesList[i] == (DateTime) e.Value)
                {
                    number = number + 1;
                }
            }
            if (DatesList.Count == 0 || number == 0)
            {
                DatesList.Add((DateTime)e.Value);
                MaskList.Add(CurrentModels[NumbersofDates].EditMask);
                NumbersofDates = NumbersofDates + 1;
                Counter = Counter + 1;
            }

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
            string maskValue = "d";
            for (int i = 0; i < DatesList.Count; i++)
            {

                if (DatesList[i] == dateTime)
                {
                    maskValue = MaskList[i];
                }
            }
            if (maskValue == "d")
            {
                return string.Format("{0:0000}/{1:00}/{2:00}",
                    PersianCalendar.GetYear(dateTime),
                    PersianCalendar.GetMonth(dateTime),
                    PersianCalendar.GetDayOfMonth(dateTime));
            }
            else
            {
                return string.Format("{0:0000}/{1:00}/{2:00}-{3:00}:{4:00}",
                    PersianCalendar.GetYear(dateTime),
                    PersianCalendar.GetMonth(dateTime),
                    PersianCalendar.GetDayOfMonth(dateTime),
                    PersianCalendar.GetHour(dateTime),
                    PersianCalendar.GetMinute(dateTime));
            }
        }


        protected override PropertyDescriptorCollection FilterProperties(PropertyDescriptorCollection collection)
        {
            return base.FilterProperties(collection);
        }

        public override string ToString()
        {
            return base.ToString();
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
            if (eventHandler == null)
                return;
            eventHandler(this.GetEventSender(), e);
        }
    }
}
