9. **Namespace (Nazwa przestrzeni)**:
   - **Definicja**: Namespace to spos�b organizowania kodu w C#. Umo�liwia grupowanie klas, interfejs�w i innych typ�w w logiczne jednostki.
   - **Przyk�ad**:
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
    - **Definicja**: Alias przestrzeni nazw umo�liwia nadanie kr�tszej lub bardziej zrozumia�ej nazwy dla d�ugiej przestrzeni nazw.
    - **Przyk�ad**:
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
    - **Definicja**: LINQ to zestaw technologii w .NET umo�liwiaj�cy wykonywanie zapyta� do r�nych �r�de� danych (np. bazy danych, kolekcje) w spos�b podobny do SQL.
    - **Przyk�ad**:
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

13. **Lambda (Wyra�enie lambda)**:
    - **Definicja**: Lambda to anonimowa funkcja, kt�ra mo�e by� u�ywana do tworzenia delegat�w lub wyra�e� drzewiastych.
    - **Przyk�ad**:
      ```csharp
      Func<int, int, int> dodaj = (a, b) => a + b;
      Console.WriteLine(dodaj(5, 3)); // Output: 8
      ```

14. **Try-Catch (Obs�uga wyj�tk�w)**:
    - **Definicja**: Try-Catch to mechanizm obs�ugi wyj�tk�w, kt�ry pozwala na przechwytywanie i obs�ug� b��d�w podczas wykonywania programu.
    - **Przyk�ad**:
      ```csharp
      try
      {
          int dzielnik = 0;
          int wynik = 10 / dzielnik;
      }
      catch (DivideByZeroException ex)
      {
          Console.WriteLine("Nie mo�na dzieli� przez zero!");
      }
      ```

15. **Asynchroniczno�� (Asynchronous Programming)**:
    - **Definicja**: Programowanie asynchroniczne pozwala na wykonywanie operacji w tle, co umo�liwia aplikacji reagowanie na zdarzenia bez blokowania g��wnego w�tku.
    - **Przyk�ad**:
      ```csharp
      public async Task PobierzDaneAsync()
      {
          HttpClient klient = new HttpClient();
          string dane = await klient.GetStringAsync("https://example.com");
          Console.WriteLine(dane);
      }
      ```



22. **Async/Await**:
    - **Definicja**: S�owa kluczowe `async` i `await` umo�liwiaj� wykonywanie operacji asynchronicznych w �atwy spos�b. `async` oznacza, �e metoda jest asynchroniczna, a `await` wskazuje, �e program powinien czeka� na zako�czenie operacji asynchronicznej przed kontynuowaniem.
    - **Przyk�ad**:
      ```csharp
      public async Task PrzykladAsync()
      {
          await Task.Delay(1000);
          Console.WriteLine("Min�a 1 sekunda");
      }
      ```

23. **Garbage Collection (GC)**:
    - **Definicja**: Garbage Collection to automatyczny proces zarz�dzania pami�ci�, kt�ry usuwa nieu�ywane obiekty z pami�ci, aby zwolni� zasoby.
    - **Przyk�ad**:
      ```csharp
      // Wywo�anie garbage collection
      GC.Collect();
      ```

24. **Yield**:
    - **Definicja**: S�owo kluczowe `yield` umo�liwia iterowanie przez elementy sekwencji bez konieczno�ci tworzenia pe�nej kolekcji w pami�ci.
    - **Przyk�ad**:
      ```csharp
      public IEnumerable<int> GenerujLiczby()
      {
          yield return 1;
          yield return 2;
          yield return 3;
      }
      ```
