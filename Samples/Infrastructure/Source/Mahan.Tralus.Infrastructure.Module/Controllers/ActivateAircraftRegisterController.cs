using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraPrinting.Native;
using Tralus.Framework.Module;
using Mahan.Infrastructure.BusinessModel;
using Mahan.Infrastructure.Module.BusinessLogics;

namespace Mahan.Infrastructure.Module.Controllers
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
