using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.Migration;
using Mahan.Tralus.Framework.Utility.ReflectionHelpers;

namespace Mahan.Tralus.Infrastructure.Migration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : TralusDbMigrationConfiguration<Data.InfrastructureDbContext>//DbMigrationsConfiguration<Mahan.Tralus.Infrastructure.Data.InfrastructureDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mahan.Tralus.Infrastructure.Data.InfrastructureDbContext context)
        {
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
