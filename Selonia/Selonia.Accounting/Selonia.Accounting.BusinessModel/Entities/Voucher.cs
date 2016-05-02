using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class Voucher : EntityBase
    {
        public Voucher()
        {
            VoucherItems = new List<VoucherItem>();
        }

        public virtual DateTime? VoucherDate { get; set; }

        public virtual string TempNo { get; set; }

        public virtual string FixNo { get; set; }

        public virtual string Description { get; set; }

        public virtual VoucherType VoucherType { get; set; }

        public virtual VoucherState VoucherState { get; set; }

        private long? _creditSum;
        public virtual long? CreditSum
        {
            get { return _creditSum ?? (_creditSum = VoucherItems.Sum(vi => vi.Credit)); }
            set { _creditSum = value; }
        }

        private long? _debitSum;
        public virtual long? DebitSum
        {
            get { return _debitSum ?? (_debitSum = VoucherItems.Sum(vi => vi.Debit)); }
            set { _debitSum = value; }
        }

        [Aggregated]
        public virtual ICollection<VoucherItem> VoucherItems { get; set; }
    }
}
