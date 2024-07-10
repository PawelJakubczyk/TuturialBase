namespace Classes.SimpleCalculator;



public interface INumeric
{
    // Właściwości dotyczące typów liczbowych
    int IntegerProperty { get; set; }
    double DoubleProperty { get; set; }
    decimal DecimalProperty { get; set; }
}

public class VoidCalculator
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



        //INumeric num1, INumeric num2, string operation
        //double result;
        //switch (operation)
        //{
        //    case "+":
        //        result = num1 + num2;
        //        break;
        //    case "-":
        //        result = num1 - num2;
        //        break;
        //    case "*":
        //        result = num1 * num2;
        //        break;
        //    case "/":
        //        if (num2 != 0)
        //        {
        //            result = num1 / num2;
        //        }
        //        else
        //        {
        //            return "Error: Division by zero is not allowed.";
        //        }
        //        break;
        //    default:
        //        return "Error: Invalid operation.";
        //}
        //return $"Result: {result}";
    }

