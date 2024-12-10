namespace Encyclopedia.LinqExamples;

internal class LinqQuantifier
{
    private IEnumerable<int> intColection = [1, 2, 3, 4, 5];
    private IEnumerable<char> charColection = ['a', 'b', 'c', 'd', 'e'];
    private IEnumerable<object> mixColection = [1, "b", 3, "d", 5];
    private IEnumerable<List<int>> colectionList = [[1, 2, 3, 4], [4, 3, 2, 1]];
    private IEnumerable<object> objectIntColection = [1, 2, 3, 4, 5];

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