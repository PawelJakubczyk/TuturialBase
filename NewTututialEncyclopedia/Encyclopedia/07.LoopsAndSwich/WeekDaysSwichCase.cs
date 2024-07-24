namespace Encyclopedia.LoopsAndSwich;

public enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

public class WeekDaysSwichCase
{
    private string message;

    public string GetDayMessage(Days day)
    {
        switch (day)
        {
            case Days.Sunday:
                message = "Relax, it's Sunday!";
                break;

            case Days.Monday:
                message = "Back to work, it's Monday.";
                break;

            case Days.Tuesday:
                message = "It's Tuesday, keep going!";
                break;

            case Days.Wednesday:
                message = "Halfway there, it's Wednesday.";
                break;

            case Days.Thursday:
                message = "Almost the weekend, it's Thursday.";
                break;

            case Days.Friday:
                message = "It's Friday, weekend is near!";
                break;

            case Days.Saturday:
                message = "Enjoy your Saturday!";
                break;

            default:
                message = "Invalid day!";
                break;
        }
        return message;
    }
}

//class Program
//{
//    static void Main()
//    {
//        WeekDaysSwichCase WeekDaysSwichCase = new WeekDaysSwichCase();

//        foreach (Days day in Enum.GetValues(typeof(Days)))
//        {
//            string message = WeekDaysSwichCase.GetDayMessage(day);
//            Console.WriteLine(message);
//        }
//    }
//}