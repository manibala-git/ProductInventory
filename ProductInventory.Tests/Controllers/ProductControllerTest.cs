
using Microsoft.AspNetCore.Mvc;
using ProductInventory.Api.Controllers;
using ProductInventory.Api.Models;
public class ProductControllerTest
{
    [Fact]
    public void ProductAdd_ShouldReturnOK()
    {
        ProductController productController = new ProductController();
        var result = productController.CreateProduct(new Products("101", "Book", "10", 1000.00));
        Assert.IsType<OkObjectResult>(result);
                  
        
    }
}
