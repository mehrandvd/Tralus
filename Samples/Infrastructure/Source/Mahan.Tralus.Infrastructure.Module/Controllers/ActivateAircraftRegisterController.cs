using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraPrinting.Native;
using Mahan.Tralus.Framework.Module;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Infrastructure.Module.BusinessLogics;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    public class ActivateAircraftRegisterController : TralusBusinessLogicViewController<AircraftRegister, ActivateAircraftRegisterBusinessLogic>, IMultipleExecution<AircraftRegister>
    {
        protected override void OnAfterExecute()
        {
            RefreshDetailViewItems("IsActive");
        }

        public bool OnCanExecute(IEnumerable<AircraftRegister> entities)
        {
            return CanExecuteForAll(entities);
        }

        public void OnExecute(IEnumerable<AircraftRegister> entities)
        {
            ExecuteOneByOne(entities);
        }

    }
}
