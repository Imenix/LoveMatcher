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
            //Arrange
            CompareName n = new();
            //Act
            var result = n.LengthName("Joe");
            //Assert
            Assert.AreNotEqual(0,result);
        }

        [TestMethod()]
        public void LengthIsEvenTest()
        {
            Assert.Fail();
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