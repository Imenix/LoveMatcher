public class InputCheck
{
    /// <summary>
    /// Checks the age.
    /// </summary>
    /// <param name="age">The age.</param>
    /// <returns></returns>
    public bool CheckAge(int age)
    {
        return age > 0 || age < 100;
    }

    /// <summary>
    /// Checks the format of the DateTime
    /// </summary>
    /// <returns></returns>
    public bool CheckDateTimeFormat() //https://stackoverflow.com/questions/371987/how-to-validate-a-datetime-in-c
    {
        DateTime temp;
        if (DateTime.TryParse(startDateTextBox.Text, out temp))
        {
            // Yay :)
        }
        else
        {
            // Aww.. :(
        }
    }

    /// <summary>
    /// Controls that the input is letters or '-'.
    /// </summary>
    /// <returns></returns>
    public bool CheckLetters(string input)  //https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp/1181426
    {
       bool result = input.All(Char.IsLetter);
    }
}