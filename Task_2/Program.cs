
using Task_2;

var books = new List<Book>
{
    new Book { Title = "1984" },
    new Book { Title = "To Kill a Mockingbird" },
    new Book { Title = "The Great Gatsby" }
};
var sorted = from book in books
                                    orderby book.Title ascending    
                                    select book;
foreach (var book in sorted)
{
    Console.WriteLine(book.Title);
}
