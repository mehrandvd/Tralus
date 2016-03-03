using Tralus.Framework.Module;
using Mahan.Infrastructure.BusinessModel;
using Mahan.Infrastructure.Module.BusinessLogics;

namespace Mahan.Infrastructure.Module.Controllers
{
    public class DeactivateAircraftRegisterController : TralusBusinessLogicViewController<AircraftRegister, DeactivateAircraftRegisterBusinessLogic>
    {
        protected override void OnAfterExecute()
        {
            RefreshDetailViewItems("IsActive");
        }
    }
}
