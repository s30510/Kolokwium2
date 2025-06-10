using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTemplate.Models;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int id { get; set; }

    public DateTime CreatedAt { get; set; }
    
    public DateTime? FulfilledAt { get; set; }

    [ForeignKey(nameof(Client))]
    public int ClientId { get; set; }
    public Client Client { get; set; }
    
    [ForeignKey(nameof(Status))]
    public int StatusId { get; set; }
    public Status Status { get; set; }

    public ICollection<Product_Order> ProductOrders { get; set; }
}