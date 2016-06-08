#region Copyright (c) 2000-2015 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{       eXpressApp Framework                                        }
{                                                                   }
{       Copyright (c) 2000-2015 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2015 Developer Express Inc.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.StateMachine;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities.StateMachines
{
    [DefaultProperty("Name")]
    [DisplayName("StateMachine")]
    [ImageName("BO_StateMachine")]
    [RuleCriteria("StateMachine.StartState", DefaultContexts.Save, "(Active = false) or ((StartState is not null) and (Active = true))", SkipNullOrEmptyValues = false)]
    [Table("Tralus.StateMachine")]
    public class StateMachine : EntityBase, IStateMachine, IStateMachineUISettings, IObjectSpaceLink
    {
        private IObjectSpace objectSpace;
        private Type targetObjectType;
        private StringObject statePropertyNameObj;
        
        public StateMachine()
        {
            States = new List<StateMachineState>();
            Active = true;
        }
        
        public String Name { get; set; }
        
        public Boolean Active { get; set; }
        
        [Browsable(false)]
        public String TargetObjectTypeName { get; set; }
        
        [NotMapped]
        [ImmediatePostData]
        [TypeConverter(typeof(StateMachineTypeConverter))]
        [RuleRequiredField("StateMachine.TargetObjectType", DefaultContexts.Save)]
        public Type TargetObjectType
        {
            get
            {
                if ((targetObjectType == null) && !String.IsNullOrWhiteSpace(TargetObjectTypeName))
                {
                    ITypeInfo typeInfo = XafTypesInfo.Instance.FindTypeInfo(TargetObjectTypeName);
                    if (typeInfo != null)
                    {
                        targetObjectType = typeInfo.Type;
                    }
                }
                return targetObjectType;
            }
            set
            {
                targetObjectType = value;
                if (targetObjectType != null)
                {
                    TargetObjectTypeName = targetObjectType.FullName;
                }
                else
                {
                    TargetObjectTypeName = "";
                }
            }
        }
        
        [Browsable(false)]
        [RuleRequiredField("StateMachine.StatePropertyName", DefaultContexts.Save)]
        public String StatePropertyNameBase { get; set; }
        
        [NotMapped]
        [ImmediatePostData]
        [DisplayName("State Property Name")]
        [DataSourceProperty("AvailableStatePropertyNames")]
        public StringObject StatePropertyName
        {
            get
            {
                if ((statePropertyNameObj == null) && !String.IsNullOrWhiteSpace(StatePropertyNameBase))
                {
                    statePropertyNameObj = new StringObject(StatePropertyNameBase);
                }
                return statePropertyNameObj;
            }
            set
            {
                statePropertyNameObj = value;
                if (statePropertyNameObj != null)
                {
                    StatePropertyNameBase = statePropertyNameObj.Name;
                }
                else
                {
                    StatePropertyNameBase = "";
                }
            }
        }
        [NotMapped]
        [Browsable(false)]
        public IList<StringObject> AvailableStatePropertyNames
        {
            get
            {
                List<StringObject> result = new List<StringObject>();
                if (TargetObjectType != null)
                {
                    foreach (String availableStatePropertyName in new StateMachineLogic(objectSpace).FindAvailableStatePropertyNames(TargetObjectType))
                    {
                        if ((StatePropertyName != null) && (StatePropertyName.Name == availableStatePropertyName))
                        {
                            result.Add(StatePropertyName);
                        }
                        else
                        {
                            result.Add(new StringObject(availableStatePropertyName));
                        }
                    }
                }
                return result;
            }
        }
        
        [DataSourceProperty("States")]
        public virtual StateMachineState StartState { get; set; }
        
        [Aggregated]
        [InverseProperty("StateMachine")]
        [RuleUniqueValue("StateMachine.UniqueStateMarker", DefaultContexts.Save, TargetPropertyName = "MarkerValue")]
        public virtual IList<StateMachineState> States { get; set; }
        
        public Boolean ExpandActionsInDetailView { get; set; }
        
        public IState FindCurrentState(Object targetObject)
        {
            return new StateMachineLogic(objectSpace).FindCurrentState(this, targetObject, StartState);
        }
        
        public void ExecuteTransition(Object targetObject, IState targetState)
        {
            new StateMachineLogic(objectSpace).ExecuteTransition(targetObject, targetState);
        }
        
        IList<IState> IStateMachine.States
        {
            get
            {
                return States.ToList<IState>();
            }
        }
        
        string IStateMachine.StatePropertyName
        {
            get
            {
                return StatePropertyName != null ? StatePropertyName.Name : "";
            }
        }
        
        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
    }
}
