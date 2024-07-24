namespace Encyclopedia.ClassesExamples;

public abstract class AbstractAnimal
{
    public abstract void MakeSound(); // Metoda abstrakcyjna

    public void Move()
    {
        Console.WriteLine("The animal moves.");
    }
}

public class AbstractDog : AbstractAnimal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof! Woof!");
    }
}

public class AbstractCat : AbstractAnimal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows: Meow! Meow!");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Animal dog = new Dog();
//        Animal cat = new Cat();

//        Console.WriteLine("Dog:");
//        dog.MakeSound();
//        dog.Move();

//        Console.WriteLine("\nCat:");
//        cat.MakeSound();
//        cat.Move();
//    }
//}