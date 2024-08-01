namespace TuturialEncyclopedia.C_.Encyclopedia._05.Class_and_Objects.Classes_and_ClassMembers.ClassMembers._04.Methods.FactoryMethod;

public sealed class FactoryMethodExamples
{

}

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    // Prywatny konstruktor
    private Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Metoda fabryczna do tworzenia instancji
    public static Person Create(string name, int age)
    {
        // Możesz dodać dodatkową logikę walidacyjną lub inną logikę tutaj
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty", nameof(name));
        }
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative", nameof(age));
        }

        return new Person(name, age);
    }
}