using System.Globalization;

namespace LoveMatcher
{
    public static class InputCheck
    {
        /// <summary>
        /// Checks if the age is between 0 and 100.
        /// </summary>
        /// <param name="input">Birthdate in string format.</param>
        /// <returns>True if age is between 0 and 100. /returns>
        public static bool CheckAge(string input)
        {
            _ = DateTime.TryParse(input, out DateTime birthDate);
            var age = DateTime.Today.Year - birthDate.Year;
            return age > 0 && age < 101;
        }

        /// <summary>
        /// Checks the format of the DateTime
        /// </summary>
        /// <returns>True or false.</returns>
        public static bool CheckDateTimeFormat(string date) //https://stackoverflow.com/a/11999950
        {
            string[] formats = { "yyyy/MM/dd", "yyyy-MM-dd", "yyyy MM dd" };
            return DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        /// <summary>
        /// Controls that the input is only letters, " " or '-'. Cannot be only " "'s or '-''s;
        /// </summary>
        /// <returns>True or false.</returns>
        public static bool CheckLetters(string input)  //https://stackoverflow.com/a/34264342
        {
            if (input.All(c => c.Equals(' ')) || input.All(c => c.Equals('-') || c.Equals(' '))) return false;
            else return input.All(c => char.IsLetter(c) || c.Equals('-') || c.Equals(' '));
        }
    }
}