using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    /// <summary>
    /// اطلاعات مربوط به یک شرکت هواپیمایی در این شی ذخیره می‌شود.
    /// </summary>
    [Table("Airline", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Airline : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }
        
        public virtual Country Country { get; set; }
        public Guid? CountryId { get; set; }
        
        [StringLength(200)]
        public string IataCode { get; set; }
        
        [StringLength(200)]
        public string IcaoCode { get; set; }
        
        [StringLength(200)]
        public string Abv { get; set; }
        
        [StringLength(200)]
        public string FullName { get; set; }
        
        [StringLength(200)]
        public string ShortName { get; set; }
        
        [StringLength(20)]
        public string Status { get; set; }
    }
}
