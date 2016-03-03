using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
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
