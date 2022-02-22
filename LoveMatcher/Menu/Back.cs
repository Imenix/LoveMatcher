
public static class Back
{
    public static void MainMenu()
    {
        string name1 = "";
        string age1 = "";
        string name2 = "";
        string age2 = "";
        int result = 1;

        Front.MainMenuText();
        var choice = Console.ReadKey();
        Console.Clear();
        switch (choice.Key)
        {
            case ConsoleKey.D1:
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
                Console.ReadLine();
                break;

            case ConsoleKey.D2:
                Environment.Exit(0);
                break;
            default:
                MainMenu();
                break;
        }
    }
}