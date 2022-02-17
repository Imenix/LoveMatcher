namespace LoveMatcher.Helper.Graphic
{
    internal static class Assets
    {
        internal static string[] Heart = new string[]
        {
            " ▄▀▀▀▄ ▄▀▀▀▄",
            "█ ███▄▀▄███ █",
            "█ █████████ █",
            " ▀▄▀█████▀▄▀",
            "   ▀▄▀█▀▄▀",
            "     ▀▄▀"
        };

        internal static string[] InputBox(string name, string age)
        {
            return new string[]
            {
            "┌──────────────────────────────────┐",
           $"│ Name: {name}{SpaceAdjusted(name, 27)}│",
           $"│ Age(yyy/mm/dd: {age}{SpaceAdjusted(age, 18)}│",
            "└──────────────────────────────────┘"
            };
        }
        /// <summary>
        /// Adds a string with the amount of spaces needed to reach a "wall" in the graphic box.
        /// This is so that the box will stay the same size regardless of what length the names are.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="length">The length.</param>
        /// <returns>Returns a string consisting of the number of " " needed to reach the length given.</returns>
        private static string SpaceAdjusted(string text, int length) //For helping with boxbuilding
        {
            int amount = length - text.Length;
            string spaces = "";
            for (int i = 0; i < amount; i++)
            {
                spaces += " ";
            }
            return spaces;
        }
    }
}
