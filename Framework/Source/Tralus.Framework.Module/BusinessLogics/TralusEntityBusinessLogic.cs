using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module
{
    public abstract class TralusEntityBusinessLogic<TEntity> : IObjectSpaceLink
        where TEntity : EntityBase
    {
        protected TralusEntityBusinessLogic(TEntity selectedObject) : this()
        {
            SelectedObject = selectedObject;
        }

        protected TralusEntityBusinessLogic()
        {
            
        }

        public TEntity SelectedObject { get; set; }

        protected virtual void ExecuteImpl() { }

        //protected virtual void OnExecute(IEnumerable<TEntity> entities) { }

        protected virtual bool CanExecuteImpl()
        {
            return true;
        }

        //protected virtual bool OnCanExecute(IEnumerable<TEntity> entities)
        //{
        //    return true;
        //}

        public bool CanExecute()
        {
            return CanExecuteImpl();
        }

        public void Execute()
        {
            ExecuteImpl();
        }

        //public void Execute(IEnumerable<TEntity> entities)
        //{
        //    ExecuteImpl(entities);
        //}

        public override string ToString()
        {
            return GetType().ToString();
        }

        public bool IsGranted()
        {
            return IsGrantedImpl();
        }

        protected virtual bool IsGrantedImpl()
        {
            var requests = GetSecurityRequests();
            if (requests == null)
                return true;

            return requests.Any(SecuritySystem.IsGranted);
        }

        protected virtual IEnumerable<IPermissionRequest> GetSecurityRequests()
        {
            return null;
        }

        protected IPermissionRequest CreatePermissionRequest(object entity, string requestedPermission)
        {
            var handle = ObjectSpace.GetObjectHandle(entity);
            var request = new ClientPermissionRequest(entity.GetType(), null, handle, requestedPermission);
            return request;
        }

        public IObjectSpace ObjectSpace { get; set; }
    }
}
