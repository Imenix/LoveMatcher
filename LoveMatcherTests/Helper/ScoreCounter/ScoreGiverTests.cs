using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoveMatcher.Helper.ScoreCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter.Tests
{
    [TestClass()]
    public class ScoreGiverTests
    {
        [TestMethod()]
        public void AgeDifference_ScoreTest_ZeroDiff()
        {
            var age1 = 35;
            var age2 = 35;

            ScoreGiver test = new();
            var actual = test.AgeDifference_Score(age1, age2);

            var expected = 65;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeDifference_ScoreTest_DiffBetween_0And9()
        {
            var age1 = 88;
            var age2 = 92;

            ScoreGiver test = new();
            var actual = test.AgeDifference_Score(age1, age2);

            var expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeDifference_ScoreTest_DiffBetween_10And19()
        {
            var age1 = 18;
            var age2 = 37;

            ScoreGiver test = new();
            var actual = test.AgeDifference_Score(age1, age2);

            var expected = 55;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeDifference_ScoreTest_Diff_Over20()
        {
            var age1 = 20;
            var age2 = 60;

            ScoreGiver test = new();
            var actual = test.AgeDifference_Score(age1, age2);

            var expected = 45;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(22, 30)]
        [DataRow(15, 17)]
        public void IsOver17_ScoreTest_BothTrueOrFalse(int age1, int age2)
        {
            ScoreGiver test = new();
            var actual = test.IsOver17_Score(age1, age2);

            var expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(22, 30)]
        [DataRow(59, 77)]
        public void AgeIsEvenNumber_ScoreTest(int age1, int age2)
        {
            ScoreGiver test = new();
            var actual = test.AgeIsEvenNumber_Score(age1, age2);

            var expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeIsEvenNumber_ScoreTest_TrueAndFalse()
        {
            var age1 = 25;
            var age2 = 34;

            ScoreGiver test = new();
            var actual = test.AgeIsEvenNumber_Score(age1, age2);

            var expected = 45;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void LengthIsEven_ScoreTest_TrueAndFalse()
        {
            var age1 = 25;
            var age2 = 34;

            ScoreGiver test = new();
            var actual = test.AgeIsEvenNumber_Score(age1, age2);

            var expected = 45;

            Assert.AreEqual(expected, actual);
        }
    }
}