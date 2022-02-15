public class Convert
{
    /// <summary> Converts string to int[] by converting char to numeric value </summary>
    /// <param name="name"></param>
    /// <returns> int[].</returns>
    public int[] CharToInt(string name) //TESTA
    {
        var numbers[] = new int[name.Length];
        for (int i = 0; i < name.Length; i++)
        {
            int number = (int)Char.GetNumericValue(name[i]);
            numbers[i] = number;
        }
        return numbers;
    }
    /// <summary>
    /// Makes the first letter a capital letter and rest to lower case. Takes away unnecessary spaces
    /// </summary>
    /// <param name="namn">The name.</param>
    /// <returns></returns>
    private static string NameCheck(string name)
    {
        name = name.Trim();
        var firstLetter = name.Substring(0, 1).ToUpper();
        var rest = name.Substring(1).ToLower();
        return firstLetter + rest;
    }
}
