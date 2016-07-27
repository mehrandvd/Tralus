using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;
using AuthenticationException = System.Security.Authentication.AuthenticationException;

namespace Tralus.Shell.Module.Security
{
    public class TralusAuthenticationBase : AuthenticationActiveDirectory<User>
    {
        public override object Authenticate(IObjectSpace objectSpace)
        {
            string userName = GetUserName();
            var user = objectSpace.FindObject<User>(new BinaryOperator("UserName", userName));

            if (user == null)
            {
                if (CreateUserAutomatically)
                {
                    user = objectSpace.CreateObject<User>();
                    user.UserName = userName;
                    var adminRole = objectSpace.FindObject<Role>(new BinaryOperator("Name", "Tralus.TralusAdmin"));
                    user.Roles.Add(adminRole);
                    bool strictSecurityStrategyBehavior = SecurityModule.StrictSecurityStrategyBehavior;
                    SecurityModule.StrictSecurityStrategyBehavior = false;
                    objectSpace.CommitChanges();
                    SecurityModule.StrictSecurityStrategyBehavior = strictSecurityStrategyBehavior;
                }
                else
                {
                    var candidateUser = objectSpace.FindObject<CandidateUser>(new BinaryOperator("Username", userName));

                    if (candidateUser == null)
                    {
                        candidateUser = objectSpace.CreateObject<CandidateUser>();
                        candidateUser.Username = userName;

                        bool strictSecurityStrategyBehavior = SecurityModule.StrictSecurityStrategyBehavior;
                        SecurityModule.StrictSecurityStrategyBehavior = false;
                        objectSpace.CommitChanges();
                        SecurityModule.StrictSecurityStrategyBehavior = strictSecurityStrategyBehavior;
                    }
                }

            }
            if (user == null)
            {
                throw new AuthenticationException(userName);
            }
            return user;
        }
    }
}