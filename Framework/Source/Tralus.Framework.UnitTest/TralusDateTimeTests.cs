//using Tralus.Framework.BusinessModel.Utility;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Tralus.Framework.UnitTest
//{
//    public class TralusDateTimeTests
//    {
//        [Theory(DisplayName = "تبدیل تاریخ و زمان داده شده به مقدار یو تی سی متناظر با آن")]
//        [MemberData("DateTimeUTCData")]
//        public void DateTimeUtcShouldReturnsCorrectStringBasedOnGivenDateTimeValue(DateTime inputValue, string expected)
//        {
//            TralusDateTime sut = inputValue;
//            var actual = sut.DateTimeUtc.Value.ToString("yyyy/MM/dd HH:mm:ss");

//            Assert.Equal(expected, actual);
//        }


//        public static IEnumerable<Object[]> DateTimeUTCData
//        {
//            get
//            {
//                var data = new List<object[]> {
//                    new object[] {
//                        new DateTime(2015, 03, 19, 04, 15, 00, DateTimeKind.Utc),
//                        "2015/03/19 04:15:00"
//                    }
//                };
//                return data.ToArray();
//            }
//        }
//    }
//}
