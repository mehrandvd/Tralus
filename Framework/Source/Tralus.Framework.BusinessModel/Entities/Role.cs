using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Utils;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("Role", Schema = "System")]
    [DefaultProperty("Name")]
    public class Role : EntityBase, ISecurityRole, IOperationPermissionProvider, ISecuritySystemRole
    {
        public Role()
        {
            Users = new List<User>();
            TypePermissions = new List<TypePermissionObject>();
            ChildRoles = new List<Role>();
            ParentRoles = new List<Role>();
        }

        public Role(bool initialzie) : this()
        {
            if (initialzie)
                ((IXafEntityObject) this).OnCreated();
        }

        public String Name { get; set; }
        
        public Boolean IsAdministrative { get; set; }
        
        public Boolean CanEditModel { get; set; }
        
        public virtual IList<User> Users { get; set; }
        
        [Aggregated]
        public virtual IList<TypePermissionObject> TypePermissions { get; set; }
        
        public virtual IList<Role> ChildRoles { get; set; }
        
        public virtual IList<Role> ParentRoles { get; set; }
        
        String ISecurityRole.Name
        {
            get { return Name; }
        }
        
        IEnumerable<IOperationPermissionProvider> IOperationPermissionProvider.GetChildren()
        {
            var result = new List<IOperationPermissionProvider>();
            result.AddRange(new EnumerableConverter<IOperationPermissionProvider, Role>(ChildRoles));
            return result;
        }

        IEnumerable<IOperationPermission> IOperationPermissionProvider.GetPermissions()
        {
            var result = new List<IOperationPermission>();
            foreach (TypePermissionObject persistentPermission in TypePermissions)
            {
                result.AddRange(persistentPermission.GetPermissions());
            }
            if (IsAdministrative)
            {
                result.Add(new IsAdministratorPermission());
            }
            if (CanEditModel)
            {
                result.Add(new ModelOperationPermission());
            }
            return result;
        }
    }
}
