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
using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Tralus.Framework.BusinessModel.Entities.StateMachines
{
    [DisplayName("StateMachine Appearance")]
    [ImageName("BO_Appearance")]
    [Appearance("StateMachineAppearance.AppearanceForAction", TargetItems = "BackColor; FontColor; FontStyle", Enabled = false, Criteria = "AppearanceItemType='Action'")]
    [Table("StateMachineAppearance", Schema = "System")]
    public class StateMachineAppearance : EntityBase, IAppearanceRuleProperties
    {
        public StateMachineAppearance()
        {
            AppearanceItemType = "ViewItem";
            Context = "Any";
        }
        
        [RuleRequiredField("StateMachineAppearance.TargetItems", DefaultContexts.Save)]
        public String TargetItems { get; set; }
        
        [ImmediatePostData]
        public String AppearanceItemType { get; set; }
        
        [Browsable(false)]
        [FieldSize(FieldSizeAttribute.Unlimited)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public String Criteria
        {
            get
            {
                if ((State != null) && (State.StateMachine != null) && (State.Marker != null))
                {
                    return new BinaryOperator(State.StateMachine.StatePropertyName.Name, State.Marker).ToString();
                }
                else
                {
                    return "0=1";
                }
            }
            set { }
        }
        
        public String Context { get; set; }
        
        [Browsable(false)]
        public Type DeclaringType
        {
            get
            {
                if ((State != null) && (State.StateMachine != null))
                {
                    return State.StateMachine.TargetObjectType;
                }
                else
                {
                    return null;
                }
            }
        }

        public Color? FontColor
        {
            get { return Color.FromArgb(FontColorInt); }
            set { FontColorInt = value.HasValue ? value.Value.ToArgb() : 0; }
        }

        public Color? BackColor
        {
            get { return Color.FromArgb(BackColorInt); }
            set { BackColorInt = value.HasValue ? value.Value.ToArgb() : 0; }
        }

        public Int32 Priority { get; set; }
        
        public FontStyle? FontStyle { get; set; }
        
        [Browsable(false)]
        public Int32 FontColorInt { get; set; }
        
        [Browsable(false)]
        public Int32 BackColorInt { get; set; }
        
        public ViewItemVisibility? Visibility { get; set; }
        
        public Boolean? Enabled { get; set; }
        
        [Browsable(false)]
        public String Method { get; set; }
        
        [Browsable(false)]
        public virtual StateMachineState State { get; set; }
    }
}
