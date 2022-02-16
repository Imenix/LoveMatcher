namespace LoveMatcher.Helper.Comparing
{
    public class CompareName
    {
        //skillnad p� l�ngd
        /// <summary>
        /// Calculates the difference between lenght of the names
        /// </summary>
        public int LengthName(string name)
        {
            var nameLength = name.Length;
            return nameLength;
        }

        //�r l�ngderna udda eller j�mna
        /// <summary>
        /// Checks if lenght of the name is even or not
        /// </summary>
        /// <returns></returns>
        public object LengthIsEven(string name)
        {
            var nameLength = name.Length;
            if (nameLength % 2 == 0) return true;
            else return false;
        }

        //skillnad i m�ngd vokaler
        /// <summary>
        /// Checks the number of vocals in the name.
        /// </summary>
        /// <returns></returns>
        public int NumberOfVocals()
        {
            return 0;
        }

        //skillnad i m�ngd konsonanter
        /// <summary>
        /// Checks the number of consonants in the name.
        /// </summary>
        public int NumberOfConsonants()
        {
            return 0;
        }

        //Skillnad i m�ngd dubbla bokst�ver
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