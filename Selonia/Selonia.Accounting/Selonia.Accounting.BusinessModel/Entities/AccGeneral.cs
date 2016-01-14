using System.Collections.Generic;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class AccGeneral : EntityBase
    {
        public AccGeneral()
        {
            Ledgers = new List<AccLedger>();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public AccGroup Group { get; set; }

        public ICollection<AccLedger> Ledgers { get; set; }
    }
}