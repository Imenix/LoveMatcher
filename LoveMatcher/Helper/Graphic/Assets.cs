
internal static class Assets
{
    internal static string[] Heart = new string[]
    {
            " ▄▀▀▀▄ ▄▀▀▀▄",
            "█ ███▄▀▄███ █",
            "█ █████████ █",
            " ▀▄▀█████▀▄▀",
            "   ▀▄▀█▀▄▀",
            "     ▀▄▀"
    };
    internal static string[] Heart2 = new string[]
    {
            " ▄▀▀▀▄ ▄▀▀▀▄",
            "█  ▄▄ ▀ ▄▄  █",
            "█  ███▄███  █",
            " ▀▄ ▀███▀ ▄▀",
            "   ▀▄ ▀ ▄▀",
            "     ▀▄▀"
    };
    internal static string[] Heart3 = new string[]
    {
            " ▄▀▀▀▄ ▄▀▀▀▄",
            "█     ▀     █",
            "█   █▄ ▄█   █",
            " ▀▄  ▀█▀  ▄▀",
            "   ▀▄   ▄▀",
            "     ▀▄▀"
    };
    internal static string[] Heart4 = new string[]
    {
            " ▄▀▀▀▄ ▄▀▀▀▄",
            "█     ▀     █",
            "█    ▄ ▄    █",
            " ▀▄   ▀   ▄▀",
            "   ▀▄   ▄▀",
            "     ▀▄▀"
    };

    /// <summary>
    /// Takes the result and puts it in a box that the Draw() function can use.
    /// </summary>
    /// <param name="result">The result.</param>
    /// <returns>A box with the result in it.</returns>
    internal static string[] PercentBox(int result)
    {
        return new string[]
        {
             "┌─┴─┐",
            $"│{result}{AddChars(result.ToString(),3,' ')}│",
             "└───┘"
        };
    }

    /// <summary>
    /// Takes a name and an age string and puts it in a box that the Draw() function can use.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="age">The age.</param>
    /// <returns>A box with a name and an age.</returns>
    internal static string[] InputBox(string name, string age)
    {
        return new string[]
        {
            "┌──────────────────────────────────┐",
           $"│ Name: {name}{AddChars(name, 27,' ')}│",
           $"│ Age(yyy/mm/dd: {age}{AddChars(age, 18,' ')}│",
            "└──────────────────────────────────┘"
        };
    }

    /// <summary>
    /// Adds a string with the amount of chars needed to reach a "wall" in the graphic box.
    /// This is so that the boxes will stay the same size regardless of what length the names are.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="length">The length.</param>
    /// <returns>Returns a string consisting of the number of chars needed to reach the length given.</returns>
    private static string AddChars(string text, int length, char symbol)
    {
        int amount = length - text.Length;
        string chars = "";
        for (int i = 0; i < amount; i++)
        {
            chars += symbol;
        }
        return chars;
    }
}
