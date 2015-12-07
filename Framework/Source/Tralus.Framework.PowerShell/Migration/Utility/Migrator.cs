using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;

namespace Tralus.Framework.PowerShell.Migration
{
    public class Migrator
    {
        public Migrator()
        {
            MigrationAssemblies = new List<Assembly>();
        }

        public List<Assembly> MigrationAssemblies { get; set; }
        public DbConnectionInfo TargetDatabase { get; set; }

        public List<MigrationBundle> GetMigrationBundles()
        {
            var migrationConfigurations = ResolveDbMigrationsConfigurations();

            var migrators = migrationConfigurations
                .Select(dbMigrationsConfiguration => new DbMigrator(dbMigrationsConfiguration))
                .ToList();

            List<ApplyingMigration> pendingMigrations;
            List<ApplyingMigration> localMigrations;
            
            ResolveMigrations(migrators, out pendingMigrations, out localMigrations);

            var migrationChunks = new List<List<ApplyingMigration>>();

            if (pendingMigrations.Any())
            {
                var currentMigrator = pendingMigrations.First().Migrator;
                var currentChunk = new List<ApplyingMigration>();

                foreach (var applyingMigration in pendingMigrations)
                {
                    if (applyingMigration.Migrator != currentMigrator)
                    {
                        migrationChunks.Add(currentChunk);
                        currentChunk = new List<ApplyingMigration>();
                        currentMigrator = applyingMigration.Migrator;
                    }

                    currentChunk.Add(applyingMigration);
                }

                migrationChunks.Add(currentChunk);

                var migrationBundles = new List<MigrationBundle>();

                foreach (var chunk in migrationChunks)
                {
                    var firstMigration = chunk.First();

                    var bundle = new MigrationBundle()
                    {
                        Migrator = firstMigration.Migrator,
                        TargetMigrationName = chunk.Last().MigrationName,
                        MigrationNames = chunk.Select(m => m.MigrationName).ToList()
                    };

                    var currentLocalMigrations =
                        firstMigration.Migrator.GetLocalMigrations()
                            .OrderBy(m => m)
                            .ToList();

                    var sourceIndex = currentLocalMigrations.IndexOf(firstMigration.MigrationName);

                    if (sourceIndex > 0)
                    {
                        bundle.SourceMigrationName = currentLocalMigrations[sourceIndex - 1];
                    }

                    migrationBundles.Add(bundle);
                }

                return migrationBundles;
            }

            return new List<MigrationBundle>();
        }

        private static void ResolveMigrations(IEnumerable<DbMigrator> migrators, out List<ApplyingMigration> pendingMigrations, out List<ApplyingMigration> localMigrations)
        {
            pendingMigrations = new List<ApplyingMigration>();
            localMigrations = new List<ApplyingMigration>();

            foreach (var migrator in migrators)
            {
                pendingMigrations.AddRange(
                    migrator.GetPendingMigrations()
                        .Select(m => new ApplyingMigration() {Migrator = migrator, MigrationName = m}));

                localMigrations.AddRange(
                    migrator.GetLocalMigrations()
                        .Select(m => new ApplyingMigration() {Migrator = migrator, MigrationName = m}));
            }

            pendingMigrations = pendingMigrations
                .OrderBy(m => m.MigrationName)
                .ToList();

            localMigrations = localMigrations
                .OrderBy(m => m.MigrationName)
                .ToList();
        }

        private IEnumerable<DbMigrationsConfiguration> ResolveDbMigrationsConfigurations()
        {
            var migrationConfigurations = new List<DbMigrationsConfiguration>();
            foreach (var assembly in MigrationAssemblies)
            {
                var assemblyTypes = assembly.GetTypes().ToList();

                var configurationTypes =
                    assemblyTypes
                    .Where(t => t.IsSubclassOf(typeof (DbMigrationsConfiguration)) && !t.IsAbstract)
                    .ToList();

                if (!configurationTypes.Any())
                    LogWarning(string.Format("No DbMigrationConfiguration for '{0}'. Make shure the 'Configuraiton' class is public in the assembly", assembly));

                migrationConfigurations.AddRange(
                    configurationTypes.Select(c =>
                    {
                        var config = (DbMigrationsConfiguration) Activator.CreateInstance(c);
                        if (TargetDatabase != null)
                            config.TargetDatabase = TargetDatabase;

                        return config;
                    }));
            }

            return migrationConfigurations;
        }

        public List<MigrationBundle> GetMigrationPlan()
        {
            return GetMigrationBundles();
        }

        public Action<string> LogDetail { get; set; }
        public Action<string> LogWarning { get; set; }
    }
}