using CodeFirstTemplate.Exceptions;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    
    DatabaseContext _dbContext;

    public DbService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async  Task<GetCharacterDto> GetCharacterByIdAsync(int id)
    {

        var data = await  _dbContext.Characters
            .Include(i => i.CharacterTitles)
            .ThenInclude(i => i.Title)
            .Include(e => e.Backpacks)
            .ThenInclude(i => i.Item).Where(w=>w.Id == id).FirstOrDefaultAsync();


        if (data == null)
        {
            throw new NoFoundException();
        }

        var dto = new GetCharacterDto
        {
            FirstName = data.FirstName,
            LastName = data.LastName,
            CurrentWeight = data.CurrentWeight,
            MaxWeight = data.MaxWeight,
            BackPackItems = data.Backpacks.Select(s=>new ItemDto
            {
                ItemName = s.Item.Name,
                ItemWeight = s.Item.Weight,
                Amount = s.Amount,
            }).ToList(),
            Titles = data.CharacterTitles.Select(s=>new TitleDto
            {
                Title =s.Title.Name,
                AcquairedDate = s.AcquairedDate,
            }).ToList()
            
        };


        return dto;

    }
}