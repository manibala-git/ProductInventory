namespace ProductInventory.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using ProductInventory.Api.Models;
using ProductInventory.Api.Service;

[ApiController]
[Route("api/[controller]")]






public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }



    [HttpPost]
    public ActionResult CreateProduct([FromBody] Products products)
    {
        Products newProduct = _productService.AddProduct(products);
        return Ok(newProduct);
    }

    [HttpGet("{id}")]

    public ActionResult GetProduct(string id)
    {

        var product = _productService.GetProduct(id);
        
        return Ok(product);

    }
    [HttpGet]
    public ActionResult GetAllProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

}