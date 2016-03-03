using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Mask;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("TimeZone", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public partial class TimeZone : FixedEntityBase<TimeZone>
    {
        public TimeZone()
            : this("")
        {
        }

        public TimeZone(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(200)]
        public string IanaCode { get; set; }
    }
}
