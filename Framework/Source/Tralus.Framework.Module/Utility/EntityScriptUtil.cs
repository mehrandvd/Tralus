using System;
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
            LazyLoader = new Lazy<Dictionary<Type, List<EntityScript>>>(
                () =>
                {
                    using (var db = new FrameworkDbContext())
                    {
                        var esGroups =
                            from es in db.Set<EntityScript>().ToList()
                            group es by es.TargetType
                            into esGroup
                            select esGroup;


                        var cach = esGroups.ToDictionary(esg => esg.Key, esg => esg.ToList());
                        return cach;
                    }
                }
            );
        }

        public static Dictionary<Type, List<EntityScript>> CachedScripts => LazyLoader.Value;

        private static readonly Lazy<Dictionary<Type, List<EntityScript>>> LazyLoader;

        public static List<Assembly> RefAssemblies
        {
            get
            {
                var businessAssemblies =
                    AppDomain.CurrentDomain
                        .GetAssemblies()
                        .Where(ass => !ass.IsDynamic && ass.FullName.Contains("BusinessModel") && ass.GetTypes().Any(t => t.IsSubclassOf(typeof (EntityBase)) && !t.IsAbstract))
                        .ToList();

                return businessAssemblies;
            }
        }

        public static void Run(EntityScript script, object inputObject)
        {
            var options = ScriptOptions.Default
                .WithReferences(RefAssemblies);

            var hostType = typeof (ScriptHost<>).MakeGenericType(script.TargetType);
            var host = Activator.CreateInstance(hostType, inputObject);
            var result = CSharpScript.RunAsync(script.Script, options, host).Result;
        }
    }

    public class ScriptHost<T>
    {
        public ScriptHost(object entity)
        {
            Entity = (T) entity;
        }
        public T Entity { get; set; }
    }
}
