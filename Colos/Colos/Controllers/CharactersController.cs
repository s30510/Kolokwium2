using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace Colos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        
        IDbService _dbService;

        public CharactersController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacters(int id)
        {
            var data = await _dbService.GetCharacterByIdAsync(id);
            
            return Ok(data);
        }
    }
}
