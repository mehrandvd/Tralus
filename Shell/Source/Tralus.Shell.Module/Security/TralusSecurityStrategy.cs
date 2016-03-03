using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Shell.Module.Security
{public class TralusSecurityStrategy : SecurityStrategyComplex
    {
        public TralusSecurityStrategy(AuthenticationBase authentication)
            : base(typeof(User), typeof(Role), authentication)
        {
            
        }
    public override bool IsGranted(IPermissionRequest permissionRequest)
        {
            var result = base.IsGranted(permissionRequest);
            return result;
        }

        public override IList<bool> IsGranted(IList<IPermissionRequest> permissionRequests)
        {
            var result = base.IsGranted(permissionRequests);
            return result;
        }
    }
}
