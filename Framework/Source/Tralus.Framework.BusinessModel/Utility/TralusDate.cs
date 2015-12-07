using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.ExpressApp.DC;
using NodaTime;

namespace Tralus.Framework.BusinessModel.Utility
{
    /// <summary>
    /// Use this class as a ComplexType in entities to represent a DateTime property. This type creates 13 related columns in database.
    /// </summary>
    [DomainComponent]
    public class TralusDate
    {
        private DateTime? _date;
        private string _dateInAltCalendar;

        /// <summary>
        /// Gets or sets the DateTime value. This property holds the main value for DateTime. The other properties
        /// are calculated based on this value.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? Date
        {
            get { return _date; }
            set
            {
                DateTime? newValue;
                if (value != null)
                    newValue = DateTime.SpecifyKind(value.Value, DateTimeKind.Utc).Date;
                else
                    newValue = null;

                if (newValue != _date)
                {
                    _date = newValue;
                    AffectUtcChanged();
                }
            }
        }

        /// <summary>
        /// Gets the Shamsi representation of Date. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        public string DateInAltCalendar
        {
            get
            {
                if (Date != null)
                    return _dateInAltCalendar ?? (_dateInAltCalendar = GetDateInAltCalendar(Date.Value));
                return null;
            }
            private set { _dateInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Year of DateTimeUtc in the AltCalendar
        /// </summary>
        public int? AltCalendarYearUtc
        {
            get
            {
                if (Date.HasValue)
                    return AltCalendar.GetYear(Date.Value);
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Month of DateTimeUtc in the AltCalendar
        /// </summary>
        public int? AltCalendarMonthUtc
        {
            get
            {
                if (Date.HasValue)
                    return AltCalendar.GetMonth(Date.Value);
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Day of DateTimeUtc in the AltCalendar
        /// </summary>
        public int? AltCalendarDayUtc
        {
            get
            {
                if (Date.HasValue)
                    return AltCalendar.GetDayOfMonth(Date.Value);
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Default AltCalendar which is used for AltCalendar properties conversions.
        /// </summary>
        private static readonly Calendar AltCalendar = TralusDateTime.AltCalendar;

        /// <summary>
        /// Will be called automatically when Date property is set to a new value.
        /// The main job of this method is to clear the proper private variables to enforce them to recalculate.
        /// </summary>
        private void AffectUtcChanged()
        {
            _dateInAltCalendar = null;
        }

        private string GetDateInAltCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
                AltCalendar.GetYear(dateTime),
                AltCalendar.GetMonth(dateTime),
                AltCalendar.GetDayOfMonth(dateTime));
        }

        /// <summary>
        /// Checks the <param name="dateTime"></param> kind. If it is Utc it will be assigned to Date,
        /// otherwise it will be assigned to DateTimeLocal
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static implicit operator TralusDate(DateTime dateTime)
        {
            var tralusDate = new TralusDate();

            if (dateTime.Kind == DateTimeKind.Utc)
            {
                tralusDate.Date = dateTime;
            }
            else
                tralusDate.Date = dateTime.ToUniversalTime().Date;

            return tralusDate;
        }

        /// <summary>
        /// Checks the <param name="dateTime"></param> kind. If it is Utc it will be assigned to DateTimeUtc,
        /// otherwise it will be assigned to DateTimeLocal
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static implicit operator TralusDate(TralusDateTime dateTime)
        {
            var tralusDate = new TralusDate {Date = dateTime.DateUtc};
            return tralusDate;
        }

        /// <summary>
        /// Checks if value is between <paramref name="from"/> and <paramref name="to"/> 
        /// and is NOT equal to neither <paramref name="from"/> nor <paramref name="to"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool IsBetween(DateTime from, DateTime to)
        {
            return Date > from.ToUniversalTime() && Date < to.ToUniversalTime();
        }

        /// <summary>
        /// Checks if value is between <paramref name="from"/> and <paramref name="to"/> 
        /// or is equal with <paramref name="from"/> but NOT equal to <paramref name="to"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool IsBetweenEqualLeft(DateTime from, DateTime to)
        {
            return Date >= from.ToUniversalTime() && Date < to.ToUniversalTime();
        }

        /// <summary>
        /// Checks if value is between <paramref name="from"/> and <paramref name="to"/> 
        /// or is equal to <paramref name="to"/> but NOT equal to <paramref name="from"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool IsBetweenEqualRight(DateTime from, DateTime to)
        {
            return Date > from.ToUniversalTime() && Date <= to.ToUniversalTime();
        }

        /// <summary>
        /// Checks if value is between <paramref name="from"/> and <paramref name="to"/> 
        /// or is equal to either <paramref name="to"/> or <paramref name="from"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool IsBetweenEqualBoth(DateTime from, DateTime to)
        {
            return Date >= from.ToUniversalTime() && Date <= to.ToUniversalTime();
        }

        /// <summary>
        /// Returns a string that represents the current local dateTime in alternative calendar.
        /// </summary>
        /// <example>1394/05/25</example>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return DateInAltCalendar;
        }
    }
}
