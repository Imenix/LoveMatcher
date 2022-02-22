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
            var ofAge1 = compare.IsOver17(age1);
            var ofAge2 = compare.IsOver17(age2);
            return GiveScore(ofAge1, ofAge2);
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
    }
}
