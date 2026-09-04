using WarehouseTracker.Logic;

var service = new ProductService();
Console.WriteLine("Товары с количеством меньше 10:");
foreach (var item in service.GetLowStock())
{
    Console.WriteLine($"{item.Id}: {item.Name} - {item.Quantity} шт.");
}
