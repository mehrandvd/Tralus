using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tralus.Framework.UnitTest.DateTimeTests
{


    /// <summary>
    /// 1384 - 1399
    /// </summary>

    [TestFixture]
    public class TralusDateTimeStandardTests : TralusDateTimeTestsBase
    {

        // Test: 
        // 21 March 2005 20:29 UTC 
        // یک فروردین 1384 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_84_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2005, 03, 21, 20, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2005/03/21 20:29:00",
                dateTimeLocal: "2005/03/21 23:59:00",
                dateTimeHome: "2005/03/21 23:59:00",
                dateUtc: "2005/03/21",
                dateLocal: "2005/03/21",
                dateHome: "2005/03/21",
                timeUtc: "20:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/01/01",
                dateLocalInAltCalendar: "1384/01/01",
                dateHomeInAltCalendar: "1384/01/01",
                dateTimeUtcInAltCalendar: "1384/01/01 20:29:00",
                dateTimeLocalInAltCalendar: "1384/01/01 23:59:00",
                dateTimeHomeInAltCalendar: "1384/01/01 23:59:00"
                );

        }

        // Test: 
        // 22 March 2005 20:30 UTC 
        // دوم فروردین 1384 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        // تغییر ساعت باید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_84_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2005, 03, 21, 20, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2005/03/21 20:30:00",
                dateTimeLocal: "2005/03/22 01:00:00",
                dateTimeHome: "2005/03/22 01:00:00",
                dateUtc: "2005/03/21",
                dateLocal: "2005/03/22",
                dateHome: "2005/03/22",
                timeUtc: "20:30:00",
                timeLocal: "01:00:00",
                timeHome: "01:00:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 01,
                altCalendarDayUtc: 01,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/01/01",
                dateLocalInAltCalendar: "1384/01/02",
                dateHomeInAltCalendar: "1384/01/02",
                dateTimeUtcInAltCalendar: "1384/01/01 20:30:00",
                dateTimeLocalInAltCalendar: "1384/01/02 01:00:00",
                dateTimeHomeInAltCalendar: "1384/01/02 01:00:00"
                );

        }

        // Test: 
        // 21 September 2005 20:29 UTC 
        // سی شهریور 1384 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_84_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2005, 09, 21, 19, 29, 00, DateTimeKind.Utc),
                dateTimeUtc: "2005/09/21 19:29:00",
                dateTimeLocal: "2005/09/21 23:59:00",
                dateTimeHome: "2005/09/21 23:59:00",
                dateUtc: "2005/09/21",
                dateLocal: "2005/09/21",
                dateHome: "2005/09/21",
                timeUtc: "19:29:00",
                timeLocal: "23:59:00",
                timeHome: "23:59:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/06/30",
                dateLocalInAltCalendar: "1384/06/30",
                dateHomeInAltCalendar: "1384/06/30",
                dateTimeUtcInAltCalendar: "1384/06/30 19:29:00",
                dateTimeLocalInAltCalendar: "1384/06/30 23:59:00",
                dateTimeHomeInAltCalendar: "1384/06/30 23:59:00"
                );
        }

        // Test: 
        // 21 September 2005 19:30 UTC 
        // سی شهریور 1384 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد    
        [Test]
        public void UtcToLocal_StandardTest_84_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2005, 09, 21, 19, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2005/09/21 19:30:00",
                dateTimeLocal: "2005/09/21 23:00:00",
                dateTimeHome: "2005/09/21 23:00:00",
                dateUtc: "2005/09/21",
                dateLocal: "2005/09/21",
                dateHome: "2005/09/21",
                timeUtc: "19:30:00",
                timeLocal: "23:00:00",
                timeHome: "23:00:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/06/30",
                dateLocalInAltCalendar: "1384/06/30",
                dateHomeInAltCalendar: "1384/06/30",
                dateTimeUtcInAltCalendar: "1384/06/30 19:30:00",
                dateTimeLocalInAltCalendar: "1384/06/30 23:00:00",
                dateTimeHomeInAltCalendar: "1384/06/30 23:00:00"
                );
        }

        // Test: 
        // 21 September 2005 18:30 UTC 
        // سی شهریور 1384 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_84_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2005, 09, 21, 18, 30, 00, DateTimeKind.Utc),
                dateTimeUtc: "2005/09/21 18:30:00",
                dateTimeLocal: "2005/09/21 23:00:00",
                dateTimeHome: "2005/09/21 23:00:00",
                dateUtc: "2005/09/21",
                dateLocal: "2005/09/21",
                dateHome: "2005/09/21",
                timeUtc: "18:30:00",
                timeLocal: "23:00:00",
                timeHome: "23:00:00",
                altCalendarYearUtc: 1384,
                altCalendarMonthUtc: 06,
                altCalendarDayUtc: 30,
                localTimeZoneId: "Asia/Tehran",
                dateUtcInAltCalendar: "1384/06/30",
                dateLocalInAltCalendar: "1384/06/30",
                dateHomeInAltCalendar: "1384/06/30",
                dateTimeUtcInAltCalendar: "1384/06/30 18:30:00",
                dateTimeLocalInAltCalendar: "1384/06/30 23:00:00",
                dateTimeHomeInAltCalendar: "1384/06/30 23:00:00"
                );
        }


        // Test: 
        // 21 March 2006 20:29 UTC 
        // یک فروردین 1385 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_85_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2006/03/21 20:29:00",
            dateTimeLocal: "2006/03/21 23:59:00",
            dateTimeHome: "2006/03/21 23:59:00",
            dateUtc: "2006/03/21",
            dateLocal: "2006/03/21",
            dateHome: "2006/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1385,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1385/01/01",
            dateLocalInAltCalendar: "1385/01/01",
            dateHomeInAltCalendar: "1385/01/01",
            dateTimeUtcInAltCalendar: "1385/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1385/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1385/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2006 20:30 UTC 
        // دوم فروردین 1385 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        // تغییر ساعت در این تاریخ و ساعت نباید رخ دهد. سالی است که به دستور رییس جمهور، تغییر ساعت رخ نداد    
        [Test]
        public void UtcToLocal_StandardTest_85_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2006/03/21 20:30:00",
            dateTimeLocal: "2006/03/22 00:00:00",
            dateTimeHome: "2006/03/22 00:00:00",
            dateUtc: "2006/03/21",
            dateLocal: "2006/03/22",
            dateHome: "2006/03/22",
            timeUtc: "20:30:00",
            timeLocal: "00:00:00",
            timeHome: "00:00:00",
            altCalendarYearUtc: 1385,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1385/01/01",
            dateLocalInAltCalendar: "1385/01/02",
            dateHomeInAltCalendar: "1385/01/02",
            dateTimeUtcInAltCalendar: "1385/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1385/01/02 00:00:00",
            dateTimeHomeInAltCalendar: "1385/01/02 00:00:00"
            );

        }

        // Test: 
        // 21 September 2005 20:29 UTC 
        // سی شهریور 1385 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_85_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2006/09/21 19:29:00",
            dateTimeLocal: "2006/09/21 22:59:00",
            dateTimeHome: "2006/09/21 22:59:00",
            dateUtc: "2006/09/21",
            dateLocal: "2006/09/21",
            dateHome: "2006/09/21",
            timeUtc: "19:29:00",
            timeLocal: "22:59:00",
            timeHome: "22:59:00",
            altCalendarYearUtc: 1385,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1385/06/30",
            dateLocalInAltCalendar: "1385/06/30",
            dateHomeInAltCalendar: "1385/06/30",
            dateTimeUtcInAltCalendar: "1385/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1385/06/30 22:59:00",
            dateTimeHomeInAltCalendar: "1385/06/30 22:59:00"
            );
        }

        // Test: 
        // 21 September 2006 19:30 UTC 
        // سی شهریور 1385 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت در این تاریخ و ساعت نباید رخ دهد. سالی است که به دستور رییس جمهور، تغییر ساعت رخ نداد    
        [Test]
        public void UtcToLocal_StandardTest_85_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2006/09/21 19:30:00",
            dateTimeLocal: "2006/09/21 23:00:00",
            dateTimeHome: "2006/09/21 23:00:00",
            dateUtc: "2006/09/21",
            dateLocal: "2006/09/21",
            dateHome: "2006/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1385,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1385/06/30",
            dateLocalInAltCalendar: "1385/06/30",
            dateHomeInAltCalendar: "1385/06/30",
            dateTimeUtcInAltCalendar: "1385/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1385/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1385/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2006 18:30 UTC 
        // سی شهریور 1385 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت در این تاریخ و ساعت نباید رخ دهد. سالی است که به دستور رییس جمهور، تغییر ساعت رخ نداد    
        [Test]
        public void UtcToLocal_StandardTest_85_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2006, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2006/09/21 18:30:00",
            dateTimeLocal: "2006/09/21 22:00:00",
            dateTimeHome: "2006/09/21 22:00:00",
            dateUtc: "2006/09/21",
            dateLocal: "2006/09/21",
            dateHome: "2006/09/21",
            timeUtc: "18:30:00",
            timeLocal: "22:00:00",
            timeHome: "22:00:00",
            altCalendarYearUtc: 1385,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1385/06/30",
            dateLocalInAltCalendar: "1385/06/30",
            dateHomeInAltCalendar: "1385/06/30",
            dateTimeUtcInAltCalendar: "1385/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1385/06/30 22:00:00",
            dateTimeHomeInAltCalendar: "1385/06/30 22:00:00"
            );
        }




        // Test: 
        // 21 March 2007 20:29 UTC 
        // یک فروردین 1386 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_86_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2007, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2007/03/21 20:29:00",
            dateTimeLocal: "2007/03/21 23:59:00",
            dateTimeHome: "2007/03/21 23:59:00",
            dateUtc: "2007/03/21",
            dateLocal: "2007/03/21",
            dateHome: "2007/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1386,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1386/01/01",
            dateLocalInAltCalendar: "1386/01/01",
            dateHomeInAltCalendar: "1386/01/01",
            dateTimeUtcInAltCalendar: "1386/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1386/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1386/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2007 20:30 UTC 
        // دوم فروردین 1386 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_86_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2007, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2007/03/21 20:30:00",
            dateTimeLocal: "2007/03/22 00:00:00",
            dateTimeHome: "2007/03/22 00:00:00",
            dateUtc: "2007/03/21",
            dateLocal: "2007/03/22",
            dateHome: "2007/03/22",
            timeUtc: "20:30:00",
            timeLocal: "00:00:00",
            timeHome: "00:00:00",
            altCalendarYearUtc: 1386,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1386/01/01",
            dateLocalInAltCalendar: "1386/01/02",
            dateHomeInAltCalendar: "1386/01/02",
            dateTimeUtcInAltCalendar: "1386/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1386/01/02 00:00:00",
            dateTimeHomeInAltCalendar: "1386/01/02 00:00:00"
            );

        }

        // Test: 
        // 21 September 2007 20:29 UTC 
        // سی شهریور 1386 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_86_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2007, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2007/09/21 19:29:00",
            dateTimeLocal: "2007/09/21 22:59:00",
            dateTimeHome: "2007/09/21 22:59:00",
            dateUtc: "2007/09/21",
            dateLocal: "2007/09/21",
            dateHome: "2007/09/21",
            timeUtc: "19:29:00",
            timeLocal: "22:59:00",
            timeHome: "22:59:00",
            altCalendarYearUtc: 1386,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1386/06/30",
            dateLocalInAltCalendar: "1386/06/30",
            dateHomeInAltCalendar: "1386/06/30",
            dateTimeUtcInAltCalendar: "1386/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1386/06/30 22:59:00",
            dateTimeHomeInAltCalendar: "1386/06/30 22:59:00"
            );
        }

        // Test: 
        // 21 September 2006 19:30 UTC 
        // سی شهریور 1385 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت در این تاریخ و ساعت نباید رخ دهد. سالی است که به دستور رییس جمهور، تغییر ساعت رخ نداد    
        [Test]
        public void UtcToLocal_StandardTest_86_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2007, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2007/09/21 19:30:00",
            dateTimeLocal: "2007/09/21 23:00:00",
            dateTimeHome: "2007/09/21 23:00:00",
            dateUtc: "2007/09/21",
            dateLocal: "2007/09/21",
            dateHome: "2007/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1386,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1386/06/30",
            dateLocalInAltCalendar: "1386/06/30",
            dateHomeInAltCalendar: "1386/06/30",
            dateTimeUtcInAltCalendar: "1386/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1386/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1386/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2007 18:30 UTC 
        // سی شهریور 1386 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_86_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2007, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2007/09/21 18:30:00",
            dateTimeLocal: "2007/09/21 22:00:00",
            dateTimeHome: "2007/09/21 22:00:00",
            dateUtc: "2007/09/21",
            dateLocal: "2007/09/21",
            dateHome: "2007/09/21",
            timeUtc: "18:30:00",
            timeLocal: "22:00:00",
            timeHome: "22:00:00",
            altCalendarYearUtc: 1386,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1386/06/30",
            dateLocalInAltCalendar: "1386/06/30",
            dateHomeInAltCalendar: "1386/06/30",
            dateTimeUtcInAltCalendar: "1386/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1386/06/30 22:00:00",
            dateTimeHomeInAltCalendar: "1386/06/30 22:00:00"
            );
        }



        // Test: 
        // 21 March 2008 20:29 UTC 
        // یک فروردین 1387 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_87_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2008, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2008/03/20 20:29:00",
            dateTimeLocal: "2008/03/20 23:59:00",
            dateTimeHome: "2008/03/20 23:59:00",
            dateUtc: "2008/03/20",
            dateLocal: "2008/03/20",
            dateHome: "2008/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1387,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1387/01/01",
            dateLocalInAltCalendar: "1387/01/01",
            dateHomeInAltCalendar: "1387/01/01",
            dateTimeUtcInAltCalendar: "1387/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1387/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1387/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2008 20:30 UTC 
        // دوم فروردین 1387 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_87_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2008, 03, 20, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2008/03/20 20:30:00",
            dateTimeLocal: "2008/03/21 01:00:00",
            dateTimeHome: "2008/03/21 01:00:00",
            dateUtc: "2008/03/20",
            dateLocal: "2008/03/21",
            dateHome: "2008/03/21",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1387,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1387/01/01",
            dateLocalInAltCalendar: "1387/01/02",
            dateHomeInAltCalendar: "1387/01/02",
            dateTimeUtcInAltCalendar: "1387/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1387/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1387/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2008 20:29 UTC 
        // سی شهریور 1387 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_87_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2008, 09, 20, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2008/09/20 19:29:00",
            dateTimeLocal: "2008/09/20 23:59:00",
            dateTimeHome: "2008/09/20 23:59:00",
            dateUtc: "2008/09/20",
            dateLocal: "2008/09/20",
            dateHome: "2008/09/20",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1387,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1387/06/30",
            dateLocalInAltCalendar: "1387/06/30",
            dateHomeInAltCalendar: "1387/06/30",
            dateTimeUtcInAltCalendar: "1387/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1387/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1387/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2008 19:30 UTC 
        // سی شهریور 1387 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_87_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2008, 09, 20, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2008/09/20 19:30:00",
            dateTimeLocal: "2008/09/20 23:00:00",
            dateTimeHome: "2008/09/20 23:00:00",
            dateUtc: "2008/09/20",
            dateLocal: "2008/09/20",
            dateHome: "2008/09/20",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1387,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1387/06/30",
            dateLocalInAltCalendar: "1387/06/30",
            dateHomeInAltCalendar: "1387/06/30",
            dateTimeUtcInAltCalendar: "1387/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1387/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1387/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2008 18:30 UTC 
        // سی شهریور 1387 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_87_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2008, 09, 20, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2008/09/20 18:30:00",
            dateTimeLocal: "2008/09/20 23:00:00",
            dateTimeHome: "2008/09/20 23:00:00",
            dateUtc: "2008/09/20",
            dateLocal: "2008/09/20",
            dateHome: "2008/09/20",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1387,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1387/06/30",
            dateLocalInAltCalendar: "1387/06/30",
            dateHomeInAltCalendar: "1387/06/30",
            dateTimeUtcInAltCalendar: "1387/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1387/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1387/06/30 23:00:00"
            );
        }




        // Test: 
        // 21 March 2009 20:29 UTC 
        // یک فروردین 1388 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_88_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2009, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2009/03/21 20:29:00",
            dateTimeLocal: "2009/03/21 23:59:00",
            dateTimeHome: "2009/03/21 23:59:00",
            dateUtc: "2009/03/21",
            dateLocal: "2009/03/21",
            dateHome: "2009/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1388,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1388/01/01",
            dateLocalInAltCalendar: "1388/01/01",
            dateHomeInAltCalendar: "1388/01/01",
            dateTimeUtcInAltCalendar: "1388/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1388/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1388/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2009 20:30 UTC 
        // دوم فروردین 1388 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_88_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2009, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2009/03/21 20:30:00",
            dateTimeLocal: "2009/03/22 01:00:00",
            dateTimeHome: "2009/03/22 01:00:00",
            dateUtc: "2009/03/21",
            dateLocal: "2009/03/22",
            dateHome: "2009/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1388,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1388/01/01",
            dateLocalInAltCalendar: "1388/01/02",
            dateHomeInAltCalendar: "1388/01/02",
            dateTimeUtcInAltCalendar: "1388/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1388/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1388/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2009 20:29 UTC 
        // سی شهریور 1388 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_88_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2009, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2009/09/21 19:29:00",
            dateTimeLocal: "2009/09/21 23:59:00",
            dateTimeHome: "2009/09/21 23:59:00",
            dateUtc: "2009/09/21",
            dateLocal: "2009/09/21",
            dateHome: "2009/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1388,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1388/06/30",
            dateLocalInAltCalendar: "1388/06/30",
            dateHomeInAltCalendar: "1388/06/30",
            dateTimeUtcInAltCalendar: "1388/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1388/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1388/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2009 19:30 UTC 
        // سی شهریور 1388 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_88_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2009, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2009/09/21 19:30:00",
            dateTimeLocal: "2009/09/21 23:00:00",
            dateTimeHome: "2009/09/21 23:00:00",
            dateUtc: "2009/09/21",
            dateLocal: "2009/09/21",
            dateHome: "2009/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1388,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1388/06/30",
            dateLocalInAltCalendar: "1388/06/30",
            dateHomeInAltCalendar: "1388/06/30",
            dateTimeUtcInAltCalendar: "1388/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1388/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1388/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2009 18:30 UTC 
        // سی شهریور 1388 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_88_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2009, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2009/09/21 18:30:00",
            dateTimeLocal: "2009/09/21 23:00:00",
            dateTimeHome: "2009/09/21 23:00:00",
            dateUtc: "2009/09/21",
            dateLocal: "2009/09/21",
            dateHome: "2009/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1388,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1388/06/30",
            dateLocalInAltCalendar: "1388/06/30",
            dateHomeInAltCalendar: "1388/06/30",
            dateTimeUtcInAltCalendar: "1388/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1388/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1388/06/30 23:00:00"
            );
        }



        // Test: 
        // 21 March 2010 20:29 UTC 
        // یک فروردین 1389 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_89_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2010, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2010/03/21 20:29:00",
            dateTimeLocal: "2010/03/21 23:59:00",
            dateTimeHome: "2010/03/21 23:59:00",
            dateUtc: "2010/03/21",
            dateLocal: "2010/03/21",
            dateHome: "2010/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1389,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1389/01/01",
            dateLocalInAltCalendar: "1389/01/01",
            dateHomeInAltCalendar: "1389/01/01",
            dateTimeUtcInAltCalendar: "1389/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1389/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1389/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2010 20:30 UTC 
        // دوم فروردین 1389 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_89_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2010, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2010/03/21 20:30:00",
            dateTimeLocal: "2010/03/22 01:00:00",
            dateTimeHome: "2010/03/22 01:00:00",
            dateUtc: "2010/03/21",
            dateLocal: "2010/03/22",
            dateHome: "2010/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1389,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1389/01/01",
            dateLocalInAltCalendar: "1389/01/02",
            dateHomeInAltCalendar: "1389/01/02",
            dateTimeUtcInAltCalendar: "1389/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1389/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1389/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2010 20:29 UTC 
        // سی شهریور 1389 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_89_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2010, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2010/09/21 19:29:00",
            dateTimeLocal: "2010/09/21 23:59:00",
            dateTimeHome: "2010/09/21 23:59:00",
            dateUtc: "2010/09/21",
            dateLocal: "2010/09/21",
            dateHome: "2010/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1389,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1389/06/30",
            dateLocalInAltCalendar: "1389/06/30",
            dateHomeInAltCalendar: "1389/06/30",
            dateTimeUtcInAltCalendar: "1389/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1389/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1389/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2010 19:30 UTC 
        // سی شهریور 1389 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_89_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2010, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2010/09/21 19:30:00",
            dateTimeLocal: "2010/09/21 23:00:00",
            dateTimeHome: "2010/09/21 23:00:00",
            dateUtc: "2010/09/21",
            dateLocal: "2010/09/21",
            dateHome: "2010/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1389,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1389/06/30",
            dateLocalInAltCalendar: "1389/06/30",
            dateHomeInAltCalendar: "1389/06/30",
            dateTimeUtcInAltCalendar: "1389/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1389/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1389/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2010 18:30 UTC 
        // سی شهریور 1389 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_89_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2010, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2010/09/21 18:30:00",
            dateTimeLocal: "2010/09/21 23:00:00",
            dateTimeHome: "2010/09/21 23:00:00",
            dateUtc: "2010/09/21",
            dateLocal: "2010/09/21",
            dateHome: "2010/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1389,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1389/06/30",
            dateLocalInAltCalendar: "1389/06/30",
            dateHomeInAltCalendar: "1389/06/30",
            dateTimeUtcInAltCalendar: "1389/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1389/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1389/06/30 23:00:00"
            );
        }




        // Test: 
        // 21 March 2011 20:29 UTC 
        // یک فروردین 1390 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_90_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2011, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2011/03/21 20:29:00",
            dateTimeLocal: "2011/03/21 23:59:00",
            dateTimeHome: "2011/03/21 23:59:00",
            dateUtc: "2011/03/21",
            dateLocal: "2011/03/21",
            dateHome: "2011/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1390,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1390/01/01",
            dateLocalInAltCalendar: "1390/01/01",
            dateHomeInAltCalendar: "1390/01/01",
            dateTimeUtcInAltCalendar: "1390/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1390/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1390/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2011 20:30 UTC 
        // دوم فروردین 1390 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_90_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2011, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2011/03/21 20:30:00",
            dateTimeLocal: "2011/03/22 01:00:00",
            dateTimeHome: "2011/03/22 01:00:00",
            dateUtc: "2011/03/21",
            dateLocal: "2011/03/22",
            dateHome: "2011/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1390,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1390/01/01",
            dateLocalInAltCalendar: "1390/01/02",
            dateHomeInAltCalendar: "1390/01/02",
            dateTimeUtcInAltCalendar: "1390/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1390/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1390/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2011 20:29 UTC 
        // سی شهریور 1390 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_90_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2011, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2011/09/21 19:29:00",
            dateTimeLocal: "2011/09/21 23:59:00",
            dateTimeHome: "2011/09/21 23:59:00",
            dateUtc: "2011/09/21",
            dateLocal: "2011/09/21",
            dateHome: "2011/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1390,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1390/06/30",
            dateLocalInAltCalendar: "1390/06/30",
            dateHomeInAltCalendar: "1390/06/30",
            dateTimeUtcInAltCalendar: "1390/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1390/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1390/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2011 19:30 UTC 
        // سی شهریور 1390 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_90_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2011, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2011/09/21 19:30:00",
            dateTimeLocal: "2011/09/21 23:00:00",
            dateTimeHome: "2011/09/21 23:00:00",
            dateUtc: "2011/09/21",
            dateLocal: "2011/09/21",
            dateHome: "2011/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1390,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1390/06/30",
            dateLocalInAltCalendar: "1390/06/30",
            dateHomeInAltCalendar: "1390/06/30",
            dateTimeUtcInAltCalendar: "1390/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1390/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1390/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2011 18:30 UTC 
        // سی شهریور 1390 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_90_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2011, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2011/09/21 18:30:00",
            dateTimeLocal: "2011/09/21 23:00:00",
            dateTimeHome: "2011/09/21 23:00:00",
            dateUtc: "2011/09/21",
            dateLocal: "2011/09/21",
            dateHome: "2011/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1390,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1390/06/30",
            dateLocalInAltCalendar: "1390/06/30",
            dateHomeInAltCalendar: "1390/06/30",
            dateTimeUtcInAltCalendar: "1390/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1390/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1390/06/30 23:00:00"
            );
        }



        // Test: 
        // 21 March 2012 20:29 UTC 
        // یک فروردین 1391 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_91_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2012, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2012/03/20 20:29:00",
            dateTimeLocal: "2012/03/20 23:59:00",
            dateTimeHome: "2012/03/20 23:59:00",
            dateUtc: "2012/03/20",
            dateLocal: "2012/03/20",
            dateHome: "2012/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/01/01",
            dateLocalInAltCalendar: "1391/01/01",
            dateHomeInAltCalendar: "1391/01/01",
            dateTimeUtcInAltCalendar: "1391/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1391/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1391/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2012 20:30 UTC 
        // دوم فروردین 1391 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_91_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2012, 03, 20, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2012/03/20 20:30:00",
            dateTimeLocal: "2012/03/21 01:00:00",
            dateTimeHome: "2012/03/21 01:00:00",
            dateUtc: "2012/03/20",
            dateLocal: "2012/03/21",
            dateHome: "2012/03/21",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/01/01",
            dateLocalInAltCalendar: "1391/01/02",
            dateHomeInAltCalendar: "1391/01/02",
            dateTimeUtcInAltCalendar: "1391/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1391/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1391/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2012 20:29 UTC 
        // سی شهریور 1391 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_91_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2012, 09, 20, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2012/09/20 19:29:00",
            dateTimeLocal: "2012/09/20 23:59:00",
            dateTimeHome: "2012/09/20 23:59:00",
            dateUtc: "2012/09/20",
            dateLocal: "2012/09/20",
            dateHome: "2012/09/20",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/06/30",
            dateLocalInAltCalendar: "1391/06/30",
            dateHomeInAltCalendar: "1391/06/30",
            dateTimeUtcInAltCalendar: "1391/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1391/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1391/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2012 19:30 UTC 
        // سی شهریور 1391 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_91_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2012, 09, 20, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2012/09/20 19:30:00",
            dateTimeLocal: "2012/09/20 23:00:00",
            dateTimeHome: "2012/09/20 23:00:00",
            dateUtc: "2012/09/20",
            dateLocal: "2012/09/20",
            dateHome: "2012/09/20",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/06/30",
            dateLocalInAltCalendar: "1391/06/30",
            dateHomeInAltCalendar: "1391/06/30",
            dateTimeUtcInAltCalendar: "1391/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1391/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1391/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2012 18:30 UTC 
        // سی شهریور 1391 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_91_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2012, 09, 20, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2012/09/20 18:30:00",
            dateTimeLocal: "2012/09/20 23:00:00",
            dateTimeHome: "2012/09/20 23:00:00",
            dateUtc: "2012/09/20",
            dateLocal: "2012/09/20",
            dateHome: "2012/09/20",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/06/30",
            dateLocalInAltCalendar: "1391/06/30",
            dateHomeInAltCalendar: "1391/06/30",
            dateTimeUtcInAltCalendar: "1391/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1391/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1391/06/30 23:00:00"
            );
        }

        // Test: 
        // 20 March 2013 19:29 UTC 
        // سی اسفند 1391 ساعت 23:59 به وقت محلی  
        // سال کبیسه
        [Test]
        public void UtcToLocal_StandardTest_91_Shahrivar_30_LeapYear()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/03/20 20:29:00",
            dateTimeLocal: "2013/03/20 23:59:00",
            dateTimeHome: "2013/03/20 23:59:00",
            dateUtc: "2013/03/20",
            dateLocal: "2013/03/20",
            dateHome: "2013/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1391,
            altCalendarMonthUtc: 12,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1391/12/30",
            dateLocalInAltCalendar: "1391/12/30",
            dateHomeInAltCalendar: "1391/12/30",
            dateTimeUtcInAltCalendar: "1391/12/30 20:29:00",
            dateTimeLocalInAltCalendar: "1391/12/30 23:59:00",
            dateTimeHomeInAltCalendar: "1391/12/30 23:59:00"
            );
        }


        // Test: 
        // 21 March 2013 20:29 UTC 
        // یک فروردین 1392 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_92_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/03/21 20:29:00",
            dateTimeLocal: "2013/03/21 23:59:00",
            dateTimeHome: "2013/03/21 23:59:00",
            dateUtc: "2013/03/21",
            dateLocal: "2013/03/21",
            dateHome: "2013/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1392,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1392/01/01",
            dateLocalInAltCalendar: "1392/01/01",
            dateHomeInAltCalendar: "1392/01/01",
            dateTimeUtcInAltCalendar: "1392/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1392/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1392/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2013 20:30 UTC 
        // دوم فروردین 1392 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_92_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/03/21 20:30:00",
            dateTimeLocal: "2013/03/22 01:00:00",
            dateTimeHome: "2013/03/22 01:00:00",
            dateUtc: "2013/03/21",
            dateLocal: "2013/03/22",
            dateHome: "2013/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1392,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1392/01/01",
            dateLocalInAltCalendar: "1392/01/02",
            dateHomeInAltCalendar: "1392/01/02",
            dateTimeUtcInAltCalendar: "1392/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1392/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1392/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2013 20:29 UTC 
        // سی شهریور 1392 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_92_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/09/21 19:29:00",
            dateTimeLocal: "2013/09/21 23:59:00",
            dateTimeHome: "2013/09/21 23:59:00",
            dateUtc: "2013/09/21",
            dateLocal: "2013/09/21",
            dateHome: "2013/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1392,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1392/06/30",
            dateLocalInAltCalendar: "1392/06/30",
            dateHomeInAltCalendar: "1392/06/30",
            dateTimeUtcInAltCalendar: "1392/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1392/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1392/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2013 19:30 UTC 
        // سی شهریور 1392 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_92_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/09/21 19:30:00",
            dateTimeLocal: "2013/09/21 23:00:00",
            dateTimeHome: "2013/09/21 23:00:00",
            dateUtc: "2013/09/21",
            dateLocal: "2013/09/21",
            dateHome: "2013/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1392,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1392/06/30",
            dateLocalInAltCalendar: "1392/06/30",
            dateHomeInAltCalendar: "1392/06/30",
            dateTimeUtcInAltCalendar: "1392/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1392/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1392/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2013 18:30 UTC 
        // سی شهریور 1392 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_92_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2013, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2013/09/21 18:30:00",
            dateTimeLocal: "2013/09/21 23:00:00",
            dateTimeHome: "2013/09/21 23:00:00",
            dateUtc: "2013/09/21",
            dateLocal: "2013/09/21",
            dateHome: "2013/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1392,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1392/06/30",
            dateLocalInAltCalendar: "1392/06/30",
            dateHomeInAltCalendar: "1392/06/30",
            dateTimeUtcInAltCalendar: "1392/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1392/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1392/06/30 23:00:00"
            );
        }

       
        
        // Test: 
        // 21 March 2014 20:29 UTC 
        // یک فروردین 1393 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_93_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2014, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2014/03/21 20:29:00",
            dateTimeLocal: "2014/03/21 23:59:00",
            dateTimeHome: "2014/03/21 23:59:00",
            dateUtc: "2014/03/21",
            dateLocal: "2014/03/21",
            dateHome: "2014/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1393,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1393/01/01",
            dateLocalInAltCalendar: "1393/01/01",
            dateHomeInAltCalendar: "1393/01/01",
            dateTimeUtcInAltCalendar: "1393/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1393/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1393/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2014 20:30 UTC 
        // دوم فروردین 1393 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_93_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2014, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2014/03/21 20:30:00",
            dateTimeLocal: "2014/03/22 01:00:00",
            dateTimeHome: "2014/03/22 01:00:00",
            dateUtc: "2014/03/21",
            dateLocal: "2014/03/22",
            dateHome: "2014/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1393,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1393/01/01",
            dateLocalInAltCalendar: "1393/01/02",
            dateHomeInAltCalendar: "1393/01/02",
            dateTimeUtcInAltCalendar: "1393/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1393/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1393/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2014 20:29 UTC 
        // سی شهریور 1393 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_93_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2014, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2014/09/21 19:29:00",
            dateTimeLocal: "2014/09/21 23:59:00",
            dateTimeHome: "2014/09/21 23:59:00",
            dateUtc: "2014/09/21",
            dateLocal: "2014/09/21",
            dateHome: "2014/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1393,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1393/06/30",
            dateLocalInAltCalendar: "1393/06/30",
            dateHomeInAltCalendar: "1393/06/30",
            dateTimeUtcInAltCalendar: "1393/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1393/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1393/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2014 19:30 UTC 
        // سی شهریور 1393 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_93_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2014, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2014/09/21 19:30:00",
            dateTimeLocal: "2014/09/21 23:00:00",
            dateTimeHome: "2014/09/21 23:00:00",
            dateUtc: "2014/09/21",
            dateLocal: "2014/09/21",
            dateHome: "2014/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1393,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1393/06/30",
            dateLocalInAltCalendar: "1393/06/30",
            dateHomeInAltCalendar: "1393/06/30",
            dateTimeUtcInAltCalendar: "1393/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1393/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1393/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2014 18:30 UTC 
        // سی شهریور 1393 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_93_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2014, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2014/09/21 18:30:00",
            dateTimeLocal: "2014/09/21 23:00:00",
            dateTimeHome: "2014/09/21 23:00:00",
            dateUtc: "2014/09/21",
            dateLocal: "2014/09/21",
            dateHome: "2014/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1393,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1393/06/30",
            dateLocalInAltCalendar: "1393/06/30",
            dateHomeInAltCalendar: "1393/06/30",
            dateTimeUtcInAltCalendar: "1393/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1393/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1393/06/30 23:00:00"
            );
        }


        // Test: 
        // 21 March 2015 20:29 UTC 
        // یک فروردین 1394 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_94_Farvardin_01_BeforeDst()
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

        // Test: 
        // 22 March 2015 20:30 UTC 
        // دوم فروردین 1394 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_94_Farvardin_01_AfterDst()
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

        // Test: 
        // 21 September 2015 20:29 UTC 
        // سی شهریور 1394 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_94_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2015/09/21 19:29:00",
            dateTimeLocal: "2015/09/21 23:59:00",
            dateTimeHome: "2015/09/21 23:59:00",
            dateUtc: "2015/09/21",
            dateLocal: "2015/09/21",
            dateHome: "2015/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1394,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1394/06/30",
            dateLocalInAltCalendar: "1394/06/30",
            dateHomeInAltCalendar: "1394/06/30",
            dateTimeUtcInAltCalendar: "1394/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1394/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1394/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2015 19:30 UTC 
        // سی شهریور 1394 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_94_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2015/09/21 19:30:00",
            dateTimeLocal: "2015/09/21 23:00:00",
            dateTimeHome: "2015/09/21 23:00:00",
            dateUtc: "2015/09/21",
            dateLocal: "2015/09/21",
            dateHome: "2015/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1394,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1394/06/30",
            dateLocalInAltCalendar: "1394/06/30",
            dateHomeInAltCalendar: "1394/06/30",
            dateTimeUtcInAltCalendar: "1394/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1394/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1394/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2015 18:30 UTC 
        // سی شهریور 1394 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_94_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2015, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2015/09/21 18:30:00",
            dateTimeLocal: "2015/09/21 23:00:00",
            dateTimeHome: "2015/09/21 23:00:00",
            dateUtc: "2015/09/21",
            dateLocal: "2015/09/21",
            dateHome: "2015/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1394,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1394/06/30",
            dateLocalInAltCalendar: "1394/06/30",
            dateHomeInAltCalendar: "1394/06/30",
            dateTimeUtcInAltCalendar: "1394/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1394/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1394/06/30 23:00:00"
            );
        }


        //=======================================  سال کبیسه ===============================================

        // Test: 
        // 21 March 2016 20:29 UTC 
        // یک فروردین 1395 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_95_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2016/03/20 20:29:00",
            dateTimeLocal: "2016/03/20 23:59:00",
            dateTimeHome: "2016/03/20 23:59:00",
            dateUtc: "2016/03/20",
            dateLocal: "2016/03/20",
            dateHome: "2016/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1395,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1395/01/01",
            dateLocalInAltCalendar: "1395/01/01",
            dateHomeInAltCalendar: "1395/01/01",
            dateTimeUtcInAltCalendar: "1395/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1395/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1395/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2016 20:30 UTC 
        // دوم فروردین 1395 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_95_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 03, 20, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2016/03/20 20:30:00",
            dateTimeLocal: "2016/03/21 01:00:00",
            dateTimeHome: "2016/03/21 01:00:00",
            dateUtc: "2016/03/20",
            dateLocal: "2016/03/21",
            dateHome: "2016/03/21",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1395,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1395/01/01",
            dateLocalInAltCalendar: "1395/01/02",
            dateHomeInAltCalendar: "1395/01/02",
            dateTimeUtcInAltCalendar: "1395/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1395/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1395/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2016 20:29 UTC 
        // سی شهریور 1395 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_95_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 09, 20, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2016/09/20 19:29:00",
            dateTimeLocal: "2016/09/20 23:59:00",
            dateTimeHome: "2016/09/20 23:59:00",
            dateUtc: "2016/09/20",
            dateLocal: "2016/09/20",
            dateHome: "2016/09/20",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1395,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1395/06/30",
            dateLocalInAltCalendar: "1395/06/30",
            dateHomeInAltCalendar: "1395/06/30",
            dateTimeUtcInAltCalendar: "1395/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1395/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1395/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2016 19:30 UTC 
        // سی شهریور 1395 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_95_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 09, 20, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2016/09/20 19:30:00",
            dateTimeLocal: "2016/09/20 23:00:00",
            dateTimeHome: "2016/09/20 23:00:00",
            dateUtc: "2016/09/20",
            dateLocal: "2016/09/20",
            dateHome: "2016/09/20",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1395,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1395/06/30",
            dateLocalInAltCalendar: "1395/06/30",
            dateHomeInAltCalendar: "1395/06/30",
            dateTimeUtcInAltCalendar: "1395/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1395/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1395/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2016 18:30 UTC 
        // سی شهریور 1395 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_95_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2016, 09, 20, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2016/09/20 18:30:00",
            dateTimeLocal: "2016/09/20 23:00:00",
            dateTimeHome: "2016/09/20 23:00:00",
            dateUtc: "2016/09/20",
            dateLocal: "2016/09/20",
            dateHome: "2016/09/20",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1395,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1395/06/30",
            dateLocalInAltCalendar: "1395/06/30",
            dateHomeInAltCalendar: "1395/06/30",
            dateTimeUtcInAltCalendar: "1395/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1395/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1395/06/30 23:00:00"
            );
        }

        // Test: 
        // 20 March 2017 19:29 UTC 
        // سی اسفند 1395 ساعت 23:59 به وقت محلی  
        // سال کبیسه
        [Test]
        public void UtcToLocal_StandardTest_95_Esfand_30_LeapYear()
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


        // Test: 
        // 21 March 2017 20:29 UTC 
        // یک فروردین 1396 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_96_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2017/03/21 20:29:00",
            dateTimeLocal: "2017/03/21 23:59:00",
            dateTimeHome: "2017/03/21 23:59:00",
            dateUtc: "2017/03/21",
            dateLocal: "2017/03/21",
            dateHome: "2017/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1396,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1396/01/01",
            dateLocalInAltCalendar: "1396/01/01",
            dateHomeInAltCalendar: "1396/01/01",
            dateTimeUtcInAltCalendar: "1396/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1396/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1396/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2017 20:30 UTC 
        // دوم فروردین 1396 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_96_Farvardin_01_AfterDst()
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

        // Test: 
        // 21 September 2017 20:29 UTC 
        // سی شهریور 1396 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_96_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2017/09/21 19:29:00",
            dateTimeLocal: "2017/09/21 23:59:00",
            dateTimeHome: "2017/09/21 23:59:00",
            dateUtc: "2017/09/21",
            dateLocal: "2017/09/21",
            dateHome: "2017/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1396,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1396/06/30",
            dateLocalInAltCalendar: "1396/06/30",
            dateHomeInAltCalendar: "1396/06/30",
            dateTimeUtcInAltCalendar: "1396/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1396/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1396/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2017 19:30 UTC 
        // سی شهریور 1396 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_96_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2017/09/21 19:30:00",
            dateTimeLocal: "2017/09/21 23:00:00",
            dateTimeHome: "2017/09/21 23:00:00",
            dateUtc: "2017/09/21",
            dateLocal: "2017/09/21",
            dateHome: "2017/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1396,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1396/06/30",
            dateLocalInAltCalendar: "1396/06/30",
            dateHomeInAltCalendar: "1396/06/30",
            dateTimeUtcInAltCalendar: "1396/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1396/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1396/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2017 18:30 UTC 
        // سی شهریور 1396 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_96_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2017, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2017/09/21 18:30:00",
            dateTimeLocal: "2017/09/21 23:00:00",
            dateTimeHome: "2017/09/21 23:00:00",
            dateUtc: "2017/09/21",
            dateLocal: "2017/09/21",
            dateHome: "2017/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1396,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1396/06/30",
            dateLocalInAltCalendar: "1396/06/30",
            dateHomeInAltCalendar: "1396/06/30",
            dateTimeUtcInAltCalendar: "1396/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1396/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1396/06/30 23:00:00"
            );
        }


        // Test: 
        // 21 March 2018 20:29 UTC 
        // یک فروردین 1397 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_97_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2018, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2018/03/21 20:29:00",
            dateTimeLocal: "2018/03/21 23:59:00",
            dateTimeHome: "2018/03/21 23:59:00",
            dateUtc: "2018/03/21",
            dateLocal: "2018/03/21",
            dateHome: "2018/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1397,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1397/01/01",
            dateLocalInAltCalendar: "1397/01/01",
            dateHomeInAltCalendar: "1397/01/01",
            dateTimeUtcInAltCalendar: "1397/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1397/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1397/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2018 20:30 UTC 
        // دوم فروردین 1397 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_97_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2018, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2018/03/21 20:30:00",
            dateTimeLocal: "2018/03/22 01:00:00",
            dateTimeHome: "2018/03/22 01:00:00",
            dateUtc: "2018/03/21",
            dateLocal: "2018/03/22",
            dateHome: "2018/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1397,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1397/01/01",
            dateLocalInAltCalendar: "1397/01/02",
            dateHomeInAltCalendar: "1397/01/02",
            dateTimeUtcInAltCalendar: "1397/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1397/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1397/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2018 20:29 UTC 
        // سی شهریور 1397 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_97_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2018, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2018/09/21 19:29:00",
            dateTimeLocal: "2018/09/21 23:59:00",
            dateTimeHome: "2018/09/21 23:59:00",
            dateUtc: "2018/09/21",
            dateLocal: "2018/09/21",
            dateHome: "2018/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1397,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1397/06/30",
            dateLocalInAltCalendar: "1397/06/30",
            dateHomeInAltCalendar: "1397/06/30",
            dateTimeUtcInAltCalendar: "1397/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1397/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1397/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2018 19:30 UTC 
        // سی شهریور 1397 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_97_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2018, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2018/09/21 19:30:00",
            dateTimeLocal: "2018/09/21 23:00:00",
            dateTimeHome: "2018/09/21 23:00:00",
            dateUtc: "2018/09/21",
            dateLocal: "2018/09/21",
            dateHome: "2018/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1397,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1397/06/30",
            dateLocalInAltCalendar: "1397/06/30",
            dateHomeInAltCalendar: "1397/06/30",
            dateTimeUtcInAltCalendar: "1397/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1397/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1397/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2018 18:30 UTC 
        // سی شهریور 1397 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_97_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2018, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2018/09/21 18:30:00",
            dateTimeLocal: "2018/09/21 23:00:00",
            dateTimeHome: "2018/09/21 23:00:00",
            dateUtc: "2018/09/21",
            dateLocal: "2018/09/21",
            dateHome: "2018/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1397,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1397/06/30",
            dateLocalInAltCalendar: "1397/06/30",
            dateHomeInAltCalendar: "1397/06/30",
            dateTimeUtcInAltCalendar: "1397/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1397/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1397/06/30 23:00:00"
            );
        }


        // Test: 
        // 21 March 2019 20:29 UTC 
        // یک فروردین 13987 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_98_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2019, 03, 21, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2019/03/21 20:29:00",
            dateTimeLocal: "2019/03/21 23:59:00",
            dateTimeHome: "2019/03/21 23:59:00",
            dateUtc: "2019/03/21",
            dateLocal: "2019/03/21",
            dateHome: "2019/03/21",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1398,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1398/01/01",
            dateLocalInAltCalendar: "1398/01/01",
            dateHomeInAltCalendar: "1398/01/01",
            dateTimeUtcInAltCalendar: "1398/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1398/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1398/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2019 20:30 UTC 
        // دوم فروردین 1398 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_98_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2019, 03, 21, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2019/03/21 20:30:00",
            dateTimeLocal: "2019/03/22 01:00:00",
            dateTimeHome: "2019/03/22 01:00:00",
            dateUtc: "2019/03/21",
            dateLocal: "2019/03/22",
            dateHome: "2019/03/22",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1398,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1398/01/01",
            dateLocalInAltCalendar: "1398/01/02",
            dateHomeInAltCalendar: "1398/01/02",
            dateTimeUtcInAltCalendar: "1398/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1398/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1398/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2019 20:29 UTC 
        // سی شهریور 1398 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_98_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2019, 09, 21, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2019/09/21 19:29:00",
            dateTimeLocal: "2019/09/21 23:59:00",
            dateTimeHome: "2019/09/21 23:59:00",
            dateUtc: "2019/09/21",
            dateLocal: "2019/09/21",
            dateHome: "2019/09/21",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1398,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1398/06/30",
            dateLocalInAltCalendar: "1398/06/30",
            dateHomeInAltCalendar: "1398/06/30",
            dateTimeUtcInAltCalendar: "1398/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1398/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1398/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2019 19:30 UTC 
        // سی شهریور 1398 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_98_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2019, 09, 21, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2019/09/21 19:30:00",
            dateTimeLocal: "2019/09/21 23:00:00",
            dateTimeHome: "2019/09/21 23:00:00",
            dateUtc: "2019/09/21",
            dateLocal: "2019/09/21",
            dateHome: "2019/09/21",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1398,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1398/06/30",
            dateLocalInAltCalendar: "1398/06/30",
            dateHomeInAltCalendar: "1398/06/30",
            dateTimeUtcInAltCalendar: "1398/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1398/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1398/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2019 18:30 UTC 
        // سی شهریور 1398 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_98_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2019, 09, 21, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2019/09/21 18:30:00",
            dateTimeLocal: "2019/09/21 23:00:00",
            dateTimeHome: "2019/09/21 23:00:00",
            dateUtc: "2019/09/21",
            dateLocal: "2019/09/21",
            dateHome: "2019/09/21",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1398,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1398/06/30",
            dateLocalInAltCalendar: "1398/06/30",
            dateHomeInAltCalendar: "1398/06/30",
            dateTimeUtcInAltCalendar: "1398/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1398/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1398/06/30 23:00:00"
            );
        }



        // Test: 
        // 21 March 2020 20:29 UTC 
        // یک فروردین 1399 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_99_Farvardin_01_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2020, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2020/03/20 20:29:00",
            dateTimeLocal: "2020/03/20 23:59:00",
            dateTimeHome: "2020/03/20 23:59:00",
            dateUtc: "2020/03/20",
            dateLocal: "2020/03/20",
            dateHome: "2020/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/01/01",
            dateLocalInAltCalendar: "1399/01/01",
            dateHomeInAltCalendar: "1399/01/01",
            dateTimeUtcInAltCalendar: "1399/01/01 20:29:00",
            dateTimeLocalInAltCalendar: "1399/01/01 23:59:00",
            dateTimeHomeInAltCalendar: "1399/01/01 23:59:00"
            );

        }

        // Test: 
        // 22 March 2020 20:30 UTC 
        // دوم فروردین 1399 ساعت 01:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه اول سال
        [Test]
        public void UtcToLocal_StandardTest_99_Farvardin_01_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2020, 03, 20, 20, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2020/03/20 20:30:00",
            dateTimeLocal: "2020/03/21 01:00:00",
            dateTimeHome: "2020/03/21 01:00:00",
            dateUtc: "2020/03/20",
            dateLocal: "2020/03/21",
            dateHome: "2020/03/21",
            timeUtc: "20:30:00",
            timeLocal: "01:00:00",
            timeHome: "01:00:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 01,
            altCalendarDayUtc: 01,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/01/01",
            dateLocalInAltCalendar: "1399/01/02",
            dateHomeInAltCalendar: "1399/01/02",
            dateTimeUtcInAltCalendar: "1399/01/01 20:30:00",
            dateTimeLocalInAltCalendar: "1399/01/02 01:00:00",
            dateTimeHomeInAltCalendar: "1399/01/02 01:00:00"
            );

        }

        // Test: 
        // 21 September 2020 20:29 UTC 
        // سی شهریور 1399 ساعت 23:59 به وقت محلی  
        // تست یک ثانیه قبل از تغییر یافتن ساعت در نیمه دوم سال
        [Test]
        public void UtcToLocal_StandardTest_99_Shahrivar_30_BeforeDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2020, 09, 20, 19, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2020/09/20 19:29:00",
            dateTimeLocal: "2020/09/20 23:59:00",
            dateTimeHome: "2020/09/20 23:59:00",
            dateUtc: "2020/09/20",
            dateLocal: "2020/09/20",
            dateHome: "2020/09/20",
            timeUtc: "19:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/06/30",
            dateLocalInAltCalendar: "1399/06/30",
            dateHomeInAltCalendar: "1399/06/30",
            dateTimeUtcInAltCalendar: "1399/06/30 19:29:00",
            dateTimeLocalInAltCalendar: "1399/06/30 23:59:00",
            dateTimeHomeInAltCalendar: "1399/06/30 23:59:00"
            );
        }

        // Test: 
        // 21 September 2020 19:30 UTC 
        // سی شهریور 1399 ساعت 23:00 به وقت محلی  
        // تست یک ثانیه بعد از تغییر یافتن ساعت در نیمه دوم سال
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_99_Shahrivar_30_AfterDst()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2020, 09, 20, 19, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2020/09/20 19:30:00",
            dateTimeLocal: "2020/09/20 23:00:00",
            dateTimeHome: "2020/09/20 23:00:00",
            dateUtc: "2020/09/20",
            dateLocal: "2020/09/20",
            dateHome: "2020/09/20",
            timeUtc: "19:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/06/30",
            dateLocalInAltCalendar: "1399/06/30",
            dateHomeInAltCalendar: "1399/06/30",
            dateTimeUtcInAltCalendar: "1399/06/30 19:30:00",
            dateTimeLocalInAltCalendar: "1399/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1399/06/30 23:00:00"
            );
        }

        // Test: 
        // 21 September 2020 18:30 UTC 
        // سی شهریور 1399 ساعت 23:00 به وقت محلی  
        // دو ساعت در وقت جهانی دارای یک ساعت در وقت محلی می باشد
        // تغییر ساعت باید رخ دهد     
        [Test]
        public void UtcToLocal_StandardTest_99_Shahrivar_30_SameLocalConversion()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2020, 09, 20, 18, 30, 00, DateTimeKind.Utc),
            dateTimeUtc: "2020/09/20 18:30:00",
            dateTimeLocal: "2020/09/20 23:00:00",
            dateTimeHome: "2020/09/20 23:00:00",
            dateUtc: "2020/09/20",
            dateLocal: "2020/09/20",
            dateHome: "2020/09/20",
            timeUtc: "18:30:00",
            timeLocal: "23:00:00",
            timeHome: "23:00:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 06,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/06/30",
            dateLocalInAltCalendar: "1399/06/30",
            dateHomeInAltCalendar: "1399/06/30",
            dateTimeUtcInAltCalendar: "1399/06/30 18:30:00",
            dateTimeLocalInAltCalendar: "1399/06/30 23:00:00",
            dateTimeHomeInAltCalendar: "1399/06/30 23:00:00"
            );
        }

        // Test: 
        // 20 March 2021 19:29 UTC 
        // سی اسفند 1399 ساعت 23:59 به وقت محلی  
        // سال کبیسه
        [Test]
        public void UtcToLocal_StandardTest_99_Esfand_30_LeapYear()
        {
            AssertTralusDateTime(tralusDataTime: new DateTime(2021, 03, 20, 20, 29, 00, DateTimeKind.Utc),
            dateTimeUtc: "2021/03/20 20:29:00",
            dateTimeLocal: "2021/03/20 23:59:00",
            dateTimeHome: "2021/03/20 23:59:00",
            dateUtc: "2021/03/20",
            dateLocal: "2021/03/20",
            dateHome: "2021/03/20",
            timeUtc: "20:29:00",
            timeLocal: "23:59:00",
            timeHome: "23:59:00",
            altCalendarYearUtc: 1399,
            altCalendarMonthUtc: 12,
            altCalendarDayUtc: 30,
            localTimeZoneId: "Asia/Tehran",
            dateUtcInAltCalendar: "1399/12/30",
            dateLocalInAltCalendar: "1399/12/30",
            dateHomeInAltCalendar: "1399/12/30",
            dateTimeUtcInAltCalendar: "1399/12/30 20:29:00",
            dateTimeLocalInAltCalendar: "1399/12/30 23:59:00",
            dateTimeHomeInAltCalendar: "1399/12/30 23:59:00"
            );
        }
    }
}
