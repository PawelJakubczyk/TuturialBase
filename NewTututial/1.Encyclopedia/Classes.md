# Types of Classes

## Table of Contents

1. [Regular Class (Zwyk³a klasa)]
2. [Abstract Class (Klasa abstrakcyjna)]
3. [Static Class (Klasa statyczna)]
4. [Sealed Class (Klasa zapieczêtowana)]
5. [Partial Class (Klasa partial)]
6. [Nested Class (Klasa zagnie¿d¿ona)]
7. [Generic Class (Klasa generyczna)]

## 1. Regular Class (Zwyk³a klasa)

A regular class is a blueprint for creating objects. It can contain fields (pola), properties (w³aœciwoœci), methods (metody), and events (zdarzenia).

```csharp
public class RegularClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}
```

## 2. Abstract Class (Klasa abstrakcyjna)

An abstract class cannot be instantiated and is meant to be inherited by other classes. It can contain abstract methods (abstrakcyjne metody), which must be implemented by derived classes (klasy dziedzicz¹ce).

```csharp
public abstract class AbstractClass
{
    public abstract void AbstractMethod();

    public void RegularMethod()
    {
        Console.WriteLine("This is a regular method in an abstract class.");
    }
}

public class DerivedClass : AbstractClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Abstract method implemented in derived class.");
    }
}
```

## 3. Static Class (Klasa statyczna)

A static class cannot be instantiated and can only contain static members (statyczne cz³onkowie). It is used to create utility classes (klasy u¿ytkowe) or to hold static methods that are not associated with a particular object.

```csharp
public static class StaticClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }
}
```

## 4. Sealed Class (Klasa zapieczêtowana)

A sealed class cannot be inherited. It is used to prevent further derivation (dziedziczenie).

```csharp
public sealed class SealedClass
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
}
```

## 5. Partial Class (Klasa partial)

A partial class allows its definition to be split across multiple files. This can be useful for organizing code in large projects.

```csharp
// File1.cs
public partial class PartialClass
{
    public void Method1()
    {
        Console.WriteLine("Method1 in PartialClass.");
    }
}

// File2.cs
public partial class PartialClass
{
    public void Method2()
    {
        Console.WriteLine("Method2 in PartialClass.");
    }
}
```

## 6. Nested Class (Klasa zagnie¿d¿ona)

A nested class is a class defined within another class. It is used to logically group classes that are only used in one place.

```csharp
public class OuterClass
{
    public class NestedClass
    {
        public void Display()
        {
            Console.WriteLine("This is a nested class.");
        }
    }
}
```

## 7. Generic Class (Klasa generyczna)

A generic class is defined with a type parameter (parametr typu). It allows for type-safe data structures (bezpieczne typowo struktury danych) and methods.

```csharp
public class GenericClass<T>
{
    public T Value { get; set; }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}