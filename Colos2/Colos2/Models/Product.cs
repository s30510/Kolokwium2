using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTemplate.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int id { get; set; }

    public string Name { get; set; }
    public double Price { get; set; }
    
    public ICollection<Product_Order> ProductOrders { get; set; }
}