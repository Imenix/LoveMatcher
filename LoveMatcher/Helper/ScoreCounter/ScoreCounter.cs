namespace LoveMatcher
{
    public class ScoreCounter
    {
        ScoreGiver add = new();

        /// <summary>
        /// Sums up all the scores to Total.
        /// </summary>
        /// <param name="person1">The first person.</param>
        /// <param name="person2">The second person.</param>
        public void GivePersonScore(Person person1, Person person2)
        {
            var name1 = person1.Name;
            var bd1 = person1.Birthday;
            var age1 = person1.Age;

            var name2 = person2.Name;
            var bd2 = person2.Birthday;
            var age2 = person2.Age;

            NameScore(name1, name2);
            BirthdayScore(bd1, bd2, person1, person2);
            AgeScore(age1,age2);
        }

        /// <summary>
        /// Adds score from Name methods.
        /// </summary>
        /// <param name="name1">The name of the first person.</param>
        /// <param name="name2">The name of the second person.</param>
        private void NameScore(string name1, string name2)
        {
            add.LengthNameDiffrence_Score(name1, name2);
            add.LengthIsEven_Score(name1, name2);
            add.NumberOfVowels_Score(name1, name2);
            add.NumberOfConsonants_Score(name1, name2);
            add.NumberOfSameLetters_Score(name1, name2);
        }

        /// <summary>
        /// Adds score from Birthday methods.
        /// </summary>
        /// <param name="bd1">The birthday of the first person.</param>
        /// <param name="bd2">The birthday of the second person.</param>
        private void BirthdayScore(DateTime bd1, DateTime bd2, Person person1, Person person2)
        {
            CompareBirthday comp = new();

            var monthDiff = comp.CompareMonth(bd1, bd2);
            var dayDiff = comp.CompareDay(bd1, bd2);
            bool monthEven1 = comp.MonthEvenNumber(bd1);
            bool monthEven2 = comp.DayEvenNumber(bd2);
            bool dayEven1 = comp.DayEvenNumber(bd1);
            bool dayEven2 = comp.DayEvenNumber(bd2);
            string zodiac1 = comp.GetAstroSign(person1);
            string zodiac2 = comp.GetAstroSign(person2);

            add.CompareMonthScore(monthDiff);
            add.CompareDayScore(dayDiff);
            add.MonthEvenNumberScore(monthEven1, monthEven2);
            add.DayEvenNumberScore(dayEven1, dayEven2);
            add.GetZodiacSignScore(zodiac1, zodiac2);
        }

        /// <summary>
        /// Adds score from Age methods.
        /// </summary>
        /// <param name="age1">The age of the first person.</param>
        /// <param name="age2">The age of the second person.</param>
        private void AgeScore(int age1, int age2)
        {
            add.AgeDifference_Score(age1, age2);
            add.IsOver17_Score(age1, age2);
            add.AgeIsEvenNumber_Score(age1, age2);
        }
    }
}
