
using System.Collections.Generic;
using System.Linq;
namespace WarehouseTracker.Logic;

public class ProductService
{
    private readonly IProductRepository _repository;  

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<Product> GetLowStock() 
    {
        return _repository.GetAll()
            .Where(item => item.Quantity < 10)
            .ToList();
    }
}