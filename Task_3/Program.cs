using System.Collections;
using Task_3;

var products = new List<Product>
{
    new() { Name = "Apple", Category = "Fruits" },
    new() { Name = "Carrot", Category = "Vegetables" },
    new() { Name = "Banana", Category = "Fruits" },
    new() { Name = "Broccoli", Category = "Vegetables" }
};

var fruits = from product in products
                where product.Category == "Fruits"
                    select product;
var vegetables = from product in products
                where product.Category == "Vegetables"
                    select product;

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