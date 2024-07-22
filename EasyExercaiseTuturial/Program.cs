using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

Kata.Rogal();

string resoult = Kata.Order("4of Fo1r pe6ople g3ood th5e the2");
Console.WriteLine(resoult);


public static class Kata
{
    public static string Order(string words)
    {
        string[] wordsArray = words.Split(' ');
        int lengthOfSentence = wordsArray.Length;
        int[] rangeArray = Enumerable.Range(1, lengthOfSentence).ToArray();
        char[] charRangeArray = rangeArray
            .Select(x => x.ToString()[0])
            .ToArray();

        List<int> positionList = new List<int>();

        foreach (char character in charRangeArray)
        {
            foreach (string word in wordsArray)
            {
                if (word.Contains(character))
                {
                    positionList.Add(int.Parse(character.ToString()));
                }
            }
        }

        string newString = string.Empty;

        foreach (int position in positionList)
        {
            newString += $"{wordsArray[position - 1]} ";
        }

        return newString.Trim();

    }

    public static void Rogal()
    {
        var firstArray = "dfsdewFDSFSD";
        var secondArray = "okokmvfvf";

        var result =
            from item in firstArray
            from suit in secondArray
            select  $"{item}{suit}";
    }
}