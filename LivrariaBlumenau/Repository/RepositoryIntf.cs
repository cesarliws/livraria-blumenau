using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Services
{
    public interface IRepository<T>
    {
        //New object
        T New();

        //Create
        Task CreateAsync(T model);

        //Read
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(long id);

        //Update
        Task UpdateAsync(T model);
        Task PutAsync(long id, T Model);

        //Delete
        Task DeleteAsync(long id);
    }
}


