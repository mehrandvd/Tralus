using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("CargoType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class CargoType : FixedEntityBase<CargoType>
    {
        public CargoType()
            : base("")
        {

        }

        public CargoType(string fixedName)
            : base(fixedName)
        {
        }

        public long? Code { get; set; }

        public static CargoType CARGO
        {
            get { return GetFixedEntity(); }
        }

        public static CargoType MAIL
        {
            get { return GetFixedEntity(); }
        }

        public static CargoType PAX_BAGS
        {
            get { return GetFixedEntity(); }
        }


        public override List<CargoType> PredefinedValues()
        {
            var result = new List<CargoType>
            {
                new CargoType("CARGO")
                {
                    Id = new Guid("08C5F79D-CFB6-427F-B55B-35429BFB3466"),
                    Code = 100,
                    Name = "CARGO"
                },
                new CargoType("MAIL")
                {
                    Id = new Guid("8B261C21-6B7B-445E-88DD-31D79F652470"),
                    Code = 101,
                    Name = "MAIL"
                },
                new CargoType("PAX_BAGS")
                {
                    Id = new Guid("6E198F77-7583-4708-BED0-61D4D9132CD6"),
                    Code = 102,
                    Name = "PAX_BAGS"
                }
            };


            return result;
        }
    }
}
