using System.Collections.Generic;
using WarehouseTracker.Logic;

namespace WarehouseTracker.Data;

public class DemoProductRepository : IProductRepository
{
    public List<Product> GetAll()
    {
        return new List<Product>
        {
            new Product { Id = 100, Name = "Демо-товар 1", Quantity = 5 },
            new Product { Id = 101, Name = "Демо-товар 2", Quantity = 3 }
        };
    }
}