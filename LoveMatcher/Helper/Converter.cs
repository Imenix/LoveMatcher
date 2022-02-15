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
}
