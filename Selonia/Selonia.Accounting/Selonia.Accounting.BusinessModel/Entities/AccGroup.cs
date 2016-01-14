using System.Collections.Generic;
using System.Collections.ObjectModel;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class AccGroup : EntityBase
    {
        public AccGroup()
        {
            Generals = new Collection<AccGeneral>();
        }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AccGeneral> Generals { get; set; }

    }
}