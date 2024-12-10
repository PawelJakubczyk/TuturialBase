1. **Klasa (Class)**:
   - **Definicja**: Klasa w C# to definicja obiektu zawieraj�ca w�a�ciwo�ci, metody, zdarzenia i innych cz�onk�w klasy. Klasa jest schematem, na podstawie kt�rego tworzone s� obiekty.
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

# Cz�onkowie Klasy(Class Members)

2. **Pole (Field)**:
   - **Definicja**: Pole to zmienna zadeklarowana na poziomie klasy. Mo�e to by� typ wbudowany (np. int) lub instancja innej klasy.
   - **Przyk�ad**:
     ```csharp
     public class Kalendarz
     {
         private DateTime aktualnaData;
     }
     ```

3. **Sta�a (Constant)**:
   - **Definicja**: Sta�a to pole, kt�rego warto�� jest ustalana w czasie kompilacji i nie mo�e by� zmieniona.
   - **Przyk�ad**:
     ```csharp
     public class Matematyka
     {
         public const double Pi = 3.14159;
     }
     ```

4. **W�a�ciwo�� (Property)**:
   - **Definicja**: W�a�ciwo�� to metody dost�pu do prywatnych p�l klasy, umo�liwiaj�ce odczyt i zapis warto�ci.
   - **Przyk�ad**:
     ```csharp
     public class Osoba
     {
         public string Imie { get; set; }
         public int Wiek { get; set; }
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

6. **Zdarzenie (Event)**:
   - **Definicja**: Zdarzenie jest mechanizmem umo�liwiaj�cym powiadamianie subskrybent�w (obiekt�w) o pewnych zdarzeniach.
   - **Przyk�ad**:
     ```csharp
     using System;

     public class Przycisk
     {
         public delegate void KlikniecieEventHandler(object sender, EventArgs e);
         public event KlikniecieEventHandler Klikniecie;

         protected virtual void OnKlikniecie()
         {
             if (Klikniecie != null)
             {
                 Klikniecie(this, EventArgs.Empty);
             }
         }

         public void Kliknij()
         {
             Console.WriteLine("Przycisk zosta� klikni�ty.");
             OnKlikniecie();
         }
     }

     public class Program
     {
         public static void Main(string[] args)
         {
             Przycisk przycisk = new Przycisk();
             przycisk.Klikniecie += Przycisk_Klikniecie;
             przycisk.Kliknij();
         }

         private static void Przycisk_Klikniecie(object sender, EventArgs e)
         {
             Console.WriteLine("Zdarzenie Klikniecie zosta�o obs�u�one.");
         }
     }
     ```

7. **Operator (Operator)**:
   - **Definicja**: Operator przeci��ony jest cz�onkiem typu. Przeci��enie operatora definiuje si� jako publiczn� statyczn� metod� w typie.
   - **Przyk�ad**:
     ```csharp
     public class Liczba
     {
         public int Wartosc { get; set; }

         public static Liczba operator +(Liczba a, Liczba b)
         {
             return new Liczba { Wartosc = a.Wartosc + b.Wartosc };
         }
     }
     ```

8. **Indeksator (Indexer)**:
   - **Definicja**: Indeksator umo�liwia indeksowanie obiektu w spos�b podobny do tablic.
   - **Przyk�ad**:
     ```csharp
     public class KolekcjaLiczb
     {
         private int[] liczby = new int[10];

         public int this[int index]
         {
             get { return liczby[index]; }
             set { liczby[index] = value; }
         }
     }
     ```

9. **Konstruktor (Constructor)**:
   - **Definicja**: Konstruktor to metoda wywo�ywana podczas tworzenia obiektu. S�u�y do inicjalizacji danych obiektu.
   - **Przyk�ad**:
     ```csharp
     public class Osoba
     {
         public string Imie { get; set; }

         public Osoba(string imie)
         {
             Imie = imie;
         }
     }
     ```

10. **Finalizator (Finalizer)**:
    - **Definicja**: Finalizator jest metod� wywo�ywan� przez silnik wykonawczy, gdy obiekt ma zosta� usuni�ty z pami�ci. U�ywane rzadko, g��wnie do zwalniania zasob�w.
    - **Przyk�ad**:
      ```csharp
      public class Zasob
      {
          ~Zasob()
          {
              // Kod do zwalniania zasob�w
          }
      }
      ```

11. **Zagnie�d�one typy (Nested Types)**:
    - **Definicja**: Zagnie�d�one typy to typy zadeklarowane wewn�trz innego typu. Cz�sto u�ywane do opisu obiekt�w u�ywanych tylko przez typy, kt�re je zawieraj�.
    - **Przyk�ad**:
      ```csharp
      public class ZewnetrznaKlasa
      {
          public class WewnetrznaKlasa
          {
              public void MetodaWewnetrzna()
              {
                  Console.WriteLine("Wewnetrzna metoda");
              }
          }
      }
      ```

### Podsumowanie
- **Klasa (Class)**: Definicja obiektu zawieraj�ca w�a�ciwo�ci, metody, zdarzenia i inne cz�onki klasy.
- **Pole (Field)**: Zmienna zadeklarowana na poziomie klasy.
- **Sta�a (Constant)**: Pole, kt�rego warto�� jest ustalana w czasie kompilacji i nie mo�e by� zmieniona.
- **W�a�ciwo�� (Property)**: Metody dost�pu do prywatnych p�l klasy.
- **Metoda (Method)**: Funkcja zdefiniowana w klasie.
- **Zdarzenie (Event)**: Mechanizm powiadamiania subskrybent�w o zdarzeniach.
- **Operator (Operator)**: Przeci��ony operator zdefiniowany jako publiczna statyczna metoda w typie.
- **Indeksator (Indexer)**: Umo�liwia indeksowanie obiektu w spos�b podobny do tablic.
- **Konstruktor (Constructor)**: Metoda wywo�ywana podczas tworzenia obiektu.
- **Finalizator (Finalizer)**: Metoda wywo�ywana przez silnik wykonawczy, gdy obiekt ma zosta� usuni�ty z pami�ci.
- **Zagnie�d�one typy (Nested Types)**: Typy zadeklarowane wewn�trz innego typu.