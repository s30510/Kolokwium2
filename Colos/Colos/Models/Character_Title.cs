using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Character_Title
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }

    public DateTime AcquairedDate { get; set; }


    [ForeignKey(nameof(Title))]
    public int TitleId { get; set; }
    public Title Title { get; set; }
    
    
    [ForeignKey(nameof(Character))]
    public int CharacterId { get; set; }
    public Character Character { get; set; }


   
}