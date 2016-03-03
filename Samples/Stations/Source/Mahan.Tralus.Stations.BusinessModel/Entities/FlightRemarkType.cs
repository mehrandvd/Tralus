using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightRemarkType", Schema = "Stations")]
    [DefaultProperty("Code")]
    public class FlightRemarkType : FixedEntityBase<FlightRemarkType>
    {
        public FlightRemarkType(string fixedName)
            : base(fixedName)
        {
        }

        public FlightRemarkType()
            : base("")
        {

        }

        public int Code { get; set; }

        public static FlightRemarkType FR
        {
            get
            {
                return GetFixedEntity();
            }
        }

        public override List<FlightRemarkType> PredefinedValues()
        {
            var result = new List<FlightRemarkType>();

            result.Add(new FlightRemarkType("FR")
            {
                Id = new Guid("AA2F9EFA-8A63-4D00-B9FD-64009FDA718A"),
                Name = "FR",
                Code = 1
            });

            return result;
        }
    }
}