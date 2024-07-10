### Typy wartoœci (Value Types)

Typy wartoœci przechowuj¹ dane bezpoœrednio. S¹ one alokowane na stosie (stack) i zawieraj¹ rzeczywist¹ wartoœæ danych. Przyk³ady typów wartoœci to:

1. **Typy liczb ca³kowitych**:
    - `byte`: 8-bitowa liczba ca³kowita (0 do 255)
    - `sbyte`: 8-bitowa liczba ca³kowita ze znakiem (-128 do 127)
    - `short`: 16-bitowa liczba ca³kowita ze znakiem (-32,768 do 32,767)
    - `ushort`: 16-bitowa liczba ca³kowita (0 do 65,535)
    - `int`: 32-bitowa liczba ca³kowita ze znakiem (-2,147,483,648 do 2,147,483,647)
    - `uint`: 32-bitowa liczba ca³kowita (0 do 4,294,967,295)
    - `long`: 64-bitowa liczba ca³kowita ze znakiem (-9,223,372,036,854,775,808 do 9,223,372,036,854,775,807)
    - `ulong`: 64-bitowa liczba ca³kowita (0 do 18,446,744,073,709,551,615)

2. **Typy zmiennoprzecinkowe**:
    - `float`: 32-bitowa liczba zmiennoprzecinkowa
    - `double`: 64-bitowa liczba zmiennoprzecinkowa

3. **Typ `decimal`**:
    - `decimal`: 128-bitowa liczba zmiennoprzecinkowa o wysokiej precyzji, u¿ywana g³ównie w aplikacjach finansowych

4. **Typy logiczne**:
    - `bool`: Typ logiczny, który mo¿e przyjmowaæ wartoœæ `true` lub `false`

5. **Typy znakowe**:
    - `char`: 16-bitowy typ przechowuj¹cy pojedynczy znak Unicode

6. **Struktury**:
    - `struct`: Typ u¿ytkownika, który mo¿e zawieraæ ró¿ne inne typy wartoœci i referencji

7. **Typ wyliczeniowy**:
    - `enum`: Typ wyliczeniowy, który jest specjalnym typem wartoœci, zdefiniowanym przez zestaw nazwanych sta³ych

### Typy referencji (Reference Types)

Typy referencji przechowuj¹ odniesienia do rzeczywistych danych, a nie same dane. S¹ one alokowane na stercie (heap). Przyk³ady typów referencji to:

1. **Klasy**:
    - `class`: Typ definiuj¹cy obiekt zawieraj¹cy dane (pola) i funkcje (metody)

2. **Interfejsy**:
    - `interface`: Typ definiuj¹cy kontrakt, który klasy lub struktury mog¹ implementowaæ

3. **Tablice**:
    - `Array`: Typ, który przechowuje kolekcjê elementów tego samego typu

4. **Typ `string`**:
    - `string`: Typ przechowuj¹cy sekwencjê znaków Unicode

5. **Typ `object`**:
    - `object`: Typ bazowy dla wszystkich typów w C#

6. **Delegaty**:
    - `delegate`: Typ, który reprezentuje metodê i mo¿e przechowywaæ odwo³ania do jednej lub wielu metod

7. **Typy zdefiniowane przez u¿ytkownika**:
    - `class`, `interface`, `delegate` i inne zdefiniowane przez u¿ytkownika typy referencji



```csharp
// typy wartoœci

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
    - **Definicja**: Struktura to typ wartoœciowy, który jest u¿ywany do grupowania powi¹zanych ze sob¹ danych. Struktury s¹ podobne do klas, ale maj¹ kilka ró¿nic, w tym to, ¿e s¹ przechowywane na stosie, a nie na stercie.
    - **Przyk³ad**:
      ```csharp
      public struct Punkt
      {
          public int X { get; set; }
          public int Y { get; set; }
      }
      ```

12. **Enum (Wyliczenie)**:
    - **Definicja**: Enum to specjalny typ danych reprezentuj¹cy zestaw sta³ych (niemodyfikowalnych) wartoœci.
    - **Przyk³ad**:
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
    - **Definicja**: Typy Nullable pozwalaj¹ na przechowywanie wartoœci null w typach wartoœciowych (np. int, bool).
    - **Przyk³ad**:
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
    - **Definicja**: Krotka to struktura danych, która mo¿e przechowywaæ wiele elementów o ró¿nych typach.
    - **Przyk³ad**:
      ```csharp
      var krotka = (1, "jeden", true);
      Console.WriteLine(krotka.Item1); // Output: 1
      Console.WriteLine(krotka.Item2); // Output: jeden
      Console.WriteLine(krotka.Item3); // Output: True
      ```
