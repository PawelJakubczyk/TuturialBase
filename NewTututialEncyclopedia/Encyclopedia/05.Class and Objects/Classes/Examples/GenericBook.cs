namespace Encyclopedia.ClassesExamples;

internal class GenericBook<T>
{
    public T? Value { get; set; }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

public class Pair<T>
{
    public T First { get; set; }
    public T Second { get; set; }

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public void Print()
    {
        Console.WriteLine($"First: {First}, Second: {Second}");
    }
}

//static void Booksss()
//{
//    // Użycie klasy generycznej z typem int
//    Pair<int> intPair = new Pair<int>(10, 20);
//    intPair.Print();

//    // Użycie klasy generycznej z typem string
//    Pair<string> stringPair = new Pair<string>("Hello", "World");
//    stringPair.Print();
//}

//// Użycie klasy generycznej z typem int
//Pair<int> intPair = new Pair<int>(10, 20);

//// Użycie klasy generycznej z typem string
//Pair<string> stringPair = new Pair<string>("Hello", "World");