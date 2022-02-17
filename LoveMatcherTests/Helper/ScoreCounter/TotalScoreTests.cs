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
    }
}