using System;
using System.ComponentModel;
using DevExpress.Utils.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace Tralus.Framework.Module.Win.Controls.BaseControl
{
    [DefaultBindingProperty("DateTime")]
    public partial class PersianDateTimeOffsetControl : BaseEdit
    {
        private EventHandler onValueChanged;
        private DateTimeOffset? _value;

        public PersianDateTimeOffsetControl()
        {
            InitializeComponent();
        }

        [Bindable(true, BindingDirection.TwoWay)]
        public DateTimeOffset? Value
        {
            get { return dateTimeSelector.Value; }
            set
            {
                if (value.HasValue && value != DateTimeOffset.MinValue)
                {
                    dateTimeSelector.Value = value.Value.DateTime;
                }
                else
                {
                    dateTimeSelector.Value = null;
                }
            }
        }


        public override string Text
        {
            get { return dateTimeSelector.Text; }
            set { dateTimeSelector.Text = value; }
        }

        public override object EditValue
        {
            get { return Value; }
            set { Value = (DateTimeOffset?)value; }
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
                return "TextEdit";
            }
        }

        [DXCategory("Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [SmartTagSearchNestedProperties]
        public RepositoryItemTextEdit Properties => this.fProperties as RepositoryItemTextEdit;

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
