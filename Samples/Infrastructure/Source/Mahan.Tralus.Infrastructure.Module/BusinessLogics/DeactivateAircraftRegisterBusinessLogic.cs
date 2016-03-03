using Mahan.Tralus.Framework.Module;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Infrastructure.Module.BusinessLogics
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