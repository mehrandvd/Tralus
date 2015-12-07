using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Tralus.Framework.Utility.ReflectionHelpers
{
    public class AssemblyResolver
    {
        /// <summary>
        /// Finds the containing assembly of <param name="sourceType"></param> and returns its related BusinessModel assembly.
        /// </summary>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public static Assembly ResolveBusinessModelAssembly(Type sourceType)
        {
            var assemblyQualifiedName = Path.GetFileNameWithoutExtension(sourceType.Assembly.Location);
            var match = Regex.Match(assemblyQualifiedName, @"(?<FirstPart>Tralus.\w*).*");
            
            if (match.Success)
            {
                var assemblyName = match.Groups["FirstPart"].Value + ".BusinessModel";
                try
                {
                    var assembly = Assembly.Load(assemblyName);
                    return assembly;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Finds the containing assembly of <param name="sourceType"></param> and returns ALL types declared in its related BusinessModel assembly.
        /// </summary>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public static Type[] GetCurrentModuleTypes(Type sourceType)
        {
            var assembly = ResolveBusinessModelAssembly(sourceType);
            if (assembly != null)
            {
                var entities = assembly.GetTypes();
                return entities;
            }
            return new Type[]{};

        }
    }
}
