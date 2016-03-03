using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using DevExpress.ExpressApp.DC;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("DelayType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class DelayType : FixedEntityBase<DelayType>
    {
        public DelayType(string fixedName)
            : base(fixedName)
        {
        }

        public DelayType()
            : base("")
        {
            DelayCodes = new List<DelayCode>();
        }

        public virtual ICollection<DelayCode> DelayCodes { get; set; }

        public static DelayType AirTrafficControl
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType CargoandMailHandling
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType DamagetoAircraft
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType OperationandCrew
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType PassengerandBaggageHandling
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType Ramp
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType ReactionaryReasonsorMiscellaneous
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType Technical
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType Uncategorized
        {
            get { return GetFixedEntity(); }
        }

        public static DelayType Weather
        {
            get { return GetFixedEntity(); }
        }


        public override List<DelayType> PredefinedValues()
        {
            var result = new List<DelayType>();

            result.Add(new DelayType("AirTrafficControl")
            {
                Id = new Guid("9B66E433-2303-453C-B3EE-FEDDD854DBEB"),
                Name = "Air Traffic Control"
            });

            result.Add(new DelayType("CargoandMailHandling")
            {
                Id = new Guid("78E8AD94-4EF6-49F5-9C77-79EFA58E0C2F"),
                Name = "Cargo and Mail Handling"
            });

            result.Add(new DelayType("DamagetoAircraft")
            {
                Id = new Guid("D310871C-CC9F-4593-9398-CB598A2621D7"),
                Name = "Damage to Aircraft"
            });

            result.Add(new DelayType("OperationandCrew")
            {
                Id = new Guid("0C2117AC-6594-4177-AD1D-22280F0F220C"),
                Name = "Operation and Crew"
            });

            result.Add(new DelayType("PassengerandBaggageHandling")
            {
                Id = new Guid("A85F3663-C817-46F2-A0A6-28080EE9154E"),
                Name = "Passenger and Baggage Handling "
            });

            result.Add(new DelayType("Ramp")
            {
                Id = new Guid("E1635E2F-3E67-4F4E-8DC6-7B30A1256F35"),
                Name = "Ramp"
            });

            result.Add(new DelayType("ReactionaryReasonsorMiscellaneous")
            {
                Id = new Guid("EC7D22B4-F2E9-4C42-B260-0AA9BE689792"),
                Name = "Reactionary Reasons or Miscellaneous"
            });

            result.Add(new DelayType("Technical")
            {
                Id = new Guid("4D1E01DA-9C98-484A-BC70-BAF4FD24F4BE"),
                Name = "Technical"
            });

            result.Add(new DelayType("Uncategorized")
            {
                Id = new Guid("325D51D3-5958-4132-AE3A-E1EF78D4B833"),
                Name = "Uncategorized"
            });

            result.Add(new DelayType("Weather")
            {
                Id = new Guid("C2082E03-A41C-4693-ABB5-F3ED8269094D"),
                Name = "Weather"
            });

            return result;
        }
    }
}
