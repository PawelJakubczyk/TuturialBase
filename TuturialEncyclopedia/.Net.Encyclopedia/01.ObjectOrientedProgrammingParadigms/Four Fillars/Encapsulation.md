Nkapsupizcja/Hermetyzacja

Modyfikatory dostępu określają widoczność metody dla innych klas i obiektów.

- `public`: Metoda jest dostępna z każdego miejsca.
- `internal`: Metoda jest dostępna tylko w tym samym zestawie (assembly).
- `protected`: Metoda jest dostępna w tej samej klasie i w klasach dziedziczących.
- `protected internal`: Metoda jest dostępna w tym samym zestawie i w klasach dziedziczących.
- `private protected`: Metoda jest dostępna w tej samej klasie i w klasach dziedziczących, ale tylko w obrębie tego samego zestawu (assembly).
- `private`: Metoda jest dostępna tylko w obrębie tej samej klasy.

- `file` : Metoda jest dostępna w obrębie pliku


### 1. Typy najwyższego poziomu
**(klasy, interfejsy, struktury, delegaty)**:
- `public`
- `internal` (Brak modyfikatora - domyślnie)

### 2. Elementy członkowskie klas i struktur
**(pola, właściwości, metody, konstruktory)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`

### 3. Elementy członkowskie interfejsów
- `public` (nie można jawnie określić modyfikatora dostępu)

### 4. Typy zagnieżdżone
**(klasy, struktury, interfejsy zagnieżdżone)**:
- `public`
- `protected`
- `private`
- `internal`
- `protected internal`
- `private protected`



| Caller Location                     | public | protected internal | protected | internal | private protected | private |
|-------------------------------------|--------|---------------------|-----------|----------|--------------------|---------|
| Within class (<span style="color:green">same assembly</span>)     |   ✓    |          ✓          |     ✓     |     ✓    |         ✓          |    ✓    |
| Derived class (<span style="color:green">same assembly</span>)    |   ✓    |          ✓          |     ✓     |     ✗    |         ✗          |    ✗    |
| Non-derived class (<span style="color:green">same assembly</span>)|   ✓    |          ✗          |     ✗     |     ✓    |         ✗          |    ✗    |
| Derived class (<span style="color:red">different assembly</span>) |   ✓    |          ✓          |     ✓     |     ✗    |         ✗          |    ✗    |
| Non-derived class (<span style="color:red">different assembly</span>)|  ✓   |          ✗          |     ✗     |     ✗    |         ✗          |    ✗    |
