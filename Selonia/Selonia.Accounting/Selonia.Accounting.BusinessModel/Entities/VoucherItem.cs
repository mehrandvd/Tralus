using System.Collections.Generic;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class VoucherItem : EntityBase
    {
        public VoucherItem()
        {
            VoucherItemSegments = new List<VoucherItemSegment>();
        }
        public virtual int RowNo { get; set; }
        public virtual long Debit { get; set; }
        public virtual long Credit { get; set; }
        public virtual AccLedger Ledger { get; set; }
        public virtual string Description { get; set; }

        public virtual ICollection<VoucherItemSegment> VoucherItemSegments { get; set; }
    }
}