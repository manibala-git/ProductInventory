namespace ProductInventory.Api.Models;

public class Products
{
    public string Id{ get; set; }
    public string Name{ get; set; }

    public string Quantity{ get; set; }
    public double Price{ get; set; }

    public Products()
    {

    }

    public Products(string id, string name, string quantity, Double price)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}