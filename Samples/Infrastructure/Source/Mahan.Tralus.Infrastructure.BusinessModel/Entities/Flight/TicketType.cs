using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("TicketType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class TicketType : FixedEntityBase<TicketType>
    {
        public TicketType()
            : base("")
        {

        }

        public TicketType(string fixedName)
            : base(fixedName)
        {
        }

        public long? Code { get; set; }

        public static TicketType E_TKT
        {
            get { return GetFixedEntity(); }
        }

        public static TicketType FOC
        {
            get { return GetFixedEntity(); }
        }

        public static TicketType P_GS
        {
            get { return GetFixedEntity(); }
        }

        public override List<TicketType> PredefinedValues()
        {
            var result = new List<TicketType>
            {
                new TicketType("E_TKT")
                {
                    Id = new Guid("C03F954E-CE11-4517-AD0F-8502D634FBBE"),
                    Code = 100,
                    Name = "E_TKT"
                },
                new TicketType("FOC")
                {
                    Id = new Guid("3487089E-700E-4692-B908-532CA5E2A08B"),
                    Code = 101,
                    Name = "FOC"
                },
                new TicketType("P_GS")
                {
                    Id = new Guid("E8ADFD66-B107-439D-9872-7C8187D2C629"),
                    Code = 102,
                    Name = "P_GS"
                }
            };


            return result;
        }
    }
}
