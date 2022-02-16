using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CompareAgeTests
    {
        [TestMethod()]
        [DataRow(30,26)]
        [DataRow(45, 35)]
        public void AgeDifferenceTest_FirstIsHigherThanSecond(int age1, int age2)
        {
            CompareAge actual = new();
            actual.AgeDifference(age1, age2);

            var expected = age1 - age2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(18)]
        [DataRow(99)]
        public void IstOver17Test(int age)
        {
            CompareAge compare = new();
            var actual = compare.IsOver17(age);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [DataRow(17)]
        [DataRow(1)]
        public void IsNotOver17Test(int age)
        {
            CompareAge compare = new();
            var actual = compare.IsOver17(age);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [DataRow(68)]
        [DataRow(18)]
        public void AgeIsEvenNumberTest(int age)
        {
            CompareAge compare = new();
            var actual = compare.AgeIsEvenNumber(age);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [DataRow(99)]
        [DataRow(5)]
        public void AgeIsNotEvenNumberTest(int age)
        {
            CompareAge compare = new();
            var actual = compare.AgeIsEvenNumber(age);

            Assert.IsFalse(actual);
        }
    }
}