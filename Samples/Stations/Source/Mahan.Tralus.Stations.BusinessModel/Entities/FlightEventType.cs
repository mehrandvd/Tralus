using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightEventType", Schema = "Stations")]
    [DefaultProperty("Code")]
    public class FlightEventType : FixedEntityBase<FlightEventType>
    {
        public FlightEventType() : this ("")
        {
            
        }

        public FlightEventType(string fixedName) : base(fixedName)
        {
        }

        public string Name { get; set; }

        public static FlightEventType ATA
        {
            get { return GetFixedEntity(); }
        }

        public static FlightEventType CCT
        {
            get { return GetFixedEntity(); }
        }

        public static FlightEventType DCT
        {
            get { return GetFixedEntity(); }
        }

        public static FlightEventType IN
        {
            get { return GetFixedEntity(); }
        }

        public static FlightEventType OUT
        {
            get { return GetFixedEntity(); }
        }

        public static FlightEventType OFF
        {
            get { return GetFixedEntity(); }
        }

        public override List<FlightEventType> PredefinedValues()
        {
            var result = new List<FlightEventType>();

            result.Add(
                new FlightEventType("ATA")
                {
                    Id = new Guid("675D7DDD-448B-44EF-96CB-BB8B77855395"),
                    Name = "ATA"
                });

            result.Add(
                new FlightEventType("CCT")
                {
                    Id = new Guid("D44ADF77-2348-410C-914F-E4BE75CE01C2"),
                    Name = "CCT"
                });

            result.Add(
                new FlightEventType("DCT")
                {
                    Id = new Guid("00B251FA-5E69-4BA0-8C7E-C419B5CE6332"),
                    Name = "DCT"
                });

            result.Add(
                new FlightEventType("IN")
                {
                    Id = new Guid("035D9951-5C35-4CEC-A5E8-5EE4313454FB"),
                    Name = "IN"
                });

            result.Add(
                new FlightEventType("OUT")
                {
                    Id = new Guid("11540FE7-3CEA-4616-869E-6394B94679A0"),
                    Name = "OUT"
                });

            result.Add(
                new FlightEventType("OFF")
                {
                    Id = new Guid("792A9EE3-0ACF-44BC-AE4A-2721D47617C3"),
                    Name = "OFF"
                });

            return result;
        }
    }
}