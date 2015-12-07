using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Tralus.Framework.BusinessModel.Entities
{
    public abstract class FixedEntityBase<TEntity> : FixedEntityBase
        where TEntity : FixedEntityBase<TEntity>, new()
    {
        public FixedEntityBase(string fixedName)
            : base(fixedName)
        {
        }

        public static TEntity GetFixedEntity([CallerMemberName] string callerName = null)
        {
            // ToDo: Exception Management should be applied on this.
            var entity = AllDictionary[callerName];
            return entity;
        }

        private static Dictionary<string, TEntity> _allDictionary;

        public static Dictionary<string, TEntity> AllDictionary
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _allDictionary, () =>
                {
                    return All.ToDictionary(item => item.ProgrammingKey);
                });

                return _allDictionary;
            }
        }

        private static List<TEntity> _all;

        public static List<TEntity> All
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _all, () =>
                {
                    var objectSpace = CreateObjectSpace(typeof(TEntity));
                    if (objectSpace != null)
                    {
                        var list = objectSpace.GetObjects(typeof(TEntity));
                        return list.Cast<TEntity>().ToList();
                    }

                    return new TEntity().PredefinedValues().ToList();
                });

                return _all;
            }
        }

        public abstract List<TEntity> PredefinedValues();

        public override void PopulateDbContext(DbContext dbContext)
        {
            var predefinedValues = PredefinedValues().ToArray();
            dbContext.Set<TEntity>()
                .AddOrUpdate(predefinedValues);
        }
    }
}