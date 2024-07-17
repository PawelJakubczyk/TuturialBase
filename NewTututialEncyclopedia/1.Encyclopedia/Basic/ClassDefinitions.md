1. **Klasa (Class)**:
   - **Definicja**: Klasa w C# to definicja obiektu zawieraj¹ca w³aœciwoœci, metody i wydarzenia. Klasa jest schematem, na podstawie którego tworzone s¹ obiekty.
   - **Przyk³ad**:
     ```csharp
     public class Samochod
     {
         public string Marka { get; set; }
         public int RokProdukcji { get; set; }

         public void Uruchom()
         {
             Console.WriteLine("Samochód uruchomiony");
         }
     }
     ```

2. **Obiekt (Object)**:
   - **Definicja**: Obiekt to instancja klasy. Obiekty s¹ tworzone na podstawie definicji klasy i mog¹ mieæ w³asne wartoœci w³aœciwoœci.
   - **Przyk³ad**:
     ```csharp
     Samochod mojSamochod = new Samochod();
     mojSamochod.Marka = "Toyota";
     mojSamochod.RokProdukcji = 2020;
     mojSamochod.Uruchom();
     ```

3. **Dziedziczenie (Inheritance)**:
   - **Definicja**: Dziedziczenie pozwala jednej klasie (klasie pochodnej) dziedziczyæ w³aœciwoœci i metody innej klasy (klasy bazowej).
   - **Przyk³ad**:
     ```csharp
     public class Pojazd
     {
         public int Predkosc { get; set; }
     }

     public class Samochod : Pojazd
     {
         public string Marka { get; set; }
     }
     ```

4. **Interfejs (Interface)**:
   - **Definicja**: Interfejs definiuje zbiór metod i w³aœciwoœci, które klasa musi implementowaæ. Interfejsy zapewniaj¹ sposób na wdro¿enie wielokrotnego dziedziczenia w C#.
   - **Przyk³ad**:
     ```csharp
     public interface IPojazd
     {
         void Uruchom();
     }

     public class Samochod : IPojazd
     {
         public void Uruchom()
         {
             Console.WriteLine("Samochód uruchomiony");
         }
     }
     ```

5. **Metoda (Method)**:
   - **Definicja**: Metoda to funkcja zdefiniowana w klasie, która wykonuje pewne operacje na danych.
   - **Przyk³ad**:
     ```csharp
     public class Kalkulator
     {
         public int Dodaj(int a, int b)
         {
             return a + b;
         }
     }
     ```

6. **W³aœciwoœæ (Property)**:
   - **Definicja**: W³aœciwoœæ to mechanizm dostêpu do prywatnych pól klasy, umo¿liwiaj¹cy odczyt i zapis wartoœci.
   - **Przyk³ad**:
     ```csharp
     public class Osoba
     {
         public string Imie { get; set; }
         public int Wiek { get; set; }
     }
     ```

7. **Delegat (Delegate)**:
   - **Definicja**: Delegat to typ reprezentuj¹cy metodê z okreœlonym podpisem. Delegaty s¹ u¿ywane do definiowania metod wywo³ania zwrotnego (callback).
   - **Przyk³ad**:
     ```csharp
     public delegate void PowitanieDelegate(string message);

     public class Program
     {
         public static void Main()
         {
             PowitanieDelegate powitanie = PowitanieMetoda;
             powitanie("Witaj w C#");
         }

         public static void PowitanieMetoda(string message)
         {
             Console.WriteLine(message);
         }
     }
     ```

8. **Zdarzenie (Event)**:
   - **Definicja**: Zdarzenie jest mechanizmem umo¿liwiaj¹cym powiadamianie subskrybentów (obiektów) o pewnych zdarzeniach.
   - **Przyk³ad**:
     ```csharp
     public class Program
     {
         public delegate void Powiadomienie();
         public event Powiadomienie OnPowiadomienie;

         public void WywolajZdarzenie()
         {
             if (OnPowiadomienie != null)
             {
                 OnPowiadomienie();
             }
         }
     }
     ```



