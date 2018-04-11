using System.Threading.Tasks;
using LivrariaBlumenau.Models;
using LivrariaBlumenau.Services;

using Microsoft.AspNetCore.Mvc;

namespace LivrariaBlumenau.Controllers
{
    [Produces("application/json")]
    [Route("api/Livro")]
    public class LivroController : Controller
    {
        private DbEntities _context;
        private IModelService<Livro> _livroService;

        public LivroController(IModelService<Livro> livroService, DbEntities context)
        {
            _livroService = livroService;
            _context = context;
        }

        // GET: api/livro
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var livros = await _livroService.GetAllAsync();
            return Ok(livros);
        }

        // GET api/livro/:id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            Livro livro = await _livroService.GetAsync(id);
            if (livro == null)
                NotFound();

            return Ok(livro);
        }

        // POST api/livro
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Livro livro)
        {
            if (livro == null)
            {
                return BadRequest();
            }
            await _livroService.CreateAsync(livro);
            return Ok();
        }

        // PUT api/livro/:id
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Livro livro)
        {
            if (id == 0 || livro == null)
            {
                return BadRequest();
            }
            await _livroService.PutAsync(id, livro);
            return Ok();
        }

        // DELETE api/livro/:id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _livroService.DeleteAsync(id);
            return NoContent();
        }
    }
}
