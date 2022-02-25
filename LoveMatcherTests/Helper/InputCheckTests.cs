using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class InputCheckTests
    {
        #region DateTimeFormat
        [TestMethod()]
        [DataRow("2002/01/04")]
        [DataRow("2002-01-04")]
        [DataRow("2002 01 04")]
        [DataRow("2002 12 13")]

        public void CheckDateTimeFormatTest_IsDateTRUE(string date)
        {
            Assert.IsTrue(InputCheck.CheckDateTimeFormat(date));
        }

        [TestMethod()]
        [DataRow("20020104")]
        [DataRow("98 02 03")]
        [DataRow("02/03/1998")]
        [DataRow("02/13/1998")]
        [DataRow("13/03/1998")]
        [DataRow("1998/13/12")]
        [DataRow(null)]
        public void CheckDateTimeFormatTest_IsDateFALSE(string date)
        {
            Assert.IsFalse(InputCheck.CheckDateTimeFormat(date));
        }
        #endregion

        #region Letters
        [TestMethod()]
        [DataRow("abc")]
        [DataRow("ABC")]
        [DataRow("Abc")]
        [DataRow("A b c")]
        [DataRow("a-b-c")]

        public void CheckLettersTest_Accepted(string input)
        {
            Assert.IsTrue(InputCheck.CheckLetters(input));
        }

        [TestMethod()]
        [DataRow(" ")]
        [DataRow("")]
        [DataRow("-")]
        [DataRow("- - -")]
        [DataRow("123")]
        public void CheckLettersTest_Denied(string input)
        {
            Assert.IsFalse(InputCheck.CheckLetters(input));
        }
        #endregion

        #region Age
        [TestMethod()]
        [DataRow(-99)]
        [DataRow(-1)]
        public void CheckAgeTest_WithinBorder(int amount)
        {
            DateTime today = DateTime.Today;
            string birth = today.AddYears(amount).ToString();
            Assert.IsTrue(InputCheck.CheckAge(birth));
        }
        [TestMethod()]
        [DataRow(-101)]
        [DataRow(1)]
        [DataRow(0)]
        [DataRow(2)]
        public void CheckAgeTest_OutideBorder(int amount)
        {
            DateTime today = DateTime.Today;
            string birth = today.AddYears(amount).ToString();
            Assert.IsFalse(InputCheck.CheckAge(birth));
        }
        #endregion
    }
}