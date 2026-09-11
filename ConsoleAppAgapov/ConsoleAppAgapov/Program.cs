
using System;
using System.IO;
using WarehouseTracker.Data;
using WarehouseTracker.Logic;

string jsonPath = Path.Combine(AppContext.BaseDirectory, "products.json");
string xmlPath = Path.Combine(AppContext.BaseDirectory, "products.xml");

string kind = args.Length > 0 ? args[0] : "json";

IProductRepository repository = kind switch
{
    "xml" => new XmlProductRepository(xmlPath),
    "memory" => new ProductRepository(),
    _ => new JsonProductRepository(jsonPath)
};

Console.WriteLine($"Хранилище: {kind}");
var service = new ProductService(repository);

Console.WriteLine("Название нового товара: ");
string name = Console.ReadLine() ?? "";
service.AddProduct(name, 5);

Console.WriteLine("Товары с количеством меньше 10:");
foreach (var item in service.GetLowStock())
{
    Console.WriteLine($"{item.Id}: {item.Name} - {item.Quantity} шт.");
}

Console.WriteLine($"Суммарное количество товаров: {service.GetTotalQuantity()}");