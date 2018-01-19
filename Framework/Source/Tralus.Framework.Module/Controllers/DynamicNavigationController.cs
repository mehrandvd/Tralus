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
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Reflection.Emit;
using System.Reflection;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.Module.Controllers
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Reflection;
    using System.Reflection.Emit;

    using DevExpress.ExpressApp.Model.Core;
    using DevExpress.ExpressApp.SystemModule.ModelXmlConverters;
    using DevExpress.XtraPrinting.Native;

    using Mono.Cecil;

    using Tralus.Framework.BusinessModel.Entities;
    using Tralus.Framework.Module.Interface;
    using Tralus.Framework.Utility.ReflectionHelpers;

    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public partial class DynamicNavigationController : WindowController
    {
        private static readonly Dictionary<string, Func<object, object>> ChoiceActionItemCloneFunction = new Dictionary<string, Func<object, object>>
        {
            {
                typeof(ChoiceActionItem).FullName, (o) =>
                    {
                        var model = ((ChoiceActionItem)o).Model;
                        return new ChoiceActionItem(model.Clone(ChoiceActionItemCloneFunction));
                    }
            },
            {
                typeof(IModelBaseChoiceActionItem).FullName, (o) =>
                    {
                        var type = o.GetType();
                      //  var applicationCreator = type.GetProperty("ApplicationCreator");

                        var nodeInfo = ModelEditorHelper.CreateDummyNodeInfo();
                        var result = Activator.CreateInstance(type, nodeInfo, "@" + Guid.NewGuid().ToString());
                        return result;
                    }
            },
            {
                "ModelNavigationItems", (o) =>
                    {
                        var type = o.GetType();
                        //  var applicationCreator = type.GetProperty("ApplicationCreator");

                        var nodeInfo = ModelEditorHelper.CreateDummyNodeInfo();
                        var result = Activator.CreateInstance(type, nodeInfo, "@" + Guid.NewGuid().ToString());
                        return result;
                    }
            },
            {
                "ModelListView", (o) =>
                    {
                        var type = o.GetType();
                        //  var applicationCreator = type.GetProperty("ApplicationCreator");

                        var nodeInfo = ModelEditorHelper.CreateDummyNodeInfo();
                        var result = Activator.CreateInstance(type, nodeInfo, "@" + Guid.NewGuid().ToString());
                        ModelListViewNodesGenerator.GenerateNodes((IModelListView)result, ((IModelListView)o).ModelClass);
                        return result;
                    }
            }
        };
        private ShowNavigationItemController navigationController;

        public DynamicNavigationController()
        {
            this.InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }

        protected override void OnFrameAssigned()
        {
            this.UnsubscribeFromEvents();
            base.OnFrameAssigned();
            this.navigationController = Frame.GetController<ShowNavigationItemController>();
            if (this.navigationController != null)
            {
                this.navigationController.NavigationItemCreated -= navigationItemCreated;
                this.navigationController.NavigationItemCreated += navigationItemCreated;
            }
        }

        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
        void navigationItemCreated(object sender, NavigationItemCreatedEventArgs e)
        {
            ChoiceActionItem navigationItem = e.NavigationItem;
            CreateDynamicMenu(navigationItem);
        }

        private void CreateDynamicMenu(ChoiceActionItem navigationItem)
        {
            IDynamicNavigationItem dynamicNode = navigationItem.Model as IDynamicNavigationItem;

            if (dynamicNode != null)
            {
                ITypeInfo objectTypeInfo = XafTypesInfo.Instance.FindTypeInfo(dynamicNode.DataSource?.Name);
                var actionCriteria = dynamicNode.ActionCriteria;

                if (!string.IsNullOrWhiteSpace(actionCriteria))
                {
                    ((IModelListView)((IModelNavigationItem)navigationItem.Model).View).Filter = actionCriteria;
                }

                if (objectTypeInfo != null)
                {
                    IList dynamicList;

                    IObjectSpace objectSpace = this.Application.CreateObjectSpace();
                    if (string.IsNullOrWhiteSpace(dynamicNode.DataSourceCriteria))
                    {
                        dynamicList = objectSpace.GetObjects(objectTypeInfo.Type);
                    }
                    else
                    {
                        CriteriaOperator criteriaOperator = CriteriaOperator.Parse(dynamicNode.DataSourceCriteria, objectTypeInfo.Type);
                        dynamicList = objectSpace.GetObjects(objectTypeInfo.Type, criteriaOperator);
                    }

                    if (dynamicList.Count > 0)
                    {
                        //ChoiceActionItem docsGroup =
                        //    new ChoiceActionItem(
                        //        "CustomDocuments",
                        //        "Task-Based Help",
                        //        null)
                        //    { ImageName = "BO_Report" };
                        //navigationItem.Items.Add(docsGroup);

                        var choiceActionItems = new ChoiceActionItem[navigationItem.Items.Count];
                        navigationItem.Items.CopyTo(choiceActionItems, 0);
                        navigationItem.Items.Clear();

                        var sourceAlias = dynamicNode.SourceAlias;

                        if (string.IsNullOrWhiteSpace(sourceAlias))
                        {
                            sourceAlias = $"Selected{objectTypeInfo.Type.Name}";
                        }

                        foreach (EntityBase dynamicObject in dynamicList)
                        {
                            // ViewShortcut shortcut = new ViewShortcut(objectTypeInfo.Type, ((EntityBase)dynamicList).Id.ToString(), dynamicNode.ActionView.Id);

                            //dynamic MyDynamic = new System.Dynamic.ExpandoObject();
                            //MyDynamic["Asdf"] = "A";


                            var dynamicItem = new ChoiceActionItem(
                                                  "@" + Guid.NewGuid(),
                                                  dynamicObject.ToString(),
                                                  $"{sourceAlias}:{dynamicObject.Id}")
                            {
                                ImageName = navigationItem.Model.ImageName
                            };

                            //((IDynamicNavigationItem)dynamicItem.Model).ExtendedParameters = $"{sourceAlias}:{dynamicObject.Id}"; 

                            dynamicItem.Items.AddRange(choiceActionItems.Select(this.CloneChoiceActionItem).ToList());

                            navigationItem.Items.Add(dynamicItem);
                        }
                    }
                }
            }

            if (navigationItem.ParentItem == null)
            {
                FillDaynamicMenuExtendecParameters(navigationItem);
            }
        }

        private ChoiceActionItem CloneChoiceActionItem(ChoiceActionItem source)
        {
            var result = new ChoiceActionItem(CreateModelBase(source.Model));

            var type = source.GetType();

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
                        object clone;

                        if (s.GetType() == typeof(ChoiceActionItem))
                        {
                            clone = CloneChoiceActionItem((ChoiceActionItem)s);
                        }
                        else
                        {
                            clone = s.Clone(ChoiceActionItemCloneFunction);
                        }

                        addMethod?.Invoke(
                            propertyInfo.GetMethod?.Invoke(result, null),
                            new object[] { clone });
                    }
                }
                else
                {
                    object sourcePropertyValue;

                    if (propertyInfo.Name == "Id")
                    {
                        sourcePropertyValue = "@" + Guid.NewGuid().ToString();
                    }
                    else
                    {
                        sourcePropertyValue = propertyInfo.GetGetMethod()?.Invoke(source, null);
                    }

                    propertyInfo.GetSetMethod()?.Invoke(result, new object[] { sourcePropertyValue });
                }
            }

            return result;
        }

        private IModelBaseChoiceActionItem CreateModelBase(IModelBaseChoiceActionItem source)
        {
            if (source == null)
            {
                return null;
            }

            var type = source.GetType();

            var nodeInfo = ModelEditorHelper.CreateDummyNodeInfo();
            var result = Activator.CreateInstance(type, nodeInfo, "@" + Guid.NewGuid().ToString());

            var viewProperty = type.GetProperty("View");
            var sourceView = viewProperty?.GetMethod?.Invoke(source, new object[] { });





            //foreach (var propertyInfo in type.GetProperties())
            //{
            //    var genericListType = GetGenericListType(propertyInfo.PropertyType);
            //    if (genericListType != null)
            //    {
            //        var instanceType = genericListType.GetGenericArguments()[0];
            //        var sourceList = (IEnumerable)propertyInfo.GetGetMethod()?.Invoke(source, null);

            //        if (sourceList == null)
            //        {
            //            continue;
            //        }

            //        var addMethod = propertyInfo.PropertyType.GetMethods()
            //            .FirstOrDefault(
            //                m =>
            //                    {
            //                        if (m.Name == "Add")
            //                        {
            //                            var parameterInfos = m.GetParameters();
            //                            return parameterInfos.Length == 1
            //                                   && parameterInfos[0].ParameterType == instanceType;
            //                        }

            //                        return false;
            //                    });

            //        foreach (var s in sourceList)
            //        {
            //            //var changeType = Convert.ChangeType(s, instanceType);

            //            var clone = s.Clone(ChoiceActionItemCloneFunction);
            //            addMethod?.Invoke(
            //                propertyInfo.GetMethod?.Invoke(result, null),
            //                new object[] { clone });
            //        }
            //    }
            //    else
            //    {
            //        object sourcePropertyValue = null;

            //        switch (propertyInfo.Name)
            //        {
            //            case "Id":
            //                sourcePropertyValue = "@" + Guid.NewGuid();
            //                break;
            //            case "Item":

            //                break;
            //            case "Root":
            //                sourcePropertyValue = source.Root;
            //                break;
            //            default:
            //                sourcePropertyValue = (propertyInfo.GetGetMethod()?.Invoke(source, null)).Clone(ChoiceActionItemCloneFunction);
            //                break;
            //        }

            //        propertyInfo.GetSetMethod()?.Invoke(result, new object[] { sourcePropertyValue });
            //    }
            //}


            return (IModelBaseChoiceActionItem)result;
        }

        private void FillDaynamicMenuExtendecParameters(ChoiceActionItem parentNavigationItem)
        {
            foreach (var targetNavigationItem in parentNavigationItem.Items)
            {
                ChoiceActionItem firstDynamicParent = targetNavigationItem.ParentItem;

                var extendedParameters = string.Empty;

                while (true)
                {
                    extendedParameters = GetExtendedParameters(firstDynamicParent);
                    if (!string.IsNullOrWhiteSpace(extendedParameters) || firstDynamicParent.ParentItem == null)
                    {
                        break;
                    }

                    firstDynamicParent = firstDynamicParent.ParentItem;
                }

                if (!string.IsNullOrWhiteSpace(extendedParameters))
                {
                    if (targetNavigationItem.Model is IDynamicNavigationItem)
                    {
                        SetExtendedParameters(targetNavigationItem, extendedParameters);

                        var filter = ((IModelListView)((IModelNavigationItem)targetNavigationItem.Model).View).Filter;

                        var targetExtendedParameters = GetExtendedParameters(targetNavigationItem);

                        if (!string.IsNullOrWhiteSpace(filter) && !string.IsNullOrWhiteSpace(targetExtendedParameters))
                        {
                            targetExtendedParameters.Split(',')
                                .ForEach(
                                    ex =>
                                        {
                                            if (!string.IsNullOrWhiteSpace(ex))
                                            {
                                                var keyValue = ex.Split(':');
                                                if (keyValue.Length == 2)
                                                {
                                                    var key = keyValue[0];
                                                    var value = keyValue[1];
                                                    filter = filter.Replace(key, value);
                                                }
                                            }
                                        });
                            ((IModelListView)((IModelNavigationItem)targetNavigationItem.Model).View).Filter = filter;
                        }
                    }
                    else
                    {
                        if (targetNavigationItem.Data is string)
                        {
                            SetExtendedParameters(targetNavigationItem, extendedParameters);
                        }
                    }
                }

                FillDaynamicMenuExtendecParameters(targetNavigationItem);
            }
        }

        private static void SetExtendedParameters(ChoiceActionItem targetNavigationItem, string extendedParameters)
        {
            var dynamicNavigationItem = targetNavigationItem.Model as IDynamicNavigationItem;
            if (dynamicNavigationItem != null)
            {
                dynamicNavigationItem.ExtendedParameters += $",{extendedParameters}";
            }
            else
            {
                if (targetNavigationItem.Data == null || targetNavigationItem.Data is string)
                {
                    targetNavigationItem.Data += $",{extendedParameters}";
                }
            }

        }

        private string GetExtendedParameters(ChoiceActionItem choiceActionItem)
        {
            return ((choiceActionItem?.Model as IDynamicNavigationItem)?.ExtendedParameters + ","
             + (choiceActionItem.Data as string)).Trim(',');
        }

        private void UnsubscribeFromEvents()
        {
            if (navigationController != null)
            {
                navigationController.NavigationItemCreated -= navigationItemCreated;
                navigationController = null;
            }
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
