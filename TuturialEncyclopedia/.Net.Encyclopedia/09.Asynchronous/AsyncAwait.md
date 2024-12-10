
**Asynchroniczno�� (Asynchronous Programming)**:
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

**Async/Await**:
    - **Definicja**: S�owa kluczowe `async` i `await` umo�liwiaj� wykonywanie operacji asynchronicznych w �atwy spos�b. `async` oznacza, �e metoda jest asynchroniczna, a `await` wskazuje, �e program powinien czeka� na zako�czenie operacji asynchronicznej przed kontynuowaniem.
    - **Przyk�ad**:
      
      ```csharp
      public async Task PrzykladAsync()
      {
          await Task.Delay(1000);
          Console.WriteLine("Min�a 1 sekunda");
      }
      ```
