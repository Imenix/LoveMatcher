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
    public class ScoreCounterTests
    {
        [TestMethod()]
        public void GivePersonScoreTest()
        {
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
            var expected = 75;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NameScoreTest()
        {
            string name1 = "";
            string name2 = "";

            ScoreCounter test = new();
            test.NameScore(name1, name2);

            var actual = TotalScore.Total;
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BirthdayScoreTest()
        {
            var date1 = new DateTime(1975, 06, 04);
            var date2 = new DateTime(1963, 12, 18);

            ScoreCounter test = new();
            test.BirthdayScore(date1, date2);

            var actual = TotalScore.Total;
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeScoreTest()
        {
            int age1 = 46;
            int age2 = 58;

            ScoreCounter test = new();
            test.AgeScore(age1, age2);

            var actual = TotalScore.Total;
            var expected = 75;

            Assert.AreEqual(expected, actual);
        }
    }
}