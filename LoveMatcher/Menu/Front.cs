public class Front
{
	public static void MainMenuText()
    {
        Box.Simple(new string[]
        {"Choose an option",
         "[1]  Start comparing",
         "[2]  Exit",
        });
    }

    public static void CompareMenuText_StageOne()
    {
        Box.Simple(new string[]
        {"Name:",
         "Age(yyyy/mm/dd):",
         "[btn] Return"
        });
    }

    public void ResultMenuText()
    {

    }
}