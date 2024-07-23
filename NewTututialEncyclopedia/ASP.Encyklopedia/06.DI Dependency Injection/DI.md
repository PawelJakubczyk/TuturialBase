Wbudowany kontener DI, pozwala na rejestracje typów jako
abstrakcje pod postaci¹ interface lub jako konkretn¹ klasê.
Taki typ po rejestracji, bêdzie mo¿liwy do wstrzykniêcia przez
konstruktor dowolnego, innego typu, zarejestrowanego w
kontenerze DI.

Aby zarejestrowaæ typ w wbudowanym kontenerze, mo¿emy
wykorzystaæ jedn¹ z 3 metod na kolekcji serwisów, w

S¹ to:

- AddSingleton

- AddScoped

- AddTransient

W zale¿noœci od wybranej metody, obiekt dostarczany przez
dependency inject, bêdzie mia³ ró¿ne d³ugoœci ¿ycia.