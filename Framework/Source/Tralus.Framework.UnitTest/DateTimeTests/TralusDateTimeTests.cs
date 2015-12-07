using System;
using NUnit.Framework;

namespace Tralus.Framework.UnitTest.DateTimeTests
{
    [TestFixture]
    public class TralusDateTimeAdHocTests : TralusDateTimeTestsBase
    {

        /// <summary>
        /// 1394 - 2015.
        /// </summary>

        // Test: 1
        // 19 March 2015 04:15 UTC 
        // بیست و هشت اسفند 1393 ساعت 07:45 به وقت محلی  
        // تست  تبدیل تاریخ و زمان 
        [Test]
        public void UtcToLocal_28_Esfand_93_SimpleConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 19, 04, 15, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/19 04:15:00",
                dateTimeLocal: "2015/03/19 07:45:00",
                dateTimeHome: "2015/03/19 07:45:00",
                dateUtc: "2015/03/19",
                dateLocal: "2015/03/19",
                dateHome: "2015/03/19",
                timeUtc: "04:15:00",
                timeLocal: "07:45:00",
                timeHome: "07:45:00",
                altCalendarYearUtc: 1393,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 28,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1393/12/28",
                dateLocalInAltCalendar: "1393/12/28",
                dateHomeInAltCalendar: "1393/12/28",
                dateTimeUtcInAltCalendar: "1393/12/28 04:15:00",
                dateTimeLocalInAltCalendar: "1393/12/28 07:45:00",
                dateTimeHomeInAltCalendar: "1393/12/28 07:45:00"
                );
        }

        // Test: 2
        // 20 March 2015 04:15 UTC 
        // بیست و نه اسفند 1393 ساعت 07:45 به وقت محلی  
        // تست  تبدیل تاریخ و زمان 
        [Test]
        public void UtcToLocal_29_Esfand_93_SimpleConversion()
        {

            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 20, 04, 15, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/20 04:15:00",
                dateTimeLocal: "2015/03/20 07:45:00",
                dateTimeHome: "2015/03/20 07:45:00",
                dateUtc: "2015/03/20",
                dateLocal: "2015/03/20",
                dateHome: "2015/03/20",
                timeUtc: "04:15:00",
                timeLocal: "07:45:00",
                timeHome: "07:45:00",
                altCalendarYearUtc: 1393,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 29,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1393/12/29",
                dateLocalInAltCalendar: "1393/12/29",
                dateHomeInAltCalendar: "1393/12/29",
                dateTimeUtcInAltCalendar: "1393/12/29 04:15:00",
                dateTimeLocalInAltCalendar: "1393/12/29 07:45:00",
                dateTimeHomeInAltCalendar: "1393/12/29 07:45:00"

                );
        }

        // Test: 3
        // 21 March 2015 04:15 UTC 
        // یک فروردین 1394 ساعت 07:45 به وقت محلی  
        // تست  تبدیل تاریخ و زمان 
        [Test]
        public void UtcToLocal_01_Farvardin_94_SimpleConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 21, 04, 15, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/21 04:15:00",
                dateTimeLocal: "2015/03/21 07:45:00",
                dateTimeHome: "2015/03/21 07:45:00",
                dateUtc: "2015/03/21",
                dateLocal: "2015/03/21",
                dateHome: "2015/03/21",
                timeUtc: "04:15:00",
                timeLocal: "07:45:00",
                timeHome: "07:45:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/01/01",
                dateLocalInAltCalendar: "1394/01/01",
                dateHomeInAltCalendar: "1394/01/01",
                dateTimeUtcInAltCalendar: "1394/01/01 04:15:00",
                dateTimeLocalInAltCalendar: "1394/01/01 07:45:00",
                dateTimeHomeInAltCalendar: "1394/01/01 07:45:00"
                );
        }


        // Test: 4
        // 19 March 2015 23:45 UTC 
        // بیست و نه اسفند 1393 ساعت 03:15 به وقت محلی  
        // تاریخ باید تغییر کند
        [Test]
        public void UtcToLocal_28_Esfand_94_DateShouldChange()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 19, 23, 45, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/19 23:45:00",
                dateTimeLocal: "2015/03/20 03:15:00",
                dateTimeHome: "2015/03/20 03:15:00",
                dateUtc: "2015/03/19",
                dateLocal: "2015/03/20",
                dateHome: "2015/03/20",
                timeUtc: "23:45:00",
                timeLocal: "03:15:00",
                timeHome: "03:15:00",
                altCalendarYearUtc: 1393,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 28,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1393/12/28",
                dateLocalInAltCalendar: "1393/12/29",
                dateHomeInAltCalendar: "1393/12/29",
                dateTimeUtcInAltCalendar: "1393/12/28 23:45:00",
                dateTimeLocalInAltCalendar: "1393/12/29 03:15:00",
                dateTimeHomeInAltCalendar: "1393/12/29 03:15:00"
                );
        }


        // Test: 5
        // 20 March 2015 23:45 UTC 
        // یک فروردین 1394 ساعت 03:15 به وقت محلی  
        // تست قبل از تغییر ساعت 
        [Test]
        public void UtcToLocal_01_Farvardin_94_BeforeDstChange()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 20, 23, 45, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/20 23:45:00",
                dateTimeLocal: "2015/03/21 03:15:00",
                dateTimeHome: "2015/03/21 03:15:00",
                dateUtc: "2015/03/20",
                dateLocal: "2015/03/21",
                dateHome: "2015/03/21",
                timeUtc: "23:45:00",
                timeLocal: "03:15:00",
                timeHome: "03:15:00",
                altCalendarYearUtc: 1393,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 29,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1393/12/29",
                dateLocalInAltCalendar: "1394/01/01",
                dateHomeInAltCalendar: "1394/01/01",
                dateTimeUtcInAltCalendar: "1393/12/29 23:45:00",
                dateTimeLocalInAltCalendar: "1394/01/01 03:15:00",
                dateTimeHomeInAltCalendar: "1394/01/01 03:15:00"
                );
        }

        // Test: 6
        // 21 March 2015 20:30 UTC 
        // دوم فروردین 1394 ساعت 01:00 به وقت محلی  
        // تست بعد از تغییر ساعت 
        [Test]
        public void UtcToLocal_02_Farvardin_94_AfterDstChange()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/21 20:30:00",
                dateTimeLocal: "2015/03/22 01:00:00",
                dateTimeHome: "2015/03/22 01:00:00",
                dateUtc: "2015/03/21",
                dateLocal: "2015/03/22",
                dateHome: "2015/03/22",
                timeUtc: "20:30:00",
                timeLocal: "01:00:00",
                timeHome: "01:00:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/01/01",
                dateLocalInAltCalendar: "1394/01/02",
                dateHomeInAltCalendar: "1394/01/02",
                dateTimeUtcInAltCalendar: "1394/01/01 20:30:00",
                dateTimeLocalInAltCalendar: "1394/01/02 01:00:00",
                dateTimeHomeInAltCalendar: "1394/01/02 01:00:00"
                );
        }


        // Test: 7
        // 22 March 2015 00:15 UTC 
        // دوم فروردین 1394 ساعت 04:45 به وقت محلی  
        // تست  تبدیل تاریخ و زمان 
        [Test]
        public void UtcToLocal_02_Farvardin_94_SimpleConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 22, 00, 15, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/22 00:15:00",
                dateTimeLocal: "2015/03/22 04:45:00",
                dateTimeHome: "2015/03/22 04:45:00",
                dateUtc: "2015/03/22",
                dateLocal: "2015/03/22",
                dateHome: "2015/03/22",
                timeUtc: "00:15:00",
                timeLocal: "04:45:00",
                timeHome: "04:45:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 02,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/01/02",
                dateLocalInAltCalendar: "1394/01/02",
                dateHomeInAltCalendar: "1394/01/02",
                dateTimeUtcInAltCalendar: "1394/01/02 00:15:00",
                dateTimeLocalInAltCalendar: "1394/01/02 04:45:00",
                dateTimeHomeInAltCalendar: "1394/01/02 04:45:00"
                );

        }

        // Test: 8
        // 21 September 2015 00:00 UTC 
        // سی شهریور 1394 ساعت 04:30 به وقت محلی  
        // تست  تبدیل تاریخ و زمان 
        [Test]
        public void UtcToLocal_30_Shahrivar_94_SimpleConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 00, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 00:00:00",
                dateTimeLocal: "2015/09/21 04:30:00",
                dateTimeHome: "2015/09/21 04:30:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/21",
                dateHome: "2015/09/21",
                timeUtc: "00:00:00",
                timeLocal: "04:30:00",
                timeHome: "04:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/30",
                dateHomeInAltCalendar: "1394/06/30",
                dateTimeUtcInAltCalendar: "1394/06/30 00:00:00",
                dateTimeLocalInAltCalendar: "1394/06/30 04:30:00",
                dateTimeHomeInAltCalendar: "1394/06/30 04:30:00"
                );
        }

        // Test: 9
        // 22 September 2015 00:00 UTC 
        // سی و یک شهریور 1394 ساعت 03:30 به وقت محلی  
        // تست بعد از تغییر ساعت 
        [Test]
        public void UtcToLocal_31_Shahrivar_94_AfterDstChange()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 22, 00, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/22 00:00:00",
                dateTimeLocal: "2015/09/22 03:30:00",
                dateTimeHome: "2015/09/22 03:30:00",
                dateUtc: "2015/09/22",
                dateLocal: "2015/09/22",
                dateHome: "2015/09/22",
                timeUtc: "00:00:00",
                timeLocal: "03:30:00",
                timeHome: "03:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 31,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/31",
                dateLocalInAltCalendar: "1394/06/31",
                dateHomeInAltCalendar: "1394/06/31",
                dateTimeUtcInAltCalendar: "1394/06/31 00:00:00",
                dateTimeLocalInAltCalendar: "1394/06/31 03:30:00",
                dateTimeHomeInAltCalendar: "1394/06/31 03:30:00"
                );

        }

        // Test: 10
        // 21 September 2015 06:00 UTC 
        // سی شهریور 1394 ساعت 10:30 به وقت محلی  
        // تست قبل از تغییر ساعت 
        [Test]
        public void UtcToLocal_30_Shahrivar_94_BeforeConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 06, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 06:00:00",
                dateTimeLocal: "2015/09/21 10:30:00",
                dateTimeHome: "2015/09/21 10:30:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/21",
                dateHome: "2015/09/21",
                timeUtc: "06:00:00",
                timeLocal: "10:30:00",
                timeHome: "10:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/30",
                dateHomeInAltCalendar: "1394/06/30",
                dateTimeUtcInAltCalendar: "1394/06/30 06:00:00",
                dateTimeLocalInAltCalendar: "1394/06/30 10:30:00",
                dateTimeHomeInAltCalendar: "1394/06/30 10:30:00"
                );

        }

        // Test: 11
        // 22 September 2015 06:00 UTC 
        // سی و یک شهریور 1394 ساعت 09:30 به وقت محلی  
        // تست قبل از تغییر ساعت 
        [Test]
        public void UtcToLocal_31_Shahrivar_94_BeforeConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 22, 06, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/22 06:00:00",
                dateTimeLocal: "2015/09/22 09:30:00",
                dateTimeHome: "2015/09/22 09:30:00",
                dateUtc: "2015/09/22",
                dateLocal: "2015/09/22",
                dateHome: "2015/09/22",
                timeUtc: "06:00:00",
                timeLocal: "09:30:00",
                timeHome: "09:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 31,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/31",
                dateLocalInAltCalendar: "1394/06/31",
                dateHomeInAltCalendar: "1394/06/31",
                dateTimeUtcInAltCalendar: "1394/06/31 06:00:00",
                dateTimeLocalInAltCalendar: "1394/06/31 09:30:00",
                dateTimeHomeInAltCalendar: "1394/06/31 09:30:00"
                );
        }

        // Test: 12
        // 21 September 2015 20:00 UTC 
        // سی شهریور 1394 ساعت 23:30 به وقت محلی  
        // تست تاریخ و ساعت تکراری 
        [Test]
        public void UtcToLocal_30_Shahrivar_94_DoubleUTCConversion_Time_19()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 20, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 20:00:00",
                dateTimeLocal: "2015/09/21 23:30:00",
                dateTimeHome: "2015/09/21 23:30:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/21",
                dateHome: "2015/09/21",
                timeUtc: "20:00:00",
                timeLocal: "23:30:00",
                timeHome: "23:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/30",
                dateHomeInAltCalendar: "1394/06/30",
                dateTimeUtcInAltCalendar: "1394/06/30 20:00:00",
                dateTimeLocalInAltCalendar: "1394/06/30 23:30:00",
                dateTimeHomeInAltCalendar: "1394/06/30 23:30:00"
                );

        }


        // Test: 13
        // 21 September 2015 19:00 UTC 
        // سی شهریور 1394 ساعت 23:30 به وقت محلی  
        // تست تاریخ و ساعت تکراری 
        [Test]
        public void UtcToLocal_30_Shahrivar_94_DoubleUTCConversion_Time_20()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 19, 00, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 19:00:00",
                dateTimeLocal: "2015/09/21 23:30:00",
                dateTimeHome: "2015/09/21 23:30:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/21",
                dateHome: "2015/09/21",
                timeUtc: "19:00:00",
                timeLocal: "23:30:00",
                timeHome: "23:30:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/30",
                dateHomeInAltCalendar: "1394/06/30",
                dateTimeUtcInAltCalendar: "1394/06/30 19:00:00",
                dateTimeLocalInAltCalendar: "1394/06/30 23:30:00",
                dateTimeHomeInAltCalendar: "1394/06/30 23:30:00"
                );

        }


        // Test: 14
        // 21 March 2015 20:29 UTC 
        // یک فروردین  1394 ساعت 23:59 به وقت محلی  
        // تست قبل از تغییر ساعت 
        [Test]
        public void UtcToLocal_StandardTest_01_Farvardin_94_BeforeConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 21, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/21 20:29:00",
                dateTimeLocal: "2015/03/21 23:59:00",
                dateTimeHome: "2015/03/21 23:59:00",
                dateUtc: "2015/03/21",
                dateLocal: "2015/03/21",
                dateHome: "2015/03/21",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/01/01",
                dateLocalInAltCalendar: "1394/01/01",
                dateHomeInAltCalendar: "1394/01/01",
                dateTimeUtcInAltCalendar: "1394/01/01 20:29:00",
                dateTimeLocalInAltCalendar: "1394/01/01 23:59:00",
                dateTimeHomeInAltCalendar: "1394/01/01 23:59:00"
                );

        }





        /// <summary>
        /// 1394 - 2015
        /// </summary>

        // Test: 15
        // 20 March 2015 20:29 UTC 
        // بیست و نه اسفند 1393 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_29_Esfand_93_BeforeDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 20, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/20 20:29:00",
                dateTimeLocal: "2015/03/20 23:59:00",
                dateTimeHome: "2015/03/20 23:59:00",
                dateUtc: "2015/03/20",
                dateLocal: "2015/03/20",
                dateHome: "2015/03/20",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1393,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 29,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1393/12/29",
                dateLocalInAltCalendar: "1393/12/29",
                dateHomeInAltCalendar: "1393/12/29",
                dateTimeUtcInAltCalendar: "1393/12/29 20:29:00",
                dateTimeLocalInAltCalendar: "1393/12/29 23:59:00",
                dateTimeHomeInAltCalendar: "1393/12/29 23:59:00"
                );

        }

        // Test: 16
        // 21 March 2015 20:30 UTC 
        // دوم فروردین 1394 ساعت 00:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        // تغییر ساعت باید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_01_Farvardin_94_AfterDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 03, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/03/21 20:30:00",
                dateTimeLocal: "2015/03/22 01:00:00",
                dateTimeHome: "2015/03/22 01:00:00",
                dateUtc: "2015/03/21",
                dateLocal: "2015/03/22",
                dateHome: "2015/03/22",
                timeUtc: "20:30:00",
                timeLocal: "01:00:00",
                timeHome: "01:00:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/01/01",
                dateLocalInAltCalendar: "1394/01/02",
                dateHomeInAltCalendar: "1394/01/02",
                dateTimeUtcInAltCalendar: "1394/01/01 20:30:00",
                dateTimeLocalInAltCalendar: "1394/01/02 01:00:00",
                dateTimeHomeInAltCalendar: "1394/01/02 01:00:00"
                );

        }

        // Test: 17
        // 21 September 2015 20:29 UTC 
        // سی شهریور 1394 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_30_Shahrivar_94_BeforeDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 20:29:00",
                dateTimeLocal: "2015/09/21 23:59:00",
                dateTimeHome: "2015/09/21 23:59:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/21",
                dateHome: "2015/09/21",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/30",
                dateHomeInAltCalendar: "1394/06/30",
                dateTimeUtcInAltCalendar: "1394/06/30 20:29:00",
                dateTimeLocalInAltCalendar: "1394/06/30 23:59:00",
                dateTimeHomeInAltCalendar: "1394/06/30 23:59:00"
                );
        }

        // Test: 18
        // 21 September 2015 20:30 UTC 
        // سی و یک شهریور 1394 ساعت 00:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_31_Shahrivar_94_AfterConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2015/09/21 20:30:00",
                dateTimeLocal: "2015/09/22 00:00:00",
                dateTimeHome: "2015/09/22 00:00:00",
                dateUtc: "2015/09/21",
                dateLocal: "2015/09/22",
                dateHome: "2015/09/22",
                timeUtc: "20:30:00",
                timeLocal: "00:00:00",
                timeHome: "00:00:00",
                altCalendarYearUtc: 1394,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1394/06/30",
                dateLocalInAltCalendar: "1394/06/31",
                dateHomeInAltCalendar: "1394/06/31",
                dateTimeUtcInAltCalendar: "1394/06/30 20:30:00",
                dateTimeLocalInAltCalendar: "1394/06/31 00:00:00",
                dateTimeHomeInAltCalendar: "1394/06/31 00:00:00"
                );
        }

        /// <summary>
        /// 1385 - 2006.
        /// offsett should be "+3:30".
        /// </summary>

        // Test: 19
        // 20 March 2006 20:29 UTC 
        // بیست و نه اسفند 1384 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_29_Esfand_85_BeforeDstConversion()
        {
            // Test 16 
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 03, 20, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2006/03/20 20:29:00",
                dateTimeLocal: "2006/03/20 23:59:00",
                dateTimeHome: "2006/03/20 23:59:00",
                dateUtc: "2006/03/20",
                dateLocal: "2006/03/20",
                dateHome: "2006/03/20",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 29,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/12/29",
                dateLocalInAltCalendar: "1384/12/29",
                dateHomeInAltCalendar: "1384/12/29",
                dateTimeUtcInAltCalendar: "1384/12/29 20:29:00",
                dateTimeLocalInAltCalendar: "1384/12/29 23:59:00",
                dateTimeHomeInAltCalendar: "1384/12/29 23:59:00"
                );

        }

        // Test: 20
        // 20 March 2006 20:30 UTC 
        // یک فروردین 1385 ساعت 00:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        // تغییر ساعت نباید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_01_Farvardin_85_AfterDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 03, 20, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2006/03/20 20:30:00",
                dateTimeLocal: "2006/03/21 00:00:00",
                dateTimeHome: "2006/03/21 00:00:00",
                dateUtc: "2006/03/20",
                dateLocal: "2006/03/21",
                dateHome: "2006/03/21",
                timeUtc: "20:30:00",
                timeLocal: "00:00:00",
                timeHome: "00:00:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 29,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/12/29",
                dateLocalInAltCalendar: "1385/01/01",
                dateHomeInAltCalendar: "1385/01/01",
                dateTimeUtcInAltCalendar: "1384/12/29 20:30:00",
                dateTimeLocalInAltCalendar: "1385/01/01 00:00:00",
                dateTimeHomeInAltCalendar: "1385/01/01 00:00:00"
                );

        }

        // Test: 21
        // 20 September 2006 20:29 UTC 
        // سی شهریور 1385 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_30_Shahrivar_85_BeforeDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 09, 21, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2006/09/21 20:29:00",
                dateTimeLocal: "2006/09/21 23:59:00",
                dateTimeHome: "2006/09/21 23:59:00",
                dateUtc: "2006/09/21",
                dateLocal: "2006/09/21",
                dateHome: "2006/09/21",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1385,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1385/06/30",
                dateLocalInAltCalendar: "1385/06/30",
                dateHomeInAltCalendar: "1385/06/30",
                dateTimeUtcInAltCalendar: "1385/06/30 20:29:00",
                dateTimeLocalInAltCalendar: "1385/06/30 23:59:00",
                dateTimeHomeInAltCalendar: "1385/06/30 23:59:00"
                );
        }

        // Test: 22
        // 21 September 2006 20:30 UTC 
        // سی و یک شهریور 1385 ساعت 00:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت نباید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_31_Shahrivar_85_NoDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 09, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2006/09/21 20:30:00",
                dateTimeLocal: "2006/09/22 00:00:00",
                dateTimeHome: "2006/09/22 00:00:00",
                dateUtc: "2006/09/21",
                dateLocal: "2006/09/22",
                dateHome: "2006/09/22",
                timeUtc: "20:30:00",
                timeLocal: "00:00:00",
                timeHome: "00:00:00",
                altCalendarYearUtc: 1385,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1385/06/30",
                dateLocalInAltCalendar: "1385/06/31",
                dateHomeInAltCalendar: "1385/06/31",
                dateTimeUtcInAltCalendar: "1385/06/30 20:30:00",
                dateTimeLocalInAltCalendar: "1385/06/31 00:00:00",
                dateTimeHomeInAltCalendar: "1385/06/31 00:00:00"
                );
        }



        /// <summary>
        ///  1395 - 2016.
        /// سال کبیسه
        /// </summary>

        // Test: 23
        // 20 March 2017 20:29 UTC 
        // سی اسفند 1395 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_30_Esfand_95_BeforeDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 03, 20, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2017/03/20 20:29:00",
                dateTimeLocal: "2017/03/20 23:59:00",
                dateTimeHome: "2017/03/20 23:59:00",
                dateUtc: "2017/03/20",
                dateLocal: "2017/03/20",
                dateHome: "2017/03/20",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1395,
                altCalendarMonthUtc: 12,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1395/12/30",
                dateLocalInAltCalendar: "1395/12/30",
                dateHomeInAltCalendar: "1395/12/30",
                dateTimeUtcInAltCalendar: "1395/12/30 20:29:00",
                dateTimeLocalInAltCalendar: "1395/12/30 23:59:00",
                dateTimeHomeInAltCalendar: "1395/12/30 23:59:00"
                );
        }

        // Test: 24
        // 21 March 2017 20:30 UTC 
        // دوم فروردین 1396 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        // تغییر ساعت باید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_01_Farvardin_96_AfterDstConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 03, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2017/03/21 20:30:00",
                dateTimeLocal: "2017/03/22 01:00:00",
                dateTimeHome: "2017/03/22 01:00:00",
                dateUtc: "2017/03/21",
                dateLocal: "2017/03/22",
                dateHome: "2017/03/22",
                timeUtc: "20:30:00",
                timeLocal: "01:00:00",
                timeHome: "01:00:00",
                altCalendarYearUtc: 1396,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1396/01/01",
                dateLocalInAltCalendar: "1396/01/02",
                dateHomeInAltCalendar: "1396/01/02",
                dateTimeUtcInAltCalendar: "1396/01/01 20:30:00",
                dateTimeLocalInAltCalendar: "1396/01/02 01:00:00",
                dateTimeHomeInAltCalendar: "1396/01/02 01:00:00"
                );

        }

        // Test: 25
        // 20 September 2016 20:29 UTC 
        // سی شهریور 1396 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت نباید رخ دهد  
        [Test]
        public void UtcToLocal_StandardTest_30_Shahrivar_95_BeforeConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 09, 20, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2016/09/20 20:29:00",
                dateTimeLocal: "2016/09/20 23:59:00",
                dateTimeHome: "2016/09/20 23:59:00",
                dateUtc: "2016/09/20",
                dateLocal: "2016/09/20",
                dateHome: "2016/09/20",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1395,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1395/06/30",
                dateLocalInAltCalendar: "1395/06/30",
                dateHomeInAltCalendar: "1395/06/30",
                dateTimeUtcInAltCalendar: "1395/06/30 20:29:00",
                dateTimeLocalInAltCalendar: "1395/06/30 23:59:00",
                dateTimeHomeInAltCalendar: "1395/06/30 23:59:00"
                );
        }

        // Test: 26
        // 20 September 2016 20:30 UTC 
        // سی و یک شهریور 1396 ساعت 00:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد  
        [Test]
        public void UtcToLocal_StandardTest_31_Shahrivar_95_Conversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 09, 20, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2016/09/20 20:30:00",
                dateTimeLocal: "2016/09/21 00:00:00",
                dateTimeHome: "2016/09/21 00:00:00",
                dateUtc: "2016/09/20",
                dateLocal: "2016/09/21",
                dateHome: "2016/09/21",
                timeUtc: "20:30:00",
                timeLocal: "00:00:00",
                timeHome: "00:00:00",
                altCalendarYearUtc: 1395,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1395/06/30",
                dateLocalInAltCalendar: "1395/06/31",
                dateHomeInAltCalendar: "1395/06/31",
                dateTimeUtcInAltCalendar: "1395/06/30 20:30:00",
                dateTimeLocalInAltCalendar: "1395/06/31 00:00:00",
                dateTimeHomeInAltCalendar: "1395/06/31 00:00:00"
                );
        }


        

    }

}
