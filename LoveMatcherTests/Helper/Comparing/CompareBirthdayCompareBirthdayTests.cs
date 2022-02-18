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
            int expected = 4;
            var result = test.CompareMonth(date, date2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void CompareMonthTest2()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);
            var date2 = new DateTime(1995, 6, 29);
            int expected = 4;
            var result = test.CompareMonth(date2, date);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CompareDayTest()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);
            var date2 = new DateTime(1995, 6, 29);
            int expected = 16;
            var result = test.CompareDay(date, date2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CompareDayTest2()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);
            var date2 = new DateTime(1995, 6, 29);
            int expected = 16;
            var result = test.CompareDay(date2, date);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MonthEvenNumberTest()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);

            var result = test.MonthEvenNumber(date);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DayEvenNumberTest()
        {
            var test = new CompareBirthday();
            var date = new DateTime(1995, 2, 13);

            var result = test.DayEvenNumber(date);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ZodiacSignTest()
        {
            var test = new CompareBirthday();
            var person = new Person();
            var date = new DateTime(1990, 1, 29);
            person.Birthday = date;
            var expected = "Aquarius";
            var result = test.GetAstroSign(person);

            Assert.AreEqual(expected, result);
        }
    }
}