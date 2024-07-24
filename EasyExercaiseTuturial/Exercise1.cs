using System.Numerics;


namespace Exercise;

internal class Exercise1
{
    /*
Hello World:
Napisz program, który wyświetla na ekranie tekst "Hello, World!".

Kalkulator:
Napisz program, który poprosi użytkownika o wprowadzenie dwóch liczb i wyświetli ich sumę, różnicę, iloczyn oraz iloraz.

Sprawdź parzystość:
Napisz program, który poprosi użytkownika o wprowadzenie liczby całkowitej i wyświetli, czy jest ona parzysta czy nieparzysta.

Proste wyrażenia logiczne:
Napisz program, który poprosi użytkownika o wprowadzenie jego wieku i wyświetli, czy użytkownik jest pełnoletni (18 lat lub więcej).

Pętla for:
Napisz program, który wyświetli liczby od 1 do 10.

Tablica liczb:
Napisz program, który poprosi użytkownika o wprowadzenie pięciu liczb, zapisze je do tablicy, a następnie wyświetli ich średnią arytmetyczną.

Kalkulator BMI:
Napisz program, który obliczy i wyświetli BMI (Body Mass Index) na podstawie wzrostu (w metrach) i wagi (w kilogramach) podanych przez użytkownika.

Odwracanie ciągu znaków:
Napisz program, który poprosi użytkownika o wprowadzenie ciągu znaków i wyświetli ten ciąg odwrócony.

Zgadnij liczbę:
Napisz prostą grę, w której program losuje liczbę od 1 do 100, a użytkownik ma zgadnąć tę liczbę. Program powinien informować użytkownika, czy jego zgadywana liczba jest za wysoka, za niska, czy prawidłowa.

Tabliczka mnożenia:
Napisz program, który wyświetli tabliczkę mnożenia dla liczb od 1 do 10.
     */
}

public class Writehello
{
public static void SayHello(string message)
{
    Console.WriteLine(message);
}
}

// Calculator class inheriting from CalculatorBase
public sealed class StaticGenericCalculator
{
// Method to add two numbers of generic type
public static TType AddNumbers<TType>(TType number1, TType number2)
    where TType : INumber<TType>
{
    return number1 + number2;
}

// Method to subtract two numbers of generic type
public static TType SubtractNumbers<TType>(TType number1, TType number2)
    where TType : INumber<TType>
{
    return number1 - number2;
}

// Method to multiply two numbers of generic type
public static TType MultiplyNumbers<TType>(TType number1, TType number2)
    where TType : INumber<TType>
{
    return number1 * number2;
}

// Method to divide two numbers of generic type
public static TType DivideNumbers<TType>(TType number1, TType number2)
    where TType : INumber<TType>
{
    return number1 / number2;
}
}

internal static class Parity
{
private static bool IsOdd(int value)
{
    return value % 2 == 0;
}

private static bool IsEven(int value)
{
    return value % 2 == 1;
}

private static string CheckPairity(int value)
{
    return (value % 2) switch
    {
        0 => "Even",
        1 or -1 => "Odd",
        _ => throw new ArgumentException("Invalid input"),
    };
}
}

internal class PersonalID
{
public string Sex { get; set; }
public string Name { get; set; }
public string SureName { get; set; }
public DateTime BirthTime { get; set; }
public int Age { get; set; }
public int majoritAge = 18;

public PersonalID(string name, string surName, string sex, DateTime birthTime)
{
    Name = name;
    SureName = surName;
    Sex = sex;
    BirthTime = birthTime;

    Age = CalculateAge();
}

public bool CheckMajorit()
{
    if (Age >= majoritAge)
        return true;
    return false;
}

internal int CalculateAge()
{
    DateTime today = DateTime.Now;
    int age = today.Year - BirthTime.Year;

    if (BirthTime.Date > today.AddYears(-age)) age--;

    return age;
}
}

internal class AdvanceGameDice
{
public int Position { get; set; }
public int sideNumber { get; set; }

public Random RandomForDice = new Random();

public AdvanceGameDice(int sideNumber)
{
    this.sideNumber = sideNumber;
    Position = RandomForDice.Next(1, sideNumber);
}

public void RelolDice()
{
    Position = RandomForDice.Next(1, sideNumber);
}

public void ImproveDice()
{ Position = Math.Min(sideNumber, Position + 1); }

public void DemoteDice()
{ Position = Math.Max(1, Position - 1); }
}

internal class SalaryStatistic
{
public float[] SallaryArray { get; set; }

public SalaryStatistic(float[] sallaryArray)
{
    SallaryArray = sallaryArray;
}

public float SalaryAvrage()
{
    return SallaryArray.Average();
}

public float GetLastSalar()
{
    return SallaryArray[^1];
}

public float GetSumSalaryLastHalfYear()
{
    if (SallaryArray.Length <= 6)
    {
        return SallaryArray.Sum();
    };
    return SallaryArray[^6..^0].Sum();
}

public float GetSumSalaryLastYear()
{
    if (SallaryArray.Length <= 12)
    {
        return SallaryArray.Sum();
    };
    return SallaryArray[^12..^0].Sum();
}
}

public class BmiCalkulator
{
private float Mass { get; set; }
private int Height { get; set; }
private float BMI { get; set; }

public BmiCalkulator(float mass, int height)
{
    Mass = mass;
    Height = height;
    CalculateBMI();
}

private void CalculateBMI()
{
    BMI = Mass / Height;
}

public string ReturnClasifikation()
{
    return BMI switch
    {
        < 16 => "Underweight(Severe thinness)",
        < 16.9f => "Underweight(Moderate thinness)",
        < 18.4f => "Underweight(Mild thinness)",
        < 24.9f => "Normal range",
        < 29.9f => "Overweight (Pre-obese)",
        < 34.9f => "Obese (Class I)",
        < 39.9f => "Obese (Class II)",
        > 40.0f => "Obese (Class III)",
        _ => "Incorect Data",
    };
}

public void ChangeMass(float newMass)
{
    Mass = newMass;
}

public void ChangeHeight(int newHeight)
{
    Height = newHeight;
}
}

public record Robal(string Input, int Age);

public static class StringExpansion
{
public static bool ROOO(this (string, int) input)
{
    throw new NotImplementedException();
}

public static bool IsNullOrEmpty(this string input)
{
    return string.IsNullOrWhiteSpace(input);
}

public static bool NotNullOrEmpty(this string input)
{
    return input.IsNullOrEmpty() is false;
}

public static void ROGAL()
{
    string littleRogal = "I am Rogal";
    bool result = littleRogal.NotNullOrEmpty();
    bool resultInOtherWay = NotNullOrEmpty(littleRogal);
}

public static string Reverse(this string stringToRevers)
{
    if (stringToRevers.IsNullOrEmpty())
    {
        return stringToRevers;
    }

    string reverseString = string.Empty;
    char[] CharArray = stringToRevers.ToCharArray();

    for (int i = (CharArray.Length - 1); i >= 0; i--)
    {
        reverseString += i;
    }
    return reverseString;
}
}

public class NumberGameSelector
{
private Random random = new Random();
private int _randomNumber;

public NumberGameSelector()
{
    _randomNumber = random.Next(1, 101);
}
}
//    public string Guess(int number) => number switch
//    {
//        < _randomNumber => "too low",
//        > _randomNumber => "too high",
//        _ => "congratulations, you nailed it!"
//    };
//}
