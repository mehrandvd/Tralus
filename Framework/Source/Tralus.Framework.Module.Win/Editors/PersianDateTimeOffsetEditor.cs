using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using Tralus.Framework.Module.Win.Controls.BaseControl;

namespace Tralus.Framework.Module.Win.Editors
{
    [PropertyEditor(typeof(DateTimeOffset?), true)]
    [PropertyEditor(typeof(DateTimeOffset), true)]
    public class PersianDateTimeOffsetEditor : WinPropertyEditor, IInplaceEditSupport
    {
        private PersianDateTimeOffsetControl control;
        public PersianDateTimeOffsetEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
            
        }

        static PersianDateTimeOffsetEditor()
        {
            RepositoryItemPersianDateTimeOffset.RegisterPersianDateTimeOffsetEditor();
        }

        protected override object CreateControlCore()
        {
            control = new PersianDateTimeOffsetControl();
            control.ValueChanged += control_ValueChanged;
            this.ControlBindingProperty = "Value";
            return control;
        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            OnControlValueChanged();
        }

        public RepositoryItem CreateRepositoryItem()
        {
            return new RepositoryItemPersianDateTimeOffset();
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
        
        protected override void OnControlCreating()
        {
            base.OnControlCreating();
        }
    }
}
