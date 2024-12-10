**Lambda (Wyra�enie lambda)**:
    - **Definicja**: Lambda to anonimowa funkcja, kt�ra mo�e by� u�ywana do tworzenia delegat�w lub wyra�e� drzewiastych.
    - **Przyk�ad**:

      ```csharp
      Func<int, int, int> dodaj = (a, b) => a + b;
      Console.WriteLine(dodaj(5, 3)); // Output: 8
      ```