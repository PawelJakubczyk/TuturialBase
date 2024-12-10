1. **Dziedziczenie (Inheritance)**:
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

2. **Interfejs (Interface)**:
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





3. **Delegat (Delegate)**:
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



4. **Indexer**:
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

5. **Extension Methods (Metody rozszerzeñ)**:
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

6. **Partial Class (Klasa czêœciowa)**:
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

7. **Generics (Typy generyczne)**:
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

8. **Polimorfizm (Polymorphism)**:
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

9. **Overloading (Przeci¹¿anie)**:
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


10. **Operator overloading (Przeci¹¿anie operatorów)**:
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








