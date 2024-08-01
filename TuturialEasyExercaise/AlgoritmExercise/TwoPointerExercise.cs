using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuturialEasyExercaise.AlgoritmExercise
{
    internal class TwoPointerExercise
    {
        public bool CheckIfTwoNumberFromArrayCanGiveExpectationsSum(List<int> arrayToCheck, int ExpectedSum)
        {
            arrayToCheck.OrderBy(x => x);
            int lenght = arrayToCheck.Count;
            int start = 0;
            int end = lenght -1;

            //if (arrayToCheck[start] + arrayToCheck[end] )

            switch (arrayToCheck[start] + arrayToCheck[end])
            {
                > 
            }


            

        }
    }
}
