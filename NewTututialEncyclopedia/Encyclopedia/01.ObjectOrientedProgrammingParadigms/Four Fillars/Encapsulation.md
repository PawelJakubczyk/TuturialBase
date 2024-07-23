Nkapsupizcja/Hermetyzacja

Modyfikatory dost�pu okre�laj� widoczno�� metody dla innych klas i obiekt�w.

- `public`: Metoda jest dost�pna z ka�dego miejsca.
- `protected`: Metoda jest dost�pna w tej samej klasie i w klasach dziedzicz�cych.
- `private`: Metoda jest dost�pna tylko w obr�bie tej samej klasy.
- `internal`: Metoda jest dost�pna tylko w tym samym zestawie (assembly).
- `file` :
- `protected internal`: Metoda jest dost�pna w tym samym zestawie i w klasach dziedzicz�cych.
- `private protected`: Metoda jest dost�pna w tej samej klasie i w klasach dziedzicz�cych, ale tylko w obr�bie tego samego zestawu (assembly).


### 1. Typy najwy�szego poziomu
**(klasy, interfejsy, struktury, delegaty)**:
- `public`
- `internal` (Brak modyfikatora - domy�lnie)

### 2. Elementy cz�onkowskie klas i struktur
**(pola, w�a�ciwo�ci, metody, konstruktory)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`

### 3. Elementy cz�onkowskie interfejs�w
- `public` (nie mo�na jawnie okre�li� modyfikatora dost�pu)

### 4. Typy zagnie�d�one
**(klasy, struktury, interfejsy zagnie�d�one)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`


