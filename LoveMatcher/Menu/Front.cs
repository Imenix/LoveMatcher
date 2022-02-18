public static class Front
{
    public static void MainMenuText()
    {
        Box.ThinBorder(new string[]
           {"Choose an option",
            "[1]  Start comparing",
            "[2]  Exit",
           });
    }

    public static void CompareMenuFront()
    {
        Box.ThinBorder(new string[]
        {"Write the first names and ages of the ones you want to compare"
        });
        MenuGraphics.CompareMenuGraphics();
    }

    }

    public static void ResultMenu()
    {

    }
}