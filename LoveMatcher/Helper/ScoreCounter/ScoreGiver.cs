using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    public class ScoreGiver
    {
        CompareAge compare = new();
        Comparing.CompareName cn = new();
        TotalScore totalScore = new();

        /// <summary>
        /// Checks difference in age and gives or takes points accordingly
        /// </summary>
        /// <param name="age1">Age of the first person.</param>
        /// <param name="age2">Age of the second person.</param>
        /// <returns></returns>
        public int AgeDifference_Score(int age1, int age2)
        {
            var diff = compare.AgeDifference(age1,age2);

            return diff switch
            {
                0 => totalScore.AddToTotal(15),
                > 0 and < 10 => totalScore.AddToTotal(10),
                >= 10 and < 20 => totalScore.AddToTotal(5),
                _ => totalScore.SubstractFromTotal(5),
            };
        }

        /// <summary>
        /// Determines whether both persons' age is at least 18 and gives points accordingly.
        /// </summary>
        /// <param name="person1">The first person.</param>
        /// <param name="person2">The second person.</param>
        /// <returns></returns>
        public int IsOver17_Score(int age1, int age2)
        {
            var oldEnough1 = compare.IsOver17(age1);
            var oldEnough2 = compare.IsOver17(age2);
            return GiveScore(oldEnough1, oldEnough2);
        }

        /// <summary>
        /// Determines whether both persons' age is even or odd and gives points accordingly.
        /// </summary>
        /// <param name="person1">The first person.</param>
        /// <param name="person2">The second person.</param>
        /// <returns></returns>
        public int AgeIsEvenNumber_Score(int age1, int age2)
        {
            var even1 = compare.AgeIsEvenNumber(age1);
            var even2 = compare.AgeIsEvenNumber(age2);
            return GiveScore(even1, even2);
        }

        /// <summary>
        /// Helpmethod for checking if both variables are true or false.
        /// </summary>
        /// <param name="age1">if set to <c>true</c> [age1].</param>
        /// <param name="age2">if set to <c>true</c> [age2].</param>
        /// <returns></returns>
        private int GiveScore(bool age1, bool age2)
        {
            if ((age1 && age2) || (!age1 && !age2))
            {
                return totalScore.AddToTotal(10);
            }
            else
            {
                return totalScore.SubstractFromTotal(5);
            }
        }

        /// <summary>
        /// Length the name score.
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
        /// <returns></returns>
        public int LengthNameDiffrence_Score(string person1, string person2)
        {
            var totalDiff = cn.LengthNameDiffrence(person1, person2);
            if (totalDiff > 7)
            {
                return totalScore.AddToTotal(15);
            }
            else if (totalDiff > 3)
            {
               return totalScore.AddToTotal(10);
            }
            else if (totalDiff > 1)
            {
                return totalScore.AddToTotal(5);
            }
            else
            {
                return totalScore.AddToTotal(0);
            }
        }
        /// <summary>
        /// Lengthes the is even score.
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
        /// <returns></returns>
        public int LengthIsEven_Score(string person1, string person2)
        {
            var isEven1 = cn.LengthIsEven(person1);
            var isEven2 = cn.LengthIsEven(person2);

            if (isEven1 && isEven2)
            {
                return totalScore.AddToTotal(10);
            }
            else if ((!isEven1 && isEven2) || (!isEven2 && isEven1))
            {
                return totalScore.AddToTotal(5);
            }
            else return totalScore.AddToTotal(0);
        }
        /// <summary>
        /// Numbers the of vowels score.
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
        /// <returns></returns>
        public int NumberOfVowels_Score(string person1, string person2)
        {
            var count = cn.NumberOfVowels(person1);
            count += cn.NumberOfVowels(person2);

            if(count >= 10)
            {
                return totalScore.AddToTotal(10);
            }else if (count >= 5)
            {
                return totalScore.AddToTotal(5);
            }
            else { return totalScore.SubstractFromTotal(5); };

        }
        /// <summary>
        /// Numbers the of consonants score.
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
        /// <returns></returns>
        public int NumberOfConsonants_Score(string person1, string person2)
        {
            var count = cn.NumberOfConsonants(person1);
            count += cn.NumberOfConsonants(person2);

            if (count >= 10)
            {
                return totalScore.AddToTotal(10);
            }
            else if (count >= 5)
            {
                return totalScore.AddToTotal(5);
            }
            else
            {
               return totalScore.SubstractFromTotal(5);
            };

        }
        /// <summary>
        /// Numbers the of same letters score.
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
        /// <returns></returns>
        public int NumberOfSameLetters_Score(string person1, string person2)
        {
            var counter = cn.NumberOfSameLetters(person1, person2);

            if(counter >= 5)
            {
                return totalScore.AddToTotal(10);
            }else if (counter >= 3)
            {
                return totalScore.AddToTotal(5);
            }
            else { return totalScore.SubstractFromTotal(5); };
        }

        public void CompareMonthScore(int diff)
        {
            if (diff <= 4) totalScore.AddToTotal(10);
            else if (diff > 4 && diff <= 8) totalScore.AddToTotal(0);
            else totalScore.SubstractFromTotal(5);
        }
        public void CompareDayScore(int diff)
        {
            if (diff <= 10) totalScore.AddToTotal(10);
            else if (diff > 10 && diff <= 20) totalScore.AddToTotal(0);
            else totalScore.SubstractFromTotal(5);
        }
        public void MonthEvenNumberScore(bool person1, bool person2)
        {
            if ((person1 && person2) || (!person1 && !person2)) totalScore.AddToTotal(10);
            else totalScore.SubstractFromTotal(5);
        }
        public void DayEvenNumberScore(bool person1, bool person2)
        {
            if ((person1 && person2) || (!person1 && !person2)) totalScore.AddToTotal(10);
            else totalScore.SubstractFromTotal(5);
        }
        public void GetZodiacSignScore(string zodiac1, string zodiac2)
        {
            GetZodiacElement(zodiac1);
            GetZodiacElement(zodiac2);
            if ((zodiac1 == "Fire" && zodiac2 == "Air") || (zodiac2 == "Fire" && zodiac1 == "Air")) totalScore.AddToTotal(10);
            else if ((zodiac1 == "Water" && zodiac2 == "Earth") || (zodiac2 == "Earth" && zodiac1 == "Water")) totalScore.AddToTotal(10);
            else totalScore.SubstractFromTotal(0);

        }
        private void GetZodiacElement(string element)
        {
            if (element == "Aries" || element == "Leo" || element == "Saggitarius") element = "Fire";
            else if (element == "Taurus" || element == "Virgo" || element == "Capricorn") element = "Earth";
            else if (element == "Gemini" || element == "Libra" || element == "Aquarius") element = "Air";
            else element = "Water";
        }
    }
}
