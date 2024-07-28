namespace Encyclopedia.ClassesExamples.ClassMembers;





public sealed class AutoImplementedPropertiesExamples
{
        public string? Name
        { get; set; }

        public decimal Price
        { get; set; }

    //Constructor will be set automaticly
    //public AutoImplementedPropertiesExamples(string? name, decimal price)
    //{
    //    Name = name;
    //    Price = price;
    //}
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
