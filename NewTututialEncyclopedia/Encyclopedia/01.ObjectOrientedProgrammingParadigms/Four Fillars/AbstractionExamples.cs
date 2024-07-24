namespace Encyclopedia.OOP.FourFilarsExamples;

// Abstract Class Example
public abstract class Shape
{
    // Abstract method: you must implement this method in the inheriting class
    public abstract double CalculateArea();

    // Abstract method: you must implement this method in the inheriting class
    public abstract double CalculatePerimeter();

    // Concrete method: Every inheriting class will have this method, and this method cannot be changed
    public void DisplayInfo()
    {
        Console.WriteLine("Shape: " + this.GetType().Name);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Perimeter: " + CalculatePerimeter());
    }

    // Virtual method: Every inheriting class will have this method, and this method can be overridden
    public virtual void DisplayComment()
    {
        Console.WriteLine(
            @"A shape is a graphical representation of an object's form or its external boundary,
                outline, or external surface. It is distinct from other object properties, such as color,
                texture, or material type. In geometry, shape excludes information about the object's location,
                scale, orientation, and reflection. A figure is a representation including both shape and size."
        );
    }
}

// Class inheriting from the abstract class
public sealed class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementation of the method to calculate the area
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Implementation of the method to calculate the perimeter
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    // Override the DisplayComment method to provide specific comment for Circle
    public override void DisplayComment()
    {
        Console.WriteLine("A circle is a shape with all points at the boundary having the same distance to the center.");
    }
}

// Class inheriting from the abstract class
public sealed class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implementation of the method to calculate the area
    public override double CalculateArea()
    {
        return Width * Height;
    }

    // Implementation of the method to calculate the perimeter
    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    // Override the DisplayComment method to provide specific comment for Rectangle
    public override void DisplayComment()
    {
        Console.WriteLine("A rectangle is a shape with four sides and four right angles, especially one with unequal adjacent sides.");
    }
}

// Interface Class Example
public interface IPrinter
{
    void Print(string document); // Method to print a document
}

// Define the second interface called IScanner
public interface IScanner
{
    void Scan(string document); // Method to scan a document
}

// Implement both interfaces in a class called MultiFunctionDevice
public class MultiFunctionDevice : IPrinter, IScanner
{
    // Implement the Print method from IPrinter
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }

    // Implement the Scan method from IScanner
    public void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}");
    }
}