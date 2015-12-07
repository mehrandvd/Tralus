using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Threading;
using DevExpress.ExpressApp.DC;
using JetBrains.Annotations;
using NodaTime;

namespace Tralus.Framework.BusinessModel.Utility
{
    /// <summary>
    /// Use this class as a ComplexType in entities to represent a DateTime property. This type creates 13 related columns in database.
    /// </summary>
    [DomainComponent()]
    public class TralusDateTime
    {
        private DateTime? _dateTimeLocal;
        private Instant? _instant;
        private string _localTimeZoneId;
        private DateTimeZone _timeZone;
        private DateTime? _dateTimeUtc;
        private DateTime? _dateTimeHome;
        private string _dateUtcInAltCalendar;
        private string _dateLocalInAltCalendar;
        private string _dateHomeInAltCalendar;
        private string _dateTimeUtcInAltCalendar;
        private string _dateTimeLocalInAltCalendar;
        private string _dateTimeHomeInAltCalendar;
        /// <summary>
        /// Gets or sets the DateTime value. This property holds the main value for DateTime. The other properties
        /// are calculated based on this value.
        /// </summary>
        public DateTime? DateTimeUtc
        {
            get { return _dateTimeUtc; }
            set
            {
                DateTime? newValue;
                if (value != null)
                    newValue = DateTime.SpecifyKind(value.Value, DateTimeKind.Utc);
                else
                    newValue = null;

                if (newValue != _dateTimeUtc)
                {
                    _dateTimeUtc = newValue;
                    AffectUtcChanged();
                }
            }
        }

