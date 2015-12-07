using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Validation;
using DevExpress.ExpressApp.ViewVariantsModule;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module.Interface;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.Module
{
    public class TralusModule : ModuleBase
    {
        protected TralusModule()
        {
            var entityTypes =
                AssemblyResolver.GetCurrentModuleTypes(GetType())
                    .Where(e => e.IsSubclassOf(typeof (EntityBase)) && !e.IsAbstract);

            AdditionalExportedTypes.Add(typeof(EntityBase));

            foreach (var entity in entityTypes)
            {
                AdditionalExportedTypes.Add(entity);
            }

            this.RequiredModuleTypes.Add(typeof(ConditionalAppearanceModule));
            this.RequiredModuleTypes.Add(typeof(ValidationModule));
            this.RequiredModuleTypes.Add(typeof(ViewVariantsModule));
        }
    }
}
