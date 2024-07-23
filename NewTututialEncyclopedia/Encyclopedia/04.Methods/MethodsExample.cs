using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTututial.MethodsExample;


public abstract class AbstaractClass
{
    public virtual void OverrideMethod()
    {
        Console.WriteLine("This is a method to be overridden.");
    }
    
    public virtual void SealedOverrideMethod()
    {
        Console.WriteLine("This is a method to be overridden and seled.");
    }
}

public sealed class MethodsExample : AbstaractClass
{
    // Public method
    public void PublicMethod()
    {
        Console.WriteLine("This is a public method. Anyone can access it.");
    }

    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method. Accessible only within this class.");
    }

    // Protected method
    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method. Accessible within this class and derived classes.");
    }

    // Internal method
    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method. Accessible within the same assembly.");
    }

    // Protected internal method
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("This is a protected internal method. Accessible within the same assembly and derived classes.");
    }

    // Private protected method
    private protected void PrivateProtectedMethod()
    {
        Console.WriteLine("This is a private protected method. Accessible within the same assembly and derived classes.");
    }

    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method. Belongs to the class itself, not instances.");
    }

    // Virtual method
    public override void OverrideMethod()
    {
        Console.WriteLine("This is an overridden method. Overrides a base class method.");
    }

    // Sealed override method
    public sealed override void SealedOverrideMethod()
    {
        Console.WriteLine("This is a sealed overridden method. Prevents further overriding in derived classes.");
    }

    // Asynchronous method
    public async Task AsyncMethod()
    {
        await Task.Delay(1000);
        Console.WriteLine("This is an async method. Performs asynchronous operations.");
    }
}
