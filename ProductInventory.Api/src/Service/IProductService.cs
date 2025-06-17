namespace ProductInventory.Api.Service;

using ProductInventory.Api.Models;

public interface IProductService
{
    public Products GetProduct(string id);
    public Products AddProduct(Products products);
    public List<Products> GetAllProducts();

    public void DeleteProduct(string id);
    public Products updateProduct(string id,Products products);
   
}