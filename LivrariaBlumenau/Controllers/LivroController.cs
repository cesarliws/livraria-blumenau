using System.Threading.Tasks;
using LivrariaBlumenau.Models;
using LivrariaBlumenau.Services;

using Microsoft.AspNetCore.Mvc;

namespace LivrariaBlumenau.Controllers
{
    [Produces("application/json")]
    public class LivroController : Controller
    {
        private DbEntities _context;
        private IModelService<Livro> _livroService;

        public LivroController(IModelService<Livro> livroService, DbEntities context)
        {
            _livroService = livroService;
            _context = context;
        }

        [HttpGet]
        [Route("api/Livro/Index")]
        public async Task<IActionResult> Get()
        {
            var livros = await _livroService.GetAllAsync();
            return Ok(livros);
        }

        [HttpGet]
        [Route("api/Livro/{id}")]
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

        [HttpPost]
        [Route("api/Livro/Create")]
        public async Task<IActionResult> Create([FromBody]Livro livro)
        {
            if (livro == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _livroService.CreateAsync(livro);
            return Ok(livro);
        }

        [HttpPut]
        [Route("api/Livro/Edit")]
        public async Task<IActionResult> Edit([FromBody]Livro livro)
        {
            if (livro == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            await _livroService.UpdateAsync(livro);
            return Ok(livro);
        }

        [HttpDelete]
        [Route("api/Livro/Delete/{id}")]
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
