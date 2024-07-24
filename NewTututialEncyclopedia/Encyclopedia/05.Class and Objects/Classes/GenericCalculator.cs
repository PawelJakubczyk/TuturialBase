namespace NewTututialEncyklopedia.Types;
using System.Numerics;


//INumber<TNumber> IGenericType<Generic Parameter>
public class GenericCalculator
{
    public static TNumber AddTwoNumbers<TNumber>(TNumber number1, TNumber number2)
        where TNumber : INumber<TNumber>
    {
        return number1 + number2;
    }

    public static TNumber SubtractTwoNumbers<TNumber>(TNumber number1, TNumber number2)
        where TNumber : INumber<TNumber>
    {
        return number1 - number2;
    }

    public static TNumber MultiplyTwoNumbers<TNumber>(TNumber number1, TNumber number2)
        where TNumber : INumber<TNumber>
    {
        return number1 * number2;
    }

    public static TNumber DivideTwoNumbers<TNumber>(TNumber number1, TNumber number2)
        where TNumber : INumber<TNumber>
    {
        return number1 / number2;
    }
}


