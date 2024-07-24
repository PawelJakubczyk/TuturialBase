using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.EasyExcercise;

public class Kata
{
    public static string DoubleChar(string s)
    {
        string newString = string.Empty;
        foreach (char c in s)
        {
            newString.Append(c).Append(c);
        }
        return newString;
    }
}