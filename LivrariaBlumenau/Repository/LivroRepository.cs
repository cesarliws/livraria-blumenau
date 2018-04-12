using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LivrariaBlumenau.Models;

using Microsoft.EntityFrameworkCore;

namespace LivrariaBlumenau.Services
{
    public class LivroRepository : IRepository<Livro>
    {
        private EntitiesContext context;

        public LivroRepository(EntitiesContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Livro livro)
        {
            context.Livros.Add(livro);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var livro = await FindLivro(id);
            context.Remove(livro);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Livro>> GetAllAsync()
        {
            return await context.Livros.OrderBy(l => l.Titulo).ToListAsync();
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
                context.Entry(l).CurrentValues.SetValues(livro);
                await context.SaveChangesAsync();
            }
        }

        public async Task PutAsync(long id, Livro livro)
        {
            var l = await FindLivro(id);

            if (l != null)
            {
                context.Entry(l).CurrentValues.SetValues(livro);
                await context.SaveChangesAsync();
            }
        }

        public Livro New()
        {
            return new Livro();
        }

        private async Task<Livro> FindLivro(long id)
        {
            var livro = await context.Livros.SingleOrDefaultAsync(l => l.Id == id);
            return livro;
        }
    }
}
