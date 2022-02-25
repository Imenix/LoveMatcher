namespace LoveMatcher
{
    public static class Back
    {
        public static void MainMenu()
        {
            Assets.MainMenuText();
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
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }

        private static void CompareMenu()
        {
            TotalScore.Total = 50;
            Person person1 = new();
            Person person2 = new();

            string name1;
            string age1;
            string name2;
            string age2;
            double result;
            double percent;
            double match;

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

            } while (!InputCheck.CheckDateTimeFormat(age1) || !InputCheck.CheckAge(age1));

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
            } while (!InputCheck.CheckDateTimeFormat(age2) || !InputCheck.CheckAge(age2));

            person2.Birthday = Converting.ToExactDateTime(age2);
            #endregion

            ScoreCounter sc = new();
            sc.GivePersonScore(person1, person2);// <-- här ska allt slängas in o jämföras.

            result = TotalScore.Total; // resultatet får värdet efter alla tester
            percent = result / 180;
            match = percent * 100;
            double match2 = (double)Math.Round(match, 0);

            Console.Clear();
            MenuGraphics.CompareMenuGraphics(name1, age1, name2, age2);
            MenuGraphics.FillBar(match2, 50, 17, 9);
            MenuGraphics.HeartBasedOnResult(match2);
            Console.ReadKey();
            Console.Clear();

            CompareAgainMenu();
        }

        public static void CompareAgainMenu()
        {
            Console.SetCursorPosition(0, 0);
            Assets.CompareAgainText();
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
}