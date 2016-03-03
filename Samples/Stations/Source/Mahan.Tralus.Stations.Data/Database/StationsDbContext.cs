using System;
using System.Data.Common;
using System.Data.Entity;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.Data;
using Mahan.Tralus.Stations.BusinessModel;

namespace Mahan.Tralus.Stations.Data
{
    public class StationsDbContext : DbContextBase<StationsDbContext>
    {
        public StationsDbContext(String connectionString)
            : base(connectionString)
        {
        }
        public StationsDbContext(DbConnection connection)
            : base(connection, false)
        {
        }

        public StationsDbContext()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany<Role>(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(
                m => m.ToTable("UserRoles", "System")
                    .MapLeftKey("UserId")
                    .MapRightKey("RoleId"));

            modelBuilder.Entity<Role>()
               .HasMany<Role>(r => r.ChildRoles)
               .WithMany(r => r.ParentRoles)
               .Map(
               m =>
                   m.ToTable("RoleRoles", "System")
                   .MapLeftKey("ParentRoleId")
                   .MapRightKey("ChildRoleId")
                   );

            modelBuilder.Entity<FlightReportView>()
                .HasOptional(r => r.FlightReport)
                .WithOptionalDependent(s => s.FlightReportView)
                .Map(m=>m.MapKey("FlightReportId"));          

        }
    }
}