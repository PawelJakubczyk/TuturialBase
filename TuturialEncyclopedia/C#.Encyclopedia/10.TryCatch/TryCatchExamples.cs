namespace Encyclopedia.TryCatchExamples;

internal class TryCatchExamples
{
    public int _dividend { get; set; }
    public int _divisor { get; set; }

    public TryCatchExamples(int dividend, int divisor)
    {
        _dividend = dividend;
        _divisor = divisor;
    }

    public void Divide()
    {
        try
        {
            Console.WriteLine("Before executing code in the try block.");
            int result = _dividend / _divisor;

            Console.WriteLine($"Division result: {result}");
            Console.WriteLine("After executing code in the try block.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("The finally block always executes, regardless of whether an exception occurred.");
        }
    }

    public void DivideWithThrow()
    {
        try
        {
            Console.WriteLine("Before executing code in the try block (DivideWithThrow).");
            int result = _dividend / _divisor;
            Console.WriteLine($"Division result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Caught exception in DivideWithThrow, rethrowing the exception.");
            throw; // Rethrow the exception, preserving the original call stack
        }
        finally
        {
            Console.WriteLine("The finally block (DivideWithThrow) always executes, regardless of whether an exception occurred.");
        }
    }
    public void DivideWithThrowException()
    {
        try
        {
            Console.WriteLine("Before executing code in the try block (DivideWithThrowEx).");
            int result = _dividend / _divisor;
            Console.WriteLine($"Division result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            throw new DivideByZeroException("divisor should not be 0", ex); 
            // "Caught exception in DivideWithThrowEx, rethrowing the exception with a reset call stack."
        }
        finally
        {
            Console.WriteLine("The finally block (DivideWithThrowEx) always executes, regardless of whether an exception occurred.");
        }
    }
}

