using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("Unit", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Unit : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }
    }
}
