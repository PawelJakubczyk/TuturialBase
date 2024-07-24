namespace Exercise;
public static class integerExtension
{
    public static int Power(this int source, int pow)
    {
        return (int)Math.Pow(source, pow);
    }
}
