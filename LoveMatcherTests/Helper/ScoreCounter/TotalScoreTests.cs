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
    public class TotalScoreTests
    {
        [TestMethod()]
        public void AddToTotalTest()
        {
            TotalScore.Total = 50;

            const int newScore = 10;

            TotalScore test = new();
            var actual = test.AddToTotal(newScore);

            const int expected = 65;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractFromTotalTest()
        {
            TotalScore.Total = 50;
            const int minusScore = 10;

            TotalScore test = new();
            var actual = test.SubstractFromTotal(minusScore);

            const int expected = 85;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractFromTotalTest_ScoreNotUnderZero()
        {
            TotalScore.Total = 50;
            const int minusScore = 20;

            TotalScore test = new();
            var actual = test.SubstractFromTotal(minusScore);

            const int expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}