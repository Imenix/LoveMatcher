namespace LoveMatcher
{
    public class CompareName
    {
        /// <summary>
        /// Calculates the difference between lenght of the names
        /// </summary>
        public int LengthNameDiffrence(string name1, string name2)
        {
            if (name1.Length > name2.Length) return name1.Length - name2.Length;
            else return name2.Length - name1.Length;
        }

        /// <summary>
        /// Checks if length of the name is even or not
        /// </summary>
        /// <returns>True if length is even</returns>
        public bool LengthIsEven(string name)
        {
            var nameLength = name.Length;
            return nameLength % 2 == 0;
        }

        /// <summary>
        /// Checks the amount of vowels in the name.
        /// </summary>
        /// <returns>The amount of vowels.</returns>
        public int NumberOfVowels(string name)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'å', 'ä', 'ö' };
            int vowelSum = name.ToLower().Count(c => vowels.Contains(c));
            return vowelSum;
        }

        /// <summary>
        /// Checks the amount of consonants in the name.
        /// </summary>
        /// <returns>The amount of consonants.</returns>
        public int NumberOfConsonants(string name)
        {
            var consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            int consonantSum = name.ToLower().Count(c => consonants.Contains(c));
            return consonantSum;
        }

        /// <summary>
        /// Checks how many of the same letters the names have.
        /// </summary>
        /// <returns>The amount of duplicate letters.</returns>
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
            return point;
        }
    }
}