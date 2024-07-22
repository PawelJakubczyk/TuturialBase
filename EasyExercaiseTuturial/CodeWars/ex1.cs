using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EasyExercaiseTuturial.CodeWars;

//int resoult = (int)DigPow.digPow(46288, 3);
//Console.WriteLine(resoult);

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

