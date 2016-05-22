using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.Migration
{
    public abstract class TralusDbMigrationConfiguration<TDbContext> : DbMigrationsConfiguration<TDbContext>
        where TDbContext : DbContext
    {
        protected override void Seed(TDbContext context)
        {
            base.Seed(context);

            var types =
                AssemblyResolver.GetCurrentModuleTypes(GetType())
                    .Where(t => t.IsSubclassOf(typeof(FixedEntityBase)) && !t.IsAbstract);

            var instances =
                from type in types
                let instance = (FixedEntityBase)Activator.CreateInstance(type, (Enum)null)
                orderby instance.PredefinedValuesApplyingOrder
                select instance;

            foreach (var instance in instances)
            {
                instance.PopulateDbContext(context);
            }

            context.SaveChanges();
        }

        public void ApplySeed(string connectionString)
        {
            var context = Activator.CreateInstance(typeof(TDbContext), connectionString);
            Seed((TDbContext)context);
        }
    }
}