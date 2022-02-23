using System.Globalization;

public static class InputCheck
{
    /// <summary>
    /// Checks if the age is between 0 and 100.
    /// </summary>
    /// <param name="input">Birthdate in string format.</param>
    /// <returns>True if age is between 0 and 100. /returns>
    public static bool CheckAge(string input)
    {
        DateTime.TryParse(input, out DateTime birthDate);
        var age = DateTime.Today.Year - birthDate.Year;
        return age > 0 && age < 100;
    }

    /// <summary>
    /// Checks the format of the DateTime
    /// </summary>
    /// <returns>True or false.</returns>
    public static bool CheckDateTimeFormat(string date) //https://stackoverflow.com/a/11999950
    {
        string[] formats = { "yyyy/MM/dd", "yyyy-MM-dd", "yyyy MM dd" };
        return DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture,DateTimeStyles.None, out _);
    }

    /// <summary>
    /// Controls that the input is only letters, " " or '-'. Cannot be only " " or '-';
    /// </summary>
    /// <returns>True or false.</returns>
    public static bool CheckLetters(string input)  //https://stackoverflow.com/a/34264342
    {
        if (input.All(c => c.Equals(' ')) || input.All(c => c.Equals('-'))) return false;
        else return input.All(c => char.IsLetter(c) || c.Equals('-') || c.Equals(' '));
    }
    public static void CheckCursorPosition() //https://stackoverflow.com/q/6723755  funkar nästan felfritt. ska nog kolla igenom den mer noga sen.
    {
        string str = string.Empty;
        while (true)
        {
            char c = Console.ReadKey(true).KeyChar;
            if (c == '\r')
                break;
            if (c == '\b')
            {
                if (str != "")
                {
                    str = str.Substring(0, str.Length - 1);
                    Console.Write("\b \b");
                }
            }
            else if (str.Length < 15)
            {
                Console.Write(c);
                str += c;
            }
        }
    }
}