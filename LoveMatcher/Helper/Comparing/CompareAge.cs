
public class CompareAge
{
    /// <summary>
    /// Calculates the age gap.
    /// </summary>
    /// <param name="age1">Age of the first person.</param>
    /// <param name="age2">Age of the second person.</param>
    /// <returns></returns>
    public int AgeDifference(int age1, int age2)
    {
        return age1 < age2 ? age2 - age1 :age1 - age2;
    }

    /// <summary>
    /// Determines whether the person is at least 18 years old.
    /// </summary>
    /// <param name="age">The age of the person.</param>
    /// <returns>
    ///   <c>true</c> if the specified age is over 17; otherwise, <c>false</c>.
    /// </returns>
    public bool IsOver17(int age)
    {
        return age > 17;
    }

    //jämna eller ojämna nummer
    /// <summary>
    /// Determines whether the age is even or odd number.
    /// </summary>
    /// <param name="age">The age of the person.</param>
    /// <returns>
    ///   <c>true</c> if the age is even; otherwise, <c>false</c>.
    /// </returns>
    public bool AgeIsEvenNumber(int age)
    {
        return age % 2 == 0;
    }
}