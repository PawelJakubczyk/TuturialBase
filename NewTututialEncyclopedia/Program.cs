using Classes.ConstructorPerson;
using NewTututialEncyklopedia.Classes;

using System.Text;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NewTututialEncyclopedia._1.Encyclopedia._13.Attribiutes;
using System.Reflection;
using System;

PersonAttribute aPerson = new("John", "Doe", 30, "123 Main St", new DateTime(1990, 1, 1));

Console.WriteLine(aPerson.ToString());
Console.WriteLine(aPerson.FirstName);

PropertyInfo[] properties = typeof(PersonAttribute).GetProperties();

foreach (PropertyInfo property in properties)
{
    Console.WriteLine($"{property.Name}:");
    Console.WriteLine($"  {property.GetValue(aPerson)}");
    Console.WriteLine($"  [{property.GetCustomAttribute<AttributeExamples>()?.DisplayName}]");
    Console.WriteLine();
}














