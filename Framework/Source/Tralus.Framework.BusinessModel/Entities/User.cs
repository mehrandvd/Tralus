using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.Security;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("User", Schema = "System")]
    public class User : EntityBase, ISecurityUser, IAuthenticationActiveDirectoryUser, IAuthenticationStandardUser, IOperationPermissionProvider, ISecurityUserWithRoles, INotifyPropertyChanged, ICanInitialize
    {
        private Boolean changePasswordOnFirstLogon;
        public const string ruleId_RoleRequired = "Role required";
        public const string ruleId_UserNameRequired = "User Name required";
        public const string ruleId_UserNameIsUnique = "User Name is unique";
        public User()
        {
            IsActive = true;
            Roles = new List<Role>();
        }
        
        [RuleRequiredField(User.ruleId_UserNameRequired, "Save", "The user name must not be empty")]
        [RuleUniqueValue(User.ruleId_UserNameIsUnique, "Save", "The login with the entered UserName was already registered within the system")]
        public String UserName { get; set; }
        
        public Boolean IsActive { get; set; }
        
        public Boolean ChangePasswordOnFirstLogon
        {
            get { return changePasswordOnFirstLogon; }
            set
            {
                changePasswordOnFirstLogon = value;
                if (PropertyChanged != null)
                {
                    var args = new PropertyChangedEventArgs("ChangePasswordOnFirstLogon");
                    PropertyChanged(this, args);
                }
            }
        }
        
        [Browsable(false), SecurityBrowsable]
        public String StoredPassword { get; set; }
        
        [RuleRequiredField(User.ruleId_RoleRequired, DefaultContexts.Save, TargetCriteria = "IsActive=True", CustomMessageTemplate = "An active user must have at least one role assigned")]
        public virtual IList<Role> Roles { get; set; }
        
        Boolean ISecurityUser.IsActive
        {
            get { return IsActive; }
        }
        
        String ISecurityUser.UserName
        {
            get { return UserName; }
        }
        
        String IAuthenticationActiveDirectoryUser.UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        
        Boolean IAuthenticationStandardUser.ComparePassword(String password)
        {
            var passwordCryptographer = new PasswordCryptographer();
            return passwordCryptographer.AreEqual(StoredPassword, password);
        }
        
        Boolean IAuthenticationStandardUser.ChangePasswordOnFirstLogon
        {
            get { return ChangePasswordOnFirstLogon; }
            set { ChangePasswordOnFirstLogon = value; }
        }
       
        String IAuthenticationStandardUser.UserName
        {
            get { return UserName; }
        }
        
        IEnumerable<IOperationPermissionProvider> IOperationPermissionProvider.GetChildren()
        {
            return new EnumerableConverter<IOperationPermissionProvider, Role>(Roles);
        }
        
        IEnumerable<IOperationPermission> IOperationPermissionProvider.GetPermissions()
        {
            return new IOperationPermission[0];
        }
        
        IList<ISecurityRole> ISecurityUserWithRoles.Roles
        {
            get
            {
                IList<ISecurityRole> result = new List<ISecurityRole>();
                foreach (Role role in Roles)
                {
                    result.Add(role);
                }
                return new ReadOnlyCollection<ISecurityRole>(result);
            }
        }
        
        void ICanInitialize.Initialize(IObjectSpace objectSpace, SecurityStrategyComplex security)
        {
            if ((security.RoleType != null) && typeof(Role).IsAssignableFrom(security.RoleType))
            {
                Role newUserRole = (Role)objectSpace.FindObject(security.RoleType, new BinaryOperator("Name", security.NewUserRoleName));
                if (newUserRole == null)
                {
                    newUserRole = (Role)objectSpace.CreateObject(security.RoleType);
                    newUserRole.Name = security.NewUserRoleName;
                    newUserRole.IsAdministrative = true;
                }
                newUserRole.Users.Add(this);
            }
        }
        
        public void SetPassword(String password)
        {
            var passwordCryptographer = new PasswordCryptographer();
            StoredPassword = passwordCryptographer.GenerateSaltedPassword(password);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
