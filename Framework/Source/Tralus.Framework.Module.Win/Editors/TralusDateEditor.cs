using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors.Repository;
using Tralus.Framework.BusinessModel.Utility;
using Tralus.Framework.Module.Interface;
using Tralus.Framework.Module.Win.Controls;

namespace Tralus.Framework.Module.Win.Editors
{
    [PropertyEditor(typeof(TralusDate), true)]
    public class TralusDateEditor : WinPropertyEditor, IInplaceEditSupport
    {
        private TralusDateControl control;
        public TralusDateEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
        }
        private void control_ValueChanged(object sender, EventArgs e)
        {
            OnControlValueChanged();
        }

        protected override object CreateControlCore()
        {
            control = new TralusDateControl();
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
            }

            control.Initialize();
            this.ControlBindingProperty = "SelectedTralusDate";
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
