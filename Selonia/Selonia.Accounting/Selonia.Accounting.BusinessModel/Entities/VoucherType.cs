using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.VoucherType")]
    public class VoucherType : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
