




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
