# Podzia³ Testów

## I. Rodzaje testów ze wzglêdu na poziomy

#### 1. Testy jednostkowe (Unit Testing)
- **Unit testing**: Testy, które sprawdzaj¹ pojedyncze jednostki kodu, takie jak funkcje, metody lub klasy, w izolacji od innych czêœci systemu. Celem jest weryfikacja, ¿e ka¿da jednostka dzia³a zgodnie z oczekiwaniami.

#### 2. Testy komponentów (Component Testing)
- **Component testing**: Testy, które sprawdzaj¹ poszczególne komponenty lub modu³y aplikacji jako ca³oœæ, w³¹czaj¹c ich zale¿noœci, ale bez integracji z ca³ym systemem. 

#### 3. Testy integracyjne (Integration Testing)
- **Integration testing**: Testy, które sprawdzaj¹, czy ró¿ne modu³y lub komponenty systemu dzia³aj¹ poprawnie po zintegrowaniu ze sob¹. Celem jest wykrycie problemów zwi¹zanych z interakcjami miêdzy komponentami.
- **Web API Test**: Testowanie interfejsów API aplikacji webowych, aby zapewniæ, ¿e komunikacja miêdzy ró¿nymi systemami dzia³a prawid³owo. 

#### 4. Testy end-to-end (E2E Testing)
- **E2E testing**: Testy, które sprawdzaj¹ pe³n¹ œcie¿kê u¿ytkownika w aplikacji, symuluj¹c rzeczywiste scenariusze u¿ycia, od pocz¹tku do koñca, aby zapewniæ, ¿e wszystkie komponenty dzia³aj¹ razem poprawnie.

## II. Testy wydajnoœciowe (Performance Testing)
- **Performance testing**: Ogólna kategoria testów, których celem jest ocena wydajnoœci systemu, w tym czas reakcji, przepustowoœæ, skalowalnoœæ i stabilnoœæ pod ró¿nym obci¹¿eniem.
- **Spike Test**: Test wydajnoœci, który sprawdza, jak system radzi sobie z nag³ymi i drastycznymi wzrostami obci¹¿enia, aby oceniæ jego elastycznoœæ i odpornoœæ.
- **Stress Test**: Test wydajnoœci, który sprawdza, jak system radzi sobie pod ekstremalnym obci¹¿eniem, przekraczaj¹cym normalne operacyjne limity, aby oceniæ jego stabilnoœæ i niezawodnoœæ.
- **Performance Test**: Testy, które sprawdzaj¹ ogóln¹ wydajnoœæ systemu, takie jak czas odpowiedzi, szybkoœæ przetwarzania i efektywnoœæ dzia³ania pod ró¿nymi obci¹¿eniami.

## III. Testy funkcjonalne (Functional Testing)
- **Smoke Test**: Szybkie testy przeprowadzane na nowym buildzie aplikacji, aby upewniæ siê, ¿e podstawowe funkcje dzia³aj¹ poprawnie. Jest to rodzaj testu wstêpnego, który ma na celu wykrycie najpowa¿niejszych problemów.

## IV. Testy akceptacyjne (Acceptance Testing)
- **Acceptance Testing**: Testy, które sprawdzaj¹, czy system spe³nia okreœlone wymagania i oczekiwania u¿ytkowników. Przeprowadzane zazwyczaj przez klienta lub koñcowych u¿ytkowników przed wdro¿eniem systemu do produkcji.

## V. Rodzaje testów ze wzglêdu na formê przeprowadzenia

### 1. Testy manualne (Manual Testing)
- **Manual Testing**: Testy przeprowadzane rêcznie przez testerów, którzy wykonuj¹ przypadki testowe bez u¿ycia narzêdzi automatyzuj¹cych. Pozwala na wykrywanie b³êdów, które mog¹ nie byæ ³atwo wykrywane przez testy automatyczne, takie jak problemy z u¿ytecznoœci¹.

### 2. Testy automatyczne (Automated Testing)
- **Automated Testing**: Testy przeprowadzane za pomoc¹ narzêdzi automatyzuj¹cych, które wykonuj¹ przypadki testowe i porównuj¹ wyniki z oczekiwaniami. Wykorzystuj¹ skrypty i narzêdzia testowe do automatyzacji procesu testowania, co pozwala na szybkie i powtarzalne testowanie du¿ych czêœci aplikacji.
  - **Testowanie oparte na s³owach kluczowych (Keyword-driven Testing)**: Metoda automatyzacji testów, w której u¿ywa siê s³ów kluczowych do reprezentowania akcji do wykonania.
  - **Testowanie oparte na danych (Data-driven Testing)**: Metoda automatyzacji testów, w której testy s¹ wykonywane z ró¿nymi zestawami danych.
- **Testy AI (AI Testing)**: Wykorzystanie sztucznej inteligencji do automatyzacji i optymalizacji procesu testowania.

# Pojecia zwi¹zane z testami

**Test Coverage**: Jaki procent kodu jest pokryty testami

**Mocking**: polega na tworzeniu fikcyjnych obiektów w oparciu o okreœlony interfejs i o ustalonym, zaprojektowanym zachowaniu.

U¿ywamy prób, aby unikn¹æ zale¿noœci lub przetestowaæ ró¿ne przypadki, a nie tylko szczêœliw¹ œcie¿kê.

# Konwencje

Test method should be named in the following manner:

    public void MethodToTest_TestScenario_ExpectedResult()

They should be structured in a following manner:
```
//Arrange

//Act

//Assert
```

# Biblioteki Testowe
```
xUnit
Moq
Fluent Assertion
```

