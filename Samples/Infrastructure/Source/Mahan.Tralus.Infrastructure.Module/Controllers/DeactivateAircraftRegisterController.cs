using Mahan.Tralus.Framework.Module;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Infrastructure.Module.BusinessLogics;

namespace Mahan.Tralus.Infrastructure.Module.Controllers
{
    public class DeactivateAircraftRegisterController : TralusBusinessLogicViewController<AircraftRegister, DeactivateAircraftRegisterBusinessLogic>
    {
        protected override void OnAfterExecute()
        {
            RefreshDetailViewItems("IsActive");
        }
    }
}
