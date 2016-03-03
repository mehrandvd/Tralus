using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors;
using Tralus.Framework.BusinessModel.Utility;

namespace Tralus.Framework.Module.Web.Editors
{
 //   [PropertyEditor(typeof(TralusTime), true)]
    public class TralusTimeEditor: WebPropertyEditor
    {
        public TralusTimeEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
        }

        protected override object GetControlValueCore()
        {
            throw new NotImplementedException();
        }

        protected override WebControl CreateEditModeControlCore()
        {
            throw new NotImplementedException();
        }

        protected override void ReadEditModeValueCore()
        {
            throw new NotImplementedException();
        }
    }
}
