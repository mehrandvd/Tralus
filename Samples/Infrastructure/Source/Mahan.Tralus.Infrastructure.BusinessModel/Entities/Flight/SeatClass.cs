using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("SeatClass", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class SeatClass : FixedEntityBase<SeatClass>
    {
        public SeatClass()
            : base("")
        {

        }

        public SeatClass(string fixedName)
            : base(fixedName)
        {
        }

        public long? Code { get; set; }

        public static SeatClass C
        {
            get { return GetFixedEntity(); }
        }

        public static SeatClass P
        {
            get { return GetFixedEntity(); }
        }

        public static SeatClass Y
        {
            get { return GetFixedEntity(); }
        }

        public override List<SeatClass> PredefinedValues()
        {
            var result = new List<SeatClass>
            {
                new SeatClass("C")

                {
                    Id = new Guid("51B00235-1EBF-43A9-AB6F-C937CE00450B"),
                    Code = 100,
                    Name = "C"
                },
                new SeatClass("P")
                {
                    Id = new Guid("BEF6EF82-A011-483F-981C-5C06A738C93E"),
                    Code = 102,
                    Name = "P"
                },
                new SeatClass("Y")
                {
                    Id = new Guid("5442A4FB-A54A-4969-823A-5B8531D2C63E"),
                    Code = 101,
                    Name = "Y"
                }
            };


            return result;
        }
    }
}
