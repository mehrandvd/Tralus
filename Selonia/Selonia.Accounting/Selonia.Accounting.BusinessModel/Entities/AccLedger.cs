using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.AccLedger")]
    public class AccLedger : AccStructure
    {
        public virtual AccGeneral General { get; set; }

        public override IHierarchyEntity Parent
        {
            get { return General; }
            set { General = (AccGeneral) value; }
        }

        public override IBindingList Children => new BindingList<AccLedger>();
    }
}