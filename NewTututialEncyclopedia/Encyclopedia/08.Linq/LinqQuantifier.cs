using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututial.LinqExamples;

internal class LinqQuantifier
{
    IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    IEnumerable<char> charColection = ['a', 'b', 'c', 'd', 'e'];
    IEnumerable<object> mixColection = [1, "b", 3, "d", 5];
    IEnumerable<List<int>> colectionList = [[1, 2, 3, 4], [4, 3, 2, 1]];
    IEnumerable<object> objectIntColection = [1, 2, 3, 4, 5];

    public bool CheckIfAnyElemrntIsGreterThanTwo()
    {
        return intColection.Any(x => x > 2);
    }

    public bool CheckIfAllElemrntIsGreterThanTwo()
    {
        return intColection.All(x => x > 2);
    }
    
    public bool CheckIfColectionContainElement()
    {
        return intColection.Contains(2);
    }
    


}
