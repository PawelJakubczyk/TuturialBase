
**Asynchronicznoœæ (Asynchronous Programming)**:
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

**Async/Await**:
    - **Definicja**: S³owa kluczowe `async` i `await` umo¿liwiaj¹ wykonywanie operacji asynchronicznych w ³atwy sposób. `async` oznacza, ¿e metoda jest asynchroniczna, a `await` wskazuje, ¿e program powinien czekaæ na zakoñczenie operacji asynchronicznej przed kontynuowaniem.
    - **Przyk³ad**:
      
      ```csharp
      public async Task PrzykladAsync()
      {
          await Task.Delay(1000);
          Console.WriteLine("Minê³a 1 sekunda");
      }
      ```
