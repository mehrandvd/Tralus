using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Utility
{
    public class ScriptRunner
    {
        public string ScriptCachId { get; set; }

        public string Script { get; set; }
        public Type ScriptContextType { get; set; }

        public ScriptRunner(string script, Type scriptContextType, string scriptCachId = null)
        {
            Script = script;
            ScriptContextType = scriptContextType;
            ScriptCachId = scriptCachId;
        }

        private static List<Assembly> SharedAssemblies
        {
            get
            {
                var businessAssemblies =
                    AppDomain.CurrentDomain
                        .GetAssemblies()
                        .Where(ass => !ass.IsDynamic && ass.FullName.Contains("BusinessModel") && ass.GetTypes().Any(t => t.IsSubclassOf(typeof(EntityBase)) && !t.IsAbstract))
                        .ToList();

                return businessAssemblies;
            }
        }

        private List<Assembly> _customAssemblies;

        public ScriptRunner WithAssemblies(List<Assembly> customAssemblies)
        {
            _customAssemblies = customAssemblies;
            return this;
        }

        private List<Assembly> GetAssemblies()
        {
            return SharedAssemblies?.Concat(_customAssemblies).ToList();
        } 

        public object Run(ScriptHostBase inputHost)
        {
            var options = ScriptOptions.Default
                .WithReferences(SharedAssemblies);

            var scriptState = CSharpScript.RunAsync(Script, options, inputHost).Result;
            return scriptState.ReturnValue;
        }

        public object Run(object inputObject, IObjectSpace objectSpace)
        {
            var hostType = typeof(ScriptHost<>).MakeGenericType(ScriptContextType);
            var host = (ScriptHostBase) Activator.CreateInstance(hostType, inputObject, objectSpace);

            return Run(host);
        }
    }
}
