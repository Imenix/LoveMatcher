 using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class CompareAgeTests
    {
        [TestMethod()]
        [DataRow(30, 26)]
        [DataRow(45, 35)]
        public void AgeDifferenceTest_FirstIsHigherThanSecond(int ageA, int ageB)
        {
            CompareAge compare = new();
            var actual = compare.AgeDifference(ageA, ageB);

            var expected = ageA - ageB;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(15, 20)]
        [DataRow(44, 45)]
        public void AgeDifferenceTest_FirstIsLowerThanSecond(int ageA, int ageB)
        {
            CompareAge compare = new();
            var actual = compare.AgeDifference(ageA, ageB);

            var expected = ageB - ageA;

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