using System;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ProductInventory.Api.Data;
using ProductInventory.Api.Models;
using ProductInventory.Api.Service;

namespace ProductInventory.Api.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Products> AddAsync(Products product)
    {
        await _context.products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<IEnumerable<Products>> GetProductsAsync()
    {
        return await _context.products.ToListAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var product = await _context.products.FindAsync(id);
        if (product is null)
        {
            return;
        }

        _context.products.Remove(product);
        await _context.SaveChangesAsync();
        return;
    }



    public async Task<Products> GetByIdAsync(Guid id)
    {
        return await _context.products.FindAsync(id)!;
    }
    

    public async Task UpdateAsync(Products product)
    {
        var existingProduct = await _context.products.FindAsync(product.Id);
        if (existingProduct is null)
        {
            throw new KeyNotFoundException("Product not found");
        }

        _context.Entry(existingProduct).CurrentValues.SetValues(product);
        await _context.SaveChangesAsync();
    }

}