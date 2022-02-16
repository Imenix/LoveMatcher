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
        public void LengthTest_Name_Fail()
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
        [DataRow(8, "aeiouåäö")]
        [DataRow(5, "lalilulelo")]
        [DataRow(5, "LALILULELO")]
        [DataRow(5, "AAaa A")]
        [DataRow(0, "")]
        [DataRow(0, "666")]
        [DataRow(0, "áÀ")]
        public void NumberOfVowelsTest(int expected, string name)
        {
            var test = new CompareName();
            Assert.AreEqual(expected, test.NumberOfVowels(name));
        }

        [TestMethod()]
        [DataRow(21, "'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'")]
        [DataRow(10, "Who Are The Patriots?")]
        [DataRow(5, "LALILULELO")]
        [DataRow(5, "BBbb B")]
        [DataRow(0, "")]
        [DataRow(0, "666")]
        public void NumberOfConsonantsTest(int expected, string name)
        {
            var test = new CompareName();
            Assert.AreEqual(expected, test.NumberOfConsonants(name));
        }

        [TestMethod()]
        public void NumberOfSameLettersTest()
        {
            Assert.Fail();
        }
    }
}