using System;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Migration.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration :  TralusDbMigrationConfiguration<Data.FrameworkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Tralus.Framework.Data.FrameworkDbContext context)
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

            //var administratorRole = new Role(true)
            //{

            //    Name = "Administrators",
            //    IsAdministrative = true,
            //    CanEditModel = true,
            //};

            //context.Set<Role>().AddOrUpdate(new Role(true)
            //{
            //    Id = new Guid("F011D97A-CDA4-46F4-BE33-B48C4CAB9A3E"),
            //    Name = "Administrators",
            //    IsAdministrative = true,
            //    CanEditModel = true,
            //});
        }
    }
}
