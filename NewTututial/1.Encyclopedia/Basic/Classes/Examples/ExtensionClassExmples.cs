using System.Collections;

namespace NewTututial.Classes.Examples;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}

public static class EnumerableExtensions
{
    public static double Median(this IEnumerable<int> source)
    {
        int[] sorted = source.OrderBy(x => x).ToArray();
        int count = sorted.Length;
        if (count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }
        if (count % 2 == 0)
        {
            return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;
        }
        else
        {
            return sorted[count / 2];
        }
    }
}
