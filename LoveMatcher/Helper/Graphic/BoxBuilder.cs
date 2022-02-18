using System;
static class Box
{
    public static void ThinBorder(string[] rows)
    {
        string longestRow = rows.OrderByDescending(s => s.Length).First();

        Console.Write("┌");
        for (int i = 0; i < longestRow.Length; i++)
        {
            Console.Write("─");
        }
        Console.WriteLine("──┐");


        foreach (var line in rows)
        {
            Console.Write($"│ {line}");
            int spaces = longestRow.Length - line.Length;
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" │");
        }

        Console.Write("└");
        for (int i = 0; i < longestRow.Length; i++)
        {
            Console.Write("─");
        }
        Console.WriteLine("──┘");
    }
}