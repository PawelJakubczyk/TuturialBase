namespace Encyclopedia.ClassesExamples.ClassMembers;

public sealed class InstanceFieldsExample
{
    //Pola instancji (Instance Fields):
    //Są to pola, które są związane z instancją klasy.Każdy obiekt klasy ma własną kopię tych pól.
    public int instanceField = 10;
}

public sealed class StaticFieldsExamples2
{
    //Pola statyczne(Static Fields):
    //Są to pola, które są związane z samą klasą, a nie z jej instancjami.Istnieje tylko jedna kopia pola statycznego, wspólna
    //dla wszystkich instancji klasy.
    public static int staticField = 12;
}

public sealed class ReadOnlyFieldsExamples
{
    //Pola tylko do odczytu(Read-Only Fields) :
    //Są to pola, które można przypisać tylko raz, zazwyczaj w konstruktorze klasy lub podczas deklaracji.Po przypisaniu nie
    //można zmieniać ich wartości.
    public readonly int readOnlyField;

    public readonly string readOnlyFieldByDeclaration = "Declaration";

    public ReadOnlyFieldsExamples(int value)
    {
        readOnlyField = value;
    }
}

public sealed class StaticReadOnlyFieldsExamples
{
    // Pola statyczne tylko do odczytu (Static Read-Only Fields):
    // Są to pola statyczne, które można przypisać tylko raz, zazwyczaj w statycznym konstruktorze klasy lub podczas deklaracji.
    // Po przypisaniu nie można zmieniać ich wartości.
    public static readonly string? staticReadOnlyField;

    public static readonly string staticReadOnlyFieldByDeclaration = "Declaration";

    // Statyczny konstruktor do inicjalizacji pola statycznego tylko do odczytu
    static StaticReadOnlyFieldsExamples()
    {
        staticReadOnlyField = "Initialized in static constructor";
    }
}


public class VolatileFieldsExamples
{
    //Pola z modyfikatorem volatile (Volatile Fields):

    //Są to pola, które mogą być modyfikowane przez różne wątki.Słowo kluczowe volatile informuje kompilator, że wartość pola może
    //zmieniać się w sposób nieprzewidywalny, co zapobiega optymalizacjom, które mogłyby zignorować zmiany wartości.
    public volatile int volatileField;
}