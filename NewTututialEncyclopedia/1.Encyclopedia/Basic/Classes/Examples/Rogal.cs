namespace TeddySmithTuturial.Classes.Rogale;

public abstract class RogalBase
{
    protected RogalBase()
    {
        Console.WriteLine("I am base coonstructor");
    } 
    protected RogalBase(string roroor)
    {
        Console.WriteLine($"I am base coonstructor {roroor}");
    } 

    public virtual void Hehe()
    {
        Console.WriteLine("From Rogal Base");
    }

    public abstract void Hehe2();
}


public interface IRogalRepository
{
    void Insert(Rogal rogal);
    void Update(Rogal rogal);
    void GetById(int rogalId);
}


public interface IGoTo
{
    void Go();
}

public interface IMoveTo
{
    void Go();
}

public class RogalService
{
    public void ManageRogal(IRogalRepository rogalRepository)
    {
        Console.WriteLine("dfsdfsd");

        var rogal = new Rogal("Dfdsf");

        rogalRepository.Insert(rogal);
    }
}

public class Michal : IGoTo, IMoveTo
{
    void IGoTo.Go()
    {
        throw new NotImplementedException();
    }

    void IMoveTo.Go()
    {
        throw new NotImplementedException();
    }
}

public class Rogal : RogalBase
{
    public override void Hehe2()
    {
        var sss = new Michal();

        ((IMoveTo)sss).Go();

        Console.WriteLine("dfdf");
    }

    public Rogal(string ddd) : base() 
    {
        Console.WriteLine(ddd);
    }

    public override void Hehe()
    {
        Console.WriteLine("From Rogal");
        base.Hehe();
    }

    private protected string HoloMolo(string momom, int bca = 11, int abc = 34, string message = "Hello") //PROTECTED AND INTERNAL
    {
        return $"{nameof(HoloMolo)}: {message}";
    }

    private protected string CzaroParams(int f, params string[] inputs) //PROTECTED AND INTERNAL
    {
        return $"{nameof(HoloMolo)}";
    }
    
    private protected string CzaroArray(string[] inputs) //PROTECTED AND INTERNAL
    {
        return $"{nameof(HoloMolo)}";
    }

    private protected string GoToGym(int hhehe) //PROTECTED AND INTERNAL
    {
        CzaroArray(["sddS", "dsfsdfds", "dfsdfs"]);
        CzaroParams(4, inputs: ["dfds", "sdfdfs", "dsfsd"]);


        return "hehe" + hhehe.ToString();
    }

    protected internal string GoToGym() // PROTECTED OR INTERNAL
    {
        return GoToGym(0);
    }
}

/*

public
internal
protected
private
protected internal
private protected
file

fields pr
 */