17. **Indexer**:
    - **Definicja**: Indexer umo¿liwia dostêp do elementów obiektu za pomoc¹ indeksów, podobnie jak w przypadku tablic.
    - **Przyk³ad**:
      ```csharp
      public class Kolekcja
      {
          private int[] liczby = new int[10];

          public int this[int indeks]
          {
              get { return liczby[indeks]; }
              set { liczby[indeks] = value; }
          }
      }
      ```

18. **Extension Methods (Metody rozszerzeñ)**:
    - **Definicja**: Metody rozszerzeñ pozwalaj¹ na dodawanie nowych metod do istniej¹cych typów bez modyfikowania ich definicji.
    - **Przyk³ad**:
      ```csharp
      public static class MetodyRozszerzen
      {
          public static int Podwoj(this int liczba)
          {
              return liczba * 2;
          }
      }

      public class Program
      {
          public static void Main()
          {
              int liczba = 5;
              Console.WriteLine(liczba.Podwoj()); // Output: 10
          }
      }
      ```

19. **Partial Class (Klasa czêœciowa)**:
    - **Definicja**: Partial Class umo¿liwia podzia³ definicji klasy na wiele plików. Ka¿da czêœæ musi byæ oznaczona s³owem kluczowym `partial`.
    - **Przyk³ad**:
      ```csharp
      public partial class Osoba
      {
          public string Imie { get; set; }
      }

      public partial class Osoba
      {
          public string Nazwisko { get; set; }
      }
      ```



25. **Generics (Typy generyczne)**:
    - **Definicja**: Typy ogólne umo¿liwiaj¹ tworzenie klas, metod i interfejsów, które mog¹ dzia³aæ na ró¿nych typach danych, zapewniaj¹c jednoczeœnie typowanie statyczne.
    - **Przyk³ad**:
      ```csharp
      public class Pudelko<T>
      {
          public T Zawartosc { get; set; }
      }

      public class Program
      {
          public static void Main()
          {
              Pudelko<int> pudelkoInt = new Pudelko<int>();
              pudelkoInt.Zawartosc = 42;

              Pudelko<string> pudelkoString = new Pudelko<string>();
              pudelkoString.Zawartosc = "Hello, world!";
          }
      }
      ```

26. **Polimorfizm (Polymorphism)**:
    - **Definicja**: Polimorfizm to zdolnoœæ obiektów do przyjmowania ró¿nych form. W C# mo¿na go osi¹gn¹æ poprzez dziedziczenie i implementacjê interfejsów.
    - **Przyk³ad**:
      ```csharp
      public class Zwierze
      {
          public virtual void DajGlos()
          {
              Console.WriteLine("Zwierze wydaje dŸwiêk");
          }
      }

      public class Pies : Zwierze
      {
          public override void DajGlos()
          {
              Console.WriteLine("Pies szczeka");
          }
      }

      public class Program
      {
          public static void Main()
          {
              Zwierze mojeZwierze = new Pies();
              mojeZwierze.DajGlos(); // Output: Pies szczeka
          }
      }
      ```

27. **Overloading (Przeci¹¿anie)**:
    - **Definicja**: Przeci¹¿anie metod to zdolnoœæ do tworzenia wielu metod o tej samej nazwie, ale ró¿nych parametrach.
    - **Przyk³ad**:
      ```csharp
      public class Kalkulator
      {
          public int Dodaj(int a, int b)
          {
              return a + b;
          }

          public double Dodaj(double a, double b)
          {
              return a + b;
          }
      }
      ```


29. **Operator overloading (Przeci¹¿anie operatorów)**:
    - **Definicja**: Przeci¹¿anie operatorów pozwala definiowaæ w³asne zachowanie dla operatorów (np. +, -, *, /) w przypadku typów zdefiniowanych przez u¿ytkownika.
    - **Przyk³ad**:
      ```csharp
      public class Punkt
      {
          public int X { get; set; }
          public int Y { get; set; }

          public static Punkt operator +(Punkt a, Punkt b)
          {
              return new Punkt { X = a.X + b.X, Y = a.Y + b.Y };
          }
      }
      ```

30. **Dependency Injection (DI)**:
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

Te pojêcia i definicje dotycz¹ zaawansowanych koncepcji i mechanizmów w jêzyku C#, które s¹ kluczowe do g³êbszego zrozumienia i tworzenia bardziej zaawansowanych aplikacji.







