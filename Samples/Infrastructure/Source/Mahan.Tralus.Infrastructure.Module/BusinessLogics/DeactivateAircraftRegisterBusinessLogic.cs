using Tralus.Framework.Module;
using Mahan.Infrastructure.BusinessModel;

namespace Mahan.Infrastructure.Module.BusinessLogics
{
    public class DeactivateAircraftRegisterBusinessLogic : TralusEntityBusinessLogic<AircraftRegister>
    {
        protected override void ExecuteImpl()
        {
            base.ExecuteImpl();
            var aircraftRegister = SelectedObject;
            aircraftRegister.IsActive = false;
        }

        protected override bool CanExecuteImpl()
        {
            var aircraftRegister = SelectedObject;
            return aircraftRegister.IsActive;
        }
    }
}