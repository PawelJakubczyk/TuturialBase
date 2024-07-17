using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututial.LinqExamples;


internal class LinqFilter
{
    Func<int, bool> Predicate = (x => x > 2);
    IEnumerable<int> intCollection = new List<int> { 1, 2, 3, 4, 5 };
    IEnumerable<object> mixCollection = new List<object> { 1, "b", 3, "d", 5 };

    // Take methods
    public IEnumerable<int> TakeFirst(int count)
    {
        return intCollection.Take(count);
    }

    public IEnumerable<int> TakeLast(int count)
    {
        return intCollection.Reverse().Take(count).Reverse();
    }

    public IEnumerable<int> TakeWhile(Func<int, bool> predicate)
    {
        return intCollection.TakeWhile(predicate);
    }

    // Skip methods
    public IEnumerable<int> SkipFirst(int count)
    {
        return intCollection.Skip(count);
    }

    public IEnumerable<int> SkipLast(int count)
    {
        return intCollection.Reverse().Skip(count).Reverse();
    }

    public IEnumerable<int> SkipWhile(Func<int, bool> predicate)
    {
        return intCollection.SkipWhile(predicate);
    }

    // Methods for collection element operations
    public IEnumerable<int> WhereGreaterThan(int threshold)
    {
        return intCollection.Where(x => x > threshold);
    }

    public IEnumerable<int> OfTypeInt()
    {
        return mixCollection.OfType<int>();
    }
}
