using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Threading;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Utility;
using NodaTime;
using Persia;
using Calendar = System.Globalization.Calendar;

namespace Mahan.Infrastructure.BusinessModel
{/// <summary>
    /// این شی اطلاعات یک رجیستر هواپیما را نگه می‌دارد.
    /// یک رجیستر، یک هواپیما است که به واسطه اینکه در حال حاضر متعلق
    ///  به یک شرکت هواپیمایی است،  یک کد رجیستر گرفته است
    ///  و اغلب سیستم‌ها از این شی برای کار با هواپیما استفاده می‌کنند.
    /// </summary>
    [Table("AircraftRegister", Schema = "Infrastructure")]
    [DefaultProperty("Code")]
    public class AircraftRegister : EntityBase
    {
        public AircraftRegister()
        {
            UnAvailableSeats = new Collection<AircraftRegisterNonAvailableSeat>();
            SeatInfo = new Collection<AircraftRegisterSeatInfo>();
        }

        [StringLength(200)]
        public string Code { get; set; }

        public virtual Aircraft Aircraft { get; set; }
        public Guid? AircraftId { get; set; }

        [StringLength(3)]
        public string ShortRegisterCode { get; set; }

        public bool? HasFirstClassSeat { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        //public virtual LirRegisterGroup LirRegisterGroup { get; set; }

        //public Guid?LirRegisterGroupId { get; set; }

        public DateTime? Timestamp { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<AircraftRegisterNonAvailableSeat> UnAvailableSeats { get; set; }
        public virtual ICollection<AircraftRegisterSeatInfo> SeatInfo { get; set; }

    }
}
