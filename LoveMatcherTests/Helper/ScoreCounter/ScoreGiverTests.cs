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
        [DataRow("Hugh", "Adam", 50)]
        [DataRow("Rockson", "John", 55)]
        [DataRow("Jo", "Adamsonslongesstname", 65)]
        public void LengthDiffrenceName_Succesful(string name1, string name2, int expected)
        {
            ScoreGiver test = new();
            var actual = test.LengthNameDiffrence_Score(name1, name2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("Hugh","Adam", 60)]
        [DataRow("Jonas","Jordi", 50)]
        [DataRow("Jon","Adam", 55)]
        public void LengthIsEven_ScoreTest_TrueAndFalse(string name1, string name2, int expected)
        {
            ScoreGiver test = new();
            var actual = test.LengthIsEven_Score(name1, name2);


            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("Adamthemadam", "JohnTheBonLononona", 60)]
        [DataRow("Jonas", "Jordiii", 55)]
        [DataRow("Jo", "Di", 45)]
        public void NumberOfVowels_Score_Test_Successful(string name1, string name2, int expected)
        {
            ScoreGiver test = new();
            var actual = test.NumberOfVowels_Score(name1, name2);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        [DataRow("Johanathemamama", "JohnTheBonLononona", 60)]
        [DataRow("Helmut", "Santana", 55)]
        [DataRow("Go", "Wi", 45)]
        public void NumberOfConsonants_Score_Test_Successful(string name1, string name2, int expected)
        {
            ScoreGiver test = new();
            var actual = test.NumberOfVowels_Score(name1, name2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("Amanda The Panda", "Amanda The Panda", 60)]
        [DataRow("Jonas", "Jon", 55)]
        [DataRow("Helmut", "Anna", 45)]
        public void NumberOfSameLetters_Score_Test_Successful(string name1, string name2, int expected)
        {
            ScoreGiver sut = new();
            var actual = sut.NumberOfSameLetters_Score(name1, name2);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5, 50)]
        [DataRow(2, 60)]
        [DataRow(10, 45)]
        public void MonthEvenNumberScoreTest(int diff, int expected)
        {
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
            ScoreGiver test = new();

            var result = test.DayEvenNumberScore(person1, person2);

            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataRow("Aries", "Libra", 60)]
        [DataRow("Libra", "Aries", 60)]
        [DataRow("Virgo", "", 60)]
        [DataRow()]
        public void GetZodiacSignScoreTest(string zodiac1, string zodiac2, int expected)
        {
            ScoreGiver score = new();

            var result = score.GetZodiacSignScore(zodiac1, zodiac2);

            Assert.AreEqual(expected, result);
        }
    }
}