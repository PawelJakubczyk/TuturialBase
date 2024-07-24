namespace Encyclopedia.ClassesExamples;

public sealed class ValidationCandy
{
    private string candyType;

    private ValidationCandy(string type)
    {
        CandyType = type;
    }

    public string[] candyTypes = ["Chocolate", "Gummy", "Lollipop", "Candy Cane", "Marshmallow"];

    public string CandyType
    {
        get { return candyType; }
        set
        {
            if (Array.Exists(candyTypes, type => type == value))
            {
                candyType = value;
            }
            else
            {
                throw new ArgumentException("Invalid candy type.");
            }
        }
    }

    public ValidationCandy Create(string candyType)
    {
        if (candyType == string.Empty)
        {
            throw new Exception("dfdsfs");
        }

        return new ValidationCandy(candyType);
    }

    public ValidationCandy Create(int candyType)
    {
        return Create(candyType.ToString());
    }
}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Candy myCandy = new Candy("Chocolate");
//            Console.WriteLine($"Candy type: {myCandy.CandyType}");

//            Candy invalidCandy = new Candy("Bubblegum"); // This will throw an exception
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}