using System.Linq;
using DevExpress.ExpressApp;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Module.Utility
{
    public class DatabaseHost
    {
        private readonly IObjectSpace _objectSpace;

        public DatabaseHost(IObjectSpace objectSpace)
        {
            this._objectSpace = objectSpace;
        }

        public IQueryable<T> Table<T>()
        {
            return _objectSpace.GetObjectsQuery<T>();
        }
    }
}