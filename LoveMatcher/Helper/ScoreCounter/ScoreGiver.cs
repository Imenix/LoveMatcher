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
        Comparing.CompareName cn = new();
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
        public int LengthName_Score(Person person1, Person person2)
        {
            var totalLength = cn.LengthName(person1.Name)+ cn.LengthName(person2.Name);
            if (totalLength < 11)
            {
                return totalScore.AddToTotal(5);
            }
            else if (totalLength < 15)
            {
               return totalScore.AddToTotal(10);
            }
            else if (totalLength < 20)
            {
                return totalScore.AddToTotal(15);
            }
            else
            {
                return totalScore.AddToTotal(0);
            }
        }
        public int LengthIsEven_Score(Person person1, Person person2)
        {
            var isEven1 = (cn.LengthIsEven(person1.Name));
            var isEven2 = (cn.LengthIsEven(person2.Name));

            if (isEven1 && isEven2)
            {
                return totalScore.AddToTotal(10);
            }
            else if ((!isEven1 && isEven2) || (!isEven2 || isEven1))
            {
                return totalScore.AddToTotal(5);
            }
            else { return 0; };
        }
        public int NumberOfVowels_Score(Person person1, Person person2)
        {
            var count = cn.NumberOfVowels(person1.Name);
            count += cn.NumberOfVowels(person2.Name);

            if(count >= 10)
            {
                return totalScore.AddToTotal(10);
            }else if (count >= 5)
            {
                return totalScore.AddToTotal(5);
            }else { return 0; };

            return 0;
        }
        public int NumberOfConsonants_Score(Person person1, Person person2)
        {
            var count = cn.NumberOfConsonants(person1.Name);
            count += cn.NumberOfConsonants(person2.Name);

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
        public int NumberOfSameLetters_Score(Person person1, Person person2)
        {
            var counter = cn.NumberOfSameLetters(person1.Name, person2.Name);

            if(counter >= 5)
            {
                return totalScore.AddToTotal(10);
            }else if (counter >= 3)
            {
                return totalScore.AddToTotal(5);
            }
            else { return 0; };
            
        }

    }
}
