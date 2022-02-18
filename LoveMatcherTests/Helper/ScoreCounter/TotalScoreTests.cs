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
            var oldScore = 5;
            var newScore = 10;

            TotalScore test = new();
            test.AddToTotal(oldScore);
            var actual = test.AddToTotal(newScore);
            

            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractFromTotalTest()
        {
            var oldScore = 45;
            var minusScore = 10;

            TotalScore test = new();
            test.AddToTotal(oldScore);
            var actual = test.SubstractFromTotal(minusScore);

            var expected = 35;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubstractFromTotalTest_ScoreNotUnderZero()
        {
            var oldScore = 5;
            var minusScore = 20;

            TotalScore test = new();
            test.AddToTotal(oldScore);
            var actual = test.SubstractFromTotal(minusScore);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}