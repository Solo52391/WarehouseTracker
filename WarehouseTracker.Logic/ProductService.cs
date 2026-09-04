using System.Collections.Generic;

namespace WarehouseTracker.Logic;

public class ProductService
{
    private readonly ProductRepository _repository = new();

    public List<Product> GetLowStock()
    {
        return _repository.GetAll()
            .Where(item => item.Quantity < 10)
            .ToList();
    }
}