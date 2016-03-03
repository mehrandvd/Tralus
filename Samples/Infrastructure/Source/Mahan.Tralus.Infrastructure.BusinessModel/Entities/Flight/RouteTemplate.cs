using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("RouteTemplate", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class RouteTemplate : EntityBase
    {
        [StringLength(200)]
        public string Name { get; set; }

        public virtual RouteTemplateType RouteTemplateType { get; set; }
        public Guid? RouteTemplateTypeId { get; set; }
    }
}
