public static class InputCheck
{
    /// <summary>
    /// Checks the age.
    /// </summary>
    /// <param name="age">The age.</param>
    /// <returns></returns>
    public static int CheckAge(int age)
    {
        if (age < 0) return 0;
        else if (age > 100) return 100;
        else return age;
        //return age > 0|| age < 100;
    }

    /// <summary>
    /// Checks the format of the DateTime
    /// </summary>
    /// <returns>True or false.</returns>
    public static bool CheckDateTimeFormat(string date) //https://stackoverflow.com/questions/371987/how-to-validate-a-datetime-in-c
    {
        return DateTime.TryParse(date, out _);
    }

    /// <summary>
    /// Controls that the input is only letters or '-'.
    /// </summary>
    /// <returns>True or false.</returns>
    public static bool CheckLetters(string input)  //https://stackoverflow.com/a/34264342
    {
        return input.All(c => char.IsLetter(c) || c.Equals('-'));
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