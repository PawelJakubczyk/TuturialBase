9. **Namespace (Nazwa przestrzeni)**:
   - **Definicja**: Namespace to sposób organizowania kodu w C#. Umo¿liwia grupowanie klas, interfejsów i innych typów w logiczne jednostki.
   - **Przyk³ad**:
     ```csharp
     namespace MojaAplikacja
     {
         public class Program
         {
             public static void Main()
             {
                 Console.WriteLine("Witaj w C#");
             }
         }
     }
     ```

   21. **Namespace alias**:
    - **Definicja**: Alias przestrzeni nazw umo¿liwia nadanie krótszej lub bardziej zrozumia³ej nazwy dla d³ugiej przestrzeni nazw.
    - **Przyk³ad**:
      ```csharp
      using kolAlias = System.Collections.Generic;

      public class Program
      {
          public static void Main()
          {
              kolAlias.List<int> liczby = new kolAlias.List<int>();
              liczby.Add(1);
              liczby.Add(2);
              Console.WriteLine(liczby.Count);
          }
      }
      ```



     10. **LINQ (Language Integrated Query)**:
    - **Definicja**: LINQ to zestaw technologii w .NET umo¿liwiaj¹cy wykonywanie zapytañ do ró¿nych Ÿróde³ danych (np. bazy danych, kolekcje) w sposób podobny do SQL.
    - **Przyk³ad**:
      ```csharp
      using System.Linq;

      public class Program
      {
          public static void Main()
          {
              int[] liczby = { 1, 2, 3, 4, 5 };
              var parzyste = from liczba in liczby
                             where liczba % 2 == 0
                             select liczba;

              foreach (var liczba in parzyste)
              {
                  Console.WriteLine(liczba);
              }
          }
      }
      ```

13. **Lambda (Wyra¿enie lambda)**:
    - **Definicja**: Lambda to anonimowa funkcja, która mo¿e byæ u¿ywana do tworzenia delegatów lub wyra¿eñ drzewiastych.
    - **Przyk³ad**:
      ```csharp
      Func<int, int, int> dodaj = (a, b) => a + b;
      Console.WriteLine(dodaj(5, 3)); // Output: 8
      ```

14. **Try-Catch (Obs³uga wyj¹tków)**:
    - **Definicja**: Try-Catch to mechanizm obs³ugi wyj¹tków, który pozwala na przechwytywanie i obs³ugê b³êdów podczas wykonywania programu.
    - **Przyk³ad**:
      ```csharp
      try
      {
          int dzielnik = 0;
          int wynik = 10 / dzielnik;
      }
      catch (DivideByZeroException ex)
      {
          Console.WriteLine("Nie mo¿na dzieliæ przez zero!");
      }
      ```

15. **Asynchronicznoœæ (Asynchronous Programming)**:
    - **Definicja**: Programowanie asynchroniczne pozwala na wykonywanie operacji w tle, co umo¿liwia aplikacji reagowanie na zdarzenia bez blokowania g³ównego w¹tku.
    - **Przyk³ad**:
      ```csharp
      public async Task PobierzDaneAsync()
      {
          HttpClient klient = new HttpClient();
          string dane = await klient.GetStringAsync("https://example.com");
          Console.WriteLine(dane);
      }
      ```



22. **Async/Await**:
    - **Definicja**: S³owa kluczowe `async` i `await` umo¿liwiaj¹ wykonywanie operacji asynchronicznych w ³atwy sposób. `async` oznacza, ¿e metoda jest asynchroniczna, a `await` wskazuje, ¿e program powinien czekaæ na zakoñczenie operacji asynchronicznej przed kontynuowaniem.
    - **Przyk³ad**:
      ```csharp
      public async Task PrzykladAsync()
      {
          await Task.Delay(1000);
          Console.WriteLine("Minê³a 1 sekunda");
      }
      ```

23. **Garbage Collection (GC)**:
    - **Definicja**: Garbage Collection to automatyczny proces zarz¹dzania pamiêci¹, który usuwa nieu¿ywane obiekty z pamiêci, aby zwolniæ zasoby.
    - **Przyk³ad**:
      ```csharp
      // Wywo³anie garbage collection
      GC.Collect();
      ```

24. **Yield**:
    - **Definicja**: S³owo kluczowe `yield` umo¿liwia iterowanie przez elementy sekwencji bez koniecznoœci tworzenia pe³nej kolekcji w pamiêci.
    - **Przyk³ad**:
      ```csharp
      public IEnumerable<int> GenerujLiczby()
      {
          yield return 1;
          yield return 2;
          yield return 3;
      }
      ```
