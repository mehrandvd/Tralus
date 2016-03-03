using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;

namespace Tralus.Framework.BusinessModel.Entities
{
    public abstract class FixedEntityBase : EntityBase
    {
        public string ProgrammingKey { get; private set; }
        
        public string Name { get; set; }

        public FixedEntityBase(string fixedName)
        {
            ((IXafEntityObject)this).OnCreated();
            ProgrammingKey = fixedName;
        }

        public virtual int PredefinedValuesApplyingOrder
        {
            get { return 1000; }
            
        }

        public abstract void PopulateDbContext(DbContext dbContext);
    }
}
