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
