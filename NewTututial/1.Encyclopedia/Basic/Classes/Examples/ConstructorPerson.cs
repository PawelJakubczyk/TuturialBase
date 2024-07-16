namespace Classes.ConstructorPerson;

public class ConstructorPerson
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    private ConstructorPerson(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    private ConstructorPerson()
    {
        FirstName = "Gall";
        LastName = "Anonymous";
        Age = 1000;
    }

    public static ConstructorPerson CreatePerson(string firstName, string lastName, int age)
    {
        return new ConstructorPerson(firstName, lastName, age);
    }

    public static ConstructorPerson CreatePerson()
    {
        return new ConstructorPerson();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
    }
}
