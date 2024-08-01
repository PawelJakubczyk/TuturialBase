Czym Jest C#?
``` 
C# jest jezykiem programowania obiektowego stworzony przez microsoft
```
Czym Jest .Net?
```
.Net jest freamworkiem C# obejmuj¹cym œrodowisko uruchomieniowe
```
.NET, .NET Core, a .NET Framework?


Jakie S¹ 4 Filary Programowania Obiektowego
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
	Klasy i metody powinny byæ odpowiedzialne za jedn¹ funkcjonalnoœæ. 
	To znaczy ¿e powiinny mieæ tylko jeden powód do zmiany.
	
	Zamiast jednej klasy która odpowiada za rejestracje autentykacje 
	i zachowywanie logów u¿ytkowników lepiej jest stworzyæ 3 niezale¿ne 
	klasy

Open/Close Principle
	Klasy powinny byæ zamkniete na modyfikacjiê lecz otwartê na 
	rozszerzenia

	lepiej jest dodaæ przeci¹¿enie do metody uwzglêdniaj¹ce nowe
	warunki ni¿ modyfikowaæ istniejac¹ metode i niepotrzebnie j¹
	rozbudowywaæ

Liscov Principle (Zasada Barbary Liscov)
	Dziedziczenia powinnym mieæ sens i nie implementowæ niepotrzebnych
	funkcjonalnoœci 
	
	je¿eli mamy klase bazow¹ ptak z metod¹ lot dziedziczenie z niej
	klasy Kurczak sprawia ¿e w kurczaku istnieje niepotrzebna b³êdna
	funkcjonalnosc

Interfase Segregation
	Klasy nie powiny implementowaæ interfceów których nie uzywaj¹
	przyk³ad z³a praktyka klasa OnlnieShop oraz LocalShop Implementuj¹
	Intrface IShop który ma kontrakty wspólne dla obu ale tak¿e 
	indywidualne tkie jak pakowanie zakópów dla Shop i Dodawanie do
	koszyka dla Online Shop

	Lepszym rozwi¹zanie jest zrobienie 3 interfejsów IShop maj¹cy tylko
	kontrakty wspólne dla obu klas IOnlineShop dla  kontraktów które ma 
	jedynie OnlineShop i ILocalShop dla kontraktów które ma jedynie
	LocalShop

Dependecy Inversion
	Wysoko poziomowe modu³y nie powinny zale¿eæ od nisko poziomowych
	modu³ów oba powinny zale¿eæ od abstrakcji

	Je¿eli mamy klasy abstrakcyjn¹ Worker i dziedzicz¹c¹ z niej klasy
	Menager i Seller to tworz¹c obiekt na bazie którejœ z tych klas
	dobr¹ prktyk¹ jest przy deklaracji typu odwo³aæ siê do typu 
	abstrakcji a nie do clasy
```
Czym jest Zasada DRY?
```
Zasada Dry czyli don't repeat yourself
	Mówi¹ca o tym by niepowtrzaæ niepotrzebnie kodu na przyk³ad maj¹c
	metode ReColorLogo i metodê ReColorText zamiast implementowaæ
	powtórzony kod do obu metod dobr¹ praktyk¹ jest zrobienie dodatkowej
	metody ReColor z której obie metody bed¹ ko¿ysta³y
