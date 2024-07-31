using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TuturialEasyExercaise.EasyExcercise;

internal class Exercise3
{
    public int UserInput = 0;
    public int Sum = 0;
    public int MaxValue;
    public double AverageValue;
    private List<int> ListOfInputs = new();

    public void GetUserInputs()
    {
        int UserInput = int.Parse(Console.ReadLine());

        do
        {
            try
            {
                UserInput = int.Parse(Console.ReadLine());
            }
            catch (TypeInitializationException)
            {
                Console.WriteLine("Bad data type input");
            }

            ListOfInputs.Add(UserInput);
        } while (UserInput != 0);

        MaxValue = ListOfInputs.Max();
        AverageValue = ListOfInputs.Average();
        Sum = ListOfInputs.Sum();
    }
}

internal class TestExercise
{
    private enum GenderEnum : int
    {
        Female = 1,
        Male = 2
    }

    public string EnumTest()
    {
        Console.WriteLine("What is your gender? 1 - Male, 2 - Female");
        int userInput = int.Parse((Console.ReadLine()));
        //GenderEnum userGender = (GenderEnum)Enum.Parse(typeof(GenderEnum), userInput);
        

        if ((int)GenderEnum.Male == userInput)
        {
            return "Only Ladies";
        }

        return "hello";

    }
}