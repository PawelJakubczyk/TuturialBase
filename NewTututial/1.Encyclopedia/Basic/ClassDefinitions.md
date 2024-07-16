1. **Klasa (Class)**:
   - **Definicja**: Klasa w C# to definicja obiektu zawieraj�ca w�a�ciwo�ci, metody i wydarzenia. Klasa jest schematem, na podstawie kt�rego tworzone s� obiekty.
   - **Przyk�ad**:
     ```csharp
     public class Samochod
     {
         public string Marka { get; set; }
         public int RokProdukcji { get; set; }

         public void Uruchom()
         {
             Console.WriteLine("Samoch�d uruchomiony");
         }
     }
     ```

2. **Obiekt (Object)**:
   - **Definicja**: Obiekt to instancja klasy. Obiekty s� tworzone na podstawie definicji klasy i mog� mie� w�asne warto�ci w�a�ciwo�ci.
   - **Przyk�ad**:
     ```csharp
     Samochod mojSamochod = new Samochod();
     mojSamochod.Marka = "Toyota";
     mojSamochod.RokProdukcji = 2020;
     mojSamochod.Uruchom();
     ```

3. **Dziedziczenie (Inheritance)**:
   - **Definicja**: Dziedziczenie pozwala jednej klasie (klasie pochodnej) dziedziczy� w�a�ciwo�ci i metody innej klasy (klasy bazowej).
   - **Przyk�ad**:
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
   - **Definicja**: Interfejs definiuje zbi�r metod i w�a�ciwo�ci, kt�re klasa musi implementowa�. Interfejsy zapewniaj� spos�b na wdro�enie wielokrotnego dziedziczenia w C#.
   - **Przyk�ad**:
     ```csharp
     public interface IPojazd
     {
         void Uruchom();
     }

     public class Samochod : IPojazd
     {
         public void Uruchom()
         {
             Console.WriteLine("Samoch�d uruchomiony");
         }
     }
     ```

5. **Metoda (Method)**:
   - **Definicja**: Metoda to funkcja zdefiniowana w klasie, kt�ra wykonuje pewne operacje na danych.
   - **Przyk�ad**:
     ```csharp
     public class Kalkulator
     {
         public int Dodaj(int a, int b)
         {
             return a + b;
         }
     }
     ```

6. **W�a�ciwo�� (Property)**:
   - **Definicja**: W�a�ciwo�� to mechanizm dost�pu do prywatnych p�l klasy, umo�liwiaj�cy odczyt i zapis warto�ci.
   - **Przyk�ad**:
     ```csharp
     public class Osoba
     {
         public string Imie { get; set; }
         public int Wiek { get; set; }
     }
     ```

7. **Delegat (Delegate)**:
   - **Definicja**: Delegat to typ reprezentuj�cy metod� z okre�lonym podpisem. Delegaty s� u�ywane do definiowania metod wywo�ania zwrotnego (callback).
   - **Przyk�ad**:
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
   - **Definicja**: Zdarzenie jest mechanizmem umo�liwiaj�cym powiadamianie subskrybent�w (obiekt�w) o pewnych zdarzeniach.
   - **Przyk�ad**:
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
    - **Definicja**: Indexer umo�liwia dost�p do element�w obiektu za pomoc� indeks�w, podobnie jak w przypadku tablic.
    - **Przyk�ad**:
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

18. **Extension Methods (Metody rozszerze�)**:
    - **Definicja**: Metody rozszerze� pozwalaj� na dodawanie nowych metod do istniej�cych typ�w bez modyfikowania ich definicji.
    - **Przyk�ad**:
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

19. **Partial Class (Klasa cz�ciowa)**:
    - **Definicja**: Partial Class umo�liwia podzia� definicji klasy na wiele plik�w. Ka�da cz�� musi by� oznaczona s�owem kluczowym `partial`.
    - **Przyk�ad**:
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
    - **Definicja**: Typy og�lne umo�liwiaj� tworzenie klas, metod i interfejs�w, kt�re mog� dzia�a� na r�nych typach danych, zapewniaj�c jednocze�nie typowanie statyczne.
    - **Przyk�ad**:
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
    - **Definicja**: Polimorfizm to zdolno�� obiekt�w do przyjmowania r�nych form. W C# mo�na go osi�gn�� poprzez dziedziczenie i implementacj� interfejs�w.
    - **Przyk�ad**:
      ```csharp
      public class Zwierze
      {
          public virtual void DajGlos()
          {
              Console.WriteLine("Zwierze wydaje d�wi�k");
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

27. **Overloading (Przeci��anie)**:
    - **Definicja**: Przeci��anie metod to zdolno�� do tworzenia wielu metod o tej samej nazwie, ale r�nych parametrach.
    - **Przyk�ad**:
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


29. **Operator overloading (Przeci��anie operator�w)**:
    - **Definicja**: Przeci��anie operator�w pozwala definiowa� w�asne zachowanie dla operator�w (np. +, -, *, /) w przypadku typ�w zdefiniowanych przez u�ytkownika.
    - **Przyk�ad**:
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

Te poj�cia i definicje dotycz� zaawansowanych koncepcji i mechanizm�w w j�zyku C#, kt�re s� kluczowe do g��bszego zrozumienia i tworzenia bardziej zaawansowanych aplikacji.







