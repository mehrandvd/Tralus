using System;
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
        protected FixedEntityBase() : this(null)
        {
            
        }

        protected FixedEntityBase(Enum value)
            : base(value)
        {
        }

        public static TEntity GetFixedEntity([CallerMemberName] string callerName = null)
        {
            if (callerName == null)
            {
                throw new ArgumentNullException(nameof(callerName), "GetFixedEntity must be called within a property.");
            }

            try
            {
                var entity = AllDictionary[callerName];
                return entity;
            }
            catch (Exception exception)
            {
                throw new Exception($"Can not find fixed entity: {callerName} on type: {typeof(TEntity)}", exception);
            }
        }

        private static Dictionary<string, TEntity> _allDictionary;

        public static Dictionary<string, TEntity> AllDictionary
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _allDictionary, () =>
                {
                    return All.ToDictionary(item => item.Value.ToString());
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

                    var newEntity = (TEntity) Activator.CreateInstance(typeof(TEntity), null);

                    return newEntity.PredefinedValues().ToList();
                });

                return _all;
            }
        }

        public abstract List<TEntity> PredefinedValues();

        public override void PredefineData(DbContext dbContext)
        {
            var predefinedValues = PredefinedValues().ToArray();
            dbContext.Set<TEntity>()
                .AddOrUpdate(predefinedValues);
        }
    }
}