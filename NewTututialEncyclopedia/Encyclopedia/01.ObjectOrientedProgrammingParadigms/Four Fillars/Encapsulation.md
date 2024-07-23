Nkapsupizcja/Hermetyzacja

Modyfikatory dostêpu okreœlaj¹ widocznoœæ metody dla innych klas i obiektów.

- `public`: Metoda jest dostêpna z ka¿dego miejsca.
- `protected`: Metoda jest dostêpna w tej samej klasie i w klasach dziedzicz¹cych.
- `private`: Metoda jest dostêpna tylko w obrêbie tej samej klasy.
- `internal`: Metoda jest dostêpna tylko w tym samym zestawie (assembly).
- `file` :
- `protected internal`: Metoda jest dostêpna w tym samym zestawie i w klasach dziedzicz¹cych.
- `private protected`: Metoda jest dostêpna w tej samej klasie i w klasach dziedzicz¹cych, ale tylko w obrêbie tego samego zestawu (assembly).


### 1. Typy najwy¿szego poziomu
**(klasy, interfejsy, struktury, delegaty)**:
- `public`
- `internal` (Brak modyfikatora - domyœlnie)

### 2. Elementy cz³onkowskie klas i struktur
**(pola, w³aœciwoœci, metody, konstruktory)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`

### 3. Elementy cz³onkowskie interfejsów
- `public` (nie mo¿na jawnie okreœliæ modyfikatora dostêpu)

### 4. Typy zagnie¿d¿one
**(klasy, struktury, interfejsy zagnie¿d¿one)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`


