using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace Tralus.Framework.BusinessModel.Entities
{
    [DefaultProperty("Name")]
    public abstract class FixedEntityBase : EntityBase, IPredefinedData
    {
        //public string ProgrammingKey { get; private set; }
        public virtual string Value { get; private set; }

        public virtual string Name { get; set; }

        protected FixedEntityBase()
        {
            
        }

        protected FixedEntityBase(Enum value)
        {
            ((IXafEntityObject)this).OnCreated();
            Value = value?.ToString()??"";
        }

        public virtual int PredefinedDataApplyingOrder => 1000;

        public abstract void PredefineData(DbContext dbContext);

        public override bool Equals(object obj)
        {
            var enumValue = obj as Enum;
            if (enumValue != null)
            {
                return enumValue.ToString() == Value;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }

        public static bool operator ==(FixedEntityBase fixedEntity, Enum enumValue)
        {
            if (fixedEntity == null)
            {
                if (enumValue == null)
                    return true;
                return false;
            }

            if (enumValue != null)
            {
                return enumValue.ToString() == fixedEntity.Value;
            }

            return false;
        }

        public static bool operator !=(FixedEntityBase fixedEntity, Enum enumValue)
        {
            return !(fixedEntity == enumValue);
        }
    }
}
