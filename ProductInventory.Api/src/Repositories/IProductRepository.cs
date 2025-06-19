using ProductInventory.Api.Models;

namespace ProductInventory.Api.Repositories;


public interface IProductRepository
{
    Task<Products> AddAsync(Products product);
    Task<IEnumerable<Products>> GetProductsAsync();
    Task DeleteAsync(Guid id);
    Task<Products> GetByIdAsync(Guid id);
    Task UpdateAsync(Products product);
    
    }

// public interface IProductRepository
// {
//     public Products Save(Products product);
//     public List<Products> GetAll();
//     public Products Get(string id);
//     public Products UpdateProduct(Products products);
//     public Products RemoveProducts(string id);
// }