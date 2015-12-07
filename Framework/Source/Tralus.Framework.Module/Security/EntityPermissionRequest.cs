using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Security
{
    public class EntityPermissionRequest : IPermissionRequest
    {
        public string EntityId { get; set; }

        public string Permission { get; set; }

        public EntityPermissionRequest(EntityBase entity, string permission)
            : this(entity.Id.ToString(), permission)
        {
            
        }

        public EntityPermissionRequest(string entityId, string permission)
        {
            EntityId = entityId;
            Permission = permission;
        }

        public object GetHashObject()
        {
            return string.Format("{0}-{1}", EntityId, Permission);
        }
    }
}
