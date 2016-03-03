using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Mahan.Tralus.Framework.Module;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Infrastructure.Module.BusinessLogics;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppViewControllertopic.
    public partial class ImportMasaterDataFromFlightAppsViewController : TralusBusinessLogicViewController<ImportMasterDataLog, ImportMasterDataFromFlightAppsBusinessLogic>
    {
    }
}
