namespace Encyclopedia.OOP.FourFilarsExamples;

public sealed class EncapsulationExamples
{
    public class BankAccount
    {
        // Prywatne pole, które nie jest dostępne poza klasą
        private decimal balance;

        // Publiczna właściwość, która kontroluje dostęp do prywatnego pola
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; } // Tylko wewnętrzne ustawienie wartości
        }

        // Publiczna metoda do wykonywania operacji na koncie
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Publiczna metoda do wypłaty środków
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }
    }

    public class Product
    {
        // Prywatne właściwości i pole
        private string name;
        private decimal price;

        // Prywatny konstruktor
        private Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        // Publiczna metoda fabryczna do tworzenia obiektów
        public static Product Create(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name) || price <= 0)
            {
                throw new ArgumentException("Invalid name or price");
            }
            return new Product(name, price);
        }

        // Publiczne właściwości tylko do odczytu
        public string Name => name;
        public decimal Price => price;
    }

    public class Car
    {
        // Prywatne pole i metoda
        private Engine engine;

        public Car()
        {
            engine = new Engine();
        }

        // Publiczna metoda, która korzysta z prywatnej metody
        public void Start()
        {
            engine.StartEngine();
        }

        // Wewnętrzna klasa, której implementacja jest ukryta
        private class Engine
        {
            public void StartEngine()
            {
                // Logika uruchamiania silnika
            }
        }
    }

    public class Temperature
    {
        private double celsius;

        // Właściwość z logiką przeliczania jednostek
        public double Celsius
        {
            get { return celsius; }
            set
            {
                if (value < -273.15) // Temperatura nie może być poniżej zera absolutnego
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Temperature cannot be below absolute zero.");
                }
                celsius = value;
            }
        }

        // Właściwość z inną jednostką
        public double Fahrenheit
        {
            get { return (celsius * 9 / 5) + 32; }
            set
            {
                Celsius = (value - 32) * 5 / 9;
            }
        }
    }

    public class Database
    {
        // Prywatna klasa pomocnicza
        private class Connection
        {
            public void Open() { /* Logika otwierania połączenia */ }
            public void Close() { /* Logika zamykania połączenia */ }
        }

        private Connection connection;

        public Database()
        {
            connection = new Connection();
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }

}