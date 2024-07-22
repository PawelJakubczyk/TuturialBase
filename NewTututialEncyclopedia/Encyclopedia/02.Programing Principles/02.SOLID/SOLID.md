### SOLID Principles in C#

1. **Single Responsibility Principle (SRP)**
   Ka�da klasa powinna mie� tylko jedn� odpowiedzialno��, tj. powinna mie� tylko jeden pow�d do zmiany.

2. **Open/Closed Principle (OCP)**
   Klasy i metody powinny by� otwarte na rozszerzenie, ale zamkni�te na modyfikacj�.

3. **Liskov Substitution Principle (LSP)**
   Obiekty w programie powinny by� zast�powalne przez ich podtypy bez wprowadzania niepo��danych efekt�w ubocznych.

4. **Interface Segregation Principle (ISP)**
   Klienci nie powinni by� zmuszani do implementacji interfejs�w, kt�rych nie u�ywaj�.

5. **Dependency Inversion Principle (DIP)**
   Wysokopoziomowe modu�y nie powinny zale�e� od niskopoziomowych modu��w. Oba powinny zale�e� od abstrakcji.

### SOLID Principles in C# Examples

1. **Single Responsibility Principle (SRP)**
   Ka�da klasa powinna mie� tylko jedn� odpowiedzialno��, tj. powinna mie� tylko jeden pow�d do zmiany.

   ```csharp
   // Z�a praktyka - Klasa wykonuje wiele zada�
   public class UserManagement
   {
       public void RegisterUser(User user) { /* implementacja */ }
       public void AuthenticateUser(string username, string password) { /* implementacja */ }
       public void UpdateUserDetails(User user) { /* implementacja */ }
   }

   // Dobra praktyka - Rozdzielenie odpowiedzialno�ci
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

   Klasy i metody powinny by� otwarte na rozszerzenie, ale zamkni�te na modyfikacj�.

   ```csharp
   // Z�a praktyka - Modyfikacja istniej�cej klasy
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

   Obiekty w programie powinny by� zast�powalne przez ich podtypy bez wprowadzania niepo��danych efekt�w ubocznych.

   ```csharp
   // Z�a praktyka - Niezgodno�� interfejs�w
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

   // Dobra praktyka - Zachowanie sp�jno�ci interfejsu
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

   Klienci nie powinni by� zmuszani do implementacji interfejs�w, kt�rych nie u�ywaj�.

   ```csharp
   // Z�a praktyka - Zbyt du�y interfejs
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

   // Dobra praktyka - Podzia� interfejs�w na mniejsze
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

   Wysokopoziomowe modu�y nie powinny zale�e� od niskopoziomowych modu��w. Oba powinny zale�e� od abstrakcji.

   ```csharp
   // Z�a praktyka - Bez zastosowania DIP
   public class Worker
   {
       private Logger _logger;

       public Worker()
       {
           _logger = new Logger();
       }

       public void DoWork() { _logger.Log("Working..."); }
   }

   // Dobra praktyka - Zastosowanie DIP z wstrzykiwaniem zale�no�ci
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