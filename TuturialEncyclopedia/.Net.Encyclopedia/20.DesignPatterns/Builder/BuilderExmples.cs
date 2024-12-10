namespace Encyclopedia.PatternsExamples;

internal class BuilderExmples
{
    // Builder is a creational design pattern, which allows constructing complex objects step by step.
}
#region House for builder use
public class HouseForBuilder
{
    public int NumberOfFloors { get; set; }
    public double Area { get; set; }

    public string Location { get; set; }

    public HouseForBuilder(int numberOfFloors, double area, string location)
    {
        NumberOfFloors = numberOfFloors;
        Area = area;
        Location = location;
    }
}
#endregion
#region Builder
public class HouseBuilder
{
    private HouseForBuilder house;

    public HouseBuilder()
    {
        house = new HouseForBuilder(0, 0.0, string.Empty);
    }

    public HouseBuilder SetNumberOfFloors(int numberOfFloors)
    {
        house.NumberOfFloors = numberOfFloors;
        return this;
    }

    public HouseBuilder SetArea(double area)
    {
        house.Area = area;
        return this;
    }

    public HouseBuilder SetLocation(string location)
    {
        house.Location = location;
        return this;
    }

    public HouseForBuilder BuildHouse()
    {
        return house;
    }
}
#endregion
#region Build House Example
class BuildHouseExample
{
    static void BuildHouseTest()
    {
        // Create an instance of HouseBuilder
        var houseBuilder = new HouseBuilder();

        // Set house properties
        var house = houseBuilder
            .SetNumberOfFloors(2)
            .SetArea(150.5)
            .SetLocation("Redmond")
            .BuildHouse();

        // Display information about the house
        Console.WriteLine($"The house has {house.NumberOfFloors} floors, {house.Area} m² and is located in {house.Location}.");

        // Another example
        var anotherHouse = houseBuilder
            .SetNumberOfFloors(1)
            .SetArea(100.0)
            .SetLocation("Seattle")
            .BuildHouse();

        Console.WriteLine($"Another house has {anotherHouse.NumberOfFloors} floor, {anotherHouse.Area} m² and is located at {anotherHouse.Location}.");
    }
}
#endregion