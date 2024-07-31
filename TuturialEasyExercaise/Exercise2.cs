using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise;

internal class Exercise2
{
}


public class DateOfBirth
{
    int DayOfBirth { get; set; }
    int MonthOfBirth { get; set; }
    int YearOfBirth { get; set; }
    DateTime FullDateOfBirth { get; set; }

    public DateOfBirth(int dayOfBirth, int monthOfBirth, int yearOfBirth)
    {
        DayOfBirth = dayOfBirth;
        MonthOfBirth = monthOfBirth;
        YearOfBirth = yearOfBirth;
        FullDateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
    }

    public int GetDaysFromBorn()
    {
        return (int)(FullDateOfBirth - DateTime.Today).TotalDays;
    }
}