namespace ProductInventory.Api.Service;

using System.Collections.Generic;
using ProductInventory.Api.Models;
using ProductInventory.Api.Repositories;



public class ProductServices : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductServices(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Products AddProduct(Products products)
    {
        return _productRepository.Save(products);
    }

    public void DeleteProduct(string id)
    {
        Products products = _productRepository.Get(id);
        _productRepository.RemoveProducts(id);
    }

    public List<Products> GetAllProducts()
    {
            return _productRepository.GetAll();

    }

    public Products GetProduct(string id)
    {
        return _productRepository.Get(id);
    }
    public Products updateProduct(string id, Products products)
    {
        Products dbProduct = _productRepository.Get(id);
        
        if (products.Name != "")
        {
            dbProduct.Name = products.Name;
        }
        Products updateProduct = _productRepository.Save(dbProduct);
        return updateProduct;
    }
    
}

