**Try-Catch (Obs�uga wyj�tk�w)**:
    - **Definicja**: Try-Catch to mechanizm obs�ugi wyj�tk�w, kt�ry pozwala na przechwytywanie i obs�ug� b��d�w podczas wykonywania programu.
    - **Przyk�ad**:
      ```csharp
      try
      {
          int dzielnik = 0;
          int wynik = 10 / dzielnik;
      }
      catch (DivideByZeroException ex)
      {
          Console.WriteLine("Nie mo�na dzieli� przez zero!");
      }
      ```



