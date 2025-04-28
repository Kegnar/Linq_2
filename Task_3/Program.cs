using System.Collections;
using Task_3;

var products = new List<Product>
{
    new() { Name = "Apple", Category = "Fruits" },
    new() { Name = "Carrot", Category = "Vegetables" },
    new() { Name = "Banana", Category = "Fruits" },
    new() { Name = "Broccoli", Category = "Vegetables" }
};

var fruits = products.GroupBy(x => x.Category == "Fruits");
var vegetables = products.GroupBy(x => x.Category == "Vegetables");

Console.WriteLine("Фрукты:");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("Овощи:");
foreach (var vegetable in vegetables)
{
    Console.WriteLine(vegetable);
}


;