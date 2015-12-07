using System.Diagnostics;
using Tralus.Framework.BusinessModel.Utility;
using NUnit.Framework;

namespace Tralus.Framework.UnitTest.DateTimeTests
{
    public class TralusDateTimeTestsBase
    {
        protected void AssertTralusDateTime(
            TralusDateTime tralusDataTime,
            string dateTimeUtc,
            string dateTimeLocal,
            string dateTimeHome,

            string dateUtc,
            string dateLocal,
            string dateHome,

            string timeUtc,
            string timeLocal,
            string timeHome,

            int altCalendarYearUtc,
            int altCalendarMonthUtc,
            int altCalendarDayUtc,

            string localTimeZoneId,

            string dateUtcInAltCalendar,
            string dateLocalInAltCalendar,
            string dateHomeInAltCalendar,

            string dateTimeUtcInAltCalendar,
            string dateTimeLocalInAltCalendar,
            string dateTimeHomeInAltCalendar
            )
        {

            Debug.Assert(tralusDataTime.DateTimeUtc != null, "tralusDataTime.DateTimeUtc != null");
            var message = string.Format("Error for: {0}", tralusDataTime.DateTimeUtc.Value);

            Assert.AreEqual(dateTimeUtc, tralusDataTime.DateTimeUtc.Value.ToString("yyyy/MM/dd HH:mm:ss"), message);
            Assert.AreEqual(dateTimeLocal, tralusDataTime.DateTimeLocal.Value.ToString("yyyy/MM/dd HH:mm:ss"), message);
            Assert.AreEqual(dateTimeHome, tralusDataTime.DateTimeHome.Value.ToString("yyyy/MM/dd HH:mm:ss"), message);

            Assert.AreEqual(dateUtc, tralusDataTime.DateUtc.Value.ToString("yyyy/MM/dd"), message);
            Assert.AreEqual(dateLocal, tralusDataTime.DateLocal.Value.ToString("yyyy/MM/dd"), message);
            Assert.AreEqual(dateHome, tralusDataTime.DateHome.Value.ToString("yyyy/MM/dd"), message);

            Assert.AreEqual(timeUtc, tralusDataTime.TimeUtc.Value.ToString(), message);
            Assert.AreEqual(timeLocal, tralusDataTime.TimeLocal.Value.ToString(), message);
            Assert.AreEqual(timeHome, tralusDataTime.TimeHome.Value.ToString(), message);

            Assert.AreEqual(altCalendarYearUtc, tralusDataTime.AltCalendarYearUtc, message);
            Assert.AreEqual(altCalendarMonthUtc, tralusDataTime.AltCalendarMonthUtc, message);
            Assert.AreEqual(altCalendarDayUtc, tralusDataTime.AltCalendarDayUtc, message);

            Assert.AreEqual(localTimeZoneId, tralusDataTime.LocalTimeZoneId, message);

            Assert.AreEqual(dateUtcInAltCalendar, tralusDataTime.DateUtcInAltCalendar, message);
            Assert.AreEqual(dateLocalInAltCalendar, tralusDataTime.DateLocalInAltCalendar, message);
            Assert.AreEqual(dateHomeInAltCalendar, tralusDataTime.DateHomeInAltCalendar, message);
            Assert.AreEqual(dateTimeUtcInAltCalendar, tralusDataTime.DateTimeUtcInAltCalendar, message);
            Assert.AreEqual(dateTimeLocalInAltCalendar, tralusDataTime.DateTimeLocalInAltCalendar, message);
            Assert.AreEqual(dateTimeHomeInAltCalendar, tralusDataTime.DateTimeHomeInAltCalendar, message);

        }
    }
}