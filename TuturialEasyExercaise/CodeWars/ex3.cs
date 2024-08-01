using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.CodeWars;

public class TestTester
{
    const int _randomNumber = 32;

    public string Guess(int number)
    {
        return number switch
        {
            _ when number < _randomNumber => "too low",
            _ when number > _randomNumber => "too high",
            _ => "congratulations, you nailed it!"
        };
    }

    public string Guess2(int number)
    {
        return number switch
        {
            < _randomNumber => "too low",
            > _randomNumber => "too high",
            _ => "congratulations, you nailed it!",
        };
    }

    public string Guess3(int number)
    {
        switch (number)
        {
            case < _randomNumber:
                return "too low";
                break;

            case > _randomNumber:
                return "too high";
                break;

            default:
                return "congratulations, you nailed it!";
                break;
        }
    }
}