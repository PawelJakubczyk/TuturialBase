using System.Numerics;
namespace TeddySmithTuturial;


// Calculator class inheriting from CalculatorBase
public sealed class StaticCalculator
{
    // Method to add two numbers of generic type
    public static TType AddNumbers<TType>(TType number1, TType number2)
        where TType : INumber<TType>
    {
        return number1 + number2;
    }

    // Method to subtract two numbers of generic type
    public static TType SubtractNumbers<TType>(TType number1, TType number2)
        where TType : INumber<TType>
    {
        return number1 - number2;
    }

    // Method to multiply two numbers of generic type
    public static TType MultiplyNumbers<TType>(TType number1, TType number2)
        where TType : INumber<TType>
    {
        return number1 * number2;
    }

    // Method to divide two numbers of generic type
    public static TType DivideNumbers<TType>(TType number1, TType number2)
        where TType : INumber<TType>
    {
        return number1 / number2;
    }
}