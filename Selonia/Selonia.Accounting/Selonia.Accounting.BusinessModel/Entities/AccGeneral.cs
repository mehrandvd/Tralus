using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.AccGeneral")]
    public class AccGeneral : AccStructure
    {
        public AccGroup Group { get; set; }

        public virtual ICollection<AccLedger> Ledgers { get; set; }

        public override IHierarchyEntity Parent
        {
            get { return Group; }
            set { Group = (AccGroup) value; }
        }

        public override IBindingList Children => new BindingList<AccLedger>(Ledgers.ToList());
    }
}