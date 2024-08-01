using Encyclopedia.ClassesExamples.ClassMembers;
using Encyclopedia.MemmoryExamples;

Console.WriteLine("test");


//// Dodanie elementów bez użycia "using"
//var example1 = new DisableExample();
//example1.AddExpentiationToList(2);
//Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));

//// Dodanie elementów w bloku "using"
//using (var example2 = new DisableExample())
//{
//    example2.AddExpentiationToList(6);
//    Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));
//}

//// Sprawdź listę po zakończeniu bloku "using"
//Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));

//// Dodanie elementów po zakończeniu bloku "using"
//NewMethod();

//Console.WriteLine("rohgkl");


//static void NewMethod()
//{
//    using var example3 = new DisableExample();
//    example3.AddExpentiationToList(5);
//    Console.WriteLine(string.Join(", ", DisableExample.exponentiationList));
//}