
using System.Collections.Generic;
using System.Linq;
using WarehouseTracker.Logic;

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

    public void AddProduct(string name, int quantity)
    {
        if (string.IsNullOrWhiteSpace(name))
            return;

        int nextId = _repository.GetAll().Count + 1;

        _repository.Add(new Product
        {
            Id = nextId,
            Name = name,
            Quantity = quantity
        });
    }
    public int GetTotalQuantity()
    {
        return _repository.GetAll().Sum(p => p.Quantity);
    }
}