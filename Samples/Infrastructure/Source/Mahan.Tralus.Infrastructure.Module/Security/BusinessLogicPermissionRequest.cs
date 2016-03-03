using DevExpress.ExpressApp.Security;

namespace Mahan.Infrastructure.Module.Security
{
    public class BusinessLogicPermissionRequest : IPermissionRequest
    {
        public object GetHashObject()
        {
            return this.GetType().FullName;
        }
    }

    public class BusinessLogicPermissionRequestProcessor :
        PermissionRequestProcessorBase<BusinessLogicPermissionRequest>
    {
        private IPermissionDictionary _permissions;

        public BusinessLogicPermissionRequestProcessor(IPermissionDictionary permissions)
        {
            _permissions = permissions;
        }

        public override bool IsGranted(BusinessLogicPermissionRequest permissionRequest)
        {
            return false;
        }
    }

}