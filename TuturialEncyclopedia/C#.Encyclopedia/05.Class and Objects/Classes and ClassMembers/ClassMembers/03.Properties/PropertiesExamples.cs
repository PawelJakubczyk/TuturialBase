namespace Encyclopedia.ClassesExamples.ClassMembers;

public sealed class AutoImplementedPropertiesExamples
{
        public string? Name
        { get; set; }

        public double Price
        { get; set; }
}

public sealed class AutoImplementedPropertiesExamplesTest
{
    private AutoImplementedPropertiesExamples test = new() { Name = "orange", Price = 13.22 };
}


public sealed class CheckAutoImplementedPropertiesExamples
{
    public string? Name
    { get; set; }

    public decimal Price
    { get; set; }

    public CheckAutoImplementedPropertiesExamples(string? name, decimal price)
    {
        Name = name;
        Price = price;
    }
}



public sealed class CheckAutoImplementedPropertiesExamplesTest
{

}