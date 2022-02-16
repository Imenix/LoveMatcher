//skillnad i månad
//är båda månaderna jämna eller udda dagar
//skillnad i dag
//är båda dagarna jämna eller udda dagar
//vilket stjärntecken/element
public class CompareBirthday
{
    int[] evenDays = new int[] { 2, 4, 6, 8, 10, 12 };
    public static int CompareMonth(DateTime date1, DateTime date2)
    {
        if (date1.Month < date2.Month) return date2.Month - date1.Month;
        else return date1.Month - date2.Month;
    }
    public static int CompareDay(DateTime date1, DateTime date2)
    {
        if (date1.Day < date2.Day) return date2.Day - date1.Day;
        else return date1.Day - date2.Day;
    }
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
    public string ZodiacSign(DateTime date)
    {
        return date.Month switch
        {
            1 => "Capricorn",
            2 => "Aquarius",
            3 => "Pisces",
            4 => "Aries",
            5 => "Taurus",
            6 => "Gemini",
            7 => "Cancer",
            8 => "Leo",
            9 => "Virgo",
            10 => "Libra",
            11 => "Scorpio",
            12 => "Sagittarius"
        };
    }
}