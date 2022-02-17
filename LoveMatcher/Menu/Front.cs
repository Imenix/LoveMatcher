public static class Front
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
        {"Write the first names and ages of the ones you want to compare"
        });
    }

    }

    public static void ResultMenu()
    {

    }
}