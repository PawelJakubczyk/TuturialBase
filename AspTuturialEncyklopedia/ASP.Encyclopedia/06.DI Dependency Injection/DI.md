Wbudowany kontener DI, pozwala na rejestracje typ�w jako
abstrakcje pod postaci� interface lub jako konkretn� klas�.
Taki typ po rejestracji, b�dzie mo�liwy do wstrzykni�cia przez
konstruktor dowolnego, innego typu, zarejestrowanego w
kontenerze DI.

Aby zarejestrowa� typ w wbudowanym kontenerze, mo�emy
wykorzysta� jedn� z 3 metod na kolekcji serwis�w, w

S� to:

- AddSingleton

- AddScoped

- AddTransient

W zale�no�ci od wybranej metody, obiekt dostarczany przez
dependency inject, b�dzie mia� r�ne d�ugo�ci �ycia.