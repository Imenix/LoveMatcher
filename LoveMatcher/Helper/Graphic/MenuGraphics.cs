public static class MenuGraphics
{
    /// <summary>
    /// Writes pretty boxes with names and ages depending on string(s) values.
    /// </summary>
    /// <param name="n1">Name1.</param>
    /// <param name="a1">Age1.</param>
    /// <param name="n2">Name2.</param>
    /// <param name="a2">Age2.</param>
    public static void CompareMenuGraphics(string n1 = "", string a1 = "", string n2 = "", string a2 = "")
    {
        Console.Clear();
        Console.WriteLine(@$"                                      ▄▀▀▀▄ ▄▀▀▀▄                                      ");
        Console.WriteLine(@$"┌──────────────────────────────────┐ █ ███▄▀▄███ █ ┌──────────────────────────────────┐");
        Console.WriteLine(@$"│ Name: {n1}{AddSpace(n1, 27)}│  ▀▄▀█████▀▄▀  │ Name: {n2}{AddSpace(n2, 27)}│");
        Console.WriteLine(@$"│ Age(yyy/mm/dd: {a1}{AddSpace(a1, 18)}│    ▀▄▀█▀▄▀    │ Age(yyy/mm/dd: {a2}{AddSpace(a2, 18)}│");
        Console.WriteLine(@$"└──────────────────────────────────┘      ▀▄▀      └──────────────────────────────────┘");
        CursorStartPos(n1, a1, n2, a2);
        InputCheck.CheckCursorPosition();
    }
    /// <summary>
    /// Sets the cursors start position to where the user will input.
    /// I.e. if Name1 is filled out then user has to input Age1, so the cursor will start next to Age.
    /// </summary>
    /// <param name="n1">Name1.</param>
    /// <param name="a1">Age1.</param>
    /// <param name="n2">Name2.</param>
    /// <param name="a2">Age2.</param>
    private static void CursorStartPos(string n1 = "", string a1 = "", string n2 = "", string a2 = "")
    {
        if (n1?.Length == 0) Console.SetCursorPosition(8, 2);
        else if (a1?.Length == 0) Console.SetCursorPosition(17, 3);
        else if (n2?.Length == 0) Console.SetCursorPosition(58, 2);
        else if (a2?.Length == 0) Console.SetCursorPosition(67, 3);
    }
    /// <summary>
    /// Adds a string with the amount of spaces needed to reach a "wall" in the graphic box.
    /// This is so that the box will stay the same size regardless of what length the names are.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="length">The length.</param>
    /// <returns>Returns a string consisting of the number of " " needed to reach the length given.</returns>
    private static string AddSpace(string text, int length) //For helping with boxbuilding
    {
        int amount = length - text.Length;
        string spaces = "";
        for (int i = 0; i < amount; i++)
        {
            spaces += " ";
        }
        return spaces;
    }
}