        /// <summary>
        /// Gets the DateTime in Local Time zone.
        /// </summary>
        public DateTime? DateTimeLocal
        {
            get
            {
                if (Instant.HasValue)
                {
                    return _dateTimeLocal ??
                           (_dateTimeLocal = new ZonedDateTime(Instant.Value, LocalTimeZone).ToDateTimeUnspecified());
                }
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the DateTime in Home Time zone.
        /// </summary>
        public DateTime? DateTimeHome
        {
            get
            {
                if (Instant.HasValue)
                {
                    return _dateTimeHome ?? (_dateTimeHome = new ZonedDateTime(Instant.Value, HomeTimeZone).ToDateTimeUnspecified());
                }
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Date part of DateTimeUtc.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateUtc
        {
            get
            {
                if (DateTimeUtc.HasValue)
                    return DateTimeUtc.Value.Date;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Date part of DateTimeLocal.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateLocal
        {
            get
            {
                if (DateTimeLocal.HasValue)
                    return DateTimeLocal.Value.Date;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Date part of DateTimeHome.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateHome
        {
            get
            {
                if (DateTimeHome.HasValue)
                    return DateTimeHome.Value.Date;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Year of DateTimeUtc in the AltCalendar
        /// </summary>
        public int? AltCalendarYearUtc
        {
            get
            {
                if (DateTimeUtc.HasValue)
                    return AltCalendar.GetYear(DateTimeUtc.Value);
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
                if (DateTimeUtc.HasValue)
                    return AltCalendar.GetMonth(DateTimeUtc.Value);
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
                if (DateTimeUtc.HasValue)
                    return AltCalendar.GetDayOfMonth(DateTimeUtc.Value);
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeUtc. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateUtcInAltCalendar
        {
            get
            {
                if (DateTimeUtc != null)
                    return _dateUtcInAltCalendar ?? (_dateUtcInAltCalendar = GetDateInAltCalendar(DateTimeUtc.Value));
                return null;
            }
            //private set { _dateUtcInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeLocal. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateLocalInAltCalendar
        {
            get
            {
                if (DateTimeLocal != null)
                    return _dateLocalInAltCalendar ?? (_dateLocalInAltCalendar = GetDateInAltCalendar(DateTimeLocal.Value));
                return null;
            }
            //private set { _dateLocalInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeHome. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateHomeInAltCalendar
        {
            get
            {
                if (DateTimeHome != null)
                    return _dateHomeInAltCalendar ?? (_dateHomeInAltCalendar = GetDateInAltCalendar(DateTimeHome.Value));
                return null;
            }
            //private set { _dateHomeInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeUtc. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateTimeUtcInAltCalendar
        {
            get
            {
                if (DateTimeUtc != null)
                    return _dateTimeUtcInAltCalendar ?? (_dateTimeUtcInAltCalendar = GetDateTimeInAltCalendar(DateTimeUtc.Value));
                return null;
            }
            //private set { _dateUtcInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeLocal. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateTimeLocalInAltCalendar
        {
            get
            {
                if (DateTimeLocal != null)
                    return _dateTimeLocalInAltCalendar ?? (_dateTimeLocalInAltCalendar = GetDateTimeInAltCalendar(DateTimeLocal.Value));
                return null;
            }
            //private set { _dateLocalInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Shamsi representation of DateTimeHome. (1394/05/25)
        /// </summary>
        /// <example>1394/05/25</example>
        [NotMapped]
        public string DateTimeHomeInAltCalendar
        {
            get
            {
                if (DateTimeHome != null)
                    return _dateTimeHomeInAltCalendar ?? (_dateTimeHomeInAltCalendar = GetDateTimeInAltCalendar(DateTimeHome.Value));
                return null;
            }
            //private set { _dateHomeInAltCalendar = value; }
        }

        /// <summary>
        /// Gets the Time part of DateTimeUtc.
        /// </summary>
        public TimeSpan? TimeUtc
        {
            get
            {
                if (DateTimeUtc.HasValue)
                    return DateTimeUtc.Value.TimeOfDay;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Time part of DateTimeLocal.
        /// </summary>
        public TimeSpan? TimeLocal
        {
            get
            {
                if (DateTimeLocal.HasValue)
                    return DateTimeLocal.Value.TimeOfDay;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets the Time part of DateTimeHome.
        /// </summary>
        public TimeSpan? TimeHome
        {
            get
            {
                if (DateTimeHome.HasValue)
                    return DateTimeHome.Value.TimeOfDay;
                return null;
            }
            private set { }
        }

        /// <summary>
        /// Gets a NodaTime instant of time representing the ticks from Unix epoch.
        /// </summary>
        [NotMapped]
        public Instant? Instant
        {
            get
            {
                if (DateTimeUtc.HasValue)
                {

                    return _instant ?? (_instant = NodaTime.Instant.FromDateTimeUtc(DateTimeUtc.Value));
                }

                return null;
            }
        }


        /// <summary>
        /// Set this proeprty for each object, if you want the local properties use a custom time zone.
        /// </summary>
        public string LocalTimeZoneId
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _localTimeZoneId, () => DefaultLocalTimeZondeId);
                return _localTimeZoneId;
            }
            set { _localTimeZoneId = value; }
        }

        /// <summary>
        /// Returns the time zone used for local properties.
        /// </summary>
        [NotMapped]
        public DateTimeZone LocalTimeZone
        {
            get
            {
                LazyInitializer.EnsureInitialized(ref _timeZone, () => DateTimeZoneProviders.Tzdb[LocalTimeZoneId]);
                return _timeZone;
            }
            protected set { }
        }

        /// <summary>
        /// Set this proeprty at startup time if you want the local properties use a custom DEFAULT time zone.
        /// </summary>
        public static string DefaultLocalTimeZondeId = DateTimeZoneProviders.Tzdb.GetSystemDefault().Id;

        /// <summary>
        /// Set this proeprty if you want the properties related to Home use a custom time zone.
        /// </summary>
        public static string HomeTimeZoneId = DateTimeZoneProviders.Tzdb.GetSystemDefault().Id;

        /// <summary>
        /// Returns the time zone used for properties related to Home.
        /// </summary>
        public static DateTimeZone HomeTimeZone
        {
            get
            {
                return DateTimeZoneProviders.Tzdb[HomeTimeZoneId];
            }
        }

        /// <summary>
        /// Default AltCalendar which is used for Shamsi properties conversions.
        /// </summary>
        public static readonly Calendar AltCalendar = new PersianCalendar();

        /// <summary>
        /// Sets the LocalDateTime with <param name="localDateTime"></param> valus.
        /// </summary>
        /// <param name="localDateTime">Contains the localDateTime dateTime which shoud be assigned to LocalDateTime</param>
        public void SetLocal(DateTime? localDateTime)
        {
            if (localDateTime != null)
            {
                DateTimeUtc = localDateTime.Value.ToUniversalTime();
            }
            else
            {
                DateTimeUtc = null;
            }
        }


        /// <summary>
        /// Will be called automatically when DateTimeUtc property is set to a new value.
        /// The main job of this method is to clear the proper private variables to enforce them to recalculate.
        /// </summary>
        private void AffectUtcChanged()
        {
            _dateTimeLocal = null;
            _instant = null;
            _dateTimeHome = null;
            _dateUtcInAltCalendar = null;
            _dateLocalInAltCalendar = null;
            _dateHomeInAltCalendar = null;
        }

        private string GetDateInAltCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00}",
                AltCalendar.GetYear(dateTime),
                AltCalendar.GetMonth(dateTime),
                AltCalendar.GetDayOfMonth(dateTime));
        }

        private string GetDateTimeInAltCalendar(DateTime dateTime)
        {
            return string.Format("{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}",
                AltCalendar.GetYear(dateTime),
                AltCalendar.GetMonth(dateTime),
                AltCalendar.GetDayOfMonth(dateTime),
                AltCalendar.GetHour(dateTime),
                AltCalendar.GetMinute(dateTime),
                AltCalendar.GetSecond(dateTime));
        }

        /// <summary>
        /// Checks the <param name="dateTime"></param> kind. If it is Utc it will be assigned to DateTimeUtc,
        /// otherwise it will be assigned to DateTimeLocal
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static implicit operator TralusDateTime(DateTime dateTime)
        {
            var tralusDateTime = new TralusDateTime();

            if (dateTime.Kind == DateTimeKind.Utc)
            {
                tralusDateTime.DateTimeUtc = dateTime;
            }
            else
                tralusDateTime.SetLocal(dateTime);

            return tralusDateTime;
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
            return DateTimeUtc > from.ToUniversalTime() && DateTimeUtc < to.ToUniversalTime();
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
            return DateTimeUtc >= from.ToUniversalTime() && DateTimeUtc < to.ToUniversalTime();
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
            return DateTimeUtc > from.ToUniversalTime() && DateTimeUtc <= to.ToUniversalTime();
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
            return DateTimeUtc >= from.ToUniversalTime() && DateTimeUtc <= to.ToUniversalTime();
        }

        /// <summary>
        /// Returns a string that represents the current local dateTime in Shamsi calendar.
        /// </summary>
        /// <example>1394/05/25</example>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return DateTimeLocalInAltCalendar;
        }

        public static TralusDateTime Null { get { return new TralusDateTime(); } }
    }
}