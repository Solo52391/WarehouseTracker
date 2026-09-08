using System.Collections.Generic;
using WarehouseTracker.Logic;
namespace WarehouseTracker.Data;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _items = new()
    {
        new Product { Id = 1, Name = "Ноутбук", Quantity = 5 },
        new Product { Id = 2, Name = "Мышь", Quantity = 15 },
        new Product { Id = 3, Name = "Клавиатура", Quantity = 8 },
        new Product { Id = 4, Name = "Монитор", Quantity = 3 }
    };

    public List<Product> GetAll()
    {
        return _items;
    }
}