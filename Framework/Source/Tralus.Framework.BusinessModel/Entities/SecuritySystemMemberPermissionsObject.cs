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
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("SecuritySystemMemberPermissionsObject", Schema = "System")]
    [DisplayName("Member Operation Permissions")]
    [ImageName("BO_Security_Permission_Member")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    public class SecuritySystemMemberPermissionsObject : EntityBase, ICheckedListBoxItemsProvider, IOwnerInitializer
    {
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [VisibleInListView(true)]
        [EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string Members { get; set; }
        
        [CriteriaOptions("Owner.TargetType")]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        [FieldSize(FieldSizeAttribute.Unlimited)]
        //[ObjectValidatorIgnoreIssue(typeof(ObjectValidatorLargeNonDelayedMember))]
        [DevExpress.ExpressApp.Model.ModelDefault("RowCount", "0")]
        [VisibleInListView(true), VisibleInDetailView(true)]
        public string Criteria { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        
        public bool AllowRead { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public bool AllowWrite { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
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
            else if (string.IsNullOrEmpty(Members))
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Members property returns null or empty string. {0} class, {1} Id", GetType(), Id);
                return result;
            }
            else
            {
                if (AllowRead)
                {
                    if (string.IsNullOrEmpty(Criteria))
                    {
                        result.Add(new MemberOperationPermission(Owner.TargetType, Members, SecurityOperations.Read));
                    }
                    else
                    {
                        result.Add(new MemberCriteriaOperationPermission(Owner.TargetType, Members, Criteria, SecurityOperations.Read));
                    }
                }
                if (AllowWrite)
                {
                    if (string.IsNullOrEmpty(Criteria))
                    {
                        result.Add(new MemberOperationPermission(Owner.TargetType, Members, SecurityOperations.Write));
                    }
                    else
                    {
                        result.Add(new MemberCriteriaOperationPermission(Owner.TargetType, Members, Criteria, SecurityOperations.Write));
                    }
                }
            }
            return result;
        }
        
        [Browsable(false)]
        public bool IsMemberExists
        {
            get
            {
                if (string.IsNullOrEmpty(Members))
                {
                    return false;
                }
                ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(Owner.TargetType);
                string[] membersArray = Members.Split(';');
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
        
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DisplayName("Read")]
        public bool? EffectiveRead
        {
            get { return AllowRead ? true : (Owner != null && Owner.AllowRead) ? (bool?)null : false; }
            set { AllowRead = value.HasValue ? value.Value : false; }
        }
        
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DisplayName("Write")]
        public bool? EffectiveWrite
        {
            get { return AllowWrite ? true : (Owner != null && Owner.AllowWrite) ? (bool?)null : false; }
            set { AllowWrite = value.HasValue ? value.Value : false; }
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
        #region ICheckedListBoxItemsProvider Members
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
        #region IMasterObjectInitializer Members
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
