using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ProductInventory.Api.Models;



[Table("Products")]
public class Products
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    [Precision(6,2)]
    public string? Quantity { get; set; } 
    public double? Price { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]

    public List<Category>? Categories { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.UtcNow;

    public Products()
    {

    }

    public Products(Guid id, string name, string quantity, Double price)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}