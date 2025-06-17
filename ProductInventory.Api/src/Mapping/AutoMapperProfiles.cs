
using AutoMapper;
using ProductInventory.Api.Data.DTOs;
using ProductInventory.Api.Models;
using ProductInventory.Api.Models.Requests;
namespace ProductInventory.Api.Models.Mapping;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Products, ProductDto>();
        CreateMap<CreateProductRequest, Products>();
    }
}