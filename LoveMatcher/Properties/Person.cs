// ålder(datum), namn, kanske kön. favorit färg??
using System;

public class Person
{
    /// <summary> Name of person </summary>
    /// <value> The name. </value>
    public string Name { get; set; }
    /// <summary> Persons birthday </summary>
    /// <value> The birthday. </value>
    public DateTime Birthday { get; set; }
    /// <summary> Persons age </summary>
    /// <value> The age. </value>
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = DateTime.Now.Year - Birthday.Year ;
        }
    }
    private int age;
    /// <summary> Persons gender </summary>
    /// <value> The gender </value>
    public string Gender { get; set; }
}