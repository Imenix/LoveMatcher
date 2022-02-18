using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMatcher.Helper.ScoreCounter
{
    internal class ScoreGiver
    {
        CompareAge compare = new();
        TotalScore totalScore = new();
        public int AgeDifference_Score()
        {
            return 0;
        }

        public void IsOver17_Score(Person person1, Person person2)
        {
            var Age1 = compare.IsOver17(person1.Age);
            var Age2 = compare.IsOver17(person2.Age);
            
            if ((Age1 && Age2) || (!Age1 && !Age2))
            {
                totalScore.AddToTotal(10);
            }
            else
            {
                totalScore.SubstractFromTotal(5);
            }
        }

        public int AgeIsEvenNumber_Score()
        {
            return 0;
        }
    }
}
