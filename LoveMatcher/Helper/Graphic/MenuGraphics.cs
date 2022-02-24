public static class MenuGraphics
{
    /// <summary>
    /// Draws the Compare menu. String defaults is "". Call method with each string user has inputed to draw it in the menu.
    /// </summary>
    /// <param name="name1">Name1.</param>
    /// <param name="age1">Age1.</param>
    /// <param name="name2">Name2.</param>
    /// <param name="age2">Age2.</param>
    public static void CompareMenuGraphics(string name1 = "", string age1 = "", string name2 = "", string age2 = "")
    {
        const int barLength = 50;
        const int leftPos = 17;
        const int topPos = 9;
        const int inputBoxHeight = 4;

        Box.ThinBorder(new string[] {"Write the first names and ages of the ones you want to compare"}, 10,0);

        Draw(Assets.InputBox(name1, age1), 0, inputBoxHeight);
        Draw(Assets.Heart, 37, 3, "Red");
        Draw(Assets.InputBox(name2, age2), 51, inputBoxHeight);
        DrawEmptyBar(barLength, leftPos, topPos);
        CursorStartPos(name1, age1, name2, age2);
    }

    /// <summary>
    /// Draws the specified string array subject. Decide starting point by specifying the cursor position, else position is 0,0
    /// </summary>
    /// <param name="subject">The subject.</param>
    /// <param name="leftPos">Cursor position left.</param>
    /// <param name="topPos">Cursor position top.</param>
    /// <param name="color">Color of subject.</param>
    private static void Draw( string[] subject, int leftPos=0, int topPos=0, string color = "White")
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

        for (int i = 0; i < subject.Length; i++)
        {
            Console.SetCursorPosition(leftPos, topPos + i); //+i makes it change row.
            Console.Write(subject[i]);
        }
        Console.ResetColor();
    }

    /// <summary>
    /// Fills the empty bar made by DrawEmptyBar(). Make sure barlength, left and top is the same as DrawEmptyBar().
    /// </summary>
    /// <param name="result">The amount to be filled.</param>
    /// <param name="barLength">Length of the bar.</param>
    /// <param name="left">Cursor position left.</param>
    /// <param name="top">Cursor position top.</param>
    public static void FillBar(int result, int barLength, int left = 0, int top = 0)
    {
        int speed = 10;
        int heartSprite = 1;
        (int l, int t) pos = (left+1,top+1);
        Console.SetCursorPosition(pos.l,pos.t); //so the filled bar begins inside the bar     

        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < barLength; i++)
            if (result / 2 > i) //While barLength is 50 and highest score is 100 the result has to be halved to be accurate
            {
                Console.SetCursorPosition(pos.l, pos.t);
                Thread.Sleep(speed);
                speed += 6;
                Console.Write("█");
                pos = Console.GetCursorPosition();
                heartSprite = AnimateHeart(heartSprite);
                Console.ForegroundColor = ConsoleColor.Red;
            }
        Console.ResetColor();
        //Console.SetCursorPosition(pos.l-1, pos.t+2);
        Draw(Assets.PercentBox(result), pos.l - 3, pos.t + 2);
    }

    /// <summary>
    /// For use in FillBar(). Animates the heart at the same time the bar fills.
    /// </summary>
    /// <param name="heartSprite">Decides what Heart sprite should be drawn.</param>
    /// <returns></returns>
    private static int AnimateHeart(int heartSprite)
    {
        int[] pos = { 37, 3 };
        switch (heartSprite)
        {
            case 1:
                Draw(Assets.Heart, pos[0], pos[1], "Red");
                return 2;
            case 2:
                Draw(Assets.Heart2, pos[0], pos[1],"DarkRed");
                return 3;
            case 3:
                Draw(Assets.Heart3, pos[0], pos[1],"DarkMagenta");
                return 4;
            case 4:
                Draw(Assets.Heart4, pos[0], pos[1],"Magenta");
                return 5;
            case 5:
                Draw(Assets.Heart3, pos[0], pos[1],"DarkMagenta");
                return 6;
            case 6:
                Draw(Assets.Heart2, pos[0], pos[1],"DarkRed");
                return 1;
            default: Draw(Assets.Heart, pos[0], pos[1], "Red");
                break;
        }
        return heartSprite;
    }

    /// <summary>
    /// Draws a heart based on the result. The higher the score the more filled the heart is.
    /// </summary>
    /// <param name="result">The result.</param>
    public static void HeartBasedOnResult(int result)
    {
        int[] pos = { 37, 3 };
        if (result is < 25 and > 0)
        {
            Draw(Assets.Heart4, pos[0], pos[1], "DarkRed");
        }
        else if (result is < 50 and >=25)
        {
            Draw(Assets.Heart3, pos[0], pos[1], "DarkMagenta");
        }
        else if (result is < 75 and >=50)
        {
            Draw(Assets.Heart2, pos[0], pos[1], "Magenta");
        }
        else if (result is >= 75)
        {
            Draw(Assets.Heart, pos[0], pos[1], "Red");
        }
    }

    /// <summary>
    /// Draw an empty progress bar. Default position (0,0).
    /// </summary>
    /// <param name="BarLength">Length of the bar.</param>
    /// <param name="left">Cursor position left.</param>
    /// <param name="top">Cursor position top.</param>
    private static void DrawEmptyBar(int BarLength, int left=0, int top=0)
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
    /// I.e. if Name1 is filled out then user has to input Age1, so the cursor will start next to Age1.
    /// </summary>
    /// <param name="name1">Name1.</param>
    /// <param name="age1">Age1.</param>
    /// <param name="name2">Name2.</param>
    /// <param name="age2">Age2.</param>
    private static void CursorStartPos(string name1 = "", string age1 = "", string name2 = "", string age2 = "")
    {
        if (name1?.Length == 0) Console.SetCursorPosition(8, 5);
        else if (age1?.Length == 0) Console.SetCursorPosition(19, 6);
        else if (name2?.Length == 0) Console.SetCursorPosition(59, 5);
        else if (age2?.Length == 0) Console.SetCursorPosition(70, 6);
    }
}
