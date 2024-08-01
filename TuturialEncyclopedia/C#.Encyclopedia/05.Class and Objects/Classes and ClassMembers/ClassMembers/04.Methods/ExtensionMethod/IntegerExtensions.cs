namespace Encyclopedia.MethodsExamples.Extensions;
public static class IntegerExtensions
{
    public static int Power(this int source, int pow)
    {
        return (int)Math.Pow(source, pow);
    }
}
