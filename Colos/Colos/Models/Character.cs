using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Character
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int  CurrentWeight{ get; set; }
    
    public int  MaxWeight{ get; set; }

    public ICollection<Backpack> Backpacks{ get; set; }

    public ICollection<Character_Title> CharacterTitles { get; set; }

}