//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EasyExercaiseTuturial.CodeWars
//{
//    internal class ex2
//    {
//    }
//}

////Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

////Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

////If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

////"is2 Thi1s T4est 3a"-- > "Thi1s is2 3a T4est"
////"4of Fo1r pe6ople g3ood th5e the2"-- > "Fo1r the2 g3ood 4of th5e pe6ople"
////""-- > ""


//public static class Kata
//{
//    public static string Order(string words)
//    {
//        string[] wordsArray = words.Split(' ');
//        int lengthOfSentence = wordsArray.Length;
//        int[] rangeArray = Enumerable.Range(1, lengthOfSentence).ToArray();
//        char[] charRangeArray = rangeArray
//            .Select(x => x.ToString()[0])
//            .ToArray();

//        int[] positionArray = new int[lengthOfSentence];
//        foreach (char character in charRangeArray)
//        {   
//            foreach (string word in wordsArray)
//            {
//                if (word.Contains(character))
//                    {
//                    positionArray.Append(character);
//                    }
//            }
//        }

//        string newString = string.Empty;

//        foreach (int position in positionArray)
//        {
//            newString += $"{wordsArray[position]} ";
//        }

//        return newString.Trim();

//    }
//}