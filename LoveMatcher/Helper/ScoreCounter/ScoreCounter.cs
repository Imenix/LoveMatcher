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
        /// Adds all the scores together to Total
        /// </summary>
        /// <param name="person1">The person1.</param>
        /// <param name="person2">The person2.</param>
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

        public void NameScore(string name1, string name2)
        {
            //add.LengthNameScore();
            //add.LengthIsEven_Score();
            //add.NumberOfVowels_Score();
            //add.NumberOfConsonants_Score();
            //add.NumberOfSameLetters_Score();
        }

        public void BirthdayScore(DateTime bd1, DateTime bd2)
        {

        }

        public void AgeScore(int age1, int age2)
        {
            add.AgeDifference_Score(age1, age2);
            add.IsOver17_Score(age1, age2);
            add.AgeIsEvenNumber_Score(age1, age2);
        }
    }
}
