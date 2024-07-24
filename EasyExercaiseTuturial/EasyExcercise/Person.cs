namespace Exercise.EasyExcercise;

public sealed class Person
{
    private readonly IFileSaver _fileSaver;

    public string Name { get; set; }


    //public Person(IFileSaver fileSaver)
    //{
    //    _fileSaver = fileSaver;
    //}

    //public static Result<Person> Create(string name)
    //{
    //    if (name.StartsWith("Rogal"))
    //    {
    //        return new Result<Person>(null, "name cannot be Rogal");
    //    }

    //    return new Result<Person>(new Person { Name = name }, string.Empty);
    //}

    public void SaveToFile(IFileSaver fileSaver)
    {
        Console.WriteLine("I am saving this person to file");
        fileSaver.Save(this);
    }
}

public interface IFileSaver
{
    void Save(Person person);
}

public sealed class TxtFileSaver : IFileSaver
{
    public void Save(Person person)
    {
        Console.WriteLine("I AM SAVING TO THE TXT");
    }
}