```
Czym jest Zasada KISS?
```
Keep It Simple Stupid - zasada wskazuje ¿e dobr¹ praktyk¹ jest uwa¿anie na
to aby kod nie by³ przesadnie skomplikowany. Czêsto proste rozwi¹zania s¹
lepsze ni¿ skomplikowane ponadto przy pracy zespo³owej nale¿y dbaæ o
czytelnoœæ kody tk aby inni mogli go z ³atwosci¹ przeczytac
```
Czym jest Zasada YAGNI?
```
Zasada czyli "You aren't gonna need it" mówi o tym aby nie implementowaæ
funkcjonalnoœci które nie bed¹ w uzyciu. Kod powinien byæ czysty od
niepotrzebnego nieu¿ywnego kodu zwieksza to czytelnoœæ i oszczêdza pamiêæ
```
Czym jest Deklarowanie?
```
Deklarowanie to proces tworzenia zmiennej, sta³ej lub referencji
```
Czym jest Inicjalizowanie?
```
inicjalizacja to proces przypisywania wartoœci do zmiennej/klasy w
momencie jej tworzenia
```
Czym jest Zmienna?
```
Jest to obiekt który mo¿e byæ wype³niony danymi
```
Czym jest Sta³a?
```
jest to obiekt który po zadeklarowaniu wartoœci nie mo¿e ulec zmianie
```
Czym s¹ typy wartoœciowe w C#?
```
Typy wartoœciowe to typy których obiekty zapisuj¹ wartoœci w pamiêci na
stosie
```
Czym s¹ typy referencyjne w C#?
```
Typy referencyjne to typy których obiekty zapisuj¹ wartoœci w pamieci na
stercie i referencje do tych wartoœci na stosie
```
Czym s¹ typy dynamiczne w C#?

Czym s¹ typy wyliczeniowy w jêzyku C#? 

Jaka jest ró¿nica pomiêdzy typami dynamicznymi a wartoœciowymi?

Czym jest Zmienna Wartoœciowa?
```
Jest to specyficzny typ zmiennej który przechowuje wartoœci w pamiêci
Sterty (Stock)
```
Czym jest Zmienna Referencyjna?
```
Jest to specyficzny typ zmiennej który przechowuje wartoœci w Stosie(HIP)
i przechowuje referencje do wartoœci w Stercie(Stock)
```
Czym jest Klasa?
```
Klsa jest szablonem na podstawie którego tworzymy objekt.
```
Czym jest Metoda?
```
Metoda jest to cz³onek kalsy który posiada swoj¹ funkcjonalnoœc
```
Czym jest Boxing w C#

Czym jset unboxing w C#

Czym s¹ wskaŸniki(pointer) w C#?

Co nale¿y wiedzieæ o Garbage Collector?

Czym jest Structura?

Jaki jest cel u¿ywania operatora is w C#?

Jaki jest cel u¿ywania operatora as w C#?

Czym s¹ typy dopuszczaj¹ce wartoœci puste(nullable types) C#?

Jak u¿ywaæ operatorów ? oraz ?? w jêzyku C#?

Czy w jêzyku C# mo¿na utworzyæ metodê, która mo¿e przyjmowaæ zmienn¹ 
liczbê parametrów?

U¿ywaj¹c s³owa kluczowego params mo¿esz przekazaæ dodatkowe parametry?

Która klasa jest klas¹ bazow¹ dla wszystkich tablic(arrays) w jêzyku C#?

Sortowanie tablic w jêzyku C#.
	

Czym s¹ struktury w C#?
	

Jakie s¹ ró¿nice pomiêdzy klas¹ a struktur¹ w C#?
	

Czym jest typ wyliczeniowy(enum) w jêzyku C#?
	

Jaki jest domyœlny modyfikator dostêpu dla klasy?
	

Jaki jest domyœlny modyfikator dostêpu dla sk³adników klasy?
	

Czym jest dziedziczenie w C#?
	

Czy wielokrotne dziedzicznie klas jest mo¿liwe w C#?
	

Czym jest polimorfizm w C#?
	

Czym jest przeci¹¿anie metod w C#?
	

Modyfikator dostêpu Sealed w C#.
	

Jak utworzyæ klasê abstrakcyjn¹ opatrzon¹ modyfikatorem Sealed w C#?
	

Czym s¹ metody wirtualne w jêzyku C#?
	

Czym jest interfejs w C#?
	

Czym s¹ dyrektywy preprocesora w C#?
	

Która klasa jest klas¹ bazow¹ dla wszystkich wyj¹tków w C#?
	

Jaka jest ró¿nica pomiêdzy klas¹ System.ApplicationException oraz klas¹
System.SystemException?

Jaki jest cel u¿ycia klas generycznych w jêzyku C#? 

Co to jest interfejs generyczny? 

Jaka jest rola delegata Predicate w jêzyku C#? 

Jak dodaæ element do listy w C#? 

Jakie s¹ dwie podstawowe operacje, które mo¿na wykonaæ na stosie?

Który blok bêdzie odpowiedzialny za przechwycenie wyj¹tku? 



W jêzyku C#, struktury to wartoœciowe typy danych. Pozwala to na 
przechowywanie ró¿nych wartoœci za pomoc¹ jednej zmiennej. Struktury 
s¹ u¿ywane do reprezentacji rekordów, takich jak informacje o ksi¹¿kach
w bibliotece. Na przyk³ad, mo¿emy stworzyæ strukturê Ksiazka z 
atrybutami, takimi jak tytu³, autor, tematyka i ID ksi¹¿ki. Struktury 
s¹ bardziej efektywne ni¿ klasy, gdy chodzi o przechowywanie danych, 
ale nie maj¹ takiego bogatego zachowania jak klasy


```
Jest to obiekt w jêzyku
```


Czym jest namespace

Czym jest Jagged Array (Zagnie¿dzona tblica)

Na ile sposobów mo¿na przekazaæ parametry do metody?

Czy mo¿na zwróciæ wiele wartoœci z funkcji w C#?

Czym s¹ przestrzenie nazw(namespace) w C#?

Jaki jest cel u¿ywania s³owa kluczowego using w C#?

Jakie s¹ typy komentarzy w C#?

Jakie s¹ rodzaje pêtli w C#?

Jaka jest ró¿nica pomiêdzy pêtl¹ while, a do while?

Jaka jest ró¿nica pomiêdzy s³owem kluczowym continue, a break?

Jaka jest ró¿nica pomiêdzy klas¹ a obiektem?

Jaka jest ró¿nica pomiêdzy deklaracj¹ a inicjalizacj¹?

Wymieñ podstawowe za³o¿enia programowania obiektowego.
Czym jest dziedziczenie, hermetyzacja, abstrakcja, polimorfizm: podaj
przyk³ady (najlepiej z w³asnego doœwiadczenia). Z jakiej klasy niejawnie
dziedzicz¹ wszystkie klasy w .NET? Czy jêzyk C# obs³uguje wielokrotne
dziedziczenie?

Czym jest rekursja?
Czym jest wyra¿enie lambda?
Czym s¹ obliczenia równoleg³e (wielow¹tkowoœæ) i do czego s³u¿¹? Jakie
klasy s¹ stosowane?
Czym jest JSON?
Czym jest REST?
Opowiedz o SPA concept.
Z jakich wzorców projektowych GoF korzysta³eœ?
Na czym polega ró¿nica miêdzy metodami GET i POST HTTP?
Jaki problem rozwi¹zuje Docker? Jakie ma zalety i wady?

Na czym polega zasadnicza ró¿nica miêdzy testami jednostkowe (unit test)
a testami integracyjnymi?

Czym jest Exception?
Do czego s³u¿y try, catch, finaly? W jakim przypadku blok finally nie wykonuje siê?
Czym jest call stack? Jakie znasz s³owa kluczowe?

Czym jest ASP.NET?
Jakie s¹ typy Action filters?
Czym jest Web Service?
Czym jest CLR?
Czym jest Garbage Collection na poziomie podstawowym?
Czym jest delegat?
Czym siê ró¿ni Delegate od Action?
Czym jest LINQ i do czego s³u¿y? Podaj kilka przyk³adów zastosowania LINQ.
Czym jest przestrzeñ nazw (namespace) i do czego s³u¿y?

Jakie znasz typy danych?
Jakie znasz proste typy danych?
Czym jest typ Nullable?
Czym s¹ typy referencyjne i typy wartoœci? Który jest class, a który struct? W jakim obszarze pamiêci s¹ przechowywane?
Czym siê ró¿ni value od reference type? String to reference czy value?
Na czym polega ró¿nica miêdzy string builder i string?
Czym s¹ generyki (generics)? Jakie problemy rozwi¹zuj¹?
Czym jest boxing/unboxing?
Czym jest Array, List, HashSet, Dictionary? Podaj przyk³ady zastosowania wymienionych struktur danych. Na czym polega trudnoœæ operacji (wyszukiwanie, wstawianie i usuwanie)?
Jakie znasz kolekcje?
Do czego s³u¿y operator yield?

Czym jest klasa?
Czym ró¿ni siê klasa od klasy abstrakcyjnej?

Czym ró¿ni siê klasa abstrakcyjna od interfejsu? Do czego s³u¿¹ interfejsy
i jakie zadania wykonuj¹?

Jakie znasz modyfikatory dostêpu?
Na czym polega ró¿nica miêdzy klas¹ zwyk³¹ i statyczn¹?
Na czym polega ró¿nica miêdzy nadpisywaniem metod a s³owami kluczowymi 
new i override?
Na czym polega ró¿nica miêdzy const a read only?
Jaka jest ró¿nica miêdzy struktur¹ a klas¹. Podaj przyk³ady struktur.

Czy mo¿e egzemplarz struktury przechowywaæ siê w stercie (heap)? Jak to 
zrobiæ?