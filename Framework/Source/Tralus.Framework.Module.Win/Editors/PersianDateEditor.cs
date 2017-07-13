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
    [PropertyEditor(typeof(DateTime?), true)]
    [PropertyEditor(typeof(DateTime), true)]
    public class PersianDateEditor : WinPropertyEditor, IInplaceEditSupport
    {
        private PersianDateControl control;
        public PersianDateEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
            RepositoryItemPersianDate.RegisterPersianDateEditor();
        }

        static PersianDateEditor()
        {
            RepositoryItemPersianDate.RegisterPersianDateEditor();
        }

        protected override object CreateControlCore()
        {
            control = new PersianDateControl();
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
            return new RepositoryItemPersianDateTime(Model);
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
