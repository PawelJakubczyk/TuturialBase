namespace Exercise.EasyExcercise;

public sealed class Container
{
    public void Add<TInterface, TConcreteImplementation>()
    {
        Console.WriteLine($"Adding to container: interface - {typeof(TInterface).Name}, implementation: {typeof(TConcreteImplementation).Name}");
    }
}