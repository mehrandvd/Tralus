using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class VoucherItem : EntityBase
    {
        private long _debit;
        private long _credit;

        public VoucherItem()
        {
            VoucherItemSegments = new List<VoucherItemSegment>();
        }
        public virtual int RowNo { get; set; }

        public virtual long Debit
        {
            get { return _debit; }
            set
            {
                _debit = value;

                if (Voucher != null)
                    Voucher.DebitSum = null;
            }
        }

        public virtual long Credit
        {
            get { return _credit; }
            set
            {
                _credit = value;

                if (Voucher != null)
                    Voucher.CreditSum = null;
            }
        }

        public virtual AccLedger Ledger { get; set; }

        public virtual string Description { get; set; }

        [NotMapped]
        public virtual Segment Segment1 { get; set; }

        [NotMapped]
        public virtual Segment Segment2 { get; set; }

        [NotMapped]
        public virtual Segment Segment3 { get; set; }

        [NotMapped]
        public virtual Segment Segment4 { get; set; }

        public virtual Voucher Voucher { get; set; }

        public virtual ICollection<VoucherItemSegment> VoucherItemSegments { get; set; }
    }
}