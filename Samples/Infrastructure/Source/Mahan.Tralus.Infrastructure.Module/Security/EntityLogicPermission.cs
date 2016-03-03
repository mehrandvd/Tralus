using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module;

namespace Mahan.Infrastructure.Module.Security
{
    public class EntityLogicPermission<TBusinessLogic, TBusinessLogicEntity> : IOperationPermission
        where TBusinessLogic : TralusEntityBusinessLogic<TBusinessLogicEntity>
        where TBusinessLogicEntity : EntityBase
    {
        public string Operation { get { return typeof (TBusinessLogic).FullName; } }
    }
}
