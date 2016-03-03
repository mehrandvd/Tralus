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
using Tralus.Framework.Module.Win.Controls;namespace Tralus.Framework.Module.Win.Editors
{
    //[PropertyEditor(typeof(TralusTime), true)]
    public class TralusTimeEditor : WinPropertyEditor, IInplaceEditSupport
    {
        public TralusTimeEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model)
        {
        }


        protected override object CreateControlCore()
        {
            return new Label();
        }

        public RepositoryItem CreateRepositoryItem()
        {
            return new RepositoryItem();
        }
    }
}
