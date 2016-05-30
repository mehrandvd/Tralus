using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("EntitySequence", Schema = "System")]
    public class EntitySequence : EntityBase
    {
        public EntitySequence()
        {
            SequenceItems = new List<EntitySequenceItem>();
        }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual ICollection<EntitySequenceItem> SequenceItems { get; set; }
    }
}
