namespace ProductInventory.Api.Service;

using System.Collections.Generic;
using AutoMapper;
using ProductInventory.Api.Data.DTOs;
using ProductInventory.Api.Models;
using ProductInventory.Api.Models.Requests;
using ProductInventory.Api.Repositories;
using ProductInventory.Api.Request;

public class ProductServices : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public ProductServices(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;

    }

    public async Task<ProductDto> CreateProduct(CreateProductRequest createProduct)
    {
        var product = _mapper.Map<Products>(createProduct);
        await _productRepository.AddAsync(product);
        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }

    public async Task<IEnumerable<ProductDto>> GetAll()
    {
        var products = await _productRepository.GetProductsAsync();
        var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
        return productDtos;
    }

    public async Task<ProductDto> GetById(Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }

    // public Products AddProduct(Products products)
    // {
    //     return _productRepository.Save(products);
    // }

    // public void DeleteProduct(string id)
    // {
    //     Products products = _productRepository.Get(id);
    //     _productRepository.RemoveProducts(id);
    // }

    // public List<Products> GetAllProducts()
    // {
    //         return _productRepository.GetAll();

    // }

    // public Products GetProduct(string id)
    // {
    //     return _productRepository.Get(id);
    // }
    // public Products UpdateProduct(string id, Products products)
    // {
    //     Products dbProduct = _productRepository.Get(id);
    //     if (dbProduct == null)
    //     {
    //         throw new Exception("Not Found");
    //     }

    //     if (products.Name != "")
    //     {
    //         dbProduct.Name = products.Name;
    //     }
    //     Products updateProduct = _productRepository.UpdateProduct(dbProduct);
    //     return updateProduct;
    // }
    public async Task<ProductDto> UpdateProduct(Guid id, UpdateProductRequest request)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return null;
        }

        _mapper.Map(request, product);
        await _productRepository.UpdateAsync(product);

        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }

    public async Task<bool> DeleteProductAsync(Guid id)
    {
        var product = _productRepository.GetByIdAsync(id);
        if(product is null)
        {
            return false;
        }
        await _productRepository.DeleteAsync(id);
        return true;

    }
    
}

