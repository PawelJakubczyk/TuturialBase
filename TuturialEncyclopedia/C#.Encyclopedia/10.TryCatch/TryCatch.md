**Try-Catch (Obs³uga wyj¹tków)**:
    - **Definicja**: Try-Catch to mechanizm obs³ugi wyj¹tków, który pozwala na przechwytywanie i obs³ugê b³êdów podczas wykonywania programu.
    - **Przyk³ad**:
      ```csharp
      try
      {
          int dzielnik = 0;
          int wynik = 10 / dzielnik;
      }
      catch (DivideByZeroException ex)
      {
          Console.WriteLine("Nie mo¿na dzieliæ przez zero!");
      }
      ```



