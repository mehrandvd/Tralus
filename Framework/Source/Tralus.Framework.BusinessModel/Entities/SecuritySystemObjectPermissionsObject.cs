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
using Tralus.Framework.BusinessModel.Security;
using SecurityOperations = DevExpress.ExpressApp.Security.SecurityOperations;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("SecuritySystemObjectPermissionsObject", Schema = "System")]
    [System.ComponentModel.DisplayName("Object Operation Permissions")]
    [ImageName("BO_Security_Permission_Object")]
    [DefaultListViewOptions(true, NewItemRowPosition.Top)]
    public class SecuritySystemObjectPermissionsObject : EntityBase, IOwnerInitializer, ICheckedListBoxItemsProvider
    {
        [VisibleInListView(true), VisibleInDetailView(true)]
        [EditorAlias(EditorAliases.CheckedListBoxEditor)]
        public string Permissions { get; set; }

        [FieldSize(FieldSizeAttribute.Unlimited)]
        [CriteriaOptions("Owner.TargetType")]
        [VisibleInListView(true)]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        public string Criteria { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public bool AllowRead { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public bool AllowWrite { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public bool AllowDelete { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public bool AllowNavigate { get; set; }
        
        [VisibleInListView(false), VisibleInDetailView(false)]
        public virtual TypePermissionObject Owner { get; set; }
        
        public IList<IOperationPermission> GetPermissions()
        {
            IList<IOperationPermission> result = new List<IOperationPermission>();
            if (Owner == null)
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Owner property returns null. {0} class, {1} Id", GetType(), Id);
            }
            else if (Owner.TargetType == null)
            {
                Tracing.Tracer.LogWarning("Cannot create OperationPermission objects: Owner.TargetType property returns null. {0} class, {1} Id", GetType(), Id);
            }
            else
            {
                if (AllowRead)
                {
                    result.Add(new ObjectOperationPermission(Owner.TargetType, Criteria, SecurityOperations.Read));
                }

                if (AllowWrite)
                {
                    result.Add(new ObjectOperationPermission(Owner.TargetType, Criteria, SecurityOperations.Write));
                }

                if (AllowDelete)
                {
                    result.Add(new ObjectOperationPermission(Owner.TargetType, Criteria, SecurityOperations.Delete));
                }

                if (AllowNavigate)
                {
                    result.Add(new ObjectOperationPermission(Owner.TargetType, Criteria, SecurityOperations.Navigate));
                }

                if (Permissions != null)
                {
                    var splittedPermissions = Permissions.Split(';').Select(n => n.Trim());
                    foreach (var permission in splittedPermissions)
                    {
                        result.Add(new ObjectOperationPermission(Owner.TargetType, Criteria, permission));
                    }
                }
            }

            return result;
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
        
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DisplayName("Delete")]
        public bool? EffectiveDelete
        {
            get { return AllowDelete ? true : (Owner != null && Owner.AllowDelete) ? (bool?)null : false; }
            set { AllowDelete = value.HasValue ? value.Value : false; }
        }
        
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DisplayName("Navigate")]
        public bool? EffectiveNavigate
        {
            get { return AllowNavigate ? true : (Owner != null && Owner.AllowNavigate) ? (bool?)null : false; }
            set { AllowNavigate = value.HasValue ? value.Value : false; }
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
                    
                    if (Owner.AllowDelete)
                    {
                        result = string.Concat(result, string.Format(CaptionHelper.GetLocalizedText("Messages", "Delete") + CaptionHelper.GetLocalizedText("Messages", "IsInheritedFrom"), CaptionHelper.GetClassCaption(Owner.TargetType.FullName)));
                    }
                    
                    if (Owner.AllowNavigate)
                    {
                        result = string.Concat(result, string.Format(CaptionHelper.GetLocalizedText("Messages", "Navigate") + CaptionHelper.GetLocalizedText("Messages", "IsInheritedFrom"), CaptionHelper.GetClassCaption(Owner.TargetType.FullName)));
                    }
                }

                return result;
            }
        }

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
    }
}
