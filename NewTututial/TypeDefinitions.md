### Typy warto�ci (Value Types)

Typy warto�ci przechowuj� dane bezpo�rednio. S� one alokowane na stosie (stack) i zawieraj� rzeczywist� warto�� danych. Przyk�ady typ�w warto�ci to:

1. **Typy liczb ca�kowitych**:
    - `byte`: 8-bitowa liczba ca�kowita (0 do 255)
    - `sbyte`: 8-bitowa liczba ca�kowita ze znakiem (-128 do 127)
    - `short`: 16-bitowa liczba ca�kowita ze znakiem (-32,768 do 32,767)
    - `ushort`: 16-bitowa liczba ca�kowita (0 do 65,535)
    - `int`: 32-bitowa liczba ca�kowita ze znakiem (-2,147,483,648 do 2,147,483,647)
    - `uint`: 32-bitowa liczba ca�kowita (0 do 4,294,967,295)
    - `long`: 64-bitowa liczba ca�kowita ze znakiem (-9,223,372,036,854,775,808 do 9,223,372,036,854,775,807)
    - `ulong`: 64-bitowa liczba ca�kowita (0 do 18,446,744,073,709,551,615)

2. **Typy zmiennoprzecinkowe**:
    - `float`: 32-bitowa liczba zmiennoprzecinkowa
    - `double`: 64-bitowa liczba zmiennoprzecinkowa

3. **Typ `decimal`**:
    - `decimal`: 128-bitowa liczba zmiennoprzecinkowa o wysokiej precyzji, u�ywana g��wnie w aplikacjach finansowych

4. **Typy logiczne**:
    - `bool`: Typ logiczny, kt�ry mo�e przyjmowa� warto�� `true` lub `false`

5. **Typy znakowe**:
    - `char`: 16-bitowy typ przechowuj�cy pojedynczy znak Unicode

6. **Struktury**:
    - `struct`: Typ u�ytkownika, kt�ry mo�e zawiera� r�ne inne typy warto�ci i referencji

7. **Typ wyliczeniowy**:
    - `enum`: Typ wyliczeniowy, kt�ry jest specjalnym typem warto�ci, zdefiniowanym przez zestaw nazwanych sta�ych

### Typy referencji (Reference Types)

Typy referencji przechowuj� odniesienia do rzeczywistych danych, a nie same dane. S� one alokowane na stercie (heap). Przyk�ady typ�w referencji to:

1. **Klasy**:
    - `class`: Typ definiuj�cy obiekt zawieraj�cy dane (pola) i funkcje (metody)

2. **Interfejsy**:
    - `interface`: Typ definiuj�cy kontrakt, kt�ry klasy lub struktury mog� implementowa�

3. **Tablice**:
    - `Array`: Typ, kt�ry przechowuje kolekcj� element�w tego samego typu

4. **Typ `string`**:
    - `string`: Typ przechowuj�cy sekwencj� znak�w Unicode

5. **Typ `object`**:
    - `object`: Typ bazowy dla wszystkich typ�w w C#

6. **Delegaty**:
    - `delegate`: Typ, kt�ry reprezentuje metod� i mo�e przechowywa� odwo�ania do jednej lub wielu metod

7. **Typy zdefiniowane przez u�ytkownika**:
    - `class`, `interface`, `delegate` i inne zdefiniowane przez u�ytkownika typy referencji



```csharp
// typy warto�ci

int liczbaCalkowita = 42;             
double liczbaZmiennoprzecinkowa = 3.14; 
char znak = 'A';                      
bool logiczny = true;      

// typy referencji

string tekst = "Hello, World!";       
object obiekt = new object();         
int[] tablica = {1, 2, 3, 4, 5};      

public class Osoba                   
{
    public string Imie { get; set; }
    public int Wiek { get; set; }
}
```




11. **Struktura (Struct)**:
    - **Definicja**: Struktura to typ warto�ciowy, kt�ry jest u�ywany do grupowania powi�zanych ze sob� danych. Struktury s� podobne do klas, ale maj� kilka r�nic, w tym to, �e s� przechowywane na stosie, a nie na stercie.
    - **Przyk�ad**:
      ```csharp
      public struct Punkt
      {
          public int X { get; set; }
          public int Y { get; set; }
      }
      ```

12. **Enum (Wyliczenie)**:
    - **Definicja**: Enum to specjalny typ danych reprezentuj�cy zestaw sta�ych (niemodyfikowalnych) warto�ci.
    - **Przyk�ad**:
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




16. **Nullable (Typy Nullable)**:
    - **Definicja**: Typy Nullable pozwalaj� na przechowywanie warto�ci null w typach warto�ciowych (np. int, bool).
    - **Przyk�ad**:
      ```csharp
      int? liczba = null;
      if (liczba.HasValue)
      {
          Console.WriteLine(liczba.Value);
      }
      else
      {
          Console.WriteLine("Brak warto�ci");
      }
      ```



20. **Tuple (Krotka)**:
    - **Definicja**: Krotka to struktura danych, kt�ra mo�e przechowywa� wiele element�w o r�nych typach.
    - **Przyk�ad**:
      ```csharp
      var krotka = (1, "jeden", true);
      Console.WriteLine(krotka.Item1); // Output: 1
      Console.WriteLine(krotka.Item2); // Output: jeden
      Console.WriteLine(krotka.Item3); // Output: True
      ```
