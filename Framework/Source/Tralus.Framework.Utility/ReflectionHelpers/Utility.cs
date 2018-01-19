using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.Utility.ReflectionHelpers
{
    using ReflectionHelpers;
    using System.Collections;

    public static class Utility
    {
        public static T Clone<T>(this T source, Dictionary<string, Func<object, object>> contructorDisDictionary = null)
        {
            if (source == null)
            {
                return default(T);
            }

            var type = typeof(T);

            if (type == typeof(object))
            {
                type = source.GetType();
            }

            object result = null;

            if (type.IsInterface)
            {
                if (contructorDisDictionary != null && contructorDisDictionary.ContainsKey(type.FullName))
                {
                    var ctor = contructorDisDictionary[type.FullName];
                    result = ctor.Invoke(source);
                }

                type = source.GetType();
            }


            if (result == null)
            {
                if (contructorDisDictionary != null && contructorDisDictionary.ContainsKey(type.FullName))
                {
                    var ctor = contructorDisDictionary[type.FullName];
                    result = ctor.Invoke(source);
                }
                else
                {
                    if (type.GetConstructors().FirstOrDefault(c => c.GetParameters().Length == 0) != null)
                    {
                        result = Activator.CreateInstance(type);
                    }
                }
            }

            foreach (var propertyInfo in type.GetProperties())
            {
                var genericListType = GetGenericListType(propertyInfo.PropertyType);
                if (genericListType != null)
                {
                    var instanceType = genericListType.GetGenericArguments()[0];
                    var sourceList = (IEnumerable)propertyInfo.GetGetMethod()?.Invoke(source, null);

                    if (sourceList == null)
                    {
                        continue;
                    }

                    var addMethod = propertyInfo.PropertyType.GetMethods()
                        .FirstOrDefault(
                            m =>
                                {
                                    if (m.Name == "Add")
                                    {
                                        var parameterInfos = m.GetParameters();
                                        return parameterInfos.Length == 1
                                               && parameterInfos[0].ParameterType == instanceType;
                                    }

                                    return false;
                                });

                    foreach (var s in sourceList)
                    {
                        //var changeType = Convert.ChangeType(s, instanceType);
                        try
                        {

                            addMethod?.Invoke(
                                propertyInfo.GetMethod?.Invoke(result, null),
                                new object[] { s.Clone(contructorDisDictionary) });
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                else
                {
                    object sourcePropertyValue = null;

                    if (propertyInfo.Name == "Id")
                    {
                        sourcePropertyValue = "@" + Guid.NewGuid().ToString();
                    }
                    else
                    {
                        try
                        {
                            sourcePropertyValue = propertyInfo.GetGetMethod()?.Invoke(source, null);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }

                    if (sourcePropertyValue != null)
                    {
                        try
                        {
                            propertyInfo.GetSetMethod()?.Invoke(result, new object[] { sourcePropertyValue });
                        }
                        catch (Exception e)
                        {
                        }
                    }

                }
            }

            return (T)result;
        }

        public static Type GetGenericListType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            foreach (Type @interface in type.GetInterfaces())
            {
                if (@interface.IsGenericType)
                {
                    if (@interface.GetGenericTypeDefinition() == typeof(IList<>))
                    {
                        // if needed, you can also return the type used as generic argument
                        return @interface;
                    }
                }
            }

            return null;
        }

    }
}
