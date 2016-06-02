using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;

namespace Tralus.Framework.BusinessModel.Entities
{
    public abstract class FixedEntityBase : EntityBase, IPredefinedValues
    {
        //public string ProgrammingKey { get; private set; }
        public string Value { get; set; }
        public string Name { get; set; }

        protected FixedEntityBase(Enum value)
        {
            ((IXafEntityObject)this).OnCreated();
            Value = value?.ToString()??"";
        }

        public virtual int PredefinedValuesApplyingOrder => 1000;

        public abstract void PopulateDbContext(DbContext dbContext);
    }
}
