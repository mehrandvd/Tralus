using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;


namespace Tralus.Shell.WorkflowService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetAssembly(typeof(ProjectInstaller)).Location);
            this.serviceInstaller.Description = config.AppSettings.Settings["Description"].Value;
            this.serviceInstaller.DisplayName = config.AppSettings.Settings["DisplayName"].Value;
            this.serviceInstaller.ServiceName = config.AppSettings.Settings["ServiceName"].Value;
        }
    }
}
