using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Model;

namespace Tralus.Framework.Module.Interface
{
    public interface ITralusDateTimeDefaultCalendarAndTimeZone : IModelNode
    {
        string DefaultCalendar { get; set; }
        string DefaultTimeZone { get; set; }
    }
}
