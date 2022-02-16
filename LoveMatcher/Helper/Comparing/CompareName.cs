namespace LoveMatcher.Helper.Comparing
{
    public class CompareName
    {
        //skillnad på längd
        /// <summary>
        /// Calculates the difference between lenght of the names
        /// </summary>
        public int Length()
        {
            return 0;
        }

        //är längderna udda eller jämna        
        /// <summary>
        /// Checks if lenght of the name is even or not
        /// </summary>
        /// <returns></returns>
        public bool LenghtIsEven()
        {
            return true;
        }

        //skillnad i mängd vokaler        
        /// <summary>
        /// Checks the number of vowels in the name.
        /// </summary>
        /// <returns>The amount of vowels.</returns>
        public int NumberOfVowels(string name)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelSum = name.Count(c => vowels.Contains(c));
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
            int consonantSum = name.Count(c => consonants.Contains(c));
            return consonantSum;
        }

        //Skillnad i mängd dubbla bokstäver        
        /// <summary>
        /// Checks how many same letters the names have. 
        /// </summary>
        /// <returns></returns>
        public int NumberOfSameLetters()
        {
            return 0;
        }
    }
}