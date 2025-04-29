using Task_5;

var orders = new List<Order>
{
    new Order { Amount = 150.00m },
    new Order { Amount = 200.00m },
    new Order { Amount = 75.00m }
};
var ammount = orders.Sum(o => o.Amount);

Console.WriteLine($"Сумма: {ammount}");