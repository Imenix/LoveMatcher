using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    internal class ScoreGiver
    {
        readonly CompareAge compare = new();
        TotalScore totalScore = new();
        public void AgeDifference_Score(Person person1, Person person2)
        {
            var diff = compare.AgeDifference(person1.Age, person2.Age);

            _ = diff switch
            {
                0 => totalScore.AddToTotal(15),
                > 0 and < 10 => totalScore.AddToTotal(10),
                >= 10 and < 20 => totalScore.AddToTotal(10),
                _ => totalScore.SubstractFromTotal(5),
            };

        }
        public void IsOver17_Score(Person person1, Person person2)
        {
            var age1 = compare.IsOver17(person1.Age);
            var age2 = compare.IsOver17(person2.Age);
            GiveScore(age1, age2);
        }

        public void AgeIsEvenNumber_Score(Person person1, Person person2)
        {
            var age1 = compare.AgeIsEvenNumber(person1.Age);
            var age2 = compare.AgeIsEvenNumber(person2.Age);
            GiveScore(age1, age2);
        }

        private void GiveScore(bool age1, bool age2)
        {
            if ((age1 && age2) || (!age1 && !age2))
            {
                totalScore.AddToTotal(10);
            }
            else
            {
                totalScore.SubstractFromTotal(5);
            }
        }
    }
}
