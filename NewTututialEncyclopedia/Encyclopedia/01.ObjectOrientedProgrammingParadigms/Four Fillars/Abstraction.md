
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
| The keyword �:� can be used for implementing the Abstract class. | The keyword �:� and �,� can be used for implementing the Interface. |
| It can be fully, partially or not implemented. | It should be fully implemented. |
| To declare abstract class, we use abstract keyword. | To declare interface, we use interface keyword. |

##PL

| **Klasa abstrakcyjna** | **Interfejs** |
|-----------------------|---------------|
| Zawiera zar�wno deklaracje, jak i implementacje metod. | Zawiera tylko deklaracje metod, w�a�ciwo�ci, zdarze� lub indeksator�w. Od C# 8, mog� r�wnie� zawiera� domy�lne implementacje. |
| Nie obs�uguje dziedziczenia wielokrotnego. | Obs�uguje dziedziczenie wielokrotne. |
| Zawiera konstruktor. | Nie zawiera konstruktora. |
| Mo�e zawiera� elementy statyczne. | Nie zawiera element�w statycznych. |
| Mo�e zawiera� r�ne modyfikatory dost�pu, takie jak public, private, protected itp. | Zawiera tylko modyfikator dost�pu public, poniewa� wszystko w interfejsie jest publiczne. |
| Wydajno�� klasy abstrakcyjnej jest wysoka. | Wydajno�� interfejsu jest ni�sza, poniewa� wymaga czasu na wyszukanie rzeczywistej metody w odpowiedniej klasie. |
| Jest u�ywana do implementacji podstawowej to�samo�ci klasy. | Jest u�ywany do implementacji dodatkowych zdolno�ci klasy. |
| Klasa mo�e dziedziczy� tylko jedn� klas� abstrakcyjn�. | Klasa mo�e implementowa� wiele interfejs�w. |
| Je�li wiele implementacji jest tego samego rodzaju i u�ywa wsp�lnego zachowania, lepiej u�y� klasy abstrakcyjnej. | Je�li wiele implementacji tylko dzieli metody, lepiej u�y� interfejsu. |
| Klasa abstrakcyjna mo�e zawiera� metody, pola, sta�e itp. | Interfejs mo�e zawiera� tylko metody, w�a�ciwo�ci, indeksatory i zdarzenia. |
| S�owo kluczowe �:� jest u�ywane do dziedziczenia klasy abstrakcyjnej. | S�owa kluczowe �:� i �,� s� u�ywane do implementacji interfejsu. |
| Mo�e by� w pe�ni, cz�ciowo lub w og�le nie zaimplementowana. | Musi by� w pe�ni zaimplementowany. |
| Do deklaracji klasy abstrakcyjnej u�ywamy s�owa kluczowego abstract. | Do deklaracji interfejsu u�ywamy s�owa kluczowego interface. |
