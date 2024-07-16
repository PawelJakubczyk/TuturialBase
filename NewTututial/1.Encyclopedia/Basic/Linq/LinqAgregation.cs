using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututial.LinqExamples;

internal class LinqAgregation
{
    IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    IEnumerable<int> secondIntColection = [-3, -2, -1, 0, 1, 2];
    IEnumerable<string> fakeIntColection = ["1", "2", "3", "4"];
    public int CountColectionElements()
    { 
    return intColection.Count();
    }

    
    public int CountColectionElementsWhereElementsAreGreaterThanTwo()
    { 
    return intColection.Where(x=> x>2).Count();
    }

    public int GethigHestInteger()
    {
        return intColection.Max();
    }
    public int GethigHestIntegerByPredicate()
    {
        return secondIntColection.MaxBy(x => x^2);
    }
    
    public int GetLowerInteger()
    {
        return intColection.Min();
    }
    public int GetLowerIntegerByPredicate()
    {
        return secondIntColection.MinBy(x => Math.Sqrt(2));
    }

    public int GetSumOfElemnts()
    {
    return intColection.Sum(); 
    }
    public int GetSumOfElemntsWithPrediction()
    {
    return fakeIntColection.Sum(x => Convert.ToInt32(x)); 
    }

    public double GetAverageOfElemnts()
    {
    return intColection.Average(); 
    }

    public double GetAverageOfElemntsWithPrediction()
    {
    return fakeIntColection.Average(x => Convert.ToInt32(x)); 
    }


}
