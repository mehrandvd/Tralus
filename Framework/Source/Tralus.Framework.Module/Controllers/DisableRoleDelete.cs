using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Controllers
{
    public class DisableRoleDelete : ViewController
    {
        public DisableRoleDelete()
        {
            TargetObjectType = typeof(Role);
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            
            var isAdmin = ((User) SecuritySystem.CurrentUser).IsUserInRole("Administrators");

            if (!isAdmin)
            {
                var getDeleteController =
                    Frame.GetController<DevExpress.ExpressApp.SystemModule.DeleteObjectsViewController>();
                getDeleteController.DeleteAction.Active.SetItemValue("Role can not be deleted", false);
            }

        }
    }
}
