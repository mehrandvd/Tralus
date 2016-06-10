using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base.General;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.AccGroup")]
    public class AccGroup : AccStructure
    {
        public virtual ICollection<AccGeneral> Generals { get; set; }
        

        public override IHierarchyEntity Parent
        {
            get { return null; }
            set { }
        }

        public override IBindingList Children
            => new BindingList<AccGeneral>((Generals ?? new List<AccGeneral>()).ToList());

    }
}