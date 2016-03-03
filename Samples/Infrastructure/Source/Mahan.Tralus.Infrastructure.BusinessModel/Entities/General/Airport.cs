using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Security;

namespace Mahan.Infrastructure.BusinessModel
{
    /// <summary>
    /// اطلاعات مربوط به یک فرودگاه در این شی ذخیره می‌شود.
    /// </summary>
    [Table("Airport", Schema = "Infrastructure")]
    [DefaultProperty("IataAirportCode")]
    [SecurityAvailablePermissions(
        SecurityOperations.ApproveFulingInvoice, 
        SecurityOperations.EditFlightLeg,
        SecurityOperations.RegisterFuelingInvoice
        )
    ]
    public class Airport : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(200)]
        public string NameEn { get; set; }

        [StringLength(3)]
        public string IataAirportCode { get; set; }
        
        public virtual City City { get; set; }
        public Guid? CityId { get; set; }
        
        [StringLength(20)]
        public string Status { get; set; }
        
        public virtual LocalityType LocalityType { get; set; }
        public Guid? LocalityTypeId { get; set; }
        
        [StringLength(200)]
        public string NickName { get; set; }
    }
}
