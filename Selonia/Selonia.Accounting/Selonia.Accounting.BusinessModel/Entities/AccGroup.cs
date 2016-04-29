using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base.General;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class AccGroup : AccStructure
    {
        public AccGroup()
        {
            Generals = new Collection<AccGeneral>();
        }

        public virtual ICollection<AccGeneral> Generals { get; set; }
        

        public override IHierarchyEntity Parent
        {
            get { return null; }
            set { }
        }

        public override IBindingList Children => new BindingList<AccGeneral>(Generals.ToList());
    }
}