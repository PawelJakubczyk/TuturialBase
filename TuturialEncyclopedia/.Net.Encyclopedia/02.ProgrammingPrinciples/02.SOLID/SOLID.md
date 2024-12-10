### SOLID Principles in C#

1. **Single Responsibility Principle (SRP)**
   Ka¿da klasa powinna mieæ tylko jedn¹ odpowiedzialnoœæ, tj. powinna mieæ tylko jeden powód do zmiany.

2. **Open/Closed Principle (OCP)**
   Klasy i metody powinny byæ otwarte na rozszerzenie, ale zamkniête na modyfikacjê.

3. **Liskov Substitution Principle (LSP)**
   Obiekty w programie powinny byæ zastêpowalne przez ich podtypy bez wprowadzania niepo¿¹danych efektów ubocznych.

4. **Interface Segregation Principle (ISP)**
   Klienci nie powinni byæ zmuszani do implementacji interfejsów, których nie u¿ywaj¹.

5. **Dependency Inversion Principle (DIP)**
   Wysokopoziomowe modu³y nie powinny zale¿eæ od niskopoziomowych modu³ów. Oba powinny zale¿eæ od abstrakcji.


| Inicja³ | Skrót | Koncepcja |
|---------|-------|-----------|
| S       | SRP | **Single responsibility principle (Zasada jednej odpowiedzialnoœci)**<br>Klasa powinna mieæ tylko jedn¹ odpowiedzialnoœæ (nigdy nie powinien istnieæ wiêcej ni¿ jeden powód do modyfikacji klasy). |
| O       | OCP | **Open/closed principle (Zasada otwarte-zamkniête)**<br>Klasy (encje) powinny byæ otwarte na rozszerzenia i zamkniête na modyfikacje. |
| L       | LSP | **Liskov substitution principle (Zasada podstawienia Liskov)**<br>Funkcje które u¿ywaj¹ wskaŸników lub referencji do klas bazowych, musz¹ byæ w stanie u¿ywaæ równie¿ obiektów klas dziedzicz¹cych po klasach bazowych, bez dok³adnej znajomoœci tych obiektów. |
| I       | ISP | **Interface segregation principle (Zasada segregacji interfejsów)**<br>Wiele dedykowanych interfejsów jest lepsze ni¿ jeden ogólny. |
| D       | DIP | **Dependency inversion principle (Zasada odwrócenia zale¿noœci)**<br>Wysokopoziomowe modu³y nie powinny zale¿eæ od modu³ów niskopoziomowych - zale¿noœci miêdzy nimi powinny wynikaæ z abstrakcji. |

### SOLID Principles in C# Examples

1. **Single Responsibility Principle (SRP)**
   Ka¿da klasa powinna mieæ tylko jedn¹ odpowiedzialnoœæ, tj. powinna mieæ tylko jeden powód do zmiany.

   ```csharp
   // Z³a praktyka - Klasa wykonuje wiele zadañ
   public class UserManagement
   {
       public void RegisterUser(User user) { /* implementacja */ }
       public void AuthenticateUser(string username, string password) { /* implementacja */ }
       public void UpdateUserDetails(User user) { /* implementacja */ }
   }

   // Dobra praktyka - Rozdzielenie odpowiedzialnoœci
   public class UserManager
   {
       public void RegisterUser(User user) { /* implementacja */ }
       public void UpdateUserDetails(User user) { /* implementacja */ }
   }

   public class UserAuthenticator
   {
       public void AuthenticateUser(string username, string password) { /* implementacja */ }
   }
   ```

2. **Open/Closed Principle (OCP)**

   Klasy i metody powinny byæ otwarte na rozszerzenie, ale zamkniête na modyfikacjê.

   ```csharp
   // Z³a praktyka - Modyfikacja istniej¹cej klasy
   public class Circle
   {
       public double Radius { get; set; }

       public double Area()
       {
           return Math.PI * Radius * Radius;
       }
   }

   // Dobra praktyka - Rozszerzenie poprzez dziedziczenie i polimorfizm
   public abstract class Shape
   {
       public abstract double Area();
   }

   public class Circle : Shape
   {
       public double Radius { get; set; }

       public override double Area()
       {
           return Math.PI * Radius * Radius;
       }
   }

   public class Rectangle : Shape
   {
       public double Width { get; set; }
       public double Height { get; set; }

       public override double Area()
       {
           return Width * Height;
       }
   }
   ```

3. **Liskov Substitution Principle (LSP)**

   Obiekty w programie powinny byæ zastêpowalne przez ich podtypy bez wprowadzania niepo¿¹danych efektów ubocznych.

   ```csharp
   // Z³a praktyka - Niezgodnoœæ interfejsów
   public class Rectangle
   {
       public int Width { get; set; }
       public int Height { get; set; }
   }

   public class Square : Rectangle
   {
       public new int Width
       {
           set { base.Width = base.Height = value; }
       }

       public new int Height
       {
           set { base.Width = base.Height = value; }
       }
   }

   // Dobra praktyka - Zachowanie spójnoœci interfejsu
   public abstract class Shape
   {
       public abstract int Area();
   }

   public class Rectangle : Shape
   {
       public int Width { get; set; }
       public int Height { get; set; }

       public override int Area()
       {
           return Width * Height;
       }
   }

   public class Square : Shape
   {
       public int SideLength { get; set; }

       public override int Area()
       {
           return SideLength * SideLength;
       }
   }
   ```

4. **Interface Segregation Principle (ISP)**

   Klienci nie powinni byæ zmuszani do implementacji interfejsów, których nie u¿ywaj¹.

   ```csharp
   // Z³a praktyka - Zbyt du¿y interfejs
   public interface IWorker
   {
       void Work();
       void TakeBreak();
       void ClockOut();
   }

   public class Robot : IWorker
   {
       public void Work() { /* implementacja */ }
       public void TakeBreak() { /* implementacja */ }
       public void ClockOut() { /* implementacja */ }
   }

   // Dobra praktyka - Podzia³ interfejsów na mniejsze
   public interface IWorker
   {
       void Work();
   }

   public interface IBreakable
   {
       void TakeBreak();
   }

   public interface IClockable
   {
       void ClockOut();
   }

   public class Robot : IWorker, IBreakable, IClockable
   {
       public void Work() { /* implementacja */ }
       public void TakeBreak() { /* implementacja */ }
       public void ClockOut() { /* implementacja */ }
   }
   ```

5. **Dependency Inversion Principle (DIP)**

   Wysokopoziomowe modu³y nie powinny zale¿eæ od niskopoziomowych modu³ów. Oba powinny zale¿eæ od abstrakcji.

   ```csharp
   // Z³a praktyka - Bez zastosowania DIP
   public class Worker
   {
       private Logger _logger;

       public Worker()
       {
           _logger = new Logger();
       }

       public void DoWork() { _logger.Log("Working..."); }
   }

   // Dobra praktyka - Zastosowanie DIP z wstrzykiwaniem zale¿noœci
   public interface ILogger
   {
       void Log(string message);
   }

   public class Logger : ILogger
   {
       public void Log(string message) { /* implementacja */ }
   }

   public class Worker
   {
       private readonly ILogger _logger;

       public Worker(ILogger logger)
       {
           _logger = logger;
       }

       public void DoWork() { _logger.Log("Working..."); }
   }
   ```