using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoveMatcher.Helper.Comparing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.Comparing.Tests
{
    [TestClass()]
    public class CompareNameTests
    {
        /// <summary>
        /// Lengthes the test name fail.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <param name="name">The name.</param>
        [TestMethod()]
        [DataRow(4, "Joel")]
        [DataRow(6, "Mikael")]
        [DataRow(13, "AmadeusMozart")]
        public void LengthTest_Name_Fail(int expected, string name)
        {
            CompareName n = new();
            var result = n.LengthName(name);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Lengthes the is even test.
        /// </summary>
        /// <param name="name">The name.</param>
/        [TestMethod()]
        [DataRow("Joel")]
        [DataRow("JonasTheBuilders")]
        public void LengthIsEvenTest(string name)
        {
            CompareName c = new();
            var actual = c.LengthIsEven(name);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Numbers the of vowels test.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        [TestMethod()]
        [DataRow(8, "aeiouåäö")]
        [DataRow(5, "lalilulelo")]
        [DataRow(5, "LALILULELO")]
        [DataRow(5, "AAaa A")]
        [DataRow(0, "")]
        [DataRow(0, "666")]
        [DataRow(0, "áÀ")]
        public void NumberOfVowelsTest(int expected, string name)
        {
            var test = new CompareName();
            Assert.AreEqual(expected, test.NumberOfVowels(name));
        }
        /// <summary>
        /// Numbers the of consonants test.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        [TestMethod()]
        [DataRow(21, "'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'")]
        [DataRow(10, "Who Are The Patriots?")]
        [DataRow(5, "LALILULELO")]
        [DataRow(5, "BBbb B")]
        [DataRow(0, "")]
        [DataRow(0, "666")]
        public void NumberOfConsonantsTest(int expected, string name)
        {
            var test = new CompareName();
            Assert.AreEqual(expected, test.NumberOfConsonants(name));
        }
        /// <summary>
        /// Numbers the of same letters test.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        [TestMethod()]
        [DataRow(3,"apa", "mapa")]
        [DataRow(0, "Johan", "Xete")]
        [DataRow(2, "Mikael", "Max")]
        [DataRow(3, "William", "Tiia")]
        [DataRow(0, "Amber", "Johnny")]
        [DataRow(11, "Rapparkalja", "Rapparkalja")]

        public void NumberOfSameLettersTest(int expected, string a, string b)
        {
            var c = new CompareName();
            var result = c.NumberOfSameLetters(a, b);

            Assert.AreEqual(expected, result);
        }
    }
}