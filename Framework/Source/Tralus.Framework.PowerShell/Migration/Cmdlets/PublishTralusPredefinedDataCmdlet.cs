using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Data;
using Tralus.Framework.Utility.ReflectionHelpers;

namespace Tralus.Framework.PowerShell.Migration
{
    [Cmdlet(VerbsData.Publish, "TralusPredefinedData", SupportsShouldProcess = true)]
    public class PublishTralusPredefinedDataCmdlet : TralusMigrationCmdletBase
    {
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            var migrator = GetMigrator();
            var migrationConfigurationTypes = migrator.GetMigrationConfigurationTypes();

            foreach (var migrationConfigurationType in migrationConfigurationTypes)
            {
                var dbmig = (DbMigrationsConfiguration)Activator.CreateInstance(migrationConfigurationType);
                var context = (DbContextBase)Activator.CreateInstance(dbmig.ContextType, ConnectionString);
                context.AllowAddFixedEntity = true;

                var types =
                    AssemblyResolver
                        .GetCurrentModuleTypes(
                            migrationConfigurationType,
                            new[]
                            {TralusAssemblyType.BusinessModel, TralusAssemblyType.Data, TralusAssemblyType.Migration})
                        .Where(t => (typeof (IPredefinedData)).IsAssignableFrom(t) && !t.IsAbstract)
                        .ToList();

                WriteVerbose($"Working on DbContext: {context} with {types.Count()} predefined data type.");

                var instances =
                    from type in types
                    let instance = (IPredefinedData)Activator.CreateInstance(type)
                    orderby instance.PredefinedDataApplyingOrder
                    select instance;

                foreach (var instance in instances)
                {
                    try
                    {
                        WriteVerbose($"\tPredefining: {instance.GetType()}");
                        instance.PredefineData(context);
                        context.SaveChanges();
                    }
                    catch (Exception exception)
                    {
                        WriteVerbose(exception.ToString());
                        throw;
                    }
                }
                WriteVerbose($"Done.");
            }









            //if (!string.IsNullOrWhiteSpace(ConnectionString))
            //{
            //    new DbConnectionInfo(ConnectionString, "System.Data.SqlClient");
            //    WriteVerbose($"Using database: {ConnectionString}");
            //    cstr = ConnectionString;
            //}
            //else if (!string.IsNullOrWhiteSpace(ConnectionName))
            //{
            //    var config = TralusConfiguration.GetConfiguration();
            //    ConnectionStringSettings connectionString = config.ConnectionStrings.ConnectionStrings[ConnectionName];

            //    if (connectionString != null)
            //    {
            //        WriteVerbose($"Using database: [{connectionString.Name}]: {connectionString.ConnectionString}");
            //        new DbConnectionInfo(connectionString.ConnectionString, connectionString.ProviderName);
            //        cstr = connectionString.ConnectionString;
            //    }
            //    else
            //    {
            //        WriteWarning($"Connection string not found: {ConnectionName}");
            //    }
            //}

            //if (!string.IsNullOrWhiteSpace(cstr))
            //{
            //    foreach (var migrationAssembly in MigrationAssemblies)
            //    {
            //        try
            //        {
            //            var assembly = Assembly.Load(migrationAssembly);

            //            var configTypes = assembly.GetTypes()
            //                .Where(t => t.IsSubclassOf(typeof(DbMigrationsConfiguration)) && !t.IsAbstract);

            //            var configs = configTypes.Select(Activator.CreateInstance);

            //            foreach (var config in configs)
            //            {
            //                var type = config.GetType();
            //                var method = type.GetMethod("ApplySeed");
            //                method.Invoke(config, new object[] { cstr });
            //            }


            //        }

            //        catch (Exception exception)
            //        {
            //            WriteWarning(string.Format("Unable to load assembly: {0}", migrationAssembly));
            //            WriteWarning(exception.ToString());
            //        }
            //    }
            //}
        }
    }
}
