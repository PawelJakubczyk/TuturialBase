namespace Encyclopedia.LinqExamples;

internal class LinqAgregation
{
    private IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    private IEnumerable<int> secondIntColection = [-3, -2, -1, 0, 1, 2];
    private IEnumerable<string> fakeIntColection = ["1", "2", "3", "4"];

    public int CountColectionElements()
    {
        return intColection.Count();
    }

    public int CountColectionElementsWhereElementsAreGreaterThanTwo()
    {
        return intColection.Where(x => x > 2).Count();
    }

    public int GethigHestInteger()
    {
        return intColection.Max();
    }

    public int GethigHestIntegerByPredicate()
    {
        return secondIntColection.MaxBy(x => x ^ 2);
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