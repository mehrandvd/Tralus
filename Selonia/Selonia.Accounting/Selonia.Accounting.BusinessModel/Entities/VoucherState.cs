using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    public class VoucherState : FixedEntityBase<VoucherState>
    {
        public Values Value { get; set; }

        public VoucherState() : base("")
        {

        }

        public VoucherState(string fixedName) : base(fixedName)
        {
        }

        public override List<VoucherState> PredefinedValues()
        {
            return new List<VoucherState>
            {
                new VoucherState(nameof(Values.Draft))
                {
                    Id = new Guid("D1AAD34F-5A77-497A-8171-C04AD2153AA1"),
                    Value = Values.Draft,
                    Name = "یادداشت",
                },
                new VoucherState(nameof(Values.Registered))
                {
                    Id = new Guid("0FBF0778-0072-4EB4-8312-91A681EAD01D"),
                    Value = Values.Registered,
                    Name = "ثبت شده",
                },
                new VoucherState(nameof(Values.Accepted))
                {
                    Id = new Guid("9FC156A2-311A-4C72-8636-F39296E67082"),
                    Value = Values.Registered,
                    Name = "تایید شده",
                },
                new VoucherState(nameof(Values.Fixed))
                {
                    Id = new Guid("CC7F3F88-6C98-466D-8203-663728C92F8A"),
                    Value = Values.Fixed,
                    Name = "قطعی شده",
                },

            };
        }

        public enum Values
        {
            [ImageName("BO_Unknown"), XafDisplayName("")]
            Draft,
            [ImageName("BO_Note"), XafDisplayName("")]
            Registered,
            [ImageName("BO_Validation"), XafDisplayName("")]
            Accepted,
            [ImageName("BO_Folder"), XafDisplayName("")]
            Fixed
        }
    }

    
}
