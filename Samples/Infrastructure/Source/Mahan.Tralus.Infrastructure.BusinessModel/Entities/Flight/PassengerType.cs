using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("PassengerType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class PassengerType : FixedEntityBase<PassengerType>
    {
        public PassengerType()
            : this("")
        {
        }

        public PassengerType(string fixedName)
            : base(fixedName)
        {

        }

        public long? Code { get; set; }

        public static PassengerType ADL
        {
            get { return GetFixedEntity(); }
        }

        public static PassengerType CHD
        {
            get { return GetFixedEntity(); }
        }

        public static PassengerType INF
        {
            get { return GetFixedEntity(); }
        }

        public override List<PassengerType> PredefinedValues()
        {
            var result = new List<PassengerType>
            {
                new PassengerType("ADL")
                {
                    Id = new Guid("9C183ADF-9000-4955-BBAC-1D5C877B5E9E"),
                    Code = 100,
                    Name = "ADL"
                },
                new PassengerType("CHD")
                {
                    Id = new Guid("F8343DCC-0901-471E-A84B-65F87E49FB2C"),
                    Code = 101,
                    Name = "CHD"
                },
                new PassengerType("INF")
                {
                    Id = new Guid("2AE38AAE-2700-49AB-AB2A-ACE5392B3B31"),
                    Code = 102,
                    Name = "INF"
                }
            };

            return result;
        }
    }
}
