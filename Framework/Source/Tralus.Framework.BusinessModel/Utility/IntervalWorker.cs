using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Utility
{
    public abstract class IntervalWorker
    {
        protected IntervalWorker()
        {
        }

        protected abstract WorkerResult ExecuteImpl();

        public WorkerResult Execute()
        {
            return ExecuteImpl();
        }

        public virtual long Interval
        {
            get { return 60000; }
            
        }
    }

    public abstract class IntervalWorker<TDbContext> : IntervalWorker where TDbContext : DbContext, new()
    {
        protected TDbContext GetDbContext()
        {
            return new TDbContext();
        }

        
    }
}
