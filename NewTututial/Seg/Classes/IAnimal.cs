namespace TeddySmithTuturial.Classes;

public interface IAnimal
{
    void MakeSound();
    void Move();
}


public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine();
        Console.WriteLine("The dog barks: Woof! Woof!");
    }

    public void Move()
    {
        Console.WriteLine("The dog runs.");
    }
}


public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("The cat meows: Meow! Meow!");
    }

    public void Move()
    {
        Console.WriteLine("The cat walks gracefully.");
    }
}


//class Program
//{
//    static void Main()
//    {
//        IAnimal dog = new Dog();
//        IAnimal cat = new Cat();

//        Console.WriteLine("Dog:");
//        dog.MakeSound();
//        dog.Move();

//        Console.WriteLine("\nCat:");
//        cat.MakeSound();
//        cat.Move();
//    }
//}