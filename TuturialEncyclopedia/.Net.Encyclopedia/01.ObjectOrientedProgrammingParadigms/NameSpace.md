**Namespace (Nazwa przestrzeni)**:
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

**Namespace alias**:
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
