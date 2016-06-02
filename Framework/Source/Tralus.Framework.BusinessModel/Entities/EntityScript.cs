using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.BusinessModel.Entities
{
    public abstract class EntityScript : EntityBase
    {
        private Type targetType;
        public string Title { get; set; }
        public string Script { get; set; }

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

        public WhenToRun WhenToRun { get; set; }

        protected virtual void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler ItemsChanged;
    }
}