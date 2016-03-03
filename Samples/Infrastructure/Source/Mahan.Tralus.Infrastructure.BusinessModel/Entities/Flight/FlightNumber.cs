using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("FlightNumber", Schema = "Infrastructure")]
    [DefaultProperty("FullFlightNumber")]
    public class FlightNumber : EntityBase
    {
        public virtual Airline Airline { get; set; }
        public Guid? AirlineId { get; set; }

        /// <summary>
        /// W5 1055
        /// </summary>
        [StringLength(200)]
        public string FullFlightNumber { get; set; }
        
        /// <summary>
        /// 1055
        /// </summary>
        public string ShortFlightNumber { get; set; }
    }
}
