namespace Encyclopedia.LinqExamples;

public class LinqSort
{
    private int[] Numbers = [1, 2, 3, 4, 5];

    // Method to sort the array using LINQ
    public void SortUsingLinq()
    {
        // Sorting in ascending order
        var sortedAscending = Numbers.OrderBy(n => n);

        Console.WriteLine("Sorted in ascending order:");
        foreach (var num in sortedAscending)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Sorting in descending order
        var sortedDescending = Numbers.OrderByDescending(n => n);

        Console.WriteLine("Sorted in descending order:");
        foreach (var num in sortedDescending)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}