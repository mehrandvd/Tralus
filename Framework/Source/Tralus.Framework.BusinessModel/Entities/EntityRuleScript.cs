using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    [Table("Tralus.EntityRuleScript")]
    public class EntityRuleScript : EntityScript
    {

    }

    public enum WhenToRun
    {
        OnNew = 100,
        OnSaving = 101,
        OnSaved = 102,
        OnDeleting = 103,
        OnDeleted =104,
        OnEndEdit =105,
        OnChanged = 106
    }
}
