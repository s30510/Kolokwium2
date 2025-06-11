using CodeFirstTemplate.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
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
            try
            {
                var data = await _dbService.GetCharacterByIdAsync(id);

                return Ok(data);
            }
            catch
            {
                return NotFound();
            }
        }



        [HttpPost("{id}/backpacks")]
        public async Task<IActionResult> AddItem(List<int> newItems, int id)
        {
            try
            {
                await _dbService.AddNewItems(newItems, id);
                return Created();
            }
            catch (OverweightException e)
            {
                return Conflict(e.Message);
            }
            catch (NoFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
    }
    }
}
