using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Base.General;

namespace Tralus.Framework.BusinessModel.Entities
{
    public interface IHierarchyEntity : IHCategory, ITreeNodeImageProvider
    {
    }
}
