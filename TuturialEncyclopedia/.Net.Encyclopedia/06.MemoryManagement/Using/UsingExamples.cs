using Encyclopedia.MemmoryExamples;
using Encyclopedia.MethodsExamples.Extensions;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Encyclopedia.MemmoryExamples;

public class UsingExamples
{
    public void WriteToFile(string filePath, string content)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(content);
            }
        }
    }

    public string ReadFromFile(string filePath)
    {
        string content = string.Empty;
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fs))
            {
                content = reader.ReadToEnd();
            }
        }
        return content;
    }
}

public class DisableExample : IDisposable
{
    public static List<int> exponentiationList = new();
    public List<int> disposalList = new();
    private bool _isDisposed = false;

    public void AddExponentiation(int number)
    {
        if (_isDisposed)
        {
            List<int> disposalList = exponentiationList.Clone();
            PerformExponentiation(disposalList, number);
        }
        if (!_isDisposed)
        {
            PerformExponentiation(exponentiationList, number);
        }
    }

    private void PerformExponentiation(List<int> list, int newNumber)
    {
        int _counter = list.Count + 1;
        list.Add(newNumber);

        for (int i = 0; i < _counter; i++)
        {
            list.Add((list[^1]) ^ 2);
        }
    }

    public List<int> GetExponentiationList()
    {
        if (_isDisposed)
        { return disposalList; }

        return exponentiationList;
    }

    public List<int> ShowExponentiationList()
    {
        if (_isDisposed)
        {
            return disposalList;
        };

        return exponentiationList;
    }

    public void Dispose()
    {
        Console.WriteLine("Disposing...");
        _isDisposed = true;
    }
}

//// Dodanie elementów bez użycia "using"
//var example1 = new DisableExample();
//example1.AddExpentiationToList(2);
//Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));
//-> 2, 0

//// Dodanie elementów w bloku "using"
//using (var example2 = new DisableExample())
//{
//    example2.AddExpentiationToList(6);
//    Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));
//    -> 2, 0, 6, 4, 6, 4
//    -> Disposing...

//}

//// Sprawdź listę po zakończeniu bloku "using"
//Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));

//  -> 2, 0
//  -> Disposing...

//// Dodanie elementów po zakończeniu bloku "using"
//NewMethod();

//Console.WriteLine("rohgkl");

//static void NewMethod()
//{
//    using var example3 = new DisableExample();
//    example3.AddExpentiationToList(5);
//    Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));
//}