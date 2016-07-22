using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel
{
    [Table("Accounting.VoucherItem")]
    public class VoucherItem : EntityBase, IOrderedEntity
    {
        private long _debit;
        private long _credit;

        public virtual int RowNo { get; private set; }

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

        [Obsolete("A controller in framework does this job.")]
        public void SetRowNo(int? rowNo = null)
        {
            if (rowNo.HasValue)
            {
                RowNo = rowNo.Value;
                return;
            }

            if (IsNew() && RowNo == 0)
            {
                RowNo = (Voucher?.VoucherItems.Any() ?? false)
                ? (int)Voucher?.VoucherItems.Max(o => o.RowNo) + 1 : 1;
            }
        }

        public void SetRowNo(int rowNo)
        {
            RowNo = rowNo;
        }

        public int RowNoProperty => RowNo;
        public IEnumerable RefList => Voucher?.VoucherItems;
    }
}