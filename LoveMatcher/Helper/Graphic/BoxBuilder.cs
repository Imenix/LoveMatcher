namespace LoveMatcher
{
    static class Box
    {
        public static void ThinBorder(string[] rows, int left = 0, int top = 0)
        {
            string longestRow = rows.OrderByDescending(s => s.Length).First();

            Console.SetCursorPosition(left, top);
            Console.Write("┌");
            for (int i = 0; i < longestRow.Length; i++)
            {
                Console.Write("─");
            }
            Console.WriteLine("──┐");
            top++;

            foreach (var line in rows)
            {
                Console.SetCursorPosition(left, top);
                Console.Write($"│ {line}");
                int spaces = longestRow.Length - line.Length;
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" │");
                top++;
            }

            Console.SetCursorPosition(left, top);
            Console.Write("└");
            for (int i = 0; i < longestRow.Length; i++)
            {
                Console.Write("─");
            }
            Console.WriteLine("──┘");
        }
    }
}