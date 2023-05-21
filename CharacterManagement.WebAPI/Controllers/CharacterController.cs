using CharacterManagement.WebAPI.Data;
using CharacterManagement.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        private readonly DmContext _context;

        public CharacterController(DmContext context)
        {
            _context = context;
        }

        // GET: api/Character
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            return await _context.Characters.ToListAsync();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var personagem = await _context.Characters.FindAsync(id);

            if (personagem == null)
            {
                return NotFound();
            }

            return personagem;
        }

        // POST: api/Character
        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(Character personagem)
        {
            _context.Characters.Add(personagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = personagem.Id }, personagem);
        }

        // DELETE: api/Character/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Character>> DeleteCharacter(int id)
        {
            var personagem = await _context.Characters.FindAsync(id);
            if (personagem == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(personagem);
            await _context.SaveChangesAsync();

            return personagem;
        }
    }
}
