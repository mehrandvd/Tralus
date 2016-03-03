using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("Unit", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Unit : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }
    }
}
