using System;
using System.Data.Common;
using System.Data.Entity;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.ExpressApp.Workflow.EF;
using DevExpress.ExpressApp.Workflow.Versioning;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Workflow.EF;
using Tralus.Framework.BusinessModel.Entities;
using Role = Tralus.Framework.BusinessModel.Entities.Role;
using User = Tralus.Framework.BusinessModel.Entities.User;

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
                   m.ToTable("UserRoles", "Tralus")
                       .MapLeftKey("UserId")
                       .MapRightKey("RoleId");
               });

            modelBuilder.Entity<Role>()
               .HasMany<Role>(r => r.ChildRoles)
               .WithMany(r => r.ParentRoles)
               .Map((m) =>
               {
                   m.ToTable("RoleRoles", "Tralus")
                       .MapLeftKey("ParentRoleId")
                       .MapRightKey("ChildRoleId");
               });

	        modelBuilder.Entity<EntityNumbering>();
	        modelBuilder.Entity<EntitySequence>();

	        modelBuilder.Entity<ReportDataV2>().ToTable("ReportDataV2", "Tralus");
	        modelBuilder.Entity<Analysis>().ToTable("Analysis", "Tralus");
	        modelBuilder.Entity<EFWorkflowDefinition>().ToTable("EFWorkflowDefinition", "Tralus");
	        modelBuilder.Entity<EFStartWorkflowRequest>().ToTable("EFStartWorkflowRequest", "Tralus");
	        modelBuilder.Entity<EFRunningWorkflowInstanceInfo>().ToTable("EFRunningWorkflowInstanceInfo", "Tralus");
	        modelBuilder.Entity<EFWorkflowInstanceControlCommandRequest>().ToTable("EFWorkflowInstanceControlCommandRequest", "Tralus");
	        modelBuilder.Entity<EFInstanceKey>().ToTable("EFInstanceKey", "Tralus");
	        modelBuilder.Entity<EFTrackingRecord>().ToTable("EFTrackingRecord", "Tralus");
	        modelBuilder.Entity<EFWorkflowInstance>().ToTable("EFWorkflowInstance", "Tralus");
	        modelBuilder.Entity<EFUserActivityVersion>().ToTable("EFUserActivityVersion", "Tralus");
	        modelBuilder.Entity<ModelDifference>().ToTable("ModelDifference", "Tralus");
	        modelBuilder.Entity<ModelDifferenceAspect>().ToTable("ModelDifferenceAspect", "Tralus");
	        modelBuilder.Entity<ModuleInfo>().ToTable("ModuleInfo", "Tralus");

	        
	    }

        public virtual DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public virtual DbSet<Analysis> Analysis { get; set; }
        public virtual DbSet<EFWorkflowDefinition> EFWorkflowDefinition { get; set; }
        public virtual DbSet<EFStartWorkflowRequest> EFStartWorkflowRequest { get; set; }
        public virtual DbSet<EFRunningWorkflowInstanceInfo> EFRunningWorkflowInstanceInfo { get; set; }
        public virtual DbSet<EFWorkflowInstanceControlCommandRequest> EFWorkflowInstanceControlCommandRequest { get; set; }
        public virtual DbSet<EFInstanceKey> EFInstanceKey { get; set; }
        public virtual DbSet<EFTrackingRecord> EFTrackingRecord { get; set; }
        public virtual DbSet<EFWorkflowInstance> EFWorkflowInstance { get; set; }
        public virtual DbSet<EFUserActivityVersion> EFUserActivityVersion { get; set; }
        public virtual DbSet<ModelDifference> ModelDifference { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspect { get; set; }
        public virtual DbSet<User> User { get; set; }
        public DbSet<ModuleInfo> ModulesInfo { get; set; }
        public DbSet<DashboardData> DashboardData { get; set; }

    }
}