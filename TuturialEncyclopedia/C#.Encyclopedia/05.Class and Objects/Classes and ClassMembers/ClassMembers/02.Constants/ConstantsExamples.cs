namespace Encyclopedia.ClassesExamples.ClassMembers;

public sealed class ConstantsExamples
{
    //Stałe(const)
    //Stałe są niezmienne i ich wartość musi być przypisana w czasie kompilacji.Stałe są statyczne z natury, co oznacza,
    //że są współdzielone przez wszystkie instancje klasy i nie można ich zmieniać po przypisaniu.
    public const int Months = 12, Weeks = 52, Days = 365;

    //Wartość musi być znana w czasie kompilacji.
    //Są niezmienne po przypisaniu.
    //Są domyślnie statyczne, więc nie można użyć modyfikatora static z const.
    //Można je stosować tylko do typów prymitywnych(np. int, float, double, char) oraz typów niezmiennych(np. string).
}

// Dla porównania
public sealed class ReadOnlyForCompareFieldsExamples
{
    //Pola tylko do odczytu(Read-Only Fields) :
    //Są to pola, które można przypisać tylko raz, zazwyczaj w konstruktorze klasy lub podczas deklaracji.Po przypisaniu nie
    //można zmieniać ich wartości.
    public readonly int readOnlyField;

    public readonly string readOnlyFieldByDeclaration = "Declaration";

    public ReadOnlyForCompareFieldsExamples(int value)
    {
        readOnlyField = value;
    }
    //Wartość może być przypisana w czasie kompilacji lub w konstruktorze.
    //Są niezmienne po przypisaniu, ale można je przypisać różnym wartościom dla różnych instancji klasy.
    //Mogą być używane zarówno z polami instancji, jak i statycznymi.
    //Mogą być używane do dowolnych typów, w tym do obiektów.
}