using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tralus.Framework.BusinessModel.Entities;

namespace Tralus.Framework.Data.Data
{
    public class FrameworkPredefinedData : IPredefinedData
    {
        public void PredefineData(DbContext dbContext)
        {

            // Roles
            var tralusAdmins = new Role()
            {
                Id = new Guid("91D53501-02EE-4E9A-936A-C723C5BA8951"),
                Name = "Tralus.TralusAdmin",
                CanEditModel = true,
                IsAdministrative = true
            };

            var admins = new Role()
            {
                Id = new Guid("6DB385F0-5504-4018-9A1F-66DD06266126"),
                Name = "Tralus.Admin",
            };

            var users = new Role()
            {
                Id = new Guid("D4651E66-85C6-4F56-BA48-8C9F5753FD75"),
                Name = "BasicUser",
            };

            dbContext.Set<Role>()
                .AddRangeIfNotExists(new List<Role>
                {
                    tralusAdmins,
                    admins,
                    users,
                });

            Func<Role, Role> reloadRole = (role) =>
            {
                return dbContext.Set<Role>().First(r => r.Id == role.Id);
            };

            dbContext.SaveChanges();

            // Users
            dbContext.Set<User>()
                .AddRangeIfNotExists(new List<User>
                {
                    new User()
                    {
                        Id = new Guid("23F81C69-2FFB-4199-8B3F-1B24A02886AE"),
                        UserName = "tralusadmin",
                        IsActive = true,
                        Roles = new List<Role>() { reloadRole(tralusAdmins) }
                    },
                    new User()
                    {
                        Id = new Guid("9F87FC95-0E44-4BF0-9705-A3521C4A3D65"),
                        UserName = "admin",
                        IsActive = true,
                        Roles = new List<Role>() { reloadRole(admins) }
                    },
                     new User()
                    {
                        Id = new Guid("B10FAFD8-FA97-4D96-9756-8029B42FCA11"),
                        UserName = "user",
                        IsActive = true,
                        Roles = new List<Role>() { reloadRole(users) }
                    }
                });

            dbContext.SaveChanges();
        }

        public int PredefinedDataApplyingOrder => 10;
    }
}
