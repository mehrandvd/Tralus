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
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.StateMachine;
using DevExpress.ExpressApp.StateMachine.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities.StateMachines
{
    [DefaultProperty("Caption")]
    [DisplayName("StateMachine State")]
    [ImageName("BO_State")]
    [RuleIsReferenced("StateIsReferenced", DefaultContexts.Delete, typeof(StateMachineTransition), "TargetState", InvertResult = true, MessageTemplateMustBeReferenced = "If you want to delete this State, you must be sure it is not referenced in any Transition as TargetState.", FoundObjectMessageFormat = "{0:SourceState.Caption}")]
    [Table("StateMachineState", Schema = "System")]

    public class StateMachineState : EntityBase, IState, IStateAppearancesProvider, IObjectSpaceLink, INotifyPropertyChanging, INotifyPropertyChanged, IMasterObjectInitializer
    {
        private IObjectSpace objectSpace;
        private String markerValue;
        private void OnPropertyChanging(String propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
        
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public StateMachineState()
        {
            Transitions = new List<StateMachineTransition>();
            Appearances = new List<StateMachineAppearance>();
        }

        public virtual Tralus.Framework.BusinessModel.Entities.StateMachines.StateMachine StateMachine { get; set; }
        
        [RuleRequiredField("StateMachineState.Caption", DefaultContexts.Save)]
        public String Caption { get; set; }
        
        [Browsable(false)]
        public String MarkerValue
        {
            get { return markerValue; }
            set
            {
                if (markerValue != value)
                {
                    OnPropertyChanging("MarkerValue");
                    markerValue = value;
                    OnPropertyChanged("MarkerValue");
                }
            }
        }
        
        [NotMapped]
        [ImmediatePostData]
        [DataSourceProperty("AvailableMarkerObjects")]
        public MarkerObject Marker
        {
            get
            {
                return new StateMachineLogic(objectSpace).GetMarkerObjectFromMarkerValue(MarkerValue, this, objectSpace);
            }
            set
            {
                MarkerValue = new StateMachineLogic(objectSpace).GetMarkerValueFromMarkerObject(value, this, objectSpace);
            }
        }
        
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [CriteriaOptions("StateMachine.TargetObjectType")]
        public String TargetObjectCriteria { get; set; }
        [Aggregated]
        [InverseProperty("SourceState")]
        public virtual IList<StateMachineTransition> Transitions { get; set; }
        [Aggregated]
        public virtual IList<StateMachineAppearance> Appearances { get; set; }
        [Browsable(false)]
        [NotMapped]
        public IList<MarkerObject> AvailableMarkerObjects
        {
            get
            {
                return new StateMachineLogic(objectSpace).GetAvailableMarkerObjects(this, objectSpace);
            }
        }
        
        IStateMachine IState.StateMachine
        {
            get { return StateMachine; }
        }
        
        Object IState.Marker
        {
            get { return (Marker != null) ? Marker.Marker : null; }
        }
        
        IList<ITransition> IState.Transitions
        {
            get
            {
                return Transitions.ToList<ITransition>();
            }
        }
        
        IList<IAppearanceRuleProperties> IStateAppearancesProvider.Appearances
        {
            get
            {
                return Appearances.ToList<IAppearanceRuleProperties>();
            }
        }
        
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        
        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
        
        #region IMasterObjectInitializer Members
        void IMasterObjectInitializer.SetMasterObject(object masterObject)
        {
            Tralus.Framework.BusinessModel.Entities.StateMachines.StateMachine stateMachine = masterObject as Tralus.Framework.BusinessModel.Entities.StateMachines.StateMachine;
            if (stateMachine != null)
            {
                StateMachine = stateMachine;
            }
        }
        #endregion
    }
}
