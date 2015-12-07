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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.StateMachine;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities.StateMachines
{
    [DefaultProperty("Caption")]
    [DisplayName("StateMachine Transition")]
    [ImageName("BO_Transition")]
    [Table("StateMachineTransition", Schema = "System")]
    public class StateMachineTransition : EntityBase, ITransition, ITransitionUISettings, IMasterObjectInitializer
    {
        private String caption;
        
        public StateMachineTransition()
        {
        }
        
        public String Caption
        {
            get
            {
                String result = caption;
                if (String.IsNullOrEmpty(result) && (TargetState != null))
                {
                    result = TargetState.Caption;
                }
                return result;
            }
            set { caption = value; }
        }
        
        public virtual StateMachineState SourceState { get; set; }
        
        [ImmediatePostData]
        [DataSourceProperty("SourceState.StateMachine.States")]
        [RuleRequiredField("StateMachineTransition.TargetState", DefaultContexts.Save)]
        public virtual StateMachineState TargetState { get; set; }
        
        public Int32 Index { get; set; }
        
        public Boolean SaveAndCloseView { get; set; }
        
        IState ITransition.TargetState
        {
            get { return TargetState; }
        }
        
        #region IMasterObjectInitializer Members
        void IMasterObjectInitializer.SetMasterObject(object masterObject)
        {
            StateMachineState state = masterObject as StateMachineState;
            if (state != null)
            {
                SourceState = state;
            }
        }
        #endregion
    }
}
