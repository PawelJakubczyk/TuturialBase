using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututial.Linq;


internal class LinqFilter
    {
    IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    IEnumerable<object> mixColection = [1, "b", 3, "d", 5];

    public IEnumerable<int> whereGreater()
    {
        return intColection.Where(x => x >= 2);
    }    
    public IEnumerable<int> whereTypeInt()
    {
        return mixColection.OfType<int>();
    }    
    public IEnumerable<int> skipFirstTwo()
    {
        return intColection.Skip(2);
    }       
    public IEnumerable<int> TakeFirstTwo()
    {
        return intColection.Take(2);
    }   
}

