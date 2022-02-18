using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    public class ScoreGiver
    {
        readonly CompareAge compare = new();
        readonly TotalScore totalScore = new();
        public int AgeDifference_Score(Person person1, Person person2)
        {
            var diff = compare.AgeDifference(person1.Age, person2.Age);

            return diff switch
            {
                0 => totalScore.AddToTotal(15),
                > 0 and < 10 => totalScore.AddToTotal(10),
                >= 10 and < 20 => totalScore.AddToTotal(10),
                _ => totalScore.SubstractFromTotal(5),
            };
        }
        public int IsOver17_Score(Person person1, Person person2)
        {
            var age1 = compare.IsOver17(person1.Age);
            var age2 = compare.IsOver17(person2.Age);
            return GiveScore(age1, age2);
        }

        public int AgeIsEvenNumber_Score(Person person1, Person person2)
        {
            var age1 = compare.AgeIsEvenNumber(person1.Age);
            var age2 = compare.AgeIsEvenNumber(person2.Age);
            return GiveScore(age1, age2);
        }

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
