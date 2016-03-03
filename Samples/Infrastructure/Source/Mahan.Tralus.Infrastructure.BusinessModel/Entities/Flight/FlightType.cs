using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("FlightType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class FlightType : FixedEntityBase<FlightType>
    {
        public FlightType() : this("ForDbMigration")
        {
            
        }

        public FlightType(string fixedName) : base(fixedName)
        {
        }

        public int Code { get; set; }

        public static FlightType Charter
        {
            get { return GetFixedEntity(); }
        }

        public static FlightType FerryFlight
        {
            get { return GetFixedEntity(); }
        }

        public static FlightType Scheduled
        {
            get { return GetFixedEntity(); }
        }

        public static FlightType Unknown
        {
            get { return GetFixedEntity(); }
        }

        public static FlightType VIP
        {
            get { return GetFixedEntity(); }
        }

        public static FlightType Hajj
        {
            get { return GetFixedEntity(); }
        }

        public override List<FlightType> PredefinedValues()
        {
            var result = new List<FlightType>();

            result.Add(new FlightType("Charter")
            {
                Id = new Guid("E3D5A0D2-EE60-4585-B185-A04DF4EAED75"),
                Code = 100,
                Name = "Charter"
               
            });

            result.Add(new FlightType("Ferry Flight")
            {
                Id = new Guid("21EA4A52-274F-4A49-A3FE-25BE68B0C2D1"),
                Code = 101,
                Name = "Ferry Flight"
            });

            result.Add(new FlightType("Scheduled")
            {
                Id = new Guid("F39289D7-1F59-4AD7-B151-FF396BA59C23"),
                Code = 102,
                Name = "Scheduled"
            });

            result.Add(new FlightType("Unknown")
            {
                Id = new Guid("3568C549-3F4A-4917-A6AC-32F5B509F53A"),
                Code = 103,
                Name = "Unknown"
            });

            result.Add(new FlightType("VIP")
            {
                Id = new Guid("A7B7604A-1146-4566-B0A4-EAF86FAE1C80"),
                Code = 104,
                Name = "VIP"
            });

            result.Add(new FlightType("Hajj")
            {
                Id = new Guid("B3BE3730-EC9C-4080-80AD-BCF95DE66679"),
                Code = 105,
                Name = "Hajj"
            });

            return result;
        }
    }
}
