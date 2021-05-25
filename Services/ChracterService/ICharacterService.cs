using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Services.ChracterService
{
    public interface ICharacterService
    {
       Task<List<Character>> GetAllCharacters();

       Task<Character> GetCharacterById(int id);
       Task<List<Character>> AddCharacter(Character newCharacter);
    }
}