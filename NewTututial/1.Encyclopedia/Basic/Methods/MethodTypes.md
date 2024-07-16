### Types of Methods in C#

1. **Instance Methods** (metody instancji):
   ```csharp
   public void InstanceMethod()
   {
       // Instance methods are associated with instances (objects) of a class or struct.
       // They can access instance variables and other instance methods.
   }
   ```

2. **Static Methods** (Metody Statyczne):
   ```csharp
   public static void StaticMethod()
   {
       // Static methods belong to the type itself rather than instances.
       // They can be called directly on the class without creating an instance.
   }
   ```

3. **Virtual Methods** (Metody wirtualne):
   ```csharp
   public virtual void VirtualMethod()
   {
       // Virtual methods can be overridden in derived classes using the `override` keyword.
       // They allow for polymorphic behavior, where the method called is determined at runtime.
   }
   ```

4. **Abstract Methods** (Metody abstrakcyjne):
   ```csharp
   public abstract void AbstractMethod();
      // Abstract methods do not have an implementation in the base class.
      // They must be overridden in derived classes (`abstract` keyword is used in the base - class).
   ```
   

5. **Methods with Parameters** (Metody z parametrami):
   ```csharp
   public void MethodWithParameters(int param1, string param2)
   {
       // Methods can accept parameters, allowing them to receive data from the caller.
       // Parameters specify the type and name of information that the method can receive.
   }
   ```

6. **Methods with Return Values** (Metody zwracaj¹ce wartoœæ):
   ```csharp
   public int MethodWithReturnValue()
   {
       return 42;
       //Methods can return a value using the `return` keyword followed by the value to be returned.
       //They specify the type of data returned to the caller (`int` in this example).
   }
   ```
   - 

7. **Generic Methods** (Metody generyczne):
   ```csharp
   public T GenericMethod<T>(T input)
   {
       // Generic methods can work with any data type specified at compile time.
       // They use type parameters (`T` in this example) to achieve this flexibility.
   }
   ```

8. **Extension Methods** (Metody rozszerzeñ):
   ```csharp
   public static class StringExtensions
   {
       public static int WordCount(this string str)
       {
           // Extension methods allow adding new methods to existing types without modifying them.
           // They are defined as static methods in static classes and use `this` keyword before the first parameter.
       }
   }
   ```
   - Extension methods enable adding functionality to existing types (`string` in this example).
   - They can be used as if they were methods of the extended type.

9. **Delegates and Anonymous Methods** (Delegaty i metody anonimowe):
   ```csharp
   delegate void Del(string message);
   
   Del handler = delegate (string message) { /* implementation */ };
   ```
   - Delegates are types that define method signatures they can reference.
   - Anonymous methods provide a way to create delegate instances inline without explicitly declaring a separate method.

10. **Asynchronous Methods** (Metody asynchroniczne):
    ```csharp
    public async Task<int> AsyncMethod()
    {
        // Asynchronous methods allow non-blocking execution, suitable for I/O-bound operations.
        // They use the `async` keyword and return `Task` or `Task<T>` to represent asynchronous operations.
    }
    ```

11. **Operator Overloading Methods** (Metody przeci¹¿ania operatorów):
    ```csharp
    public static MyClass operator +(MyClass left, MyClass right)
    {
        // Operator overloading methods redefine the behavior of operators (`+`, `-`, etc.) for user-defined types.
        // They allow custom logic to be executed when operators are used with instances of the class.
    }
    ```

12. **Constructor Methods** (Metody konstruktora):
    ```csharp
    public MyClass(int param)
    {
        // Constructors initialize objects of a class.
        // They can accept parameters to initialize instance variables during object creation.
    }
    ```