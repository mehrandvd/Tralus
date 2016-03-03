using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;

namespace Tralus.Framework.Module.Security
{
    public class EntityPermissionRequestProcessor : IPermissionRequestProcessor
    {
         private IPermissionDictionary _permissions;

         public EntityPermissionRequestProcessor(IPermissionDictionary permissions)
        {
            _permissions = permissions;
        }


        public bool IsGranted(IPermissionRequest permissionRequest)
        {
            var entityPermissionRequest = permissionRequest as EntityPermissionRequest;
            if (entityPermissionRequest != null)
            {
                
            }

            return false;
        }
    }
}
