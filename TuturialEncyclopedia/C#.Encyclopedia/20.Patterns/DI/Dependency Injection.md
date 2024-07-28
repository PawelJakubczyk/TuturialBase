11. **Dependency Injection (DI)**:
    - **Definicja**: Dependency Injection to wzorzec projektowy, kt�ry polega na przekazywaniu zale�no�ci do klasy z zewn�trz zamiast tworzenia ich wewn�trz klasy. U�atwia testowanie i zwi�ksza modularno�� kodu.
    - **Przyk�ad**:
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
              _logger.Log("Operacja zosta�a wykonana");
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