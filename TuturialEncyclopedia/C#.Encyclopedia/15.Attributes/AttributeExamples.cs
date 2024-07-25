namespace Encyclopedia.AttribiutesExamples;

public class AttributeExamples : Attribute
{
    public string DisplayName { get; set; }

    public AttributeExamples(string displayName)
    {
        DisplayName = displayName;
    }
}

public class PersonAttribute
{
    [AttributeExamples("First Name")]
    public string FirstName { get; set; }

    [AttributeExamples("Last Name")]
    public string LastName { get; set; }

    [AttributeExamples("Age")]
    public int Age { get; set; }

    [AttributeExamples("Address")]
    public string Address { get; set; }

    [AttributeExamples("Birthdate")]
    public DateTime Birthdate { get; set; }

    public PersonAttribute(string firstName, string lastName, int age, string address, DateTime birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
        Birthdate = birthdate;
    }

    public override string ToString()
    {
        return $"Person: {FirstName} {LastName}, {Age} years old, living at {Address} born on {Birthdate}";
    }
}