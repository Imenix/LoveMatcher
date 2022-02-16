using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoveMatcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CompareBirthdayTests
    {
        [TestMethod()]
        public void CompareMonthTest()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);
            var date2 = new DateTime(1995, 6, 29);
            int expected = 5;
            var result = test.CompareDay(date, date2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CompareDayTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MonthEvenNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DayEvenNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ZodiacSignTest()
        {
            Assert.Fail();
        }
    }
}