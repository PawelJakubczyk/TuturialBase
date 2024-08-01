Czym Jest C#?
``` 
C# jest jezykiem programowania obiektowego stworzony przez microsoft
```
Czym Jest .Net?
```
.Net jest freamworkiem C# obejmuj�cym �rodowisko uruchomieniowe
```
.NET, .NET Core, a .NET Framework?


Jakie S� 4 Filary Programowania Obiektowego
```
Abstrakcja
Enkapsulacja(Hermetyzacja)
Dziedziczenie
Polimorfizm
```
Czym jest SOLID?
```
SOLID to zestaw programowania obiektowego

Single Responsibility Principle:
	Klasy i metody powinny by� odpowiedzialne za jedn� funkcjonalno��. 
	To znaczy �e powiinny mie� tylko jeden pow�d do zmiany.
	
	Zamiast jednej klasy kt�ra odpowiada za rejestracje autentykacje 
	i zachowywanie log�w u�ytkownik�w lepiej jest stworzy� 3 niezale�ne 
	klasy

Open/Close Principle
	Klasy powinny by� zamkniete na modyfikacji� lecz otwart� na 
	rozszerzenia

	lepiej jest doda� przeci��enie do metody uwzgl�dniaj�ce nowe
	warunki ni� modyfikowa� istniejac� metode i niepotrzebnie j�
	rozbudowywa�

Liscov Principle (Zasada Barbary Liscov)
	Dziedziczenia powinnym mie� sens i nie implementow� niepotrzebnych
	funkcjonalno�ci 
	
	je�eli mamy klase bazow� ptak z metod� lot dziedziczenie z niej
	klasy Kurczak sprawia �e w kurczaku istnieje niepotrzebna b��dna
	funkcjonalnosc

Interfase Segregation
	Klasy nie powiny implementowa� interfce�w kt�rych nie uzywaj�
	przyk�ad z�a praktyka klasa OnlnieShop oraz LocalShop Implementuj�
	Intrface IShop kt�ry ma kontrakty wsp�lne dla obu ale tak�e 
	indywidualne tkie jak pakowanie zak�p�w dla Shop i Dodawanie do
	koszyka dla Online Shop

	Lepszym rozwi�zanie jest zrobienie 3 interfejs�w IShop maj�cy tylko
	kontrakty wsp�lne dla obu klas IOnlineShop dla  kontrakt�w kt�re ma 
	jedynie OnlineShop i ILocalShop dla kontrakt�w kt�re ma jedynie
	LocalShop

Dependecy Inversion
	Wysoko poziomowe modu�y nie powinny zale�e� od nisko poziomowych
	modu��w oba powinny zale�e� od abstrakcji

	Je�eli mamy klasy abstrakcyjn� Worker i dziedzicz�c� z niej klasy
	Menager i Seller to tworz�c obiekt na bazie kt�rej� z tych klas
	dobr� prktyk� jest przy deklaracji typu odwo�a� si� do typu 
	abstrakcji a nie do clasy
```
Czym jest Zasada DRY?
```
Zasada Dry czyli don't repeat yourself
	M�wi�ca o tym by niepowtrza� niepotrzebnie kodu na przyk�ad maj�c
	metode ReColorLogo i metod� ReColorText zamiast implementowa�
	powt�rzony kod do obu metod dobr� praktyk� jest zrobienie dodatkowej
	metody ReColor z kt�rej obie metody bed� ko�ysta�y
```
Czym jest Zasada KISS?
```
Keep It Simple Stupid - zasada wskazuje �e dobr� praktyk� jest uwa�anie na
to aby kod nie by� przesadnie skomplikowany. Cz�sto proste rozwi�zania s�
lepsze ni� skomplikowane ponadto przy pracy zespo�owej nale�y dba� o
czytelno�� kody tk aby inni mogli go z �atwosci� przeczytac
```
Czym jest Zasada YAGNI?
```
Zasada czyli "You aren't gonna need it" m�wi o tym aby nie implementowa�
funkcjonalno�ci kt�re nie bed� w uzyciu. Kod powinien by� czysty od
niepotrzebnego nieu�ywnego kodu zwieksza to czytelno�� i oszcz�dza pami��
```
Czym jest Deklarowanie?
```
Deklarowanie to proces tworzenia zmiennej, sta�ej lub referencji
```
Czym jest Inicjalizowanie?
```
inicjalizacja to proces przypisywania warto�ci do zmiennej/klasy w
momencie jej tworzenia
```
Czym jest Zmienna?
```
Jest to obiekt kt�ry mo�e by� wype�niony danymi
```
Czym jest Sta�a?
```
jest to obiekt kt�ry po zadeklarowaniu warto�ci nie mo�e ulec zmianie
```
Czym s� typy warto�ciowe w C#?
```
Typy warto�ciowe to typy kt�rych obiekty zapisuj� warto�ci w pami�ci na
stosie
```
Czym s� typy referencyjne w C#?
```
Typy referencyjne to typy kt�rych obiekty zapisuj� warto�ci w pamieci na
stercie i referencje do tych warto�ci na stosie
```
Czym s� typy dynamiczne w C#?

Czym s� typy wyliczeniowy w j�zyku C#? 

Jaka jest r�nica pomi�dzy typami dynamicznymi a warto�ciowymi?

Czym jest Zmienna Warto�ciowa?
```
Jest to specyficzny typ zmiennej kt�ry przechowuje warto�ci w pami�ci
Sterty (Stock)
```
Czym jest Zmienna Referencyjna?
```
Jest to specyficzny typ zmiennej kt�ry przechowuje warto�ci w Stosie(HIP)
i przechowuje referencje do warto�ci w Stercie(Stock)
```
Czym jest Klasa?
```
Klsa jest szablonem na podstawie kt�rego tworzymy objekt.
```
Czym jest Metoda?
```
Metoda jest to cz�onek kalsy kt�ry posiada swoj� funkcjonalno�c
```
Czym jest Boxing w C#

Czym jset unboxing w C#

Czym s� wska�niki(pointer) w C#?

Co nale�y wiedzie� o Garbage Collector?

Czym jest Structura?

Jaki jest cel u�ywania operatora is w C#?

Jaki jest cel u�ywania operatora as w C#?

Czym s� typy dopuszczaj�ce warto�ci puste(nullable types) C#?

Jak u�ywa� operator�w ? oraz ?? w j�zyku C#?

Czy w j�zyku C# mo�na utworzy� metod�, kt�ra mo�e przyjmowa� zmienn� 
liczb� parametr�w?

U�ywaj�c s�owa kluczowego params mo�esz przekaza� dodatkowe parametry?

Kt�ra klasa jest klas� bazow� dla wszystkich tablic(arrays) w j�zyku C#?

Sortowanie tablic w j�zyku C#.
	

Czym s� struktury w C#?
	

Jakie s� r�nice pomi�dzy klas� a struktur� w C#?
	

Czym jest typ wyliczeniowy(enum) w j�zyku C#?
	

Jaki jest domy�lny modyfikator dost�pu dla klasy?
	

Jaki jest domy�lny modyfikator dost�pu dla sk�adnik�w klasy?
	

Czym jest dziedziczenie w C#?
	

Czy wielokrotne dziedzicznie klas jest mo�liwe w C#?
	

Czym jest polimorfizm w C#?
	

Czym jest przeci��anie metod w C#?
	

Modyfikator dost�pu Sealed w C#.
	

Jak utworzy� klas� abstrakcyjn� opatrzon� modyfikatorem Sealed w C#?
	

Czym s� metody wirtualne w j�zyku C#?
	

Czym jest interfejs w C#?
	

Czym s� dyrektywy preprocesora w C#?
	

Kt�ra klasa jest klas� bazow� dla wszystkich wyj�tk�w w C#?
	

Jaka jest r�nica pomi�dzy klas� System.ApplicationException oraz klas�
System.SystemException?

Jaki jest cel u�ycia klas generycznych w j�zyku C#? 

Co to jest interfejs generyczny? 

Jaka jest rola delegata Predicate w j�zyku C#? 

Jak doda� element do listy w C#? 

Jakie s� dwie podstawowe operacje, kt�re mo�na wykona� na stosie?

Kt�ry blok b�dzie odpowiedzialny za przechwycenie wyj�tku? 



