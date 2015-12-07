using System;
using System.Reflection;

namespace Tralus.Framework.BusinessModel.Security
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SecurityAvailablePermissionsAttribute : Attribute
    {
        public string[] AvailablePermissions { get; set; }

        public SecurityAvailablePermissionsAttribute(params string[] availablePermissions)
        {
            AvailablePermissions = availablePermissions;
        }
    }

    public class SecurityUtil
    {
        public static string[] GetAvailablePermissions(Type type)
        {
            var att = type.GetCustomAttribute<SecurityAvailablePermissionsAttribute>();

            if (att != null)
            {
                return att.AvailablePermissions;
            }
            else
            {
                return new string[0];
            }
        }
    }
}
