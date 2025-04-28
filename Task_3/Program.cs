using System.Collections;
using Task_3;

var products = new List<Product>
{
    new() { Name = "Apple", Category = "Fruits" },
    new() { Name = "Carrot", Category = "Vegetables" },
    new() { Name = "Banana", Category = "Fruits" },
    new() { Name = "Broccoli", Category = "Vegetables" }
};

var fruits = products.FindAll(x => x.Category == "Fruits");
var vegetables = products.FindAll(x => x.Category == "Vegetables");

Console.WriteLine("Фрукты:");
foreach (var fruit in fruits)
{
    Console.WriteLine(string.Join("\n", fruit));
}

Console.WriteLine("\nОвощи:");
foreach (var vegetable in vegetables)
{
    Console.WriteLine(string.Join("\n", vegetable));
}


;