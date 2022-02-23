using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ConvertingTests
    {
        [TestMethod()]
        [DataRow("Kalle anka", "kalle anka")]
        [DataRow("Långben", "långben")]
        [DataRow("Musse", "mUsse")]
        public void ToCleanNameTest(string expected, string name)
        {
            Assert.AreEqual(expected, Converting.ToCleanName(name));
        }
    }
}