using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting.Native;
using Tralus.Framework.Module.Win.Editors;

namespace Tralus.Framework.Module.Win.Controls.BaseControl
{
    [DefaultBindingProperty("DateTime")]
    public partial class PersianDateControl : BaseEdit
    {
        private EventHandler onValueChanged;

        public PersianDateControl()
        {
            InitializeComponent();
        }

        [Bindable(true, BindingDirection.TwoWay)]
        public DateTime? Value
        {
            get { return dateTimeSelector.Value; }
            set { dateTimeSelector.Value = value; }
        }


        public override string Text
        {
            get { return dateTimeSelector.Text; }
            set { dateTimeSelector.Text = value; }
        }

        public override object EditValue
        {
            get { return Value; }
            set { Value = (DateTime?)value; }
        }

        private void dateTimeSelector_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(e);
        }

        public event EventHandler ValueChanged
        {
            add
            {
                onValueChanged += value;
            }
            remove
            {
                onValueChanged -= value;
            }
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            // Call the event handler
            onValueChanged?.Invoke(this, e);
            CompleteChanges();
            var cancelEventArgs = new CancelEventArgs();
            OnValidating(cancelEventArgs);
            OnValidated(e);
        }

        [Browsable(false)]
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemPersianDate.CustomEditName;
            }
        }

        [DXCategory("Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [SmartTagSearchNestedProperties]
        public RepositoryItemPersianDate Properties => this.fProperties as RepositoryItemPersianDate;

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnValidatingCore(CancelEventArgs e)
        {
            base.OnValidatingCore(e);
        }
    }

}
