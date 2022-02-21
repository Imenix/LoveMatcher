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
            var age1 = compare.IsOver17(person1.Age);
            var age2 = compare.IsOver17(person2.Age);
            
            if ((age1 && age2) || (!age1 && !age2))
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
        public int LengthNameScore(Person person1, Person person2)
        {
            return 0;
        }
        public int LengthIsEvenScore()
        {
            return 0;
        }
        public int NumberOfVowelsScore()
        {
            return 0;
        }
        public int NumberOfConsonantsScore()
        {
            return 0; 
        }
        public int NumberOfSameLettersScore()
        {
            return 0;
        }

    }
}
