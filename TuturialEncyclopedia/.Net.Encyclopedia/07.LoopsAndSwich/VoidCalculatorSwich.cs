using System.Numerics;

namespace Encyclopedia.LoopsAndSwich;

internal static class VoidCalculatorSwich
{
    public static TNumber AddTwoNumbersSwich<TNumber>(TNumber number1, TNumber number2, string operation)
        where TNumber : INumber<TNumber>
    {
        TNumber result;
        switch (operation)
        {
            case "+":
                result = number1 + number2;
                break;

            case "-":
                result = number1 - number2;
                break;

            case "*":
                result = number1 * number2;
                break;

            case "/":
                if (number2 != TNumber.Zero)
                {
                    result = number1 / number2;
                }
                else
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                break;

            default:
                throw new InvalidOperationException("Unsupported operation.");
        }

        return result;
    }
}