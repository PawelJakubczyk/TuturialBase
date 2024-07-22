using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class integerExtension
{
    public static int Power(this int source, int pow)
    {
        return (int)Math.Pow(source, pow);
    }
}
