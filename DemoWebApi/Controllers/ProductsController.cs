using DemoWebApi.Interface.Service;
using DemoWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DemoWebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        Log.Information("GET /api/products endpoint called");
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

    [HttpPost]
    public ActionResult<Product> CreateProduct([FromBody] ProductRequest request)
    {
        Log.Information("POST /api/products endpoint called");
        if (request == null)
        {
            Log.Warning("Invalid request body for POST /api/products");
            return BadRequest("Request body is required.");
        }

        var product = _productService.CreateProduct(request);
        return CreatedAtAction(nameof(GetProducts), null, product);
    }
}
