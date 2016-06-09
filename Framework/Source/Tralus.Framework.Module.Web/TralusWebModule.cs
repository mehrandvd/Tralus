using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Maps.Web;

namespace Tralus.Framework.Module.Web
{
    public class TralusWebModule : TralusModule
    {
        public TralusWebModule():base()
        {
            RequiredModuleTypes.Add(typeof(MapsAspNetModule));
        }
    }
}
