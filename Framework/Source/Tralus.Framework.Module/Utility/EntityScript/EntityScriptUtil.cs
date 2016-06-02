using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Helpers;
using DevExpress.ExpressApp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Data;

namespace Tralus.Framework.Module.Utility
{
    public class EntityScriptUtil
    {
        static EntityScriptUtil()
        {
            EntityScriptLazyLoader = new Lazy<ConcurrentDictionary<Type, List<EntityRuleScript>>>(
                () =>
                {
                    using (var db = new FrameworkDbContext())
                    {
                        var esGroups =
                            from es in db.Set<EntityRuleScript>().ToList()
                            group es by es.TargetType
                            into esGroup
                            select esGroup;

                        var dictionary = esGroups.ToDictionary(esg => esg.Key, esg => esg.ToList());
                        var cach = new ConcurrentDictionary<Type, List<EntityRuleScript>>(dictionary);
                        return cach;
                    }
                }
            );

            EntityNumberingLazyLoader = new Lazy<ConcurrentDictionary<Type, List<EntityNumbering>>>(
               () =>
               {
                   using (var db = new FrameworkDbContext())
                   {
                       var esGroups =
                           from es in db.Set<EntityNumbering>().ToList()
                           group es by es.TargetType
                           into esGroup
                           select esGroup;

                       var dictionary = esGroups.ToDictionary(esg => esg.Key, esg => esg.ToList());
                       var cach = new ConcurrentDictionary<Type, List<EntityNumbering>>(dictionary);
                       return cach;
                   }
               }
           );
        }

        public static ConcurrentDictionary<Type, List<EntityRuleScript>> CachedEntityScripts => EntityScriptLazyLoader.Value;

        private static readonly Lazy<ConcurrentDictionary<Type, List<EntityRuleScript>>> EntityScriptLazyLoader;

        public static ConcurrentDictionary<Type, List<EntityNumbering>> CachedEntityNumberings => EntityNumberingLazyLoader.Value;

        private static readonly Lazy<ConcurrentDictionary<Type, List<EntityNumbering>>> EntityNumberingLazyLoader;

        public static List<EntityScript> GetScriptsFor(Type type, WhenToRun? whenToRun = null)
        {
            var allScripts = new List<EntityScript>();

            List<EntityRuleScript> entityScripts;
            if (CachedEntityScripts.TryGetValue(type, out entityScripts))
                allScripts.AddRange(entityScripts);

            List<EntityNumbering> entityNumberings;
            if (CachedEntityNumberings.TryGetValue(type, out entityNumberings))
                allScripts.AddRange(entityNumberings);

            var scripts = (whenToRun != null) ? allScripts?.Where(s => s.WhenToRun == whenToRun).ToList() : allScripts;

            return scripts;
        }

        public static void Run(EntityScript entityScript, object inputObject, IObjectSpace objectSpace)
        {
            var propertyName = (entityScript as EntityNumbering)?.PropertyName;

            PropertyInfo propertyInfo = null;
            if (propertyName != null)
            {
                propertyInfo = inputObject.GetType().GetProperty(propertyName);
            }

            var oldValue = propertyInfo?.GetValue(inputObject);
            if (oldValue != null)
                return;

            var scriptRunner = new ScriptRunner(entityScript.Script, entityScript.TargetType);
            var result = scriptRunner.Run(inputObject, objectSpace);

            propertyInfo?.SetValue(inputObject, result);
        }

        public static void RunScriptsFor(object inputObject, WhenToRun whenToRun, IObjectSpace objectSpace)
        {
            var scripts = GetScriptsFor(objectSpace.GetObjectType(inputObject), whenToRun);

            if (scripts != null)
            {
                foreach (var entityScript in scripts)
                {
                    Run(entityScript, inputObject, objectSpace);
                }
            }
        }
    }
}
