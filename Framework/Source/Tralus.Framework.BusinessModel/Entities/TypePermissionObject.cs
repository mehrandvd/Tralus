using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Tralus.Framework.BusinessModel.Security;
using SecurityOperations = DevExpress.ExpressApp.Security.SecurityOperations;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("Tralus.TypePermissionObject")]
    public class TypePermissionObject : EntityBase, ITypePermissionOperations, ICheckedListBoxItemsProvider
    {
        private Type targetType;

        //[VisibleInListView(true)]
        //[EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string Permissions { get; set; }

        public TypePermissionObject()
        {
            MemberPermissions = new List<SecuritySystemMemberPermissionsObject>();
            ObjectPermissions = new List<SecuritySystemObjectPermissionsObject>();
            InstancePermissions = new List<SecuritySystemInstancePermissionsObject>();
        }

        public IEnumerable<IOperationPermission> GetPermissions()
        {
            List<IOperationPermission> result = new List<IOperationPermission>();
            if (TargetType != null)
            {
                if (AllowRead)
                {
                    result.Add(new TypeOperationPermission(TargetType, SecurityOperations.Read));
                }
                if (AllowWrite)
                {
                    result.Add(new TypeOperationPermission(TargetType, SecurityOperations.Write));
                }
                if (AllowCreate)
                {
                    result.Add(new TypeOperationPermission(TargetType, SecurityOperations.Create));
                }
                if (AllowDelete)
                {
                    result.Add(new TypeOperationPermission(TargetType, SecurityOperations.Delete));
                }
                if (AllowNavigate)
                {
                    result.Add(new TypeOperationPermission(TargetType, SecurityOperations.Navigate));
                }
                foreach (SecuritySystemMemberPermissionsObject memberPermissionObject in MemberPermissions)
                {
                    result.AddRange(memberPermissionObject.GetPermissions());
                }
                foreach (SecuritySystemObjectPermissionsObject objectPermissionObject in ObjectPermissions)
                {
                    result.AddRange(objectPermissionObject.GetPermissions());
                }
            }
            return result;
        }
        
        [DisplayName("Read")]
        public Boolean AllowRead { get; set; }
        
        [DisplayName("Write")]
        public Boolean AllowWrite { get; set; }
        
        [DisplayName("Create")]
        public Boolean AllowCreate { get; set; }
        
        [DisplayName("Delete")]
        public Boolean AllowDelete { get; set; }
        
        [DisplayName("Navigate")]
        public Boolean AllowNavigate { get; set; }
        
        [Browsable(false)]
        public String TargetTypeFullName { get; protected set; }
        
        public Role Role { get; set; }
        
        [Aggregated]
        public virtual IList<SecuritySystemMemberPermissionsObject> MemberPermissions { get; set; }
        
        [Aggregated]
        public virtual IList<SecuritySystemObjectPermissionsObject> ObjectPermissions { get; set; }
        
        [Aggregated]
        public virtual IList<SecuritySystemInstancePermissionsObject> InstancePermissions { get; set; }
        
        [NotMapped]
        [ImmediatePostData]
        [RuleRequiredField]
        public Type TargetType
        {
            get
            {
                if ((targetType == null) && !String.IsNullOrWhiteSpace(TargetTypeFullName))
                {
                    targetType = ReflectionHelper.FindType(TargetTypeFullName);
                }
                return targetType;
            }
            set
            {
                targetType = value;
                if (targetType != null)
                {
                    TargetTypeFullName = targetType.FullName;
                }
                else
                {
                    TargetTypeFullName = "";
                }
                OnItemsChanged();
            }
        }
        
        [NotMapped]
        public string Object
        {
            get
            {
                if (TargetType != null)
                {
                    string classCaption = CaptionHelper.GetClassCaption(TargetType.FullName);
                    return string.IsNullOrEmpty(classCaption) ? TargetType.Name : classCaption;
                }
                return string.Empty;
            }
        }

        [Browsable(false)]
        public string[] AvailablePermissions
        {
            get { return SecurityUtil.GetAvailablePermissions(TargetType); }
        }

        Dictionary<Object, String> ICheckedListBoxItemsProvider.GetCheckedListBoxItems(string targetMemberName)
        {
            var result = new Dictionary<Object, String>();
            if (targetMemberName == "Members" && TargetType != null)
            {
                ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(TargetType);
                foreach (IMemberInfo memberInfo in typeInfo.Members)
                {
                    if (memberInfo.IsVisible || (memberInfo.FindAttribute<SecurityBrowsableAttribute>() != null))
                    {
                        string caption = CaptionHelper.GetMemberCaption(memberInfo);
                        if (result.ContainsKey(memberInfo.Name))
                        {
                            throw new LightDictionary<string, string>.DuplicatedKeyException(memberInfo.Name, result[memberInfo.Name], caption);
                        }
                        result.Add(memberInfo.Name, caption);
                    }
                }
            }
            else if (targetMemberName == "Permissions" && TargetType != null)
            {
                result = AvailablePermissions.ToDictionary(p=>(object)p, p=>p);
            }
            return result;
        }
        protected virtual void OnItemsChanged()
        {
            if (ItemsChanged != null)
            {
                ItemsChanged(this, new EventArgs());
            }
        }
        public event EventHandler ItemsChanged;
    }
}
