using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LoveMatcher;

namespace Tests
{
    [TestClass()]
    public class ConvertingTests
    {
        [TestMethod()]
        [DataRow("Kalle anka", "kalle anka")]
        [DataRow("Långben", "långben")]
        [DataRow("Musse", "mUsse")]
        public void ToCleanNameTest(string expected, string name)
        {
            Assert.AreEqual(expected, Converting.ToCleanName(name));
        }

        [TestMethod()]
        [DataRow("2002/04/10")]
        [DataRow("2002 04 10")]
        [DataRow("2002-04-10")]
        public void ToExactDateTimeTest(string date)
        {
            DateTime expected = new(2002,04,10);
            Assert.AreEqual(expected, Converting.ToExactDateTime(date));
        }
    }
}