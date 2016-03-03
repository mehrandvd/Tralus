using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    /// <summary>
    /// اطلاعات مربوط به ماهیت یک هواپیما در این شی ذخیره می‌شود.
    /// این هواپیما برای شرکت‌های هواپیمایی به عنوان یک رجیستر شناخته می‌شود که در شی
    /// AircraftRegister
    /// شناخته می‌شود.
    /// </summary>
    [Table("Aircraft", Schema = "Infrastructure")]
    [DefaultProperty("Register")]
    public class Aircraft : EntityBase
    {
        public Aircraft()
        {
            AircraftRegisters = new Collection<AircraftRegister>();
        }

        [StringLength(200)]
        public string SerialNo { get; set; }
        
        public virtual AircraftType AircraftType { get; set; }
        public Guid? AircraftTypeId { get; set; }
        
        [StringLength(200)]
        public string Register { get; set; }
        public virtual ICollection<AircraftRegister> AircraftRegisters { get; set; } 

    }
}
