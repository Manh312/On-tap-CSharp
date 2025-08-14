using DemoWebApi.Models;

namespace DemoWebApi.Interface.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product CreateProduct(ProductRequest request);
    }
}
