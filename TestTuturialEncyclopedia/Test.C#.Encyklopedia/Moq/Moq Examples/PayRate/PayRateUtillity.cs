namespace TestTuturialEncyclopedia.Test.C_.Encyklopedia.Moq.Moq_Examples;

public interface IDateTimeProvider
{
    DayOfWeek TodayDay();
}

public class PayRateUtility: IDateTimeProvider
{

    public decimal GetPayRate(decimal baseRate)
    {
        if (TodayDay() == DayOfWeek.Sunday)
        {
            return baseRate;
        }
        return baseRate * 1.25m;
    }

    public virtual DayOfWeek TodayDay() 
    {
        return DateTime.Now.DayOfWeek;
    }
}

//Before:
//public class PayRateUtility
//{
//    public decimal GetPayRate(decimal baseRate)
//    {
//        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
//        {
//            return baseRate;
//        }
//        return baseRate * 1.25m;
//    }
//}