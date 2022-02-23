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
        
        public void PersonScore(Person person1, Person person2) //plussar ihop alla tre
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

        private void NameScore(string name1, string name2)
        {
            //add.LengthNameScore();
            add.LengthIsEvenScore();
            add.NumberOfVowelsScore();
            add.NumberOfConsonantsScore();
            add.NumberOfSameLettersScore();
        }

        private void BirthdayScore(DateTime bd1, DateTime bd2)
        {

        }

        private void AgeScore(int age1, int age2)
        {
            add.AgeDifference_Score(age1, age2);
            add.IsOver17_Score(age1, age2);
            add.AgeIsEvenNumber_Score(age1, age2);
        }
    }
}
