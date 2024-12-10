1. **Klasa (Class)**:
   - **Definicja**: Klasa w C# to definicja obiektu zawieraj¹ca w³aœciwoœci, metody, zdarzenia i innych cz³onków klasy. Klasa jest schematem, na podstawie którego tworzone s¹ obiekty.
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

# Cz³onkowie Klasy(Class Members)

2. **Pole (Field)**:
   - **Definicja**: Pole to zmienna zadeklarowana na poziomie klasy. Mo¿e to byæ typ wbudowany (np. int) lub instancja innej klasy.
   - **Przyk³ad**:
     ```csharp
     public class Kalendarz
     {
         private DateTime aktualnaData;
     }
     ```

3. **Sta³a (Constant)**:
   - **Definicja**: Sta³a to pole, którego wartoœæ jest ustalana w czasie kompilacji i nie mo¿e byæ zmieniona.
   - **Przyk³ad**:
     ```csharp
     public class Matematyka
     {
         public const double Pi = 3.14159;
     }
     ```

4. **W³aœciwoœæ (Property)**:
   - **Definicja**: W³aœciwoœæ to metody dostêpu do prywatnych pól klasy, umo¿liwiaj¹ce odczyt i zapis wartoœci.
   - **Przyk³ad**:
     ```csharp
     public class Osoba
     {
         public string Imie { get; set; }
         public int Wiek { get; set; }
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

6. **Zdarzenie (Event)**:
   - **Definicja**: Zdarzenie jest mechanizmem umo¿liwiaj¹cym powiadamianie subskrybentów (obiektów) o pewnych zdarzeniach.
   - **Przyk³ad**:
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
             Console.WriteLine("Przycisk zosta³ klikniêty.");
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
             Console.WriteLine("Zdarzenie Klikniecie zosta³o obs³u¿one.");
         }
     }
     ```

7. **Operator (Operator)**:
   - **Definicja**: Operator przeci¹¿ony jest cz³onkiem typu. Przeci¹¿enie operatora definiuje siê jako publiczn¹ statyczn¹ metodê w typie.
   - **Przyk³ad**:
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
   - **Definicja**: Indeksator umo¿liwia indeksowanie obiektu w sposób podobny do tablic.
   - **Przyk³ad**:
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
   - **Definicja**: Konstruktor to metoda wywo³ywana podczas tworzenia obiektu. S³u¿y do inicjalizacji danych obiektu.
   - **Przyk³ad**:
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
    - **Definicja**: Finalizator jest metod¹ wywo³ywan¹ przez silnik wykonawczy, gdy obiekt ma zostaæ usuniêty z pamiêci. U¿ywane rzadko, g³ównie do zwalniania zasobów.
    - **Przyk³ad**:
      ```csharp
      public class Zasob
      {
          ~Zasob()
          {
              // Kod do zwalniania zasobów
          }
      }
      ```

11. **Zagnie¿d¿one typy (Nested Types)**:
    - **Definicja**: Zagnie¿d¿one typy to typy zadeklarowane wewn¹trz innego typu. Czêsto u¿ywane do opisu obiektów u¿ywanych tylko przez typy, które je zawieraj¹.
    - **Przyk³ad**:
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
- **Klasa (Class)**: Definicja obiektu zawieraj¹ca w³aœciwoœci, metody, zdarzenia i inne cz³onki klasy.
- **Pole (Field)**: Zmienna zadeklarowana na poziomie klasy.
- **Sta³a (Constant)**: Pole, którego wartoœæ jest ustalana w czasie kompilacji i nie mo¿e byæ zmieniona.
- **W³aœciwoœæ (Property)**: Metody dostêpu do prywatnych pól klasy.
- **Metoda (Method)**: Funkcja zdefiniowana w klasie.
- **Zdarzenie (Event)**: Mechanizm powiadamiania subskrybentów o zdarzeniach.
- **Operator (Operator)**: Przeci¹¿ony operator zdefiniowany jako publiczna statyczna metoda w typie.
- **Indeksator (Indexer)**: Umo¿liwia indeksowanie obiektu w sposób podobny do tablic.
- **Konstruktor (Constructor)**: Metoda wywo³ywana podczas tworzenia obiektu.
- **Finalizator (Finalizer)**: Metoda wywo³ywana przez silnik wykonawczy, gdy obiekt ma zostaæ usuniêty z pamiêci.
- **Zagnie¿d¿one typy (Nested Types)**: Typy zadeklarowane wewn¹trz innego typu.