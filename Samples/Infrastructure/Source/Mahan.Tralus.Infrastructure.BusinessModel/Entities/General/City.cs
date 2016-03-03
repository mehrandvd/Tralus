using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using TimeZone = Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("City", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public partial class City : FixedEntityBase<City>
    {
        public City()
            : this("ForDbMigration")
        {

        }

        public City(string fixedName)
            : base(fixedName)
        {
        }

        public virtual Country Country { get; set; }
        public Guid? CountryId { get; set; }

        [StringLength(200)]
        public string NameEn { get; set; }

        public virtual TimeZone TimeZone { get; set; }
        public Guid? TimeZoneId { get; set; }
    }
}
