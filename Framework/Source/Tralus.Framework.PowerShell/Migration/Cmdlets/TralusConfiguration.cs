using System;
using System.Configuration;

namespace Tralus.Framework.PowerShell.Migration
{
    public class TralusConfiguration
    {
        public static Configuration GetConfiguration()
        {
            try
            {
                return ConfigurationManager.OpenExeConfiguration("Tralus.Shell.Win.exe");
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to load configuraiton for 'Tralus.Shell.Win.exe'.", ex);
            }
        }
    }
}