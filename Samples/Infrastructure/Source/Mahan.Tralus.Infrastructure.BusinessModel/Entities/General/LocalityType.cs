using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using DevExpress.ExpressApp;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("LocalityType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class LocalityType : FixedEntityBase<LocalityType>
    {
        public LocalityType() : this("ForDbMigration")
        {
            
        }

        public LocalityType(string fixedName) : base(fixedName)
        {
            
        }

        public long? Code { get; set; }
        
        [StringLength(200)]
        public string NameEn { get; set; }

        public static LocalityType International
        {
            get { return GetFixedEntity(); }
        }

        public static LocalityType Domestic
        {
            get { return GetFixedEntity(); }
        }

        public override List<LocalityType> PredefinedValues()
        {
            var result = new List<LocalityType>();

            result.Add(new LocalityType("International")
            {
                Id = new Guid("78B406C1-F466-4825-9225-14CC42C09658"),
                Code = 2,
                Name = "خارجی",
                NameEn = "International"
            });

            result.Add(new LocalityType("Domestic")
            {
                Id = new Guid("717F0092-BB3E-4120-B6AA-67E7372B69B8"),
                Code = 1,
                Name = "داخلی",
                NameEn = "Domestic"
            });

            return result;
        }
    }
}
