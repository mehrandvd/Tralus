using System.Web;
using Tralus.Shell.Module.Security;

namespace Tralus.Shell.Web.Security
{
    public class AdfsAuthentication : TralusAuthenticationBase
    {
        public AdfsAuthentication()
        {
            CreateUserAutomatically = false;
        }

        protected override string GetUserName()
        {
            var user = HttpContext.Current.User.Identity.Name;
            return user;
        }
    }
}