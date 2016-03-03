using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("RouteAircraft", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class RouteAircraft : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }

        public long? NumLegs { get; set; }
    }
}
