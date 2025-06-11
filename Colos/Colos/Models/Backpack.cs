using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Backpack
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }


    public int Amount { get; set; }
    
    [ForeignKey(nameof(Item))] 
    public int ItemId{ get; set; }
    public  Item Item { get; set; }
    
    
    [ForeignKey(nameof(Character))] 
    public int CharacterId { get; set; }
    public Character Character { get; set; }
    
    
}