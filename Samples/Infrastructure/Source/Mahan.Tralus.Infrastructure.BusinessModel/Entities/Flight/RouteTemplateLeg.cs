using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("RouteTemplateLeg", Schema = "Infrastructure")]
    [DefaultProperty("LegOrder")]
    public class RouteTemplateLeg : EntityBase
    {
        public virtual RouteTemplate RouteTemplate { get; set; }
        public Guid? RouteTemplateId { get; set; }

        public virtual Leg Leg { get; set; }
        public Guid? LegId { get; set; }

        public long? LegOrder { get; set; }
    }
}
