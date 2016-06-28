using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Tralus.Framework.BusinessModel.Entities
{
    public static class DbContextExtensions
    {
        public static void AddIfNotExists<T>(this DbSet<T> dbSet, T entity) where T : EntityBase
        {
            if (!dbSet.Any(e => e.Id == entity.Id))
            {
                dbSet.Add(entity);
            }
        }

        public static void AddRangeIfNotExists<T>(this DbSet<T> dbSet, IEnumerable<T> entities) where T : EntityBase
        {
            foreach (var entity in entities)
            {
                AddIfNotExists(dbSet, entity);
            }
        }

        public static void AddOrUpdate<T>(this DbContext context, IEnumerable<T> list) where T : EntityBase
        {
            context.Set<T>().AddOrUpdate(list.ToArray());
        }
    }
}