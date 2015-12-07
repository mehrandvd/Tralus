using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("SecuritySystemInstancePermissionsObject", Schema = "System")]
    [DisplayName("Member Operation Permissions")]
    [ImageName("BO_Security_Permission_Member")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    public class SecuritySystemInstancePermissionsObject : EntityBase, ICheckedListBoxItemsProvider, IOwnerInitializer
    {
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [VisibleInListView(true)]
        [EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string Operations { get; set; }


        private EntityBase instance { get; set; }

        [NotMapped]
        public virtual EntityBase Instance
        {
            get
            {
                if (instance == null && InstanceId != null)
                {
                    var objectSpace = ((IObjectSpaceLink)this).ObjectSpace;
                    instance = (EntityBase)objectSpace.GetObjectByKey(Owner.TargetType, InstanceId);
                }
                return instance;
            }
            set
            {
                instance = value;
                if (instance != null)
                {
                    InstanceId = instance.Id;
                }
            }
        }

        public Guid? InstanceId { get; set; }

        [NotMapped]
        public BindingList<EntityBase> InstancesList
        {
            get
            {
                var objectSpace = CreateObjectSpace(Owner.TargetType);

                var list = new BindingList<EntityBase>(objectSpace.GetObjects(Owner.TargetType).Cast<EntityBase>().ToList());
                return list;
            }
        }

        public virtual TypePermissionObject Owner { get; set; }

        public IList<IOperationPermission> GetPermissions()
        {
            IList<IOperationPermission> result = new List<IOperationPermission>();
            if (Owner == null)
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Owner property returns null. {0} class, {1} Id", GetType(), Id);
                return result;
            }
            else if (Owner.TargetType == null)
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Owner.TargetType property returns null. {0} class, {1} Id", GetType(), Id);
                return result;
            }
            else if (string.IsNullOrEmpty(Operations))
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Operations property returns null or empty string. {0} class, {1} Id", GetType(), Id);
                return result;
            }
            else
            {

            }
            return result;
        }

        [Browsable(false)]
        public bool IsMemberExists
        {
            get
            {
                if (string.IsNullOrEmpty(Operations))
                {
                    return false;
                }
                ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(Owner.TargetType);
                string[] membersArray = Operations.Split(';');
                if (membersArray.Length == 0)
                {
                    return false;
                }
                foreach (string member in membersArray)
                {
                    if (typeInfo.FindMember(member.Trim()) == null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public string InheritedFrom
        {
            get
            {
                string result = "";
                if (Owner != null)
                {
                    if (Owner.AllowRead)
                    {
                        result = string.Concat(result, string.Format(CaptionHelper.GetLocalizedText("Messages", "Read") + CaptionHelper.GetLocalizedText("Messages", "IsInheritedFrom"), CaptionHelper.GetClassCaption(Owner.TargetType.FullName)));
                    }
                    if (Owner.AllowWrite)
                    {
                        result = string.Concat(result, string.Format(CaptionHelper.GetLocalizedText("Messages", "Write") + CaptionHelper.GetLocalizedText("Messages", "IsInheritedFrom"), CaptionHelper.GetClassCaption(Owner.TargetType.FullName)));
                    }
                }
                return result;
            }
        }
        #region ICheckedListBoxItemsProvider Operations
        Dictionary<Object, String> ICheckedListBoxItemsProvider.GetCheckedListBoxItems(string targetMemberName)
        {
            if (Owner == null || !(Owner is ICheckedListBoxItemsProvider))
            {
                return new Dictionary<Object, String>();
            }
            return ((ICheckedListBoxItemsProvider)Owner).GetCheckedListBoxItems(targetMemberName);
        }
        protected virtual void OnItemsChanged()
        {
            if (ItemsChanged != null)
            {
                ItemsChanged(this, new EventArgs());
            }
        }
        public event EventHandler ItemsChanged;
        #endregion
        #region IMasterObjectInitializer Operations
        void IOwnerInitializer.SetMasterObject(object masterObject)
        {
            TypePermissionObject typePermission = masterObject as TypePermissionObject;
            if (typePermission != null)
            {
                Owner = typePermission;
            }
        }
        #endregion
    }
}