using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Data;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.Migration
{
    public abstract class TralusDbMigrationConfiguration<TDbContext> : DbMigrationsConfiguration<TDbContext>
        where TDbContext : DbContext
    {
        protected override void Seed(TDbContext context)
        {
            var tralusContext = context as DbContextBase;
            if (tralusContext != null)
                tralusContext.AllowAddFixedEntity = true;

            base.Seed(context);

            var types =
                AssemblyResolver
                    .GetCurrentModuleTypes(
                        GetType(),
                        new[]
                        {TralusAssemblyType.BusinessModel, TralusAssemblyType.Data, TralusAssemblyType.Migration})
                    .Where(t => (typeof (IPredefinedData)).IsAssignableFrom(t) && !t.IsAbstract);

            var instances =
                from type in types
                let instance = (IPredefinedData)Activator.CreateInstance(type)
                orderby instance.PredefinedDataApplyingOrder
                select instance;

            foreach (var instance in instances)
            {
                instance.PredefineData(context);
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