using System.Collections.Generic;

namespace WarehouseTracker.Logic;

public interface IProductRepository
{
    List<Product> GetAll();
    void Add(Product item);
}