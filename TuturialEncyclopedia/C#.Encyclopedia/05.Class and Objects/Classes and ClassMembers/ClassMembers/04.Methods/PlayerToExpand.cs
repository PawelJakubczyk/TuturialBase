namespace Encyclopedia.MethodsExamples;

// Extension Classess must be static must expnd sttic class and use this keyword
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