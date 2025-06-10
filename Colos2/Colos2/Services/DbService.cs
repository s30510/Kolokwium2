

using Colos2.Services;
using WebApplication1.Data;

public class DbService : IDbService
{

    DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }


    
}