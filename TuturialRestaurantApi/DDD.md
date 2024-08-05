

Shopway.App:
    W tej cz�ci znajduje si� warstwa aplikacji. Odpowiada za rejestracj� zale�no�ci i uruchamianie programu. Tutaj definiujemy punkt wej�cia do aplikacji i zarz�dzamy jej cyklem �ycia.

Shopway.Domain:
    To jest warstwa domenowa. Tutaj znajduj� si� modele biznesowe, regu�y biznesowe i logika domenowa. To serce aplikacji, gdzie definiujemy, jak dzia�a nasza domena.

Shopway.Infrastructure:
    Ta cz�� to warstwa infrastruktury. Odpowiada za dost�p do zewn�trznych zasob�w, takich jak baza danych, serwisy sieciowe, pliki itp. Tutaj znajduj� si� implementacje interfejs�w z warstwy domenowej.

Shopway.Persistence:
    To jest warstwa dost�pu do danych. Tutaj definiujemy repozytoria, kt�re komunikuj� si� z baz� danych lub innymi �r�d�ami danych. To miejsce, gdzie realizujemy operacje CRUD (Create, Read, Update, Delete).

Shopway.Presentation:
    Warstwa prezentacji odpowiada za interfejs u�ytkownika. Tutaj znajduj� si� kontrolery, widoki, style, skrypty i inne elementy zwi�zane z wygl�dem i interakcj� z u�ytkownikiem.
