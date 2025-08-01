using ProductInventory.Api.Data;

namespace ProductInventory.Api.Models.Requests;


public class CreateProductRequest
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; }

    public List<Category>? Categories { get; set; }
}