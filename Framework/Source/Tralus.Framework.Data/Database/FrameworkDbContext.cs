using System;
using System.Data.Common;
using System.Data.Entity;
using Tralus.Framework.BusinessModel.Entities;

namespace  Tralus.Framework.Data {
	public class FrameworkDbContext : DbContextBase<FrameworkDbContext>
	{
	    public FrameworkDbContext()
	    {
	        
	    }
		public FrameworkDbContext(String connectionString)
			: base(connectionString) {
		}
		public FrameworkDbContext(DbConnection connection)
			: base(connection, false) {
		}

	    protected override void OnModelCreating(DbModelBuilder modelBuilder)
	    {
	        base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
               .HasMany<Role>(u => u.Roles)
               .WithMany(r => r.Users)
               .Map((m) =>
               {
                   m.ToTable("UserRoles", "System")
                       .MapLeftKey("UserId")
                       .MapRightKey("RoleId");
               });

            modelBuilder.Entity<Role>()
               .HasMany<Role>(r => r.ChildRoles)
               .WithMany(r => r.ParentRoles)
               .Map((m) =>
               {
                   m.ToTable("RoleRoles", "System")
                       .MapLeftKey("ParentRoleId")
                       .MapRightKey("ChildRoleId");
               });
	    }
	}
}