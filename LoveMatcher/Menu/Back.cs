
public static class Back
{
    public static void MainMenu()
    {
        Front.MainMenuText();
        var choice = Console.ReadKey();
        Console.Clear();
        switch (choice.Key)
        {
            case ConsoleKey.D1:
                CompareMenu();
                break;

            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;

            default:
                MainMenu();
                break;
        }
    }

    private static void CompareMenu()
    {
        string name1 = "";
        string age1 = "";
        string name2 = "";
        string age2 = "";
        int result = 1;

        MenuGraphics.CompareMenuGraphics();
        name1 = Console.ReadLine();
        Console.Clear();

        MenuGraphics.CompareMenuGraphics(name1);
        age1 = Console.ReadLine();
        Console.Clear();

        MenuGraphics.CompareMenuGraphics(name1, age1);
        name2 = Console.ReadLine();
        Console.Clear();

        MenuGraphics.CompareMenuGraphics(name1, age1, name2);
        age2 = Console.ReadLine();
        Console.Clear();

        MenuGraphics.CompareMenuGraphics(name1, age1, name2, age2);
        MenuGraphics.FillBar(result, 50, 17, 9);
        MenuGraphics.HeartBasedOnResult(result);
        Console.ReadKey();
        Console.Clear();

        CompareAgainMenu();
    }

    public static void CompareAgainMenu()
    {
        Console.SetCursorPosition(0, 0);
        Front.CompareAgainText();
        var choice = Console.ReadKey();
        switch (choice.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                CompareMenu();
                break;

            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;

            default:
                CompareAgainMenu();
                break;
        }
    }
}