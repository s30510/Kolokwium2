using System.Runtime.InteropServices.JavaScript;
using CodeFirstTemplate.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    
    
   public DbSet<Client> Clients { get; set; }
   public DbSet<Status> Statuses { get; set; }
   public DbSet<Product> Products { get; set; }
   public DbSet<Order> Orders { get; set; }
   public DbSet<Product_Order> ProductOrders { get; set; }
    
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>().HasData(new List<Client>
        {
       new Client
       {
           Id=-1,
           FirstName="John",
           LastName="Pork",
       },new Client
       {
           Id=-2,
           FirstName="John",
           LastName="Pork",
       },
       new Client
       {
       Id=-3,
       FirstName="John",
       LastName="Smith",
        }
        });
        
        
        modelBuilder.Entity<Status>().HasData(new List<Status>
        {
            new Status
            {
                Id=-1,
                Name = "New",
            },
            new Status
            {
                Id=-2,
                Name = "New",
            },
            new Status
            {
                Id=-3,
                Name = "New",
            },
           

        });

        modelBuilder.Entity<Product>().HasData(new List<Product>
        {
            new Product
            {
                id = -1,
                Name = "Apple",
                Price = 9.99,
                
            },
            new Product
            {
                id = -2,
                Name = "Apple",
                Price = 9.99,
                
            },
            new Product
            {
                id = -3,
                Name = "Apple",
                Price = 9.99,
                
            },

        });



        modelBuilder.Entity<Order>().HasData(new List<Order>
        {
            new Order
            {
                id = -1,
                CreatedAt = DateTime.Parse("2009-09-01"),
                FulfilledAt = DateTime.Parse("2009-09-01"),
                StatusId = -1,
                ClientId = -2,
                
            },
            new Order
            {
                id = -2,
                CreatedAt = DateTime.Parse("2009-09-01"),
                FulfilledAt = DateTime.Parse("2009-09-01"),
                StatusId = -3,
                ClientId = -2,
            }, new Order
            {
                id = -3
                ,CreatedAt = DateTime.Parse("2009-09-01"),
                FulfilledAt = DateTime.Parse("2009-09-01"),
                StatusId = -3,
                ClientId = -1,
            },

        });
        
        modelBuilder.Entity<Product_Order>().HasData(new List<Product_Order>
        {
            new Product_Order
            {
                id = -1,
                ProductId = -2,
                OrderId = -1,
                Amount = 123
            },new Product_Order
            {
                id = -2,
                ProductId = -2,
                OrderId = -3,
                Amount = 123
            },new Product_Order
            {
                id = -3,
                ProductId = -3,
                OrderId = -1,
                Amount = 123
            }

        });
    }
}