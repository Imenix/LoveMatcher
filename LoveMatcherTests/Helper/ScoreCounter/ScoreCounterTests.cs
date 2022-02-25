using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoveMatcher.Helper.ScoreCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveMatcher;

namespace LoveMatcher.Helper.ScoreCounter.Tests
{
    [TestClass()]
    public class ScoreCounterTests
    {
        [TestMethod()]
        public void GivePersonScoreTest()
        {
            TotalScore.Total = 50;

            // Person 1 -----------------------------------------
            Person person1 = new();
            person1.Name = "Angelina";

            var date1 = new DateTime(1975, 06, 04);
            person1.Birthday = date1;
            person1.Age = 46;

            // Person 2 -----------------------------------------
            Person person2 = new();
            person2.Name = "Brad";

            var date2 = new DateTime(1963, 12, 18);
            person2.Birthday = date2;
            person2.Age = 58;

            // ---------------------------------------------------

            ScoreCounter counter = new();
            counter.GivePersonScore(person1, person2);

            var actual = TotalScore.Total;
            var expected = 130;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GivePersonScoreTest_MaximumPoints()
        {
            TotalScore.Total = 50;
            // Person 1 -----------------------------------------
            Person person1 = new();
            person1.Name = "Loisef";

            var date1 = new DateTime(1990, 06, 04);
            person1.Birthday = date1;
            person1.Age = 32;

            // Person 2 -----------------------------------------
            Person person2 = new();
            person2.Name = "Lollaaejfiefiaejfi";

            var date2 = new DateTime(1990, 08, 06);
            person2.Birthday = date2;
            person2.Age = 32;

            // ---------------------------------------------------

            ScoreCounter counter = new();
            counter.GivePersonScore(person1, person2);

            var actual = TotalScore.Total;
            var expected = 190;

            Assert.AreEqual(expected, actual);
        }
    }
}