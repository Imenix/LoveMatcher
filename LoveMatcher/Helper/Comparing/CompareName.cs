namespace LoveMatcher.Helper.Comparing
{
    public class CompareName
    {
        //skillnad på längd
        /// <summary>
        /// Calculates the difference between lenght of the names
        /// </summary>
        public int LengthName(string name) // Ändra till skillnaden i längd
        {
            var nameLength = name.Length;
            return nameLength; 
        }

        //är längderna udda eller jämna
        /// <summary>
        /// Checks if lenght of the name is even or not
        /// </summary>
        /// <returns></returns>
        public bool LengthIsEven(string name)
        {
            var nameLength = name.Length;
            if (nameLength % 2 == 0) return true;
            else return false;
        }

        //skillnad i mängd vokaler
        /// <summary>
        /// Checks the number of vowels in the name.
        /// </summary>
        /// <returns>The amount of vowels.</returns>
        public int NumberOfVowels(string name)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u','å','ä','ö' };
            int vowelSum = name.ToLower().Count(c => vowels.Contains(c));
            return vowelSum;
        }

        //skillnad i mängd konsonanter
        /// <summary>
        /// Checks the number of consonants in the name.
        /// </summary>
        /// <returns>The amount of consonants.</returns>
        public int NumberOfConsonants(string name)
        {
            var consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};
            int consonantSum = name.ToLower().Count(c => consonants.Contains(c));
            return consonantSum;
        }

        //Skillnad i mängd dubbla bokstäver
        /// <summary>
        /// Checks how many same letters the names have.
        /// </summary>
        /// <returns></returns>
        public int NumberOfSameLetters(string nameA, string nameB)
        {
            var point = 0;

            char[] charArray = nameA.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                bool check = nameB.Contains(charArray[i]);
                if (check)
                {
                    point++;
                }
            }
            //Contains
            return point;
        }
    }
}