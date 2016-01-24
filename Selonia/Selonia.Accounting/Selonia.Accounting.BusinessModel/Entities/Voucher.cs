using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public virtual string VoucherNo { get; set; }


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

        public virtual ICollection<VoucherItem> VoucherItems { get; set; }
    }
}
