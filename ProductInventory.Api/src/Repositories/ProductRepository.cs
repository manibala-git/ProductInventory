using Microsoft.AspNetCore.Http.HttpResults;
using ProductInventory.Api.Models;
using ProductInventory.Api.Service;

namespace ProductInventory.Api.Repositories;

public class ProductRepositories : IProductRepository
{
    List<Products> products;
    public ProductRepositories() {
        products = new List<Products>();
    }
    public Products Get(string id)
    {
        var product = products.Find(e => e.Id == id);
        return product;
    }

   public List<Products> GetAll()
{
    return products;
}


    public Products RemoveProducts(string id)
    {
        throw new NotImplementedException();
    }

    public Products Save(Products product)
    {
        products.Add(product);
        return product;
    }

    public Products UpdateProduct(Products products)
    {
        throw new NotImplementedException();
    }
}