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
        public void TotalScoreTest_ScoreNotUnderZero()
        {
            var minusScore = 10;

            TotalScore test = new(score: 5);
            var actual = test.SubstractFromTotal(minusScore);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddToTotalTest()
        {
            var newScore = 10;

            TotalScore test = new(score:5);
            var actual = test.AddToTotal(newScore);

            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractFromTotalTest()
        {
            var minusScore = 10;

            TotalScore test = new(score:45);
            var actual = test.SubstractFromTotal(minusScore);

            var expected = 35;

            Assert.AreEqual(expected, actual);
        }
    }
}