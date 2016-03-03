using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Security
{
    public class BusinessLogicPermissionRequestProcessor : IPermissionRequestProcessor
    {
        private IPermissionDictionary _permissions;

        public BusinessLogicPermissionRequestProcessor(IPermissionDictionary permissions)
        {
            _permissions = permissions;
        }

        //public override bool IsGranted(BusinessLogicPermissionRequest permissionRequest)
        //{
        //    return false;
        //}

        public bool IsGranted(IPermissionRequest permissionRequest)
        {
            var request = permissionRequest as IBusinessLogicPermissionRequest<EntityBase>;
            
            if (request == null) 
                return false;
            throw new System.NotImplementedException();
            
            //return request.BusinessLogic.IsGranted(_permissions);
            

        }
    }
}