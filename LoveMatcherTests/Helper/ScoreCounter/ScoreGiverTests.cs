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
        public void AgeDifference_ScoreTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsOver17_ScoreTest(Person person1, Person person2)
        {
            person1.Age = 18;
            person2.Age = 22;

            ScoreGiver test = new();
            var actual = test.IsOver17_Score(person1, person2);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AgeIsEvenNumber_ScoreTest()
        {
            Assert.Fail();
        }
    }
}