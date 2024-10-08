namespace WebApplication2.Models;

public class Sale
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public int Quantity { get; set; }
    public DateTime DateOfSale { get; set; }
    
    public int AnimalId { get; set; }
    public Animal? Animal { get; set; }
}