using Classes.SimpleCalculator;

internal static class VoidCalculatorHelpers
{
    private static decimal Calculate(INumeric num1, INumeric num2, string operation)
    {
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    return 0;
                }
                break;
            default:
                return 0;
        }
    }
}