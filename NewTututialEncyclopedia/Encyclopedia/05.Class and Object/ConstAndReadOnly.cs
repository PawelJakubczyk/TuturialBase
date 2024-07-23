using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututialEncyclopedia._1.Encyclopedia._05.Class_and_Object
{
    internal class ConstAndReadOnly
    {
    }
}

public class ConstantsExamples
{
    public const int MaxValue = 100;
    public const string Greeting = "Hello, world!";
}

public class ReadOnlyExamples
{
    public readonly int MaxItems;
    public static readonly string DefaultGreeting;

    // Instance readonly field can be initialized in constructor
    public ReadOnlyExamples(int maxItems)
    {
        MaxItems = maxItems;
    }

    // Static readonly field can be initialized in static constructor
    static ReadOnlyExamples()
    {
        DefaultGreeting = "Welcome!";
    }
}