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

        public virtual ICollection<VoucherItem> VoucherItems { get; set; }
    }
}
