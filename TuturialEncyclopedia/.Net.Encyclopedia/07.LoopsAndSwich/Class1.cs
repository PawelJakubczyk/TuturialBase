using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.LoopsAndSwich;

internal class Class1
{
    private int Point { get; set; }
    private string rank = string.Empty;

    public Class1(int point)
    {
        Point = point;
    }

    public string GetScoreRnk()
    {
        rank = Point switch
        {
            > 10000 => "Diamond",
            > 7500 => "Ruby",
            > 5000 => "Gold",
            > 3500 => "Silver",
            > 1000 => "Bronze",
            > 0 => "iron",
            _ => throw new Exception("Wrong amont of point"),
        };
        return rank;
    }
}