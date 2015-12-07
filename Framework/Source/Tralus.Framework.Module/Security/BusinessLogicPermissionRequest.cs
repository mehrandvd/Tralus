using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Security
{
    public class BusinessLogicPermissionRequest<TEntity> : IPermissionRequest, IBusinessLogicPermissionRequest<TEntity> where TEntity : EntityBase
    {
        public TralusEntityBusinessLogic<TEntity> BusinessLogic { get; private set; }
        public TEntity SelectedObject { get; private set; }

        public BusinessLogicPermissionRequest(TEntity selectedObject, TralusEntityBusinessLogic<TEntity> businessLogic)
        {
            SelectedObject = selectedObject;
            BusinessLogic = businessLogic;
        }

        public object GetHashObject()
        {
            return string.Format("{0}:{1}",SelectedObject.Id, BusinessLogic.GetType().FullName);
        }
    }
}
