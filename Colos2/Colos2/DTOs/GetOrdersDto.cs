

namespace CodeFirstTemplate.DTOs;

public class GetOrdersDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
    public string Status { get; set; }
    public ClientDto Client { get; set; }
    public List<ProductDto> Products { get; set; }
    
}

public class ClientDto{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class ProductDto
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
}