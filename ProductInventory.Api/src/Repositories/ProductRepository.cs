using Microsoft.AspNetCore.Http.HttpResults;
using ProductInventory.Api.Data;
using ProductInventory.Api.Models;
using ProductInventory.Api.Service;

namespace ProductInventory.Api.Repositories;

public class ProductRepositories : IProductRepository
{
    // List<Products> products;
    public ApplicationDbContext _context;
    public ProductRepositories(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }
    public Products Get(string id)
    {
        Products products = _context.products.Find(id);
        return products;
    }

   public List<Products> GetAll()
{
    return _context.products.ToList<Products>();
}


    public Products RemoveProducts(string id)
    {
        var product = Get(id);
        _context.products.Remove(product);
        _context.SaveChanges();
        return product;

    }

    public Products Save(Products product)
    {
        _context.products.Add(product);
        _context.SaveChanges();
        return product;
    }

    public Products UpdateProduct(Products products)
    {
        _context.Entry(products).CurrentValues.SetValues(products);
        _context.SaveChanges();
        return products;
        
    }
}