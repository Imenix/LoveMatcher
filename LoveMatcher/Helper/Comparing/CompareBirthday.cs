public class CompareBirthday
{
    /// <summary>
    /// Compares two months.
    /// </summary>
    /// <param name="date1">The date1.</param>
    /// <param name="date2">The date2.</param>
    /// <returns>Difference in months.</returns>
    public int CompareMonth(DateTime date1, DateTime date2) //borde heta MonthDifference kanske? Precis som AgeDifference
    {
        if (date1.Month < date2.Month) return date2.Month - date1.Month;
        else return date1.Month - date2.Month;
    }
    /// <summary>
    /// Compares two days.
    /// </summary>
    /// <param name="date1">The date1.</param>
    /// <param name="date2">The date2.</param>
    /// <returns>Difference in days.</returns>
    public int CompareDay(DateTime date1, DateTime date2) //borde heta DayDifference kanske? Precis som AgeDifference
    {
        if (date1.Day < date2.Day) return date2.Day - date1.Day;
        else return date1.Day - date2.Day;
    }
    /// <summary>
    /// Checks if month is an even number.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns>True if month is even.</returns>
    public bool MonthEvenNumber (DateTime date)
    {
        return date.Month switch
        {
            2 => true,
            4 => true,
            6 => true,
            8 => true,
            10 => true,
            12 => true,
            _ => false
        };
    }
    /// <summary>
    /// Checks if day is an even number.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns>True if day is even.</returns>
    public bool DayEvenNumber(DateTime date)
    {
        return date.Day switch
        {
            2 => true,
            4 => true,
            6 => true,
            8 => true,
            10 => true,
            12 => true,
            14 => true,
            16 => true,
            18 => true,
            20 => true,
            22 => true,
            24 => true,
            26 => true,
            28 => true,
            30 => true,
            _ => false
        };
    }
    /// <summary>
    /// Gets the zodiac sign of a person.
    /// </summary>
    /// <param name="person">The person.</param>
    /// <returns>The name of the sign.</returns>
    public string GetAstroSign(Person person)
    {
        int month = person.Birthday.Month;
        int day = person.Birthday.Day;

        if (IsInRange(month, day, 3, 21, 4, 19))
            return "Aries";
        else if (IsInRange(month, day, 4, 20, 5, 20))
            return "Taurus";
        else if (IsInRange(month, day, 5, 21, 6, 20))
            return "Gemini";
        else if (IsInRange(month, day, 6, 21, 7, 22))
            return "Cancer";
        else if (IsInRange(month, day, 7, 23, 8, 22))
            return "Leo";
        else if (IsInRange(month, day, 8, 23, 9, 22))
            return "Virgo";
        else if (IsInRange(month, day, 9, 23, 10, 22))
            return "Libra";
        else if (IsInRange(month, day, 10, 23, 11, 21))
            return "Scorpio";
        else if (IsInRange(month, day, 11, 22, 12, 21))
            return "Saggitarius";
        else if (IsInRange(month, day, 12, 22, 1, 19))
            return "Capricorn";
        else if (IsInRange(month, day, 1, 20, 2, 18))
            return "Aquarius";
        else if (IsInRange(month, day, 2, 19, 3, 20))
            return "Pisces";
        else
            return "Error in the stars";
    }

    private bool IsInRange(int month, int day, int startMonth, int startDay, int endMonth, int endDay)
    {
        var dateNum = (month * 32) + day;
        var startNum = (startMonth * 32) + startDay;
        var endNum = (endMonth * 32) + endDay;

        // CapricornFix, ends in januari so it needs to be added one more year
        if (startNum > endNum)
            endNum += 366;

        return (dateNum >= startNum && dateNum <= endNum);
    }
}