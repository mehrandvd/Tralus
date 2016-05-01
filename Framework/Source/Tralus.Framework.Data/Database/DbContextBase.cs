using System;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Entities.StateMachines;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.Data
{
    public abstract class DbContextBase : DbContext
    {
        protected DbContextBase()
            : base("Default")
        {
        }

        protected DbContextBase(String connectionString)
            : base(connectionString)
        {
        }

        protected DbContextBase(DbConnection connection)
            : base(connection, false)
        {
        }

        protected DbContextBase(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
        }
    }

    public abstract class DbContextBase<TDbContext> : DbContextBase where TDbContext : DbContext
    {
        static DbContextBase()
        {
            System.Data.Entity.Database.SetInitializer<TDbContext>(null);
        }

        public DbContextBase()
            : base("Default")
        {
            Initialize();
        }
        
        public DbContextBase(String connectionString) : base(connectionString)
        {
            Initialize();
        }
        
        public DbContextBase(DbConnection connection): base(connection, false) 
        {
            Initialize();
		}

        public DbContextBase(DbConnection connection, bool contextOwnsConnection )
            : base(connection, contextOwnsConnection)
        {
            Initialize();
        }

        private void Initialize()
        {
            OnInitialize();
        }

        protected virtual void OnInitialize()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entityTypes =
                AssemblyResolver.GetCurrentModuleTypes(GetType())
                    .Where(e => e.IsSubclassOf(typeof(EntityBase)) && !e.IsAbstract);

            foreach (var entity in entityTypes)
            {
                modelBuilder.RegisterEntityType(entity);
            }
        }

        public DbSet<StateMachine> StateMachines { get; set; }
        public DbSet<StateMachineState> StateMachineStates { get; set; }
        public DbSet<StateMachineTransition> StateMachineTransitions { get; set; }
        public DbSet<StateMachineAppearance> StateMachineAppearances { get; set; }

    }
}
