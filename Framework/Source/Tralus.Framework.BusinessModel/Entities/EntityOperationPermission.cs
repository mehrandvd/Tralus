using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Security;

namespace Tralus.Framework.BusinessModel.Entities
{
    public class EntityOperationPermission : IOperationPermission
    {
        public EntityOperationPermission(string operation)
        {
            Operation = operation;
        }

        public string Operation { get; private set; }
    }
}
