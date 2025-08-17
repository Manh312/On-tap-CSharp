using DemoWebApi.Models;

namespace DemoWebApi.Interface.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product CreateProduct(Product product);
    }
}
