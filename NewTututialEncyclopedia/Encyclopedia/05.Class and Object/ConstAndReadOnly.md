
| Właściwość                    | `const`                                                    | `readonly`                                                    |
|-------------------------------|------------------------------------------------------------|---------------------------------------------------------------|
| Czas inicjalizacji            | W czasie kompilacji                                        | W czasie inicjalizacji obiektu (konstruktor)                   |
| Zakres użycia                 | Pola statyczne (wspólne dla wszystkich instancji klasy)    | Pola instancji lub statyczne                                   |
| Modyfikacja po inicjalizacji  | Nie można zmienić po kompilacji                             | Można zmienić tylko w konstruktorze                            |
| Typ danych                    | Typy proste, `string`, `enum`                              | Dowolny typ danych                                             |
| Modyfikator dostępu           | Domyślnie `static`, jawnie określany                       | Domyślnie instancja, może być `static`                         |

### Przykłady

#### `const` Example
```csharp
public class Constants
{
    public const int MaxValue = 100;
    public const string Greeting = "Hello, world!";
}

// Usage
class Program
{
    static void Main()
    {
        Console.WriteLine(Constants.MaxValue);  // Outputs: 100
        Console.WriteLine(Constants.Greeting);  // Outputs: Hello, world!
    }
}
```

#### `readonly` Example
```csharp
public class Configuration
{
    public readonly int MaxItems;
    public static readonly string DefaultGreeting;

    // Instance readonly field can be initialized in constructor
    public Configuration(int maxItems)
    {
        MaxItems = maxItems;
    }

    // Static readonly field can be initialized in static constructor
    static Configuration()
    {
        DefaultGreeting = "Welcome!";
    }
}

// Usage
class Program
{
    static void Main()
    {
        var config = new Configuration(50);
        Console.WriteLine(config.MaxItems);         // Outputs: 50
        Console.WriteLine(Configuration.DefaultGreeting); // Outputs: Welcome!
    }
}
```

### Kluczowe różnice:
1. **Czas inicjalizacji**:
   - `const` jest inicjalizowane podczas kompilacji, co oznacza, że jego wartość musi być znana na etapie kompilacji.
   - `readonly` jest inicjalizowane podczas tworzenia instancji obiektu lub w konstruktorze statycznym, co daje większą elastyczność.

2. **Zakres użycia**:
   - `const` może być używane tylko dla pól statycznych i jest współdzielone przez wszystkie instancje klasy.
   - `readonly` może być używane zarówno dla pól instancji, jak i pól statycznych, co pozwala na różne wartości dla różnych instancji.

3. **Typ danych**:
   - `const` może być używane tylko dla typów prostych (`int`, `double`, `bool`, etc.), `string` i `enum`.
   - `readonly` może być używane dla dowolnych typów, w tym obiektów, struktur i klas.

4. **Modyfikacja po inicjalizacji**:
   - `const` nie może być zmieniane po jego zainicjalizowaniu.
   - `readonly` może być zainicjalizowane tylko w konstruktorze (dla pól instancji) lub w konstruktorze statycznym (dla pól statycznych), ale po tym momencie nie może być zmieniane.

### Podsumowanie
- Użyj `const` dla wartości, które są znane na etapie kompilacji i nie zmieniają się.
- Użyj `readonly` dla wartości, które są zainicjalizowane podczas tworzenia obiektu lub w konstruktorze, ale nie zmieniają się po inicjalizacji.
