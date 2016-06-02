using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("EntityNumbering", Schema = "System")]
    public class EntityNumbering : EntityScript
    {
        public string PropertyName { get; set; }
    }
}
