using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.DC;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("AirlineStation", Schema = "Infrastructure")]
    [DefaultProperty("NameEn")]
    public class AirlineStation : EntityBase
    {
        public AirlineStation()
        {
            Airports = new Collection<AirportAirlineStation>();
        }
     
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(200)]
        public string NameEn { get; set; }
        
        [StringLength(200)]
        public string StationManagerName { get; set; }
        
        [StringLength(200)]
        public string StationManagerMobilePhone { get; set; }
        
        [StringLength(200)]
        public string PhoneNo { get; set; }
        
        [StringLength(200)]
        public string Fax { get; set; }
        
        [StringLength(200)]
        public string Extension { get; set; }
        
        [StringLength(200)]
        public string EmailAddress { get; set; }
        
        public virtual LocalityType LocalityType { get; set; }
        public Guid? LocalityTypeId { get; set; }
        
        public virtual ICollection<AirportAirlineStation> Airports { get; set; } 
    }
}