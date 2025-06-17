namespace ProductInventory.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using ProductInventory.Api.Data.DTOs;
using ProductInventory.Api.Data.Response;
using ProductInventory.Api.Models;
using ProductInventory.Api.Models.Requests;
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
     // Adding a Product
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
    {
        var result = await _productService.AddProduct(request);
        if (result == null)
        {
            return BadRequest(new ApiResponse<ProductDto>(false, "Product Creation Failed", null));
        }
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, new ApiResponse<ProductDto>(true, "Product Created Successfully", result));
    }

    // Get List of Products
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _productService.GetAll();
        return Ok(new ApiResponse<IEnumerable<ProductDto>>(true, "Products Fetched Successfully", result));
    }

    // Get a Product by Id
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _productService.GetById(id);
        if (result == null)
        {
            return NotFound(new ApiResponse<ProductDto>(false, "Product Not Found", null));
        }
        return Ok(new ApiResponse<ProductDto>(true, "Product Fetched Successfully", result));
    }

/* 
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
 */
    [HttpPut("{id}")]
    public ActionResult UpdateProduct([FromBody] Products products, string id)
    {
        Products updateProd = _productService.(id, products);
        return Ok(updateProd);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(string id)
    {
        _productService.DeleteProduct(id);
        return Ok("Deleted");
    }
    

}