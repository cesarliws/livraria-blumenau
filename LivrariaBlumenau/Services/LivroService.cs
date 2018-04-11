using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LivrariaBlumenau.Models;

using Microsoft.EntityFrameworkCore;

namespace LivrariaBlumenau.Services
{
    public class LivroService : IModelService<Livro>
    {
        private DbEntities _context;

        public LivroService(DbEntities context)
        {
            _context = context;
        }

        public async Task CreateAsync(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var livro = await FindLivro(id);
            _context.Remove(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            return await _context.Livros.OrderBy(l => l.Titulo).ToListAsync();
        }

        public async Task<Livro> GetAsync(long id)
        {
            return await FindLivro(id);
        }

        public async Task UpdateAsync(Livro livro)
        {
            var l = await FindLivro(livro.Id);

            if (l != null)
            {
                _context.Entry(l).CurrentValues.SetValues(livro);
                await _context.SaveChangesAsync();
            }
        }

        public async Task PutAsync(long id, Livro livro)
        {
            var l = await FindLivro(id);

            if (l != null)
            {
                _context.Entry(l).CurrentValues.SetValues(livro);
                await _context.SaveChangesAsync();
            }
        }

        public Livro New()
        {
            return new Livro();
        }

        private async Task<Livro> FindLivro(long id)
        {
            var livro = await _context.Livros.SingleOrDefaultAsync(l => l.Id == id);
            return livro;
        }
    }
}
