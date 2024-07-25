namespace Encyclopedia.MethodsExamples;

//Metoda Equals(): Pozwala porównać dwa obiekty pod kątem równości.Wartość zwracana to true,
//jeśli obiekty są równe, lub false, jeśli nie1.

//Metoda GetHashCode(): Zwraca unikalny kod skrótu dla obiektu. Jest używana w kolekcjach,
//takich jak słowniki czy zbiory, do efektywnego wyszukiwania1.

//Metoda ToString(): Zwraca reprezentację tekstową obiektu. Domyślnie wyświetla nazwę typu
//i adres obiektu, ale można ją przesłonić, aby dostosować wyjście1.

//Metoda GetType(): Zwraca informacje o typie obiektu. Pozwala na uzyskanie obiektu klasy
//Type, który zawiera informacje o nazwie typu, przestrzeni nazw, metodach, polach i innych
//właściwościach.

internal class EachObjectMethodExamples
{
    public static void Main(string[] args)
    {
        // Tworzenie obiektu do testów
        object testObject1 = new TestClassEachObjectMethod { Name = "Object1", Value = 42 };
        object testObject2 = new TestClassEachObjectMethod { Name = "Object1", Value = 42 };
        object testObject3 = testObject1;

        // Przykład użycia Equals()
        Console.WriteLine("Equals() examples:");
        Console.WriteLine(testObject1.Equals(testObject2));
        Console.WriteLine(testObject1.Equals(testObject3));

        // Przykład użycia GetHashCode()
        Console.WriteLine("\nGetHashCode() examples:");
        Console.WriteLine(testObject1.GetHashCode());
        Console.WriteLine(testObject2.GetHashCode());
        Console.WriteLine(testObject3.GetHashCode());

        // Przykład użycia ToString()
        Console.WriteLine("\nToString() examples:");
        Console.WriteLine(testObject1.ToString());
        Console.WriteLine(testObject2.ToString());
        Console.WriteLine(testObject3.ToString());

        // Przykład użycia GetType()
        Console.WriteLine("\nGetType() examples:");
        Console.WriteLine(testObject1.GetType());
        Console.WriteLine(testObject2.GetType());
        Console.WriteLine(testObject3.GetType());
    }
}

internal class TestClassEachObjectMethod
{
    public string Name { get; set; }
    public int Value { get; set; }

    public override string ToString()
    {
        return $"TestClass: {Name}, Value: {Value}";
    }

    public override bool Equals(object obj)
    {
        if (obj is TestClassEachObjectMethod other)
        {
            return Name == other.Name && Value == other.Value;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Value);
    }
}
