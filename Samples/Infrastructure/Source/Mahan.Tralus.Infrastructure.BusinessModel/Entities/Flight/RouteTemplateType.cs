using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("RouteTemplateType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class RouteTemplateType : EntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }
    }
}