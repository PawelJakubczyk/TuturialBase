

Shopway.App:
    W tej czêœci znajduje siê warstwa aplikacji. Odpowiada za rejestracjê zale¿noœci i uruchamianie programu. Tutaj definiujemy punkt wejœcia do aplikacji i zarz¹dzamy jej cyklem ¿ycia.

Shopway.Domain:
    To jest warstwa domenowa. Tutaj znajduj¹ siê modele biznesowe, regu³y biznesowe i logika domenowa. To serce aplikacji, gdzie definiujemy, jak dzia³a nasza domena.

Shopway.Infrastructure:
    Ta czêœæ to warstwa infrastruktury. Odpowiada za dostêp do zewnêtrznych zasobów, takich jak baza danych, serwisy sieciowe, pliki itp. Tutaj znajduj¹ siê implementacje interfejsów z warstwy domenowej.

Shopway.Persistence:
    To jest warstwa dostêpu do danych. Tutaj definiujemy repozytoria, które komunikuj¹ siê z baz¹ danych lub innymi Ÿród³ami danych. To miejsce, gdzie realizujemy operacje CRUD (Create, Read, Update, Delete).

Shopway.Presentation:
    Warstwa prezentacji odpowiada za interfejs u¿ytkownika. Tutaj znajduj¹ siê kontrolery, widoki, style, skrypty i inne elementy zwi¹zane z wygl¹dem i interakcj¹ z u¿ytkownikiem.
