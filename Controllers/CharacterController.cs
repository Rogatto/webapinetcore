using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services.ChracterService;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase

    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get(){
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> getSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        
       [HttpPost]
       public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
       {
           return Ok(await _characterService.AddCharacter(newCharacter));

       }
    }
}