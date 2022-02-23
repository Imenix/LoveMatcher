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
        Person person1 = new();
        Person person2 = new();

        string name1;
        string age1;
        string name2;
        string age2;
        int result;

        #region Person1
        do
        {
            MenuGraphics.CompareMenuGraphics();
            name1 = Console.ReadLine();
        } while (!InputCheck.CheckLetters(name1));

        person1.Name = Converting.ToCleanName(name1);

        do
        {
            Console.Clear();
            MenuGraphics.CompareMenuGraphics(name1);
            age1 = Console.ReadLine();
        } while (!InputCheck.CheckDateTimeFormat(age1) && InputCheck.CheckAge(age1));

        person1.Birthday = Converting.ToExactDateTime(age1);
        #endregion

        #region Person2
        do
        {
            Console.Clear();
            MenuGraphics.CompareMenuGraphics(name1, age1);
            name2 = Console.ReadLine();
        } while (!InputCheck.CheckLetters(name2));

        person2.Name = Converting.ToCleanName(name2);

        do
        {
            Console.Clear();
            MenuGraphics.CompareMenuGraphics(name1, age1, name2);
            age2 = Console.ReadLine();
        } while (!InputCheck.CheckDateTimeFormat(age2) && InputCheck.CheckAge(age2));

        person2.Birthday = Converting.ToExactDateTime(age2);
        #endregion

        // <-- här ska allt slängas in o jämföras.

        result = 0; // resultatet får värdet efter alla tester
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