using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("EntityScript", Schema = "System")]
    public class EntityScript : EntityBase
    {
        public string Title { get; set; }

        public string Script { get; set; }

        public ScriptExecutionType ExecutionType { get; set; }

        public WhenToRun WhenToRun { get; set; }

        public string PropertyName { get; set; }

        private Type targetType;

        [Browsable(false)]
        public String TargetTypeFullName { get; protected set; }

        [NotMapped]
        public Type TargetType
        {
            get
            {
                if ((targetType == null) && !String.IsNullOrWhiteSpace(TargetTypeFullName))
                {
                    targetType = ReflectionHelper.FindType(TargetTypeFullName);
                }
                return targetType;
            }
            set
            {
                targetType = value;
                if (targetType != null)
                {
                    TargetTypeFullName = targetType.FullName;
                }
                else
                {
                    TargetTypeFullName = "";
                }
                OnItemsChanged();
            }
        }
        protected virtual void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler ItemsChanged;
    }



    public enum WhenToRun
    {
        OnLoad,
        OnCreate,
        OnInitiate,
        OnSave
    }

    public enum ScriptExecutionType
    {
        Evaluate,
        Run
    }
}
