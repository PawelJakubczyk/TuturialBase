using System.Globalization;
using System.Net.NetworkInformation;

namespace Encyclopedia.ClassesExamples;

internal class ConstAndReadOnly
{
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

    public static void Execute()
    {
        List<string> games =
        [
            "Valheim",
            "Yakuza"
        ];

        var result = GetRogals(games);
        var result2 = GetRogals(["Valheim", "Yakuza"]);
        var result32 = GetRogals2("Valheim", "Yakuza", "dfsd");

    }

    public static string GetRogals(List<string> games)
    {
        return string.Join(' ', games);
    }

    public static string GetRogals2(params string[] games)
    {
        return string.Join(' ', games);
    }
}

