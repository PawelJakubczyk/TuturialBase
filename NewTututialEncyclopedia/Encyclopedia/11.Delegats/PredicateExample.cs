using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututialEncyclopedia._1.Encyclopedia._11.Delegats;

public class PredicateExample
{
    List<int> exampleNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    public bool Check(int number, Predicate<int> predicate)
	{
        return predicate(number);
	}
    public List<int> Filter(Predicate<int> predicate)
    {
        List<int> result = exampleNumbers.FindAll(predicate);
        return result;
    }
    public List<int> Filter(List<int> numbers, Predicate<int> predicate)
    {
        List<int> result = numbers.FindAll(predicate);
        return result;
    }
}


