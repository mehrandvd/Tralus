namespace Tralus.Shell.Module.Security
{
    public class ActiveDirectoryAuthentication : TralusAuthenticationBase
    {
        public ActiveDirectoryAuthentication()
        {
            CreateUserAutomatically = false;
        }
    }
}