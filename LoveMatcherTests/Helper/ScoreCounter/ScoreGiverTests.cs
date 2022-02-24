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
        [DataRow(5, 50)]
        [DataRow(2, 60)]
        [DataRow(10, 45)]
        public void MonthEvenNumberScoreTest(int diff, int expected)
        {
            TotalScore.Total = 50;
            ScoreGiver score = new();

            var result = score.CompareMonthScore(diff);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataRow(5, 60)]
        [DataRow(15, 50)]
        [DataRow(25, 45)]
        public void DayEvenNumberScoreTest(int diff, int expected)
        {
            TotalScore.Total = 50;
            ScoreGiver score = new();

            var result = score.CompareDayScore(diff);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataRow(true, true, 60)]
        [DataRow(true, false, 45)]
        [DataRow(false, false, 60)]
        [DataRow(false, true, 45)]
        public void MonthEvenNumberScore(bool person1, bool person2, int expected)
        {
            TotalScore.Total = 50;
            ScoreGiver test = new();

            var result = test.MonthEvenNumberScore(person1, person2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataRow(true, true, 60)]
        [DataRow(true, false, 45)]
        [DataRow(false, false, 60)]
        [DataRow(false, true, 45)]
        public void DayEvenNumberScore(bool person1, bool person2, int expected)
        {
            TotalScore.Total = 50;
            ScoreGiver test = new();

            var result = test.DayEvenNumberScore(person1, person2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataRow("Aries", "Libra", 60)]
        [DataRow("Libra", "Aries", 60)]
        [DataRow("Virgo", "Pisces", 60)]
        [DataRow("Pisces", "Virgo", 60)]
        [DataRow("Leo", "Taurus", 50)]
        public void GetZodiacSignScoreTest(string zodiac1, string zodiac2, int expected)
        {
            TotalScore.Total = 50;
            ScoreGiver score = new();

            var result = score.GetZodiacSignScore(zodiac1, zodiac2);

            Assert.AreEqual(expected, result);
        }
    }
}