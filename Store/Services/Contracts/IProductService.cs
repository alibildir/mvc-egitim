using System.Linq.Expressions;
using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts;

public interface IProductService
{
    IEnumerable<Product> GetAllProductsWithDetails();
    IEnumerable<Product> GetAllProducts(Expression<Func<Product, bool>> filter = null,
        bool isTracking=false);
    Product? GetOneProduct(int id, bool isTracking=true);
    void CreateOneProduct(ProductDtoForInsertion productDto);
    void UpdateOneProduct(int id, Product product);
    void DeleteOneProduct(int id);
}
