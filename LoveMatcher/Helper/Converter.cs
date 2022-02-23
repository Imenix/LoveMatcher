using System.Globalization;

public static class Converting
{
    /// <summary> Converts string to int[] by converting char to numeric value </summary>
    /// <param name="name"></param>
    /// <returns> int[].</returns>
    public static int[] CharToInt(string name) //TESTA
    {
        var numbers = new int[name.Length];
        for (int i = 0; i < name.Length; i++)
        {
            int number = (int)Char.GetNumericValue(name[i]);
            numbers[i] = number;
        }
        return numbers;
    }

    /// <summary>
    /// Strings to exact date time (same as CheckDateTimeFormat) but converts instead of just checking.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>DateTime in formats "yyyy/MM/dd", "yyyy-MM-dd" or "yyyy MM dd". </returns>
    public static DateTime ToExactDateTime(string str)
    {
        string[] formats = { "yyyy/MM/dd", "yyyy-MM-dd", "yyyy MM dd" };
        DateTime.TryParseExact(str, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date );
        return date;
    }

    /// <summary>
    /// Makes the first letter a capital letter and rest to lower case. Takes away unnecessary spaces before and after the string.
    /// </summary>
    /// <param name="namn">The name.</param>
    /// <returns></returns>
    public static string ToCleanName(string name)
    {
        if (name != "")
        {
            name = name.Trim();
            var firstLetter = name.Substring(0, 1).ToUpper();
            var rest = name.Substring(1).ToLower();
            return firstLetter + rest;
        }
        else return name;


    }
}
