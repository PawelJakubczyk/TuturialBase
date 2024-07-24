namespace Exercise.CodeWars;

public class DigPow
{
    public static long digPow(int n, int p)
    {

        string stringNum = n.ToString();
        char[] numberCharArray = stringNum.ToCharArray();
        int[] integerArray = numberCharArray.Select(chr => int.Parse(chr.ToString())).ToArray();

        int resoult = 0;
        int step = 0;
        foreach (int integer in integerArray)
        {
            resoult += integer.Power(p + step);
            step++;
        }
        if (resoult % n == 0)
        {
            return (int)(resoult / n);
        }

        return -1;
    }
}

