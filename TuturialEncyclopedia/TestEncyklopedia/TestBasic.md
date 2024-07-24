# Podzia� Test�w

## I. Rodzaje test�w ze wzgl�du na poziomy

#### 1. Testy jednostkowe (Unit Testing)
- **Unit testing**: Testy, kt�re sprawdzaj� pojedyncze jednostki kodu, takie jak funkcje, metody lub klasy, w izolacji od innych cz�ci systemu. Celem jest weryfikacja, �e ka�da jednostka dzia�a zgodnie z oczekiwaniami.

#### 2. Testy komponent�w (Component Testing)
- **Component testing**: Testy, kt�re sprawdzaj� poszczeg�lne komponenty lub modu�y aplikacji jako ca�o��, w��czaj�c ich zale�no�ci, ale bez integracji z ca�ym systemem. 

#### 3. Testy integracyjne (Integration Testing)
- **Integration testing**: Testy, kt�re sprawdzaj�, czy r�ne modu�y lub komponenty systemu dzia�aj� poprawnie po zintegrowaniu ze sob�. Celem jest wykrycie problem�w zwi�zanych z interakcjami mi�dzy komponentami.
- **Web API Test**: Testowanie interfejs�w API aplikacji webowych, aby zapewni�, �e komunikacja mi�dzy r�nymi systemami dzia�a prawid�owo. 

#### 4. Testy end-to-end (E2E Testing)
- **E2E testing**: Testy, kt�re sprawdzaj� pe�n� �cie�k� u�ytkownika w aplikacji, symuluj�c rzeczywiste scenariusze u�ycia, od pocz�tku do ko�ca, aby zapewni�, �e wszystkie komponenty dzia�aj� razem poprawnie.

## II. Testy wydajno�ciowe (Performance Testing)
- **Performance testing**: Og�lna kategoria test�w, kt�rych celem jest ocena wydajno�ci systemu, w tym czas reakcji, przepustowo��, skalowalno�� i stabilno�� pod r�nym obci��eniem.
- **Spike Test**: Test wydajno�ci, kt�ry sprawdza, jak system radzi sobie z nag�ymi i drastycznymi wzrostami obci��enia, aby oceni� jego elastyczno�� i odporno��.
- **Stress Test**: Test wydajno�ci, kt�ry sprawdza, jak system radzi sobie pod ekstremalnym obci��eniem, przekraczaj�cym normalne operacyjne limity, aby oceni� jego stabilno�� i niezawodno��.
- **Performance Test**: Testy, kt�re sprawdzaj� og�ln� wydajno�� systemu, takie jak czas odpowiedzi, szybko�� przetwarzania i efektywno�� dzia�ania pod r�nymi obci��eniami.

## III. Testy funkcjonalne (Functional Testing)
- **Smoke Test**: Szybkie testy przeprowadzane na nowym buildzie aplikacji, aby upewni� si�, �e podstawowe funkcje dzia�aj� poprawnie. Jest to rodzaj testu wst�pnego, kt�ry ma na celu wykrycie najpowa�niejszych problem�w.

## IV. Testy akceptacyjne (Acceptance Testing)
- **Acceptance Testing**: Testy, kt�re sprawdzaj�, czy system spe�nia okre�lone wymagania i oczekiwania u�ytkownik�w. Przeprowadzane zazwyczaj przez klienta lub ko�cowych u�ytkownik�w przed wdro�eniem systemu do produkcji.

## V. Rodzaje test�w ze wzgl�du na form� przeprowadzenia

### 1. Testy manualne (Manual Testing)
- **Manual Testing**: Testy przeprowadzane r�cznie przez tester�w, kt�rzy wykonuj� przypadki testowe bez u�ycia narz�dzi automatyzuj�cych. Pozwala na wykrywanie b��d�w, kt�re mog� nie by� �atwo wykrywane przez testy automatyczne, takie jak problemy z u�yteczno�ci�.

### 2. Testy automatyczne (Automated Testing)
- **Automated Testing**: Testy przeprowadzane za pomoc� narz�dzi automatyzuj�cych, kt�re wykonuj� przypadki testowe i por�wnuj� wyniki z oczekiwaniami. Wykorzystuj� skrypty i narz�dzia testowe do automatyzacji procesu testowania, co pozwala na szybkie i powtarzalne testowanie du�ych cz�ci aplikacji.
  - **Testowanie oparte na s�owach kluczowych (Keyword-driven Testing)**: Metoda automatyzacji test�w, w kt�rej u�ywa si� s��w kluczowych do reprezentowania akcji do wykonania.
  - **Testowanie oparte na danych (Data-driven Testing)**: Metoda automatyzacji test�w, w kt�rej testy s� wykonywane z r�nymi zestawami danych.
- **Testy AI (AI Testing)**: Wykorzystanie sztucznej inteligencji do automatyzacji i optymalizacji procesu testowania.

# Pojecia zwi�zane z testami

**Test Coverage**: Jaki procent kodu jest pokryty testami

**Mocking**: polega na tworzeniu fikcyjnych obiekt�w w oparciu o okre�lony interfejs i o ustalonym, zaprojektowanym zachowaniu.

U�ywamy pr�b, aby unikn�� zale�no�ci lub przetestowa� r�ne przypadki, a nie tylko szcz�liw� �cie�k�.

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