W j�zyku C#, struktury to warto�ciowe typy danych. Pozwala to na 
przechowywanie r�nych warto�ci za pomoc� jednej zmiennej. Struktury 
s� u�ywane do reprezentacji rekord�w, takich jak informacje o ksi��kach
w bibliotece. Na przyk�ad, mo�emy stworzy� struktur� Ksiazka z 
atrybutami, takimi jak tytu�, autor, tematyka i ID ksi��ki. Struktury 
s� bardziej efektywne ni� klasy, gdy chodzi o przechowywanie danych, 
ale nie maj� takiego bogatego zachowania jak klasy


```
Jest to obiekt w j�zyku
```


Czym jest namespace

Czym jest Jagged Array (Zagnie�dzona tblica)

Na ile sposob�w mo�na przekaza� parametry do metody?

Czy mo�na zwr�ci� wiele warto�ci z funkcji w C#?

Czym s� przestrzenie nazw(namespace) w C#?

Jaki jest cel u�ywania s�owa kluczowego using w C#?

Jakie s� typy komentarzy w C#?

Jakie s� rodzaje p�tli w C#?

Jaka jest r�nica pomi�dzy p�tl� while, a do while?

Jaka jest r�nica pomi�dzy s�owem kluczowym continue, a break?

Jaka jest r�nica pomi�dzy klas� a obiektem?

Jaka jest r�nica pomi�dzy deklaracj� a inicjalizacj�?

Wymie� podstawowe za�o�enia programowania obiektowego.
Czym jest dziedziczenie, hermetyzacja, abstrakcja, polimorfizm: podaj
przyk�ady (najlepiej z w�asnego do�wiadczenia). Z jakiej klasy niejawnie
dziedzicz� wszystkie klasy w .NET? Czy j�zyk C# obs�uguje wielokrotne
dziedziczenie?

Czym jest rekursja?
Czym jest wyra�enie lambda?
Czym s� obliczenia r�wnoleg�e (wielow�tkowo��) i do czego s�u��? Jakie
klasy s� stosowane?
Czym jest JSON?
Czym jest REST?
Opowiedz o SPA concept.
Z jakich wzorc�w projektowych GoF korzysta�e�?
Na czym polega r�nica mi�dzy metodami GET i POST HTTP?
Jaki problem rozwi�zuje Docker? Jakie ma zalety i wady?

Na czym polega zasadnicza r�nica mi�dzy testami jednostkowe (unit test)
a testami integracyjnymi?

Czym jest Exception?
Do czego s�u�y try, catch, finaly? W jakim przypadku blok finally nie wykonuje si�?
Czym jest call stack? Jakie znasz s�owa kluczowe?

Czym jest ASP.NET?
Jakie s� typy Action filters?
Czym jest Web Service?
Czym jest CLR?
Czym jest Garbage Collection na poziomie podstawowym?
Czym jest delegat?
Czym si� r�ni Delegate od Action?
Czym jest LINQ i do czego s�u�y? Podaj kilka przyk�ad�w zastosowania LINQ.
Czym jest przestrze� nazw (namespace) i do czego s�u�y?

Jakie znasz typy danych?
Jakie znasz proste typy danych?
Czym jest typ Nullable?
Czym s� typy referencyjne i typy warto�ci? Kt�ry jest class, a kt�ry struct? W jakim obszarze pami�ci s� przechowywane?
Czym si� r�ni value od reference type? String to reference czy value?
Na czym polega r�nica mi�dzy string builder i string?
Czym s� generyki (generics)? Jakie problemy rozwi�zuj�?
Czym jest boxing/unboxing?
Czym jest Array, List, HashSet, Dictionary? Podaj przyk�ady zastosowania wymienionych struktur danych. Na czym polega trudno�� operacji (wyszukiwanie, wstawianie i usuwanie)?
Jakie znasz kolekcje?
Do czego s�u�y operator yield?

Czym jest klasa?
Czym r�ni si� klasa od klasy abstrakcyjnej?

Czym r�ni si� klasa abstrakcyjna od interfejsu? Do czego s�u�� interfejsy
i jakie zadania wykonuj�?

Jakie znasz modyfikatory dost�pu?
Na czym polega r�nica mi�dzy klas� zwyk�� i statyczn�?
Na czym polega r�nica mi�dzy nadpisywaniem metod a s�owami kluczowymi 
new i override?
Na czym polega r�nica mi�dzy const a read only?
Jaka jest r�nica mi�dzy struktur� a klas�. Podaj przyk�ady struktur.

Czy mo�e egzemplarz struktury przechowywa� si� w stercie (heap)? Jak to 
zrobi�?