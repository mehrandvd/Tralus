using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tralus.Framework.BusinessModel.Entities
{
    public interface IOrderedEntity
    {
        int RowNoProperty { get; }
        void SetRowNo(int rowNo);
        IEnumerable RefList { get; }
    }
}
