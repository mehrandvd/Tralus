using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Security;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    /// <summary>
    /// نوع هواپیما: مدل‌های مختلف هواپیما
    /// </summary>
    [Table("AircraftType", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    [SecurityAvailablePermissions(SecurityOperations.ActivateAircrafts)]
    public class AircraftType : EntityBase
    {

        public AircraftType()
        {
            Aircrafts = new Collection<Aircraft>();
        }
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Manufacturer { get; set; }
        
        [StringLength(200)]
        public string TypeVariation { get; set; }
        
        [StringLength(200)]
        public string FullTypeName { get; set; }
        
        [StringLength(3)]
        public string IataCode { get; set; }
        
        [StringLength(4)]
        public string IcaoCode { get; set; }
        
        [StringLength(3)]
        public string FwName { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        //public new static IEnumerable<string> AvailablePermissions
        //{
        //    get { yield return SecurityOperations.ActivateAircrafts; }
        //}

        public virtual ICollection<Aircraft> Aircrafts { get; set; } 
    }
}
