using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututialEncyklopedia.Linq;

internal class LinqProjection
{
    private IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    private IEnumerable<char> charColection = ['a', 'b', 'c', 'd', 'e'];
    private IEnumerable<object> mixColection = [1, "b", 3, "d", 5];
    private IEnumerable<List<int>> colectionList = [[1, 2, 3, 4], [4, 3, 2, 1]];
    private IEnumerable<object> objectIntColection = [1, 2, 3, 4, 5];

    public IEnumerable<int> SelectSquared()
    {
        return intColection.Select(x => x ^ 2);
    }

    public IEnumerable<string> SelectIndexWithChar()
    {
        return charColection.Select((x, i) => $"{i}:{x}");
    }

    public IEnumerable<int> SelectAddColections()
    {
        return colectionList.SelectMany(x => x);
    }

    //public IEnumerable<int> SelectColectionSquaredByColection()
    //{
    //    return colectionList.SelectMany((x, y) => (x * y));
    //}

    public IEnumerable<string> SelectCastToString()
    {
        return intColection.Select(x => x.ToString());
    }

    public IEnumerable<int> SelectCastObjectToInt()
    {
        return objectIntColection.Cast<int>();
    }
}