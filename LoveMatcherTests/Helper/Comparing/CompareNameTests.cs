using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoveMatcher.Helper.Comparing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.Comparing.Tests
{
    [TestClass()]
    public class CompareNameTests
    {
        [TestMethod()]
        public void LengthTest()
        {
            CompareName n = new();
            var result = n.LengthName("Joe");
            Assert.AreEqual(3,result);
        }

        [TestMethod()]
        [DataRow("Joel")]
        public void LengthIsEvenTest(string name)
        {
            CompareName c = new();
            var actual = c.LengthIsEven(name);
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NumberOfVocalsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NumberOfConsonantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NumberOfSameLettersTest()
        {
            Assert.Fail();
        }
    }
}