namespace Encyclopedia.DelegatsExamples;

public static class ActionsExample
{
    public static void SayHello(Action<string> greetingCallback, PersonAction person)
    {
        greetingCallback($"Hello! {person.FirstName}!");
    }

    public static void SendEmail(string recipient, PersonAction person, Action<string> emailCallback)
    {
        emailCallback("Hello, " + person.FirstName + " " + person.LastName + "! How are you?");
    }

    public static void CelebrateBirthday(PersonAction person)
    {
        Console.WriteLine("Happy birthday, " + person.FirstName + "!");
        new Action(() =>
        {
            Console.WriteLine($"We're celebrating your {person.Age} birthday");
        }).Invoke();
    }
}

public class PersonAction
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public DateTime Birthdate { get; set; }

    public PersonAction(string firstName, string lastName, int age, string address, DateTime birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
        Birthdate = birthdate;
    }
}