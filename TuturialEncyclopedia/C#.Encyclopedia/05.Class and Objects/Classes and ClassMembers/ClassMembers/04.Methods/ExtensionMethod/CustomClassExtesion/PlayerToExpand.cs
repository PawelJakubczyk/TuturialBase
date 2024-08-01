namespace Encyclopedia.MethodsExamples.Extensions;

public class PlayerToExpand
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Level { get; set; }

    public void PlayGame()
    {
        Console.WriteLine("I am playing game");
    }
}