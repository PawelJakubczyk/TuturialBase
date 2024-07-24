### Value Types (Typy wartoœci)

Value types store data directly. They are allocated on the stack (stos) and contain the actual data value. Examples of value types include:

1. **numeric types (Typy numeryczne)**:
    - `byte`: 8-bit integer (0 to 255)
    - `sbyte`: 8-bit signed integer (-128 to 127)
    - `short`: 16-bit signed integer (-32,768 to 32,767)
    - `ushort`: 16-bit integer (0 to 65,535)
    - `int`: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
    - `uint`: 32-bit integer (0 to 4,294,967,295)
    - `long`: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
    - `ulong`: 64-bit integer (0 to 18,446,744,073,709,551,615)

2. **Floating-point types (Typy zmiennoprzecinkowe)**:
    - `float`: 32-bit floating-point number
    - `double`: 64-bit floating-point number
    - `decimal`: 128-bit high-precision floating-point number, mainly used in financial applications

3. **Boolean types (Typy logiczne)**:
    - `bool`: Logical type that can be true or false

4. **Character types (Typy znakowe)**:
    - `char`: 16-bit type storing a single Unicode character

5. **Structures (Struktury)**:
    - `struct`: User-defined type that can contain various other value and reference types

6. **Enumeration types (Typy wyliczeniowe)**:
    - `enum`: Special value type defined by a set of named constants

### Reference Types (Typy referencji)

Reference types store references to the actual data rather than the data itself. They are allocated on the heap (stercie). Examples of reference types include:

1. **Classes (Klasy)**:
    - `class`: Type defining an object containing data (fields) and functions (methods)

2. **Interfaces (Interfejsy)**:
    - `interface`: Type defining a contract that classes or structures can implement

3. **Arrays (Tablice)**:
    - `Array`: Type that stores a collection of elements of the same type

4. **String type (Typ string)**:
    - `string`: Type that stores a sequence of Unicode characters

5. **Object type (Typ object)**:
    - `object`: Base type for all types in C#

6. **Delegates (Delegaty)**:
    - `delegate`: Type representing a method and can hold references to one or multiple methods

7. **User-defined types (Typy zdefiniowane przez u¿ytkownika)**:
    - `class`, `interface`, `delegate`, and other user-defined reference types

```csharp
// Value types

int liczbaCalkowita = 42;             
double liczbaZmiennoprzecinkowa = 3.14; 
char znak = 'A';                      
bool logiczny = true;      

// Reference types

string tekst = "Hello, World!";       
object obiekt = new object();         
int[] tablica = {1, 2, 3, 4, 5};      

public class Osoba                   
{
    public string Imie { get; set; }
    public int Wiek { get; set; }
}
```

11. **Structure (Struktura)**:
    - **Definition (Definicja)**: A structure is a value type used to group related data together. Structures are similar to classes but differ in that they are stored on the stack rather than the heap.
    - **Example (Przyk³ad)**:

    ```csharp
    public struct Punkt
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    ```

12. **Enum (Wyliczenie)**:
    - **Definition (Definicja)**: An enum is a special data type representing a set of named constant values.
    - **Example (Przyk³ad)**:

    ```csharp
    public enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }
    ```

16. **Nullable types (Typy Nullable)**:
    - **Definition (Definicja)**: Nullable types allow storing null values in value types (e.g., `int`, `bool`).
    - **Example (Przyk³ad)**:

    ```csharp
    int? liczba = null;
    if (liczba.HasValue)
    {
        Console.WriteLine(liczba.Value);
    }
    else
    {
        Console.WriteLine("Brak wartoœci");
    }
    ```

20. **Tuple (Krotka)**:
    - **Definition (Definicja)**: A tuple is a data structure that can hold multiple elements of different types.
    - **Example (Przyk³ad)**:

    ```csharp
    var krotka = (1, "jeden", true);
    Console.WriteLine(krotka.Item1); // Output: 1
    Console.WriteLine(krotka.Item2); // Output: jeden
    Console.WriteLine(krotka.Item3); // Output: True
    ```
