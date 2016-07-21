using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using Tralus.Framework.BusinessModel.Utility;

namespace Tralus.Framework.Module.Win
{
    public class TralusWinModule : TralusModule
    {
        protected TralusWinModule()
        {

            if (!(this is FrameworkWindowsFormsModule))
            {
                this.RequiredModuleTypes.Add(typeof(TralusModule));
                this.RequiredModuleTypes.Add(typeof(FrameworkWindowsFormsModule));
            }
        }
    }
}
