### 1. Modyfikatory dostêpu (Access Modifiers)
Modyfikatory dostêpu okreœlaj¹ widocznoœæ metody dla innych klas i obiektów.

- `public`: Metoda jest dostêpna z ka¿dego miejsca.
- `internal`: Metoda jest dostêpna tylko w tym samym zestawie (assembly).
- `protected`: Metoda jest dostêpna w tej samej klasie i w klasach dziedzicz¹cych.
- `private`: Metoda jest dostêpna tylko w obrêbie tej samej klasy.
- `protected internal`: Metoda jest dostêpna w tym samym zestawie i w klasach dziedzicz¹cych.
- `private protected`: Metoda jest dostêpna w tej samej klasie i w klasach dziedzicz¹cych, ale tylko w obrêbie tego samego zestawu (assembly).


### 2. S³owa kluczowe (opcjonalne) (Optional Keywords)
Dodatkowe s³owa kluczowe, które mog¹ byæ u¿ywane w deklaracji metody.

- `static`: Metoda nale¿y do klasy, a nie do instancji klasy.
- `virtual`: Metoda mo¿e byæ przes³oniêta w klasach pochodnych. <span style="color:red">Niedozwolone: private virtual</span>
- `override`: Metoda przes³ania metodê w klasie bazowej. <span style="color:red">Niedozwolone: private override</span>
- `abstract`: Metoda jest deklarowana, ale nie implementowana i musi byæ zaimplementowana w klasach pochodnych. <span style="color:red">Niedozwolone: private abstract</span>
- `sealed`: Uniemo¿liwia dalsze przes³anianie metody w klasach pochodnych. <span style="color:red">Niedozwolone: private sealed override</span> <span style="color:green">Konieczne: sealed override</span>
- `async`: Metoda wspó³pracuje z operacjami asynchronicznymi.

### 3. Typ zwracany (Return Type)
Typ danych, jaki metoda zwraca.

- Typy podstawowe (Primitive Types): `int`, `float`, `double`, `bool`, `char`, itp.
- Typy z³o¿one (Complex Types): `string`, `DateTime`, w³asne typy klas, struktury itp.
- `void`: Metoda nic nie zwraca.
- `Task`, `Task<T>`: Typy u¿ywane do metod asynchronicznych.

### 4. Nazwa metody (Method Name)
Zidentyfikowanie metody; powinna byæ zgodna z konwencjami nazewnictwa (CamelCase).

### 5. Parametry (Parameters)
Okreœlaj¹ dane wejœciowe metody.

- Typ (Type): Typ danych parametru (`int`, `string`, `float` itd.).
- Nazwa (Name): Nazwa parametru.
- Parametry opcjonalne (Optional Parameters): Parametry, które maj¹ wartoœci domyœlne (`int x = 10`).
- Parametry `params`: Pozwalaj¹ na przekazanie zmiennej liczby argumentów tego samego typu (`params int[] numbers`).
- Parametry `ref` i `out`: Parametry przekazywane przez referencjê.

### 6. Cia³o metody (Method Body)
Blok kodu zawarty w nawiasach klamrowych `{}`, który okreœla, co metoda robi.
