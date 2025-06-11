using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    
    
    public DbSet<Item> Items{ get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character_Title> CharacterTitles { get; set; }
    
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Title>().HasData(new List<Title>
        {
       new Title
       {
          Id = -1,
          Name = "blabla"
       },new Title
       {
           Id = -2,
           Name = "blabla"
       },
       new Title
       {
           Id = -3,
           Name = "blabla"
        }
        });
        
        
        modelBuilder.Entity<Item>().HasData(new List<Item>
        {
            new Item
            {
                Id=-1,
                Name = "Apple",
                Weight = 10
               
            },
            new Item
            {
                Id=-2,
                Name = "Apple",
                Weight = 10
            },
            new Item
            {
                Id=-3,
                Name = "Apple",
                Weight = 10
            },
           

        });

        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character
            {
                Id =-1,
                FirstName = "John",
                LastName = "Doe",
                CurrentWeight = 100,
                MaxWeight = 1020,
                
                
            },
            new Character
            {
                Id =-2,
                FirstName = "Jane",
                LastName = "Doe",
                CurrentWeight = 100,
                MaxWeight = 1002,
                
                
            },
            new Character
            {
                Id =-3,
                FirstName = "Jane",
                LastName = "Doe",
                CurrentWeight = 100,
                MaxWeight = 1200,
                
            },

        });

        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>
        {
            new Backpack
            {
                Id = -1,
                Amount = 30,
                CharacterId = -1,
                ItemId = -1,
            }
        });
        
        modelBuilder.Entity<Character_Title>().HasData(new List<Character_Title>
        {
            
            new Character_Title
            {
                Id = -1,
                AcquairedDate = DateTime.Parse("2021-09-01"),
                CharacterId = -1,
                TitleId = -1,
                
            }
        });
        
        

    }
}