namespace Encyclopedia.ClassesExamples.ClassMembers;

public sealed class IndexerExamples
{
}

public sealed class ReverseIndexerExample
{
    private readonly int[]? Numbers;

    public int this[int index]
    {
        get { return Numbers[^index]; }
        set => Numbers[^index] = value;
    }

    public ReverseIndexerExample(int[]? numbers)
    {
        Numbers = numbers;
    }
}

public sealed class DictionaryIndexerExample
{
    private readonly Dictionary<string, int> _chessTitles = new Dictionary<string, int>()
    {
        { "CandidateMaster", 2200 },
        { "FIDEMaster", 2300 },
        { "InternationalMaster", 2450 },
        { "Grandmaster", 2600 }
    };

    public int this[string title]
    {
        get
        {
            if (!_chessTitles.TryGetValue(title, out int value))
            {
            throw new KeyNotFoundException($"Title '{title}' not found.");
            }
            return value;
        }
        set
        {
            if (!_chessTitles.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Title '{title}' not found.");
            }
            _chessTitles[title] = value;
        }
    }

    public (string, int) this[int index]
    {
        get
        {
            if (index < 0 || index > _chessTitles.Count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            string title = _chessTitles.ElementAt(index).Key;
            int value = _chessTitles[title];
            return (title, value);
        }
        set
        {
            if (index < 0 || index >= _chessTitles.Count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            var oldEntry = _chessTitles.ElementAt(index);
            _chessTitles.Remove(oldEntry.Key);
            _chessTitles.Add(value.Item1, value.Item2);
        }
    }
}

public sealed class WeekDaysIndexerExample
{
    private readonly string[] WeekDays =
        [
        "Sunday",
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday"
        ];

    public string this[int index] => GetDayOfTheWeek(index);

    private string GetDayOfTheWeek(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }
        return WeekDays[(index % WeekDays.Length)];
    }
}