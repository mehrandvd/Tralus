using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.Module;
using Mahan.Infrastructure.BusinessModel;
using Mahan.Infrastructure.Module.Security;

namespace Mahan.Infrastructure.Module.BusinessLogics
{
    public class ActivateAircraftRegisterBusinessLogic : TralusEntityBusinessLogic<AircraftRegister>
    {
        protected override void ExecuteImpl()
        {
            base.ExecuteImpl();
            var aircraftRegister = SelectedObject;
            aircraftRegister.IsActive = true;
        }

        protected override bool CanExecuteImpl()
        {
            var aircraftRegister = SelectedObject;
            return !aircraftRegister.IsActive;
        }

        protected override IEnumerable<IPermissionRequest> GetSecurityRequests()
        {
            var aircraftRegister = SelectedObject;

            List<IPermissionRequest> securityRequests = null;

            if (
                aircraftRegister != null &&
                aircraftRegister.Aircraft != null &&
                aircraftRegister.Aircraft.AircraftType != null
                )
            {
                securityRequests = new List<IPermissionRequest>
                {
                    CreatePermissionRequest(aircraftRegister.Aircraft.AircraftType,
                        BusinessModel.SecurityOperations.ActivateAircrafts)
                };
            }

            return securityRequests;
        }



    }
}
