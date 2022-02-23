using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoveMatcher.Helper.ScoreCounter
{
    public class ScoreCounter
    {
        ScoreGiver add = new();

        /// <summary>
        /// Sums up all the scores to Total.
        /// </summary>
        /// <param name="person1">The first person.</param>
        /// <param name="person2">The second person.</param>
        public void GivePersonScore(Person person1, Person person2) //plussar ihop alla tre
        {
            var name1 = person1.Name;
            var bd1 = person1.Birthday;
            var age1 = person1.Age;

            var name2 = person2.Name;
            var bd2 = person2.Birthday;
            var age2 = person2.Age;

            NameScore(name1, name2);
            BirthdayScore(bd1, bd2);
            AgeScore(age1,age2);
        }

        /// <summary>
        /// Adds score from Name methods.
        /// </summary>
        /// <param name="name1">The name of the first person.</param>
        /// <param name="name2">The name of the second person.</param>
        public void NameScore(string name1, string name2)
        {
            //add.LengthNameScore();
            //add.LengthIsEven_Score();
            //add.NumberOfVowels_Score();
            //add.NumberOfConsonants_Score();
            //add.NumberOfSameLetters_Score();
        }

        /// <summary>
        /// Adds score from Birthday methods.
        /// </summary>
        /// <param name="bd1">The birthday of the first person.</param>
        /// <param name="bd2">The birthday of the second person.</param>
        public void BirthdayScore(DateTime bd1, DateTime bd2)
        {
            //add.CompareMonthScore();
            //add.CompareDayScore();
            //add.MonthEvenNumberScore();
            //add.DayEvenNumberScore();
            //add.GetZodiacSignScore();
        }

        /// <summary>
        /// Adds score from Age methods.
        /// </summary>
        /// <param name="age1">The age of the first person.</param>
        /// <param name="age2">The age of the second person.</param>
        public void AgeScore(int age1, int age2)
        {
            add.AgeDifference_Score(age1, age2);
            add.IsOver17_Score(age1, age2);
            add.AgeIsEvenNumber_Score(age1, age2);
        }
    }
}
