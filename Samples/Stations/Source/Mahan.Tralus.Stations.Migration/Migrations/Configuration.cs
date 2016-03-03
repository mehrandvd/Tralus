using Mahan.Tralus.Framework.Migration;

namespace Mahan.Tralus.Stations.Migration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : TralusDbMigrationConfiguration<Data.StationsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mahan.Tralus.Stations.Data.StationsDbContext context)
        {
            base.Seed(context);

            context.Database.ExecuteSqlCommand(String.Format(SqlResource.DropViewIfExists, "Stations.FlightReportView"));
            context.Database.ExecuteSqlCommand(SqlResource.FlightReportView);

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
