using System;
using WarehouseTracker.Data;
using WarehouseTracker.Logic;

IProductRepository repository = new ProductRepository();

var service = new ProductService(repository);

Console.WriteLine("Товары с количеством меньше 10:");
foreach (var item in service.GetLowStock())
{
    Console.WriteLine($"{item.Id}: {item.Name} - {item.Quantity} шт.");  
}

