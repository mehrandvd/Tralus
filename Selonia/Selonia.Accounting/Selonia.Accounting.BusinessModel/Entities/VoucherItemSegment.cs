using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class VoucherItemSegment : EntityBase
    {
        public virtual VoucherItem VoucherItem { get; set; }
        public virtual Segment Segment { get; set; }
    }
}