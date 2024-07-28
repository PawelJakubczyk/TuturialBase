using Encyclopedia.ClassesExamples.ClassMembers;

WeekDaysIndexerExample example = new WeekDaysIndexerExample();

// Pobieranie wartości za pomocą indeksu
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Day {i}: {example[i]}");
}

// Pobieranie wartości za pomocą indeksu większego niż 7
Console.WriteLine($"Day 10: {example[10]}");

// Pobieranie wartości za pomocą indeksu ujemnego
//Console.WriteLine($"Day -1: {example[-1]}");

// Sprawdzanie wartości po zmianie
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Day {i}: {example[i]}");
}