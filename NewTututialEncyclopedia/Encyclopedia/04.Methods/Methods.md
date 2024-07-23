### 1. Modyfikatory dost�pu (Access Modifiers)
Modyfikatory dost�pu okre�laj� widoczno�� metody dla innych klas i obiekt�w.

- `public`: Metoda jest dost�pna z ka�dego miejsca.
- `internal`: Metoda jest dost�pna tylko w tym samym zestawie (assembly).
- `protected`: Metoda jest dost�pna w tej samej klasie i w klasach dziedzicz�cych.
- `private`: Metoda jest dost�pna tylko w obr�bie tej samej klasy.
- `protected internal`: Metoda jest dost�pna w tym samym zestawie i w klasach dziedzicz�cych.
- `private protected`: Metoda jest dost�pna w tej samej klasie i w klasach dziedzicz�cych, ale tylko w obr�bie tego samego zestawu (assembly).


### 2. S�owa kluczowe (opcjonalne) (Optional Keywords)
Dodatkowe s�owa kluczowe, kt�re mog� by� u�ywane w deklaracji metody.

- `static`: Metoda nale�y do klasy, a nie do instancji klasy.
- `virtual`: Metoda mo�e by� przes�oni�ta w klasach pochodnych. <span style="color:red">Niedozwolone: private virtual</span>
- `override`: Metoda przes�ania metod� w klasie bazowej. <span style="color:red">Niedozwolone: private override</span>
- `abstract`: Metoda jest deklarowana, ale nie implementowana i musi by� zaimplementowana w klasach pochodnych. <span style="color:red">Niedozwolone: private abstract</span>
- `sealed`: Uniemo�liwia dalsze przes�anianie metody w klasach pochodnych. <span style="color:red">Niedozwolone: private sealed override</span> <span style="color:green">Konieczne: sealed override</span>
- `async`: Metoda wsp�pracuje z operacjami asynchronicznymi.

### 3. Typ zwracany (Return Type)
Typ danych, jaki metoda zwraca.

- Typy podstawowe (Primitive Types): `int`, `float`, `double`, `bool`, `char`, itp.
- Typy z�o�one (Complex Types): `string`, `DateTime`, w�asne typy klas, struktury itp.
- `void`: Metoda nic nie zwraca.
- `Task`, `Task<T>`: Typy u�ywane do metod asynchronicznych.

### 4. Nazwa metody (Method Name)
Zidentyfikowanie metody; powinna by� zgodna z konwencjami nazewnictwa (CamelCase).

### 5. Parametry (Parameters)
Okre�laj� dane wej�ciowe metody.

- Typ (Type): Typ danych parametru (`int`, `string`, `float` itd.).
- Nazwa (Name): Nazwa parametru.
- Parametry opcjonalne (Optional Parameters): Parametry, kt�re maj� warto�ci domy�lne (`int x = 10`).
- Parametry `params`: Pozwalaj� na przekazanie zmiennej liczby argument�w tego samego typu (`params int[] numbers`).
- Parametry `ref` i `out`: Parametry przekazywane przez referencj�.

### 6. Cia�o metody (Method Body)
Blok kodu zawarty w nawiasach klamrowych `{}`, kt�ry okre�la, co metoda robi.
