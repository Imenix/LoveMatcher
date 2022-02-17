
using LoveMatcher.Helper.Graphic;

public static class MenuGraphics
{
    /// <summary>
    /// Writes pretty boxes with names and ages depending on string(s) values.
    /// </summary>
    /// <param name="name1">Name1.</param>
    /// <param name="age1">Age1.</param>
    /// <param name="name2">Name2.</param>
    /// <param name="age2">Age2.</param>
    public static void CompareMenuGraphics(string name1 = "", string age1 = "", string name2 = "", string age2 = "")
    {
        Draw(Assets.InputBox(name1,age1), 0, 1);
        Draw(Assets.Heart, 37, 0);
        Draw(Assets.InputBox(name2, age2), 51, 1);
        CursorStartPos(name1, age1, name2, age2);
        InputCheck.CheckCursorPosition();
    }

    public static void Draw(string[] subject, int leftPos, int topPos)
    {
        for (int i = 0; i < subject.Length; i++)
        {
            Console.SetCursorPosition(leftPos, topPos + i);
            Console.Write(subject[i]);
        }
    }

    public static void ResultBar(int result)
    {
        const int barLength = 50;
        const int leftPos = 17;
        const int topPos = 6;
        DrawEmptyBar(barLength, leftPos, topPos);
        FillBar(result, barLength, leftPos, topPos);
    }

    private static void FillBar(int result, int BarLength, int left = 0, int top = 0)
    {
        int speed = 1;
        Console.SetCursorPosition(left + 1, top + 1); //so the filled bar begins inside the bar

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "Red");
        for (int i = 0; i < BarLength; i++)
        {
            if (result / 2 > i) //While barLength is 50 and highest score is 100 the result has to be halved to be accurate
            {
                Thread.Sleep(speed);
                speed += i;
                Console.Write("█");
            }
        }
        Console.ResetColor();
    }
    /// <summary>
    /// Draw an empty progress bar.
    /// </summary>
    /// <param name="BarLength">Length of the bar.</param>
    /// <param name="pos">Where the cursor starts writing (left, top).</param>
    private static void DrawEmptyBar(int BarLength, int left, int top)
    {
        Console.SetCursorPosition(left, top);
        for (int i = 0; i < BarLength + 2; i++)
        {
            Console.Write("▄");
        }
        Console.WriteLine();

        Console.SetCursorPosition(left, top + 1);

        Console.Write("█");
        for (int i = 0; i < BarLength; i++)
        {
            Console.Write("░");
        }
        Console.WriteLine("█");

        Console.SetCursorPosition(left, top + 2);
        for (int i = 0; i < BarLength + 2; i++)
        {
            Console.Write("▀");
        }
        Console.WriteLine();
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

    
}
