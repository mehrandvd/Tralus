using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("Company", Schema = "Infrastructure")]
    [DefaultProperty("Title")]
    public class Company : EntityBase
    {
        public double? CommercialCode { get; set; }
        
        [StringLength(200)]
        public string Title { get; set; }
    }
}
