
public class Back
{
    public void MainMenu()
    {
        var choice = Console.ReadKey();
        switch(choice.Key)
        {
        case ConsoleKey.D1:
                Front.CompareMenuFront();
        break;

        case ConsoleKey.D2:
        break;
        }
    }
}