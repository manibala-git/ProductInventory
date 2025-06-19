namespace ProductInventory.Api.Service;

using ProductInventory.Api.Data.DTOs;
using ProductInventory.Api.Models;
using ProductInventory.Api.Models.Requests;
using ProductInventory.Api.Request;

public interface IProductService
{
    // public Products GetProduct(string id);
    // public Products AddProduct(Products products);
    // public List<Products> GetAllProducts();

    // public void DeleteProduct(string id);
    // public Products UpdateProduct(string id,Products products);
     Task<ProductDto> CreateProduct(CreateProductRequest createProduct);
    Task<IEnumerable<ProductDto>> GetAll();
    Task<ProductDto> GetById(Guid id);


     Task<ProductDto> UpdateProduct(Guid id, UpdateProductRequest request);
    Task<bool> DeleteProductAsync(Guid id);
   
}