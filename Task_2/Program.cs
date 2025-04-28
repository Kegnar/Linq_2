
using Task_2;

var books = new List<Book>
{
    new Book { Title = "1984" },
    new Book { Title = "To Kill a Mockingbird" },
    new Book { Title = "The Great Gatsby" }
};
var sorted = books.OrderBy(b => b.Title);
foreach (var item in sorted)
{
    Console.WriteLine(item.Title);
}