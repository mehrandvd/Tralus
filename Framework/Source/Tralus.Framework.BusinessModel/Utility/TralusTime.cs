using System;
using DevExpress.ExpressApp.DC;

namespace Tralus.Framework.BusinessModel.Utility
{
    /// <summary>
    /// Use this class as a ComplexType in entities to represent a DateTime property. This type creates 13 related columns in database.
    /// </summary>
    [DomainComponent]
    public class TralusTime
    {
        /// <summary>
        /// Gets or sets the time value.
        /// </summary>
        public TimeSpan? Time { get; set; }

        /// <summary>
        /// Checks the <param name="dateTime"></param> kind. If it is Utc it will be assigned to DateTimeUtc,
        /// otherwise it will be assigned to DateTimeLocal
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static implicit operator TralusTime(DateTime dateTime)
        {
            return new TralusTime {Time = dateTime.TimeOfDay};
        }

        /// <summary>
        /// Returns a string that represents the current local dateTime in Shamsi calendar.
        /// </summary>
        /// <example>11:23</example>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return Time.ToString();
        }
    }
}
