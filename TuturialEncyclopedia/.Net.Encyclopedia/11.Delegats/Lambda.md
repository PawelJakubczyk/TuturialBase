**Lambda (Wyra¿enie lambda)**:
    - **Definicja**: Lambda to anonimowa funkcja, która mo¿e byæ u¿ywana do tworzenia delegatów lub wyra¿eñ drzewiastych.
    - **Przyk³ad**:

      ```csharp
      Func<int, int, int> dodaj = (a, b) => a + b;
      Console.WriteLine(dodaj(5, 3)); // Output: 8
      ```