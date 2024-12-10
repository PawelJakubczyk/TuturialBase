using System;
using System.Diagnostics;

namespace TuturialEncyclopedia.Net.Encyclopedia.Asynchronous_Programming;


//Poprawa responsywności:
//Aplikacje mogą odpowiadać na działania użytkownika nawet podczas wykonywania długotrwałych operacji, takich jak pobieranie danych z sieci czy operacje na plikach.
//Efektywność:
//Wątki nie są blokowane podczas oczekiwania na operacje wejścia/wyjścia (np.odczyt pliku, zapytanie do bazy danych).
//Łatwiejsze zarządzanie konkurencją:
//Operacje równoległe mogą być prostsze w implementacji i zarządzaniu.

//Kluczowe pojęcia
//Task: Reprezentuje jednostkę pracy asynchronicznej.
//Task<TResult>: Reprezentuje jednostkę pracy asynchronicznej, która zwraca wynik.
//async: Oznacza, że metoda zawiera operacje asynchroniczne i może używać await.
//await: Wstrzymuje wykonanie metody, dopóki oczekiwana operacja nie zakończy się.

public sealed class AsynchronousProgramming
{
    //1. Prosta metoda asynchroniczna
    public async Task SayHelloAsync()
    {
        Console.WriteLine("Rozpoczynam operację...");
        await Task.Delay(2000); // Symulacja długotrwałej operacji
        Console.WriteLine("Witaj po 2 sekundach!");
    }

    //2. Metoda zwracająca wartość
    public async Task<int> CalculateAsync(int a, int b)
    {
        await Task.Delay(1000); // Symulacja opóźnienia
        return a + b;
    }

    //3. Obsługa wyjątków w metodach asynchronicznych
    public async Task<string> GetDataAsync()
    {
        try
        {
            await Task.Delay(1000); // Symulacja opóźnienia
            throw new InvalidOperationException("Wystąpił błąd!");
        }
        catch (Exception ex)
        {
            return $"Błąd: {ex.Message}";
        }
    }

    //4. Metoda synchroniczna wywołująca kod asynchroniczny
    public void RunAsyncCodeSynchronously()
    {
        var result = CalculateAsync(5, 10).Result; // Blokuje wątek do zakończenia zadania
        Console.WriteLine($"Wynik to: {result}");
    }

    //5. Uruchamianie wielu zadań jednocześnie
    public async Task DownloadFilesAsync()
    {
        var task1 = Task.Delay(2000); // Symulacja pobierania pliku 1
        var task2 = Task.Delay(3000); // Symulacja pobierania pliku 2
        var task3 = Task.Delay(1000); // Symulacja pobierania pliku 3

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Wszystkie pliki zostały pobrane!");
    }


}