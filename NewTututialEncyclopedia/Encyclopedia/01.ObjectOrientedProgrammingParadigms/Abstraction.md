
##EN

| **Abstract Class** | **Interface** |
|-------------------|---------------|
| It contains both declaration and implementation parts. | It contains only the declaration of methods, properties, events, or indexers. Since C# 8, default implementations can also be included in interfaces. |
| Multiple inheritance is not achieved by abstract class. | Multiple inheritance is achieved by interface. |
| It contains constructor. | It does not contain constructor. |
| It can contain static members. | It does not contain static members. |
| It can contain different types of access modifiers like public, private, protected etc. | It only contains public access modifier because everything in the interface is public. |
| The performance of an abstract class is fast. | The performance of interface is slow because it requires time to search actual method in the corresponding class. |
| It is used to implement the core identity of class. | It is used to implement peripheral abilities of class. |
| A class can only use one abstract class. | A class can use multiple interface. |
| If many implementations are of the same kind and use common behavior, then it is superior to use abstract class. | If many implementations only share methods, then it is superior to use Interface. |
| Abstract class can contain methods, fields, constants, etc. | Interface can only contains methods, properties, indexers, events. |
| The keyword “:” can be used for implementing the Abstract class. | The keyword “:” and “,” can be used for implementing the Interface. |
| It can be fully, partially or not implemented. | It should be fully implemented. |
| To declare abstract class, we use abstract keyword. | To declare interface, we use interface keyword. |

##PL

| **Klasa abstrakcyjna** | **Interfejs** |
|-----------------------|---------------|
| Zawiera zarówno deklaracje, jak i implementacje metod. | Zawiera tylko deklaracje metod, w³aœciwoœci, zdarzeñ lub indeksatorów. Od C# 8, mog¹ równie¿ zawieraæ domyœlne implementacje. |
| Nie obs³uguje dziedziczenia wielokrotnego. | Obs³uguje dziedziczenie wielokrotne. |
| Zawiera konstruktor. | Nie zawiera konstruktora. |
| Mo¿e zawieraæ elementy statyczne. | Nie zawiera elementów statycznych. |
| Mo¿e zawieraæ ró¿ne modyfikatory dostêpu, takie jak public, private, protected itp. | Zawiera tylko modyfikator dostêpu public, poniewa¿ wszystko w interfejsie jest publiczne. |
| Wydajnoœæ klasy abstrakcyjnej jest wysoka. | Wydajnoœæ interfejsu jest ni¿sza, poniewa¿ wymaga czasu na wyszukanie rzeczywistej metody w odpowiedniej klasie. |
| Jest u¿ywana do implementacji podstawowej to¿samoœci klasy. | Jest u¿ywany do implementacji dodatkowych zdolnoœci klasy. |
| Klasa mo¿e dziedziczyæ tylko jedn¹ klasê abstrakcyjn¹. | Klasa mo¿e implementowaæ wiele interfejsów. |
| Jeœli wiele implementacji jest tego samego rodzaju i u¿ywa wspólnego zachowania, lepiej u¿yæ klasy abstrakcyjnej. | Jeœli wiele implementacji tylko dzieli metody, lepiej u¿yæ interfejsu. |
| Klasa abstrakcyjna mo¿e zawieraæ metody, pola, sta³e itp. | Interfejs mo¿e zawieraæ tylko metody, w³aœciwoœci, indeksatory i zdarzenia. |
| S³owo kluczowe „:” jest u¿ywane do dziedziczenia klasy abstrakcyjnej. | S³owa kluczowe „:” i „,” s¹ u¿ywane do implementacji interfejsu. |
| Mo¿e byæ w pe³ni, czêœciowo lub w ogóle nie zaimplementowana. | Musi byæ w pe³ni zaimplementowany. |
| Do deklaracji klasy abstrakcyjnej u¿ywamy s³owa kluczowego abstract. | Do deklaracji interfejsu u¿ywamy s³owa kluczowego interface. |
