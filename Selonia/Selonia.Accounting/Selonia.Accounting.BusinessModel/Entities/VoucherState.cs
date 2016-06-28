using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;

namespace Selonia.Accounting.BusinessModel.Entities
{
    [Table("Accounting.VoucherState")]
    public class VoucherState : FixedEntityBase
    {
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

        protected override IList GetFixedItems()
        {
            var list = new[]
            {
                new VoucherState((Values.Draft))
                {
                    Id = new Guid("D1AAD34F-5A77-497A-8171-C04AD2153AA1"),
                    Name = "یادداشت",
                },
                new VoucherState((Values.Registered))
                {
                    Id = new Guid("0FBF0778-0072-4EB4-8312-91A681EAD01D"),
                    Name = "ثبت شده",
                },
                new VoucherState((Values.Accepted))
                {
                    Id = new Guid("9FC156A2-311A-4C72-8636-F39296E67082"),
                    Name = "تایید شده",
                },
                new VoucherState((Values.Fixed))
                {
                    Id = new Guid("CC7F3F88-6C98-466D-8203-663728C92F8A"),
                    Name = "قطعی شده",
                },

            };

            return list;
        }

        #region Tralus Code
        public VoucherState(Values value) : base(value)
        {
        }

        public VoucherState() : base(null)
        {
        }

        public override void PredefineData(DbContext dbContext)
        {
            dbContext.AddOrUpdate(All<VoucherState>());
        }

        public static implicit operator VoucherState(Values value)
        {
            return new VoucherState().All<VoucherState>().First(o => o.Value == value.ToString());
        }
        #endregion

       
    }

    
}
