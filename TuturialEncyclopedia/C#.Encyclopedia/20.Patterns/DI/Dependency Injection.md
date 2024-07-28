11. **Dependency Injection (DI)**:
    - **Definicja**: Dependency Injection to wzorzec projektowy, który polega na przekazywaniu zale¿noœci do klasy z zewn¹trz zamiast tworzenia ich wewn¹trz klasy. U³atwia testowanie i zwiêksza modularnoœæ kodu.
    - **Przyk³ad**:
      ```csharp
      public interface ILogger
      {
          void Log(string message);
      }

      public class ConsoleLogger : ILogger
      {
          public void Log(string message)
          {
              Console.WriteLine(message);
          }
      }

      public class Serwis
      {
          private readonly ILogger _logger;

          public Serwis(ILogger logger)
          {
              _logger = logger;
          }

          public void WykonajOperacje()
          {
              _logger.Log("Operacja zosta³a wykonana");
          }
      }

      public class Program
      {
          public static void Main()
          {
              ILogger logger = new ConsoleLogger();
              Serwis serwis = new Serwis(logger);
              serwis.WykonajOperacje();
          }
      }
      ```