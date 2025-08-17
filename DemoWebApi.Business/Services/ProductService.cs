using DemoWebApi.Interface.IRepository;
using DemoWebApi.Interface.Service;
using DemoWebApi.Models;
using Serilog;

namespace DemoWebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            Log.Information("Fetching all products");
            return _repository.GetAllProducts();
        }

        public Product CreateProduct(ProductRequest request)
        {
            Log.Information("Creating new product with request: {Request}", System.Text.Json.JsonSerializer.Serialize(request));
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            };
            var createdProduct = _repository.CreateProduct(product);
            Log.Information("Product created successfully: {Product}", System.Text.Json.JsonSerializer.Serialize(createdProduct));
            return createdProduct;
        }
    }
}
