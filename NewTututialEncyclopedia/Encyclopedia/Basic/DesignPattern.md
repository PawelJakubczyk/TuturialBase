




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
