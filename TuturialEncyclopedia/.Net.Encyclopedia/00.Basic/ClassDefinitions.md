1. **Dziedziczenie (Inheritance)**:
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

2. **Interfejs (Interface)**:
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





3. **Delegat (Delegate)**:
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



4. **Indexer**:
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

5. **Extension Methods (Metody rozszerze�)**:
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

6. **Partial Class (Klasa cz�ciowa)**:
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

7. **Generics (Typy generyczne)**:
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

8. **Polimorfizm (Polymorphism)**:
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

9. **Overloading (Przeci��anie)**:
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


10. **Operator overloading (Przeci��anie operator�w)**:
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








