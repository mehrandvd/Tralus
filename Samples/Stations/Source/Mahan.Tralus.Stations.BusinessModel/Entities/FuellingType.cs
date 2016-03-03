using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
{
    [Table("FuellingType", Schema = "Stations")]
    [DefaultProperty("Name")]
    public class FuellingType : FixedEntityBase<FuellingType>
    {
        public FuellingType(string fixedName): base(fixedName)
        {
        }

        public FuellingType(): base("")
        {

        }

        public int Code { get; set; }

        public static FuellingType Fuel
        {
            get
            {
                return GetFixedEntity();

            }
        }

        public static FuellingType Refuel
        {
            get
            {
                return GetFixedEntity();

            }
        }

        public static FuellingType Defuel
        {
            get
            {
                return GetFixedEntity();

            }
        }

        public override List<FuellingType> PredefinedValues()
        {
            var result = new List<FuellingType>()
            {
                new FuellingType("Fuel")
                {
                    Id = new Guid("C023DCB3-BA62-4800-A7DD-26F64EC6BB42"),
                    Name = "Fuel",
                    Code = 1
                },

                new FuellingType("Refuel")
                {
                    Id = new Guid("6248C4CE-EC2B-4B44-A42A-2C5A221968DD"),
                    Name = "Refuel",
                    Code = 2
                },

                new FuellingType("Defuel")
                {
                    Id = new Guid("54CF9197-5522-47C0-B080-9DCDA199892E"),
                    Name = "Defuel",
                    Code = 3
                }
            };

            return result;
        }
    }
}