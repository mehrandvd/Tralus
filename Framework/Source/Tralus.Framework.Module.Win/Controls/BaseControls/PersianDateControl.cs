using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tralus.Framework.Module.Win.Controls.BaseControl
{
    public partial class PersianDateControl : UserControl
    {
        private EventHandler onValueChanged;

        public PersianDateControl()
        {
            InitializeComponent();
        }

        
        [Bindable(true,BindingDirection.TwoWay)]
        public DateTime? Value
        {
            get { return dateTimeSelector.Value; }
            set { dateTimeSelector.Value = value; }
        }

        public string Text
        {
            get { return dateTimeSelector.Text; }
            set { dateTimeSelector.Text = value; }
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
            if (onValueChanged != null)
            {
                onValueChanged(this, e);
            }
        }
    }
}
