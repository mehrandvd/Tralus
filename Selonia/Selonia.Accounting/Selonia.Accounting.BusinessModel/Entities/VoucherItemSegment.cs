using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.VoucherItemSegment")]
    public class VoucherItemSegment : EntityBase
    {
        public virtual VoucherItem VoucherItem { get; set; }
        public virtual Segment Segment { get; set; }
    }
}