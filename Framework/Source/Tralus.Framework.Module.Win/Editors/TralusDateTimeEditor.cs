using System;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
//... 
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Interface;
using Tralus.Framework.Module.Win.Controls;
using Tralus.Framework.BusinessModel.Utility;

namespace Tralus.Framework.Module.Win.Editors
{
    [PropertyEditor(typeof(TralusDateTime), true)]
    public class TralusDateTimeEditor : WinPropertyEditor, IInplaceEditSupport
    {
        private TralusDateTimeControl control;
        private string _defaultCalendar;
        public TralusDateTimeEditor(Type objectType, IModelMemberViewItem info)
            : base(objectType, info)
        {

        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            OnControlValueChanged();
        }

        protected override object CreateControlCore()
        {
            control = new TralusDateTimeControl();
            control.ValueChanged += control_ValueChanged;
            var tralusDateTime = MemberInfo.GetValue(CurrentObject) as TralusDateTime;

            if (tralusDateTime != null)
            {
                control.CurrentObjectLocalDateTimeZone = tralusDateTime.LocalTimeZone;
            }

            var defaultCalendarAndTimeZone = this.Model as ITralusDateTimeDefaultCalendarAndTimeZone;

            if (defaultCalendarAndTimeZone != null)
            {
                control.DefaultCalendar = defaultCalendarAndTimeZone.DefaultCalendar;
                control.DefaultTimeZone = defaultCalendarAndTimeZone.DefaultTimeZone;
            }

            control.Initialize();
            this.ControlBindingProperty = "SelectedTralusDateTime";
            return control;
        }


        protected override void Dispose(bool disposing)
        {
            if (control != null)
            {
                control.ValueChanged -= control_ValueChanged;
                control = null;
            }
            base.Dispose(disposing);
        }

        public RepositoryItem CreateRepositoryItem()
        {
            return new RepositoryItemDateTimeEdit();
        }
    }
}