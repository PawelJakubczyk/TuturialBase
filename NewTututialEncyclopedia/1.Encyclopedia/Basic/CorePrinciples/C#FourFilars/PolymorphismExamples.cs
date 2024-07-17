using System.Drawing;
using System.Numerics;

namespace NewTututial.FourFilars;

// Abstract base class
public abstract class Employee
{
    public abstract void Work();
}

//Abstract Class Polimorphizm
// Derived class Developer
public class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("The developer writes code.");
    }
}

// Derived class Manager
public class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("The manager manages the team.");
    }
}

//Exaple of Polimorphism data type of Jack and Hanna are Employee but they are Developer and Manager objects

public class Example
    {
    private Employee Jack = new Developer();
    private Employee Hanna = new Manager();
    }

//Inherit Class Polimorphizm
public class Measure
    {
    private INumber<decimal> RiseGrainMeasure = 0.1m;
    private INumber<double> HeliumAtomMeasure = 0.000000000000023;
    private INumber<int> PlainMeasure = 140;
}

//Inherit Method Overraiting Polimorphizm

// Define an interface IColor
public interface IColor
{
    void Fill();
}

public class Blue : IColor
{
    public void Fill()
    {
        Console.WriteLine("Filling with blue color.");
    }
}

// Client class using IColor interface
public class ColorClient
{
    private IColor _color;

    // Constructor with dependency injection of IColor
    public ColorClient(IColor color)
    {
        _color = color;
    }

    // Method to perform color filling
    public void FillWithColor()
    {
        _color.Fill();
    }
}

public class FillWithBlue
{

}

