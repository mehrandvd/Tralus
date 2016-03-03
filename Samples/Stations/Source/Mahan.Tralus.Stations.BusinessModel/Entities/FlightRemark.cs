using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel;
using Mahan.Tralus.Framework.BusinessModel.Entities;
using Mahan.Tralus.Framework.BusinessModel.Utility;
using Mahan.Tralus.Infrastructure.BusinessModel;

namespace Mahan.Tralus.Stations.BusinessModel
{
    [Table("FlightRemark", Schema = "Stations")]
    [DefaultProperty("Remark")]
    public class FlightRemark : EntityBase
    {
        public FlightRemark()
        {
            CreationDate = new TralusDateTime();
        }

        [StringLength(200)]
        public string Title { get; set; }
        
        public string Remark { get; set; }
        
        public virtual User User { get; set; }
        public Guid?  UserId { get; set; }
        
        public TralusDateTime CreationDate { get;  set; }
        
        public virtual FlightLeg FlightLeg { get; set; }
        public Guid?  FlightLegId { get; set; }

        public virtual FlightRemarkType FlightRemarkType { get; set; }
        public Guid?  FlightRemarkTypeId { get; set; }
    }
}
