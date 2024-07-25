**Namespace (Nazwa przestrzeni)**:
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

**Namespace alias**:
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
