using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }
    public int Price { get; set; }
    
    [DisplayName("Upload Image")]
    public string Image { get; set; }